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
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Depo
{
    public partial class FrmDepoIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Depo _entity;
        private DepoDAL depoDal = new DepoDAL();
        private BenimSalonumContext context = new BenimSalonumContext();
        public bool kayitedildi = false;

        public FrmDepoIslem(Entities.Tables.Depo entity)
        {
            InitializeComponent();
            cmbYetkiliKodu.DataSource = context.Personeller.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Select(c => c.PersonelKodu).ToList();

            _entity = entity;
            _entity.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;

            labelKullaniciID.DataBindings.Add("Text", _entity, "KullaniciID");
            txtDepoKodu.DataBindings.Add("Text", _entity, "DepoKodu");
            txtDepoAdi.DataBindings.Add("Text", _entity, "DepoAdi");
            cmbYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            cmbYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (depoDal.AddOrUpDate(context, _entity))
            {
                depoDal.Save(context);
                kayitedildi = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbYetkiliKodu_Validated(object sender, EventArgs e)
        {
            string secilenKod = cmbYetkiliKodu.SelectedItem.ToString()??"";
            string gelenYetkili = context.Personeller.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.PersonelKodu == secilenKod).PersonelAdi;

            if (cmbYetkiliAdi.Text != gelenYetkili)
            {
                if (!string.IsNullOrEmpty(cmbYetkiliAdi.Text))
                {
                    cmbYetkiliAdi.Text = null;
                    cmbYetkiliAdi.SelectedText = gelenYetkili;
                }
                else
                {
                    cmbYetkiliAdi.SelectedText = gelenYetkili;
                }
            }
        }

        //private void cmbYetkiliAdi_Validated(object sender, EventArgs e)
        //{
        //    string secilenAd = cmbYetkiliAdi.SelectedItem.ToString()??"";
        //    string gelenKod = context.Personeller.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.PersonelAdi == secilenAd).PersonelKodu;
        //    if (cmbYetkiliKodu.Text != gelenKod)
        //    {
        //        cmbYetkiliKodu.SelectedText = gelenKod;
        //    }
        //}
    }
}