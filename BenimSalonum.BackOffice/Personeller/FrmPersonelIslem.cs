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
using BenimSalonum.BackOffice.Tanim;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Context;

namespace BenimSalonum.BackOffice.Personeller
{
    public partial class FrmPersonelIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Personel _entity;
        private PersonelDAL personelDal = new PersonelDAL();
        private BenimSalonumContext context = new BenimSalonumContext();
        public bool kayitedildi = false;

        public FrmPersonelIslem(Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            _entity.KullaniciID = entity.KullaniciID;

            labelKullaniciID.DataBindings.Add("Text", _entity, "KullaniciID");
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelUnvani.DataBindings.Add("Text", _entity, "PersonelUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelTc.DataBindings.Add("Text", _entity, "PersonelTc", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelGiris.DataBindings.Add("DateTime", _entity, "PersonelGiris", true, DataSourceUpdateMode.OnPropertyChanged, null, "F");
            txtPersonelCikis.DataBindings.Add("DateTime", _entity, "PersonelCikis", true, DataSourceUpdateMode.OnPropertyChanged, null, "F");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMail.DataBindings.Add("Text", _entity, "EMail", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            calcPrimOrani.DataBindings.Add("Value", _entity, "PrimOrani", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
            calcAylikMaas.DataBindings.Add("Value", _entity, "AylikMaas", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (personelDal.AddOrUpDate(context, _entity))
            {
                kayitedildi = true;
                personelDal.Save(context);
                this.Close();
            }
        }

        private void txtPersonelUnvani_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.PersonelUnvani);
            form.ShowDialog();
            if (form.Secildi)
            {
                txtPersonelUnvani.Text = form._entitiy.Tanimi;

            }
        }

        private void txtPersonelGiris_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txtPersonelGiris.Text = Convert.ToString(DateTime.Now.ToLocalTime());
        }

        private void txtPersonelCikis_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txtPersonelCikis.Text = Convert.ToString(DateTime.Now.ToLocalTime());
        }
    }
}