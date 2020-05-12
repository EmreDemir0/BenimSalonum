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

namespace BenimSalonum.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuruHareket : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();

        private int _odemeTuruId;
        public FrmOdemeTuruHareket(int odemeTuruId)
        {
            InitializeComponent();

            _odemeTuruId = odemeTuruId;
            var odemeBilgi = context.OdemeTurleri.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == odemeTuruId);
            LblBaslik.Text = odemeBilgi.OdemeTuruKodu + " - " + odemeBilgi.OdemeTuruAdi + "Hareketleri";
        }
        void Listele()
        {
            gridcontOdemeHareket.DataSource = kasaHareketDal.GetALL(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == _odemeTuruId);
            gridcontKasaBakiye.DataSource = odemeTuruDal.KasaToplamListele(context, _odemeTuruId);
            gridcontGenelToplam.DataSource = odemeTuruDal.GenelToplamListele(context, _odemeTuruId);
        }

        private void FrmOdemeTuruHareket_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridOdemeHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridOdemeHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridOdemeHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}