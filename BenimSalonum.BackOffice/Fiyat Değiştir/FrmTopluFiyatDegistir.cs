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
using BenimSalonum.BackOffice.Stok;
using BenimSalonum.Entities.Tools;
using DevExpress.DataProcessing;

namespace BenimSalonum.BackOffice.Fiyat_Değiştir
{
    public partial class FrmTopluFiyatDegistir : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        StokDAL stokDal = new StokDAL();
        public FrmTopluFiyatDegistir()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();
            if (form.Secildi)
            {
                foreach (var item in form.secilen)
                {
                    context.Stoklar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.StokKodu == item.StokKodu).Load();
                }
                TopluDegistirGridControl.DataSource = context.Stoklar.Local.ToBindingList();
            }
        }
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void BtnCikar_Click(object sender, EventArgs e)
        {
            if (gridTopluDegistir.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Çıkarılacak Kayıt Bulunamadı.");
            }
            else
            {
                var secilen = (int)gridTopluDegistir.GetFocusedRowCellValue(colId);
                var result = stokDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen);
                context.Entry(result).State = EntityState.Detached;
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            gridTopluDegistir.OptionsView.ShowAutoFilterRow = true
    ? gridTopluDegistir.OptionsView.ShowAutoFilterRow = false
    : gridTopluDegistir.OptionsView.ShowAutoFilterRow = true;
        }

        private void BtnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (gridTopluDegistir.RowCount == 0)
            {
                XtraMessageBox.Show("Seçilen Bir Stok Yok");
                return;
            }
            FrmFiyatDegistir form = new FrmFiyatDegistir();
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemDegistir in form.list)
                {
                    if (itemDegistir.Degistir)
                    {
                        for (int i = 0; i < gridTopluDegistir.RowCount; i++)
                        {
                            decimal kolonDeger = 0;

                            decimal degisen = 0;

                            kolonDeger = Convert.ToDecimal(gridTopluDegistir.GetRowCellValue(i, itemDegistir.KolonAdi));
                            if (itemDegistir.DegisimTuru == "Yüzde")
                            {
                                degisen = itemDegistir.DegisimYonu == "Arttır"
                                    ? kolonDeger + kolonDeger / 100 * itemDegistir.Degeri
                                    : kolonDeger - kolonDeger / 100 * itemDegistir.Degeri;
                            }
                            else if (itemDegistir.DegisimTuru == "Tutar")
                            {
                                degisen = itemDegistir.DegisimYonu == "Arttır"
                                    ? kolonDeger + itemDegistir.Degeri
                                    : kolonDeger - itemDegistir.Degeri;
                            }
                            else
                            {
                                degisen = itemDegistir.Degeri;
                            }
                            gridTopluDegistir.SetRowCellValue(i, itemDegistir.KolonAdi, degisen);
                        }
                    }
                }
            }
        }

        private void gridTopluDegistir_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = gridTopluDegistir.RowCount;
            groupControl2.Text = "Buton Menü        Toplam Güncellenecek Ürün Sayısı : " + satirsayisi;
        }
    }
}