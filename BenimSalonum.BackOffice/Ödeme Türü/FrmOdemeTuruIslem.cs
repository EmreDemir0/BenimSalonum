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
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private OdemeTuru _entity;
        public bool kayitedildi = false;

        public FrmOdemeTuruIslem(OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            _entity.KullaniciID = entity.KullaniciID;

            labelKullaniciID.DataBindings.Add("Text", _entity, "KullaniciID");
            txtOdemeTuruKodu.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtOdemeTuruAdi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (odemeTuruDal.AddOrUpDate(context, _entity))
            {
                odemeTuruDal.Save(context);
                kayitedildi = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupGenel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}