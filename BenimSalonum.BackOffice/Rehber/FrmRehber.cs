using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenimSalonum.BackOffice.Depo;
using DevExpress.XtraEditors;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tools;
using BenimSalonum.BackOffice.Rehber;

namespace BenimSalonum.BackOffice
{
    public partial class FrmRehber : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        CariDAL cariDal = new CariDAL();
        public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();
        public bool Secildi = false;

        public FrmRehber()
        {
            InitializeComponent();

            lblUyari.Visible = true;
            RehberGridView.OptionsSelection.MultiSelect = true; // çoklu seçim açmak
            RehberGridControl.DataSource = cariDal.CariTelefonlari(context);
        }



        private void toolStripMenuItemGuncelle_Click(object sender, EventArgs e)
        {
            RehberGridControl.DataSource = cariDal.CariTelefonlari(context);
        }

        private void toolStripMenuItemEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (RehberGridView.GetSelectedRows().Length != 0)
            {
                foreach (var row in RehberGridView.GetSelectedRows())
                {
                    int cariId = (int)RehberGridView.GetRowCellValue(row, colId);
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == cariId));
                }
                Secildi = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Seçilen Bir Cari Bulunamadı.");
            }
            FrmMailGonder frmMailGonder = new FrmMailGonder(Secildi,secilen);
            frmMailGonder.ShowDialog();
        }

        private void RehberGridView_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = RehberGridView.RowCount;
            groupControl2.Text = "Buton Menü        Toplam Listelenen Kayıt Sayısı : " + satirsayisi;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}