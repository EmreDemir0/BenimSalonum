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

namespace BenimSalonum.BackOffice.Cari
{
    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        private int _cariId;
        public FrmCariHareket(int cariId)
        {
            InitializeComponent();
            _cariId = cariId;
            var cariEntity = cariDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == _cariId);
            LblBaslik.Text = cariEntity.CariKodu + " - " + cariEntity.CariAdi + " Hareketleri ";
        }
        private void Guncelle()
        {
            gridcontFisToplam.DataSource = cariDal.CariFisGenelToplam(context, _cariId);
            gridcontBakiye.DataSource = cariDal.CariGenelToplam(context, _cariId);
            gridcontCariHareket.DataSource = cariDal.CariFisAyrinti(context, _cariId);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}