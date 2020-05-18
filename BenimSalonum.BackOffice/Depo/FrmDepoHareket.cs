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
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        private int _depoId;

        public FrmDepoHareket(int depoId)
        {
            InitializeComponent();
            _depoId = depoId;
            var depoBilgi = context.Depolar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == depoId);
            LblBaslik.Text = depoBilgi.DepoKodu + " - " + depoBilgi.DepoAdi + " Hareketleri";
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridcontDepoHareket.DataSource = stokHareketDal.GetALL(context, c => c.DepoId == _depoId);
            gridcontDepoStok.DataSource = stokHareketDal.DepoStokListele(context, _depoId);
            gridcontIstatistik.DataSource = stokHareketDal.DepoIstatistikListele(context, _depoId);
        }

        private void FrmDepoHareket_Load_1(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridDepoHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridDepoHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridDepoHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}