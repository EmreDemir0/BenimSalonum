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
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Personeller
{
    public partial class FrmPersonelSec : DevExpress.XtraEditors.XtraForm
    {
        PersonelDAL personelDal = new PersonelDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        public List<Entities.Tables.PersonelHareket> secilen = new List<PersonelHareket>();
        public bool Secildi = false;
        private DateTime _donem;

        public FrmPersonelSec(DateTime donemi, bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim == true)
            {
                lblUyari.Visible = true;
                PersonelSecGridView.OptionsSelection.MultiSelect = true; // çoklu seçim açmak
            }
            _donem = donemi;
            PersonelSecGridControl.DataSource = personelDal.TariheGorePersonelListele(context, donemi.Month, donemi.Year);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (PersonelSecGridView.GetSelectedRows().Length != 0)
            {
                foreach (var row in PersonelSecGridView.GetSelectedRows())
                {
                    string personelkodu = PersonelSecGridView.GetRowCellValue(row, colPersonelKodu).ToString();
                    secilen.Add(new PersonelHareket
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        Id = Convert.ToInt32(PersonelSecGridView.GetRowCellValue(row, colId)),
                        PersonelKodu = PersonelSecGridView.GetRowCellValue(row, colPersonelKodu).ToString(),
                        PersonelAdi = PersonelSecGridView.GetRowCellValue(row, colPersonelAdi).ToString(),
                        TcKimlikNo = PersonelSecGridView.GetRowCellValue(row, colPersonelTc).ToString() ?? "",
                        Unvani = PersonelSecGridView.GetRowCellValue(row, colPersonelUnvani).ToString() ?? "",
                        Donemi = _donem,
                        AylikMaas = Convert.ToDecimal(PersonelSecGridView.GetRowCellValue(row, colAylikMaas).ToString()),
                        PrimOrani = Convert.ToDecimal(PersonelSecGridView.GetRowCellValue(row, colPrimOrani).ToString()),
                        ToplamSatis = Convert.ToDecimal(PersonelSecGridView.GetRowCellValue(row, colToplamSatis).ToString()),
                    }) ;

                    //listeye eke-klemme
                }
                Secildi = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Seçilen Bir Personel Bulunamadı.");
            }
        }

        private void PersonelSecGridControl_DoubleClick(object sender, EventArgs e)
        {
            if (PersonelSecGridView.GetSelectedRows().Length != 0)
            {
                foreach (var row in PersonelSecGridView.GetSelectedRows())
                {
                    string personelkodu = PersonelSecGridView.GetRowCellValue(row, colPersonelKodu).ToString();
                    secilen.Add(new PersonelHareket
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        Id = Convert.ToInt32(PersonelSecGridView.GetRowCellValue(row, colId)),
                        PersonelKodu = PersonelSecGridView.GetRowCellValue(row, colPersonelKodu).ToString(),
                        PersonelAdi = PersonelSecGridView.GetRowCellValue(row, colPersonelAdi).ToString(),
                        TcKimlikNo = PersonelSecGridView.GetRowCellValue(row, colPersonelTc).ToString() ?? "",
                        Unvani = PersonelSecGridView.GetRowCellValue(row, colPersonelUnvani).ToString() ?? "",
                        Donemi = _donem,
                        AylikMaas = Convert.ToDecimal(PersonelSecGridView.GetRowCellValue(row, colAylikMaas).ToString()),
                        PrimOrani = Convert.ToDecimal(PersonelSecGridView.GetRowCellValue(row, colPrimOrani).ToString()),
                        ToplamSatis = Convert.ToDecimal(PersonelSecGridView.GetRowCellValue(row, colToplamSatis).ToString()),
                    });

                    //listeye eke-klemme
                }
                Secildi = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Seçilen Bir Personel Bulunamadı.");
            }
        }
    }
}