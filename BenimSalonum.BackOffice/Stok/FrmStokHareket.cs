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

namespace BenimSalonum.BackOffice.Stok
{
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        private int _stokId;
        public FrmStokHareket(int stokId)
        {
            InitializeComponent();
            _stokId = stokId;
            var stokBilgi = context.Stoklar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).SingleOrDefault(c => c.Id == _stokId);
            LblBaslik.Text = stokBilgi.StokKodu + " - " + stokBilgi.StokAdi + " Hareketleri ";
        }
        private void Guncelle()
        {
            gridcontStokHareket.DataSource = stokHareketDal.GetALL(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.StokId == _stokId);
            gridcontGenelStok.DataSource = stokHareketDal.GetGenelStok(context,_stokId);
            gridcontDepoStok.DataSource = stokHareketDal.GetDepoStok(context, _stokId);
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}