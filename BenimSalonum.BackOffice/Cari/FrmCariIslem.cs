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
using System.Text.RegularExpressions;
using BenimSalonum.BackOffice.Tanim;

namespace BenimSalonum.BackOffice.Cari
{
    public partial class FrmCariIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Cari _entity;
        private CariDAL cariDal = new CariDAL();
        private BenimSalonumContext context = new BenimSalonumContext();
        public bool kayitedildi = false;
        CodeTool kodOlustur;

        public FrmCariIslem(Entities.Tables.Cari entity, bool kopyala = false)
        {
            InitializeComponent();
            kodOlustur = new CodeTool(this, CodeTool.Table.Cari);
            kodOlustur.barButonOlustur();

            if (kopyala)
            {
                _entity = new Entities.Tables.Cari();
                _entity.KullaniciID = entity.KullaniciID;
                _entity.Id = -1;
                _entity.Durumu = entity.Durumu;
                _entity.Aciklama = entity.Aciklama;
                _entity.Adres = entity.Adres;
                _entity.AlisOzelFiyati = entity.AlisOzelFiyati;
                _entity.CariAdi = entity.CariAdi;
                _entity.CariAltGrubu = entity.CariAltGrubu;
                _entity.CariGrubu = entity.CariGrubu;
                _entity.CariKodu = ""; ;
                _entity.CariTuru = entity.CariTuru;
                _entity.CepTelefonu = entity.CepTelefonu;
                _entity.Durumu = entity.Durumu;
                _entity.EMail = entity.EMail;
                _entity.FaturaUnvani = entity.FaturaUnvani;
                _entity.Telefon = entity.Telefon;
                _entity.Fax = entity.Fax;
                _entity.VergiDairesi = entity.VergiDairesi;
                _entity.VergiNo = entity.VergiNo;
                _entity.TicaretSicilNo = entity.TicaretSicilNo;
                _entity.MersisNo = entity.MersisNo;
                _entity.Il = entity.Il;
                _entity.Ilce = entity.Ilce;
                _entity.Semt = entity.Semt;
                _entity.Web = entity.Web;
                _entity.SatisOzelFiyati = entity.SatisOzelFiyati;
                _entity.RiskLimiti = entity.RiskLimiti ?? 0;
                _entity.IskontoOrani = entity.IskontoOrani ?? 0;
                _entity.YetkiliKisi = entity.YetkiliKisi;
                _entity.OzelKod1 = entity.OzelKod1;
                _entity.OzelKod2 = entity.OzelKod2;
                _entity.OzelKod3 = entity.OzelKod3;
                _entity.OzelKod4 = entity.OzelKod4;
                txtKod.Text = null;
            }
            else
            {
                _entity = entity;
                _entity.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
            }
            labelKullaniciID.DataBindings.Add("Text", _entity, "KullaniciID");
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtKod.DataBindings.Add("Text", _entity, "CariKodu");
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi");
            txtYetkiliKisi.DataBindings.Add("Text", _entity, "YetkiliKisi");
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi");
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo");
            txtSicilNo.DataBindings.Add("Text", _entity, "TicaretSicilNo");
            txtMersisNo.DataBindings.Add("Text", _entity, "MersisNo");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu");
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtFax.DataBindings.Add("Text", _entity, "Fax");
            txtMail.DataBindings.Add("Text", _entity, "EMail");
            txtWeb.DataBindings.Add("Text", _entity, "Web");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu");
            txtCariAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu");
            txtOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            txtOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            txtOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            txtOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");
            calcAlisOzelFiyat.DataBindings.Add("Text", _entity, "AlisOzelFiyati");
            calcSatisOzelFiyat.DataBindings.Add("Text", _entity, "SatisOzelFiyati");
            calcIskontoOrani.DataBindings.Add("Text", _entity, "IskontoOrani");
            calcIskontoOrani.DataBindings[0].FormattingEnabled = true;
            calcIskontoOrani.DataBindings[0].FormatString = "'X'0";
            calcIskontoOrani.DataBindings[0].DataSourceNullValue = "0";
            calcRiskLimiti.DataBindings.Add("Text", _entity, "RiskLimiti");
            calcRiskLimiti.DataBindings[0].FormattingEnabled = true;
            calcRiskLimiti.DataBindings[0].FormatString = "C2";
            calcRiskLimiti.DataBindings[0].DataSourceNullValue = "0";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cariDal.AddOrUpDate(context, _entity))
            {
                kodOlustur.KodArttirma();
                cariDal.Save(context);
                kayitedildi = true;
                FrmCariAnasayfa frm = new FrmCariAnasayfa();
                frm.GetAll();
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (!Regex.IsMatch(txtMail.Text, pattern))
            {
                dxErrorProvider1.SetError(this.txtMail, "Lütfen Mail Adresini Kontrol Ediniz.");
            }
        }

        private void txtVergiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCepTelefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSabitTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCariGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.CariGrubu);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtCariGrubu.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtCariGrubu.Text = null;
                    break;
            }
        }

        private void txtCariAltGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.CariAltGrubu);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtCariAltGrubu.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtCariAltGrubu.Text = null;
                    break;
            }
        }

        private void txtOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.CariOzelKod1);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtOzelKod1.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelKod1.Text = null;
                    break;
            }
        }

        private void txtOzelKod2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.CariOzelKod2);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtOzelKod2.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelKod2.Text = null;
                    break;
            }
        }

        private void txtOzelKod3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.CariOzelKod3);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtOzelKod3.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelKod3.Text = null;
                    break;
            }
        }

        private void txtOzelKod4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.CariOzelKod4);
                    form.ShowDialog();
                    if (form.Secildi)
                    {
                        txtOzelKod4.Text = form._entitiy.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelKod1.Text = null;
                    break;
            }
        }
    }
}