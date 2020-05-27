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

namespace BenimSalonum.BackOffice.Stok_Hareketleri
{
    public partial class FrmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        ExportTool export;

        public FrmStokHareketleri()
        {
            InitializeComponent();
            export = new ExportTool(this, gridStokHareketGenel, dropDownButton1);
        }
        private void Listele()
        {
            gridcontStokHareketGenel.DataSource = stokHareketDal.GetALL(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID);
        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareketGenel.OptionsView.ShowAutoFilterRow == true)
            {
                gridStokHareketGenel.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStokHareketGenel.OptionsView.ShowAutoFilterRow = true;
            }
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokHareketleri_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void gridStokHareketGenel_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = gridStokHareketGenel.RowCount;
            groupControl2.Text = "Buton Menü        Toplam Listelenen Kayıt Sayısı : " + satirsayisi;
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(gridStokHareketGenel.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareketGenel.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNo form = new FrmSeriNo(veri);
            form.ShowDialog();
        }
    }
}