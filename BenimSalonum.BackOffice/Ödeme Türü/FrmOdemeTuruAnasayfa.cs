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

namespace BenimSalonum.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuruAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        int secilen;

        public FrmOdemeTuruAnasayfa()
        {
            InitializeComponent();
        }
        void Listele()
        {
            OdemeTurleriGridControl.DataSource = odemeTuruDal.OdemeTuruListele(context);
        }
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOdemeTuruAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
        }



        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (OdemeTurleriGridView.OptionsView.ShowAutoFilterRow == true)
            {
                OdemeTurleriGridView.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                OdemeTurleriGridView.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void PicBoxAcik_Click(object sender, EventArgs e)
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

        private void OdemeTuruFilterControl_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            int a = e.ToString().IndexOf("Value", 0, e.ToString().Length - 1);
            if (a != -1)
            {
                OdemeTuruFilterControl.ApplyFilter();
            }
        }

        private void FrmOdemeTuruAnasayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle();
        }

        private void BtnOdemeTuruHareket_Click(object sender, EventArgs e)
        {
            OdemeTuruHareket();
        }

        private void OdemeTuruGridView_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = OdemeTurleriGridView.RowCount;
            groupControl2.Text = "Buton Menü        Toplam Listelenen Kayıt Sayısı : " + satirsayisi;
        }

        private void btnOdemeTuruFiltreIptal_Click(object sender, EventArgs e)
        {
            OdemeTuruFilterControl.FilterString = null;
            OdemeTuruFilterControl.ApplyFilter();
        }

        private void btnOdemeTuruFiltre_Click(object sender, EventArgs e)
        {
            OdemeTuruFilterControl.ApplyFilter();
        }

        private void toolStripMenuItemEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Ekle()
        {
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(new Entities.Tables.OdemeTuru());
            form.ShowDialog();
            if (form.kayitedildi)
            {
                Listele();
                context.KullaniciLoglari.Add(new KullaniciLog
                {
                    KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                    KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                    YapilanIslem = "Ödeme Türü Ekle",
                    YapilanIslemTarihi = DateTime.Now
                });
                context.SaveChanges();
            }
        }

        private void toolStripMenuItemDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle();
        }

        private void Duzenle()
        {
            if (OdemeTurleriGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Düzenlenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(OdemeTurleriGridView.GetFocusedRowCellValue(colId));
                FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(odemeTuruDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen));
                form.ShowDialog();
                if (form.kayitedildi)
                {
                    Listele();
                    string logSecilen = OdemeTurleriGridView.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Ödeme Türü Düzenle -  " + logSecilen,
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }

        private void toolStripMenuItemSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            if (OdemeTurleriGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Listelenecek Kayıt Bulunamadı.");
            }
            else
            {
                if (XtraMessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    secilen = Convert.ToInt32(OdemeTurleriGridView.GetFocusedRowCellValue(colId));
                    odemeTuruDal.Delete(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen);
                    odemeTuruDal.Save(context);
                    Listele();
                    string logSecilen = OdemeTurleriGridView.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Ödeme Türü Sil -  " + logSecilen,
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }

        private void toolStripMenuItemHareket_Click(object sender, EventArgs e)
        {
            OdemeTuruHareket();
        }

        private void OdemeTuruHareket()
        {
            if (OdemeTurleriGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Listelenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(OdemeTurleriGridView.GetFocusedRowCellValue(colId));
                FrmOdemeTuruHareket form = new FrmOdemeTuruHareket(secilen);
                form.ShowDialog();
            }
        }

        private void toolStripMenuItemGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}