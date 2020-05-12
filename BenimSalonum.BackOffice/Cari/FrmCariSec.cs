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
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Cari
{
    public partial class FrmCariSec : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        public List<Entities.Tables.OtherTables.CariBakiye> secilenCariBakiye = new List<Entities.Tables.OtherTables.CariBakiye>();
        public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();
        public bool Secildi = false;
        public FrmCariSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim == true)
            {
                lblUyari.Visible = true;
                GridViewCariSec.OptionsSelection.MultiSelect = true; // çoklu seçim açmak
            }
            GridControlCariSec.DataSource = cariDal.CariListele(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (GridViewCariSec.GetSelectedRows().Length != 0)
            {
                foreach (var row in GridViewCariSec.GetSelectedRows())
                {
                    int cariId = (int)GridViewCariSec.GetRowCellValue(row, colId);
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == cariId));//listeye eke-klemme
                }
                Secildi = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Seçilen Bir Cari Bulunamadı.");
            }
        }

        private void GridControlCariSec_DoubleClick(object sender, EventArgs e)
        {
            if (GridViewCariSec.GetSelectedRows().Length != 0)
            {
                foreach (var row in GridViewCariSec.GetSelectedRows())
                {
                    int cariId = (int)GridViewCariSec.GetRowCellValue(row, colId);
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == cariId));//listeye eke-klemme

                    secilenCariBakiye.Add(new Entities.Tables.OtherTables.CariBakiye
                    {
                        // CariId = GridViewCariSec.GetRowCellValue(row,colId),
                        Alacak = Convert.ToDecimal(GridViewCariSec.GetRowCellValue(row, colAlacak)),
                        Borc = Convert.ToDecimal(GridViewCariSec.GetRowCellValue(row, colBorc)),
                        Bakiye = Convert.ToDecimal(GridViewCariSec.GetRowCellValue(row, colBakiye)),
                    });
                }
                Secildi = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Seçilen Bir Cari Bulunamadı.");
            }
        }

        private void GridViewCariSec_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = GridViewCariSec.RowCount;
            groupControl2.Text = "Buton Menü        Toplam Listelenen Kayıt Sayısı : " + satirsayisi;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariSec_Load(object sender, EventArgs e)
        {

        }
    }
}