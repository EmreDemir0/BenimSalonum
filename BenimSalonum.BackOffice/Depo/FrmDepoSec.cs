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

namespace BenimSalonum.BackOffice.Depo
{
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        DepoDAL depoDal = new DepoDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        public Entities.Tables.Depo secilen = new Entities.Tables.Depo();
        private int _stokId;
        public bool secildi = false;
        public FrmDepoSec(int stokId)
        {
            InitializeComponent();
            _stokId = stokId;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridViewDepoSec.SelectedRowsCount != 0)
            {
                string depoKodu = gridViewDepoSec.GetFocusedRowCellValue(colDepoKodu).ToString();
                secilen = context.Depolar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.DepoKodu == depoKodu);
                secildi = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Hiç Bir Depo Seçilmedi");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            GridContDepoSec.DataSource = depoDal.DepoBazindaStokListele(context, _stokId);

        }

        private void GridContDepoSec_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewDepoSec.SelectedRowsCount != 0)
            {
                string depoKodu = gridViewDepoSec.GetFocusedRowCellValue(colDepoKodu).ToString();
                secilen = context.Depolar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.DepoKodu == depoKodu);
                secildi = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Hiç Bir Depo Seçilmedi");
            }
        }
    }
}