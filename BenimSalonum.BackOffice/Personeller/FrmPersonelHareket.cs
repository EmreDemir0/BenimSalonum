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

namespace BenimSalonum.BackOffice.Personeller
{
    public partial class FrmPersonelHareket : DevExpress.XtraEditors.XtraForm
    {
        private int _personelId;
        BenimSalonumContext context = new BenimSalonumContext();
        PersonelDAL personelDal = new PersonelDAL();

        FisDAL fisDal = new FisDAL();

        public FrmPersonelHareket(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            var personelBilgi = context.Personeller.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == personelId);
            LblBaslik.Text = personelBilgi.PersonelKodu + " - " + personelBilgi.PersonelAdi;
        }

        private void Listele()
        {
            gridcontPersonelHareket.DataSource = fisDal.GetALL(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.PlasiyerId == _personelId);
            gridcontFisToplam.DataSource = personelDal.PersonelFisToplam(context, _personelId);
        }

        private void FrmPersonelHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridPersonelHareket.OptionsView.ShowAutoFilterRow = true ? gridPersonelHareket.OptionsView.ShowAutoFilterRow == false : gridPersonelHareket.OptionsView.ShowAutoFilterRow == true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}