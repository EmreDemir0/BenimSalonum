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
using BenimSalonum.BackOffice.Fis;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Kasa_Hareketleri
{
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        ExportTool export;

        public FrmKasaHareketleri()
        {
            InitializeComponent();
            export = new ExportTool(this, gridKasaHareket, dropDownButton1);

        }
        private void Listele()
        {

            gridcontKasaHareket.DataSource = kasaHareketDal.GetALL(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID);
        }

        private void gridKasaHareket_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = gridKasaHareket.RowCount;
            groupControl2.Text = "Buton Menü        Toplam Listelenen Kayıt Sayısı : " + satirsayisi;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCariFiltre_Click(object sender, EventArgs e)
        {
            StokHareketFilterControl.ApplyFilter();
        }

        private void btnCariFiltreIptal_Click(object sender, EventArgs e)
        {
            StokHareketFilterControl.FilterString = null;
            StokHareketFilterControl.ApplyFilter();
        }

        private void picBoxAcik_Click(object sender, EventArgs e)
        {
            if (splitContainerControl1.PanelVisibility == SplitPanelVisibility.Both)
            {
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            }
            else
            {
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
            }
        }

        private void StokHareketFilterControl_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            int a = e.ToString().IndexOf("Value", 0, e.ToString().Length - 1);
            if (a != -1)
            {
                StokHareketFilterControl.ApplyFilter();
            }
        }

        private void FrmKasaHareketleri_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(gridKasaHareket.GetFocusedRowCellValue(colId).ToString());
            form.ShowDialog();
        }
    }
}