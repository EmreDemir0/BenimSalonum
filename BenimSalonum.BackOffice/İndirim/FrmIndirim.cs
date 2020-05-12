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

namespace BenimSalonum.BackOffice.İndirim
{
    public partial class FrmIndirim : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        IndirimDAL indirimDal = new IndirimDAL();
        public FrmIndirim()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
            BenimSalonumContext context = new BenimSalonumContext(); // neden context yenileniyor.
            IndirimGridControl.DataSource = indirimDal.IndirimListele(context);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnCariFiltre_Click(object sender, EventArgs e)
        {
            IndirimFilterControl.ApplyFilter();
        }

        private void btnCariFiltreIptal_Click(object sender, EventArgs e)
        {
            IndirimFilterControl.FilterString = null;
            IndirimFilterControl.ApplyFilter();
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (IndirimGridView.OptionsView.ShowAutoFilterRow == true)
            {
                IndirimGridView.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                IndirimGridView.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btnDurumu_Click(object sender, EventArgs e)
        {
            PasifYap();
        }

        private void IndirimGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Convert.ToBoolean(IndirimGridView.GetFocusedRowCellValue(colDurumu)))
            {
                btnDurumu.Text = "Pasif Yap";
                btnDurumu.ImageOptions.ImageIndex = 24;
            }
            else
            {
                btnDurumu.Text = "Aktif Yap";
                btnDurumu.ImageOptions.ImageIndex = 23;
            }
        }

        private void toolStripMenuItemEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Ekle()
        {
            FrmIndirimIslem form = new FrmIndirimIslem();
            form.ShowDialog();
        }

        private void toolStripMenuItemSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            if (XtraMessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var secilen = (int)IndirimGridView.GetFocusedRowCellValue(colId);
                indirimDal.Delete(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen);
                indirimDal.Save(context);
            }
        }

        private void toolStripMenuItemPasif_Click(object sender, EventArgs e)
        {
            PasifYap();
        }

        private void PasifYap()
        {
            var secilenId = (int)IndirimGridView.GetFocusedRowCellValue(colId);
            var secilen = indirimDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilenId);
            if (Convert.ToBoolean(IndirimGridView.GetFocusedRowCellValue(colDurumu)))
            {
                secilen.Durumu = false;

                btnDurumu.Text = "Pasif Yap";
                IndirimGridView.SetFocusedRowCellValue(colDurumu, false);
                btnDurumu.ImageOptions.ImageIndex = 24;
                indirimDal.Save(context);
            }
            else
            {
                secilen.Durumu = true;
                btnDurumu.Text = "Aktif Yap";
                IndirimGridView.SetFocusedRowCellValue(colDurumu, true);//sadece tablo üstünde oynama yapar bunu save etmek gerek
                btnDurumu.ImageOptions.ImageIndex = 23;
                indirimDal.Save(context);
            }
        }

        private void toolStripMenuItemGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}