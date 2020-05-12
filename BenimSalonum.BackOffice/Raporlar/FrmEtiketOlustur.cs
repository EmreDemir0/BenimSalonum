
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BenimSalonum.BackOffice.Stok;
using BenimSalonum.Entities.Context;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using DevExpress.XtraPrinting;

namespace BenimSalonum.BackOffice.Raporlar
{
    public partial class FrmEtiketOlustur : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        List<Entities.Tables.Stok> stokEntity = new List<Entities.Tables.Stok>();
        private XtraReport rapor = new XtraReport();
        private int mmToPixel(int mm)
        {
            return Convert.ToInt32(mm * 3.7795275591);
        }
        public FrmEtiketOlustur()
        {
            InitializeComponent();
            rapor.DataSource = stokEntity;
            EtiketStokGridControl.DataSource = stokEntity;
        }
            //LİSTEYE SAYFA BOYUTLARI GİRİLİP GİRİLMEDİĞİNİ KONTROL ET BOŞSA UYAR.
        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            rapor.DataSource = stokEntity;
            rapor.ReportUnit = ReportUnit.TenthsOfAMillimeter;
            rapor.Height = mmToPixel(Convert.ToInt32(calcDikeyUzunluk.Value));
            rapor.Width = mmToPixel(Convert.ToInt32(calcYatayUzunluk.Value));
            rapor.Margins.Top = mmToPixel(Convert.ToInt32(calcMarginUst.Value));
            rapor.Margins.Bottom = mmToPixel(Convert.ToInt32(calcMarginAlt.Value));
            rapor.Margins.Left = mmToPixel(Convert.ToInt32(calcMarginSol.Value));
            rapor.Margins.Right = mmToPixel(Convert.ToInt32(calcMarginSag.Value));
            rapor.RollPaper = checkRulo.Checked;

            DetailBand detail = new DetailBand();
            detail.MultiColumn.Layout = ColumnLayout.AcrossThenDown;
            detail.MultiColumn.Mode = MultiColumnMode.UseColumnWidth;
            detail.MultiColumn.ColumnWidth = mmToPixel(Convert.ToInt32(calcGenislik.Value));
            detail.Height = mmToPixel(Convert.ToInt32(calcUzunluk.Value));
            detail.MultiColumn.ColumnSpacing = mmToPixel(Convert.ToInt32(calcAraBosluk.Value));

            rapor.Bands.Add(detail);
            if (gridStokEtiket.RowCount == 0)
            {
                MessageBox.Show("Listeye Hiç Bir Ürün Eklenmedi ve Sihirbaz Kapatılıyor.");
            }
            else
            {
                FrmRaporDuzenle form = new FrmRaporDuzenle(rapor);
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec stok = new FrmStokSec(true);
            stok.ShowDialog();
            if (stok.Secildi)
            {
                foreach (var item in stok.secilen)
                {
                    stokEntity.Add(item);
                }
            }
            gridStokEtiket.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            gridStokEtiket.DeleteSelectedRows();
            gridStokEtiket.RefreshData();
        }
    }
}