using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.DataAccess;
using System.Data.Entity;
using BenimSalonum.Entities.Tables;
using BenimSalonum.BackOffice.Stok;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Hızlı_Satış
{
    public partial class FrmHizliSatis : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        HizliSatisGrupDAL hizliSatisGrupDal = new HizliSatisGrupDAL();
        HizliSatisDAL hizliSatisDal = new HizliSatisDAL();
        IndirimDAL ındirimDal = new IndirimDAL();

        private void KayitAc()
        {
            grpGrupBilgi.Enabled = true;
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            gridControlUrunEkle.Enabled = false;
            btnEkle.Enabled = false;
            btnUrunSil.Enabled = false;
        }

        private void KayitKapat()
        {
            grpGrupBilgi.Enabled = false;
            btnYeni.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            gridControlUrunEkle.Enabled = true;
            btnEkle.Enabled = true;
            btnUrunSil.Enabled = true;
        }

        public FrmHizliSatis()
        {
            InitializeComponent();

            context.HizliSatisGruplari.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();
            context.HizliSatislar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();

            gridControlGrupEkle.DataSource = context.HizliSatisGruplari.Local.ToBindingList();
            gridControlUrunEkle.DataSource = context.HizliSatislar.Local.ToBindingList();
        }

        private void gridViewGrupEkle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridViewUrunEkle.ActiveFilterString = $"GrupId='{gridViewGrupEkle.GetFocusedRowCellValue(colId)}'";
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtGrupAdi.Enabled = true;
            KayitAc();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KayitKapat();
            hizliSatisGrupDal.AddOrUpDate(context, new HizliSatisGrup
            {
                GrupAdi = txtGrupAdi.Text,
            });
            hizliSatisGrupDal.Save(context);
            txtGrupAdi.Text = "";
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
            txtGrupAdi.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Seçili olan grup ile birlikte bu gruba eklenmiş tüm ürünler silinecektir.", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int grupId = (int)gridViewGrupEkle.GetFocusedRowCellValue(colId);
                hizliSatisDal.Delete(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.GrupId == grupId);
                gridViewGrupEkle.DeleteSelectedRows();
                hizliSatisDal.Save(context);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();
            if (form.Secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    if (context.HizliSatislar.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Barkod == itemStok.Barkod) == 0)
                    {
                        hizliSatisDal.AddOrUpDate(context, new Entities.Tables.HizliSatis
                        {
                            Barkod = itemStok.Barkod,
                            UrunAdi = itemStok.StokAdi,
                            GrupId = (int)gridViewGrupEkle.GetFocusedRowCellValue(colId),
                        });
                        hizliSatisDal.Save(context);
                    }
                }
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Seçili olan ürünleri listeden çıkarmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridViewUrunEkle.DeleteSelectedRows();
                hizliSatisDal.Save(context);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}