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

namespace BenimSalonum.BackOffice.İndirim
{
    public partial class FrmIndirimIslem : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        IndirimDAL ındirimDal = new IndirimDAL();
        public FrmIndirimIslem()
        {
            InitializeComponent();
            Listele();
            btnSinirli.Checked = true;
        }
        public void Listele()
        {
            context.Indirimler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();

            IndirimlerGridControl.DataSource = context.Indirimler.Local.ToBindingList();
        }
        private BenimSalonum.Entities.Tables.Indirim StokEkle(Entities.Tables.Stok entity)
        {
            Entities.Tables.Indirim _entity = new Entities.Tables.Indirim();
            _entity.StokKodu = entity.StokKodu;
            _entity.StokAdi = entity.StokAdi;
            _entity.Barkod = entity.Barkod;

            return _entity;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();
            if (form.Secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    Entities.Tables.Indirim _entity = new Entities.Tables.Indirim();
                    _entity = StokEkle(itemStok);
                    var count = context.Indirimler.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.StokKodu == itemStok.StokKodu);
                    if (count != 0)
                    {
                        if (XtraMessageBox.Show("Seçili olan stoğa daha önceden eklenmiş bir indirim bulunmaktadır./n Var olan indirimi güncellemek ister misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            var secilenId = context.Indirimler.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.StokKodu == itemStok.StokKodu);
                            _entity.Id = secilenId.Id;
                            _entity.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
                            ındirimDal.AddOrUpDate(context, _entity);
                        }
                    }
                    else
                    {
                        _entity.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
                        ındirimDal.AddOrUpDate(context, _entity);
                    }
                }
            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            foreach (var itemIndirim in context.Indirimler.Local.ToList())
            {
                itemIndirim.Durumu = true;
                itemIndirim.Aciklama = txtAciklama.Text;
                if (btnSuresiz.Checked)
                {
                    itemIndirim.IndirimTuru = "Süresiz";
                }
                else
                {
                    itemIndirim.BaslangicTarihi = dateBaslangic.DateTime;
                    itemIndirim.BitisTarihi = dateBitis.DateTime;
                    itemIndirim.IndirimTuru = "Sınırlı";
                }
            }
            if (dateBitis.DateTime == dateBaslangic.DateTime)
            {
                XtraMessageBox.Show("Başlangıç ve Bitiş Tarihi Aynı Olamaz");
            }
            else
            {
                ındirimDal.Save(context);
            }
        }

        private void BtnCikar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Seçili olan veriyi silmek istiyor musunuz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var secilenStokId = (int)IndirimlerGridView.GetFocusedRowCellValue(colId);
                var secilen = ındirimDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilenStokId);
                context.Entry(secilen).State = EntityState.Detached;
            }
        }

        private void btnSuresiz_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSuresiz.Checked)
            {
                dateBitis.Visible = false;
                dateBaslangic.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            else
            {
                dateBitis.Visible = true;
                dateBaslangic.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (IndirimlerGridView.OptionsView.ShowAutoFilterRow == true)
            {
                IndirimlerGridView.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                IndirimlerGridView.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}