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
using BenimSalonum.Entities.Tables;
using System.Data.Entity.Migrations;
using BenimSalonum.Entities.Tables.OtherTables;

namespace BenimSalonum.BackOffice.Ayarlar
{
    public partial class FrmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        private Entities.Tables.OtherTables.KullaniciAyarlari _entity;
        KasaDAL kasaDal = new KasaDAL();
        DepoDAL depoDal = new DepoDAL();
        KullaniciAyarlariDAL kullaniciAyarlariDal = new KullaniciAyarlariDAL();
        public FrmAyarlar(KullaniciAyarlari entity)
        {
            InitializeComponent();

            _entity = entity;

            //comboFaturaYaziciSec.Properties.Items.AddRange(YaziciListesi());
            //comboBilgiFisiYaziciSec.Properties.Items.AddRange(YaziciListesi());

            toggleGuncelleme.DataBindings.Add("EditValue", _entity, "GenelAyarlar_GuncellemeKontrol");

            cmbDepoVars.DataBindings.Add("Text", _entity, "SatisAyarlari_VarsayilanDepo");

            cmbKasaVars.DataBindings.Add("Text", _entity, "SatisAyarlari_VarsayilanKasa");

            comboFaturaAyar.DataBindings.Add("Text", _entity, "SatisAyarlari_FaturaYazdirmaAyari");
            comboBilgiFisi.DataBindings.Add("Text", _entity, "SatisAyarlari_BilgiFisiYazdırmaAyari");
            comboFaturaYaziciSec.DataBindings.Add("Text", _entity, "SatisAyarlari_FaturaYazici");
            comboBilgiFisiYaziciSec.DataBindings.Add("Text", _entity, "SatisAyarlari_BilgiFisiYazici");
            calcFisKodu.DataBindings.Add("Text", _entity, "SatisAyarlari_FisKodu");

            txtFirmaAdi.DataBindings.Add("Text", _entity, "FirmaAyarlari_FirmaAdi");
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FirmaAyarlari_FaturaUnvani");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "FirmaAyarlari_VergiDairesi");
            txtVergiNo.DataBindings.Add("Text", _entity, "FirmaAyarlari_VergiNo");
            txtAdres.DataBindings.Add("Text", _entity, "FirmaAyarlari_Adres");
            txtEposta.DataBindings.Add("Text", _entity, "FirmaAyarlari_Eposta");

            txtSmsKullaniciAdi.DataBindings.Add("Text", _entity, "smsAyarlari_KullaniciAdi");
            txtSmsKullaniciNo.DataBindings.Add("Text", _entity, "smsAyarlari_KullaniciNo");
            txtSmsParola.DataBindings.Add("Text", _entity, "smsAyarlari_Parola");
            txtSmsOrjinator.DataBindings.Add("Text", _entity, "smsAyarlari_Orjinator");


            /////////////////////////////////////            


            cmbDepoVars.DataSource = context.Depolar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Select(c => c.DepoKodu).ToList();

            cmbKasaVars.DataSource = context.Kasalar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Select(c => c.KasaKodu).ToList();


            cmbDepoVars.Text = _entity.SatisAyarlari_VarsayilanDepo;
            cmbKasaVars.Text = _entity.SatisAyarlari_VarsayilanKasa;


            comboFaturaAyar.SelectedIndex = Convert.ToInt32(_entity.SatisAyarlari_FaturaYazdirmaAyari);

            toggleGuncelleme.IsOn = _entity.GenelAyarlar_GuncellemeKontrol;

            comboBilgiFisi.SelectedIndex = Convert.ToInt32(_entity.SatisAyarlari_BilgiFisiYazdırmaAyari);

            comboFaturaYaziciSec.Text = _entity.SatisAyarlari_FaturaYazici;

            comboBilgiFisiYaziciSec.Text = _entity.SatisAyarlari_BilgiFisiYazici;

            txtFirmaAdi.Text = _entity.FirmaAyarlari_FirmaAdi;

            labelControl4.Text = "Kayıt Durumu : ";
            DepoYukle();
            KasaYukle();
        }
        public void DepoYukle()
        {
            string secilenKod = cmbDepoVars.SelectedItem.ToString() ?? "";
            string gelenYetkili = context.Depolar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.DepoKodu == secilenKod).DepoAdi;

            if (cmbDepoAdiVars.Text != gelenYetkili)
            {
                if (!string.IsNullOrEmpty(cmbDepoAdiVars.Text))
                {
                    cmbDepoAdiVars.Text = null;
                    cmbDepoAdiVars.Text = gelenYetkili;
                }
                else
                {
                    cmbDepoAdiVars.Text = gelenYetkili;
                }
            }
        }
        public void KasaYukle()
        {

            string secilenKod = cmbKasaVars.SelectedItem.ToString() ?? "";
            string gelenYetkili = context.Kasalar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaKodu == secilenKod).KasaAdi;

            if (cmbKasaAdiVars.Text != gelenYetkili)
            {
                if (!string.IsNullOrEmpty(cmbKasaAdiVars.Text))
                {
                    cmbKasaAdiVars.Text = null;
                    cmbKasaAdiVars.Text = gelenYetkili;
                }
                else
                {
                    cmbKasaAdiVars.Text = gelenYetkili;
                }
            }
        }
        //private List<string> YaziciListesi()
        //{
        //    return new LocalPrintServer().GetPrintQueues().Select(c => c.Name).ToList();

        //    VİDEODAN İZLE HANGİ REFERANSI ALDIĞINA BAK
        //}

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kullaniciAyarlariDal.AddOrUpDate(context, _entity))
            {
                try
                {
                    kullaniciAyarlariDal.Save(context);
                    labelControl4.Text = "Kayıt Başarılı. " + "// " + DateTime.Now;

                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Ayarlar Kaydet",
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    labelControl4.Text = "Kayıt Hatalı. " + "//" + DateTime.Now;
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDepoVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepoYukle();
        }

        private void cmbKasaVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            KasaYukle();
        }
    }
}
