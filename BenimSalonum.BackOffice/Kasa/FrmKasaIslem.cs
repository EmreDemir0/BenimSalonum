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
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Kasa
{
    public partial class FrmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        public bool kasakayitedildi = false;
        private Entities.Tables.Kasa _entity;


        public FrmKasaIslem(Entities.Tables.Kasa entity)
        {
            InitializeComponent();

            cmbYetkiliKodu.DataSource = context.Personeller.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Select(c => c.PersonelKodu).ToList();
            cmbYetkiliAdi.DataSource = context.Personeller.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Select(c => c.PersonelAdi).ToList();


            _entity = entity;
            _entity.KullaniciID = entity.KullaniciID;

            labelKullaniciID.DataBindings.Add("Text", _entity, "KullaniciID");
            txtKasaKodu.DataBindings.Add("Text", _entity, "KasaKodu");
            txtKasaAdi.DataBindings.Add("Text", _entity, "KasaAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            cmbYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            cmbYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kasaDal.AddOrUpDate(context, _entity))
            {
                kasaDal.Save(context);
                kasakayitedildi = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbYetkiliKodu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbYetkiliKodu_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbYetkiliKodu_Validated(object sender, EventArgs e)
        {
            string secilenKod = cmbYetkiliKodu.SelectedItem.ToString();
            string gelenYetkili = context.Personeller.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.PersonelKodu == secilenKod).PersonelAdi;

            if (cmbYetkiliAdi.Text != gelenYetkili)
            {
                cmbYetkiliAdi.SelectedText = gelenYetkili;
            }
        }

        private void cmbYetkiliAdi_Validated(object sender, EventArgs e)
        {
            string secilenAd = cmbYetkiliAdi.SelectedItem.ToString();
            string gelenKod = context.Personeller.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.PersonelAdi == secilenAd).PersonelKodu;

            if (cmbYetkiliKodu.Text != gelenKod)
            {
                cmbYetkiliKodu.SelectedText = gelenKod;
            }
        }
    }
}