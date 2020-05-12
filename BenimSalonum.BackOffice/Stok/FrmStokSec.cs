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

namespace BenimSalonum.BackOffice.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        public List<Entities.Tables.Stok> secilen = new List<Entities.Tables.Stok>();
        public bool Secildi = false;

        public FrmStokSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim == true)
            {
                lblUyari.Visible = true;
                gridViewStokSec.OptionsSelection.MultiSelect = true; // çoklu seçim açmak
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridViewStokSec.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridViewStokSec.GetSelectedRows())
                {
                    int stokId = (int)gridViewStokSec.GetRowCellValue(row, colId);
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == stokId));//listeye eke-klemme
                }
                Secildi = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Seçilen bir ürün bulunamadı.");
            }
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            GridContStokSec.DataSource = stokDal.StokListele(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridContStokSec_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridViewStokSec.GetSelectedRows().Length != 0)
                {
                    foreach (var row in gridViewStokSec.GetSelectedRows())
                    {
                        int stokId = (int)gridViewStokSec.GetRowCellValue(row, colId);
                        secilen.Add(context.Stoklar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == stokId));//listeye eke-klemme
                    }
                    Secildi = true;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Seçilen bir ürün bulunamadı.");
                }
            }
            catch (Exception)
            {

            }
        }
    }
}