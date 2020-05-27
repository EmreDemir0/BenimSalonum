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

namespace BenimSalonum.BackOffice.Kasa
{
    public partial class FrmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        public Entities.Tables.Kasa entity = new Entities.Tables.Kasa();

        public bool secildi = false;
        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            GridContKasaSec.DataSource = kasaDal.KasaListele(context);

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridViewKasaSec.GetSelectedRows().Length != 0)
            {
                int kasaId = (int)gridViewKasaSec.GetFocusedRowCellValue(colKasaKodu);
                entity = context.Kasalar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == kasaId);
                secildi = true;
                this.Close();
            }
        }

        private void GridContKasaSec_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewKasaSec.GetSelectedRows().Length != 0)
            {
                int kasaId = (int)gridViewKasaSec.GetFocusedRowCellValue(colId);
                entity = context.Kasalar.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == kasaId);
                secildi = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}