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
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.BackOffice.Kasa
{
    public partial class FrmKasaAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        BenimSalonumContext context = new BenimSalonumContext();
        int secilen;
        public FrmKasaAnasayfa()
        {
            InitializeComponent();
        }
        public void Guncelle()
        {
            KasaGridControl.DataSource = kasaDal.KasaListele(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void btnCariFiltre_Click(object sender, EventArgs e)
        {
            KasaFilterControl.ApplyFilter();
        }

        private void btnCariFiltreIptal_Click(object sender, EventArgs e)
        {
            KasaFilterControl.FilterString = null;
            KasaFilterControl.ApplyFilter();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void FrmKasaAnasayfa_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void FrmKasaAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnKasaHareket_Click(object sender, EventArgs e)
        {
            KasaHareket();
        }

        private void KasaFilterControl_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            int a = e.ToString().IndexOf("Value", 0, e.ToString().Length - 1);
            if (a != -1)
            {
                KasaFilterControl.ApplyFilter();
            }
        }

        private void toolStripMenuItemEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Ekle()
        {
            FrmKasaIslem form = new FrmKasaIslem(new Entities.Tables.Kasa());
            form.ShowDialog();
            if (form.kasakayitedildi)
            {
                Guncelle();
                context.KullaniciLoglari.Add(new KullaniciLog
                {
                    KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                    KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                    YapilanIslem = "Kasa Ekle",
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

            if (KasaGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Düzenlenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(KasaGridView.GetFocusedRowCellValue(colId));
                FrmKasaIslem form = new FrmKasaIslem(kasaDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen));
                form.ShowDialog();
                if (form.kasakayitedildi)
                {
                    Guncelle();
                    string logSecilen = KasaGridView.GetFocusedRowCellValue(colKasaKodu).ToString();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Kasa Düzenle -  " + logSecilen,
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
            if (KasaGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Silinecek Kayıt Bulunamadı.");
            }
            else
            {
                if (XtraMessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    secilen = Convert.ToInt32(KasaGridView.GetFocusedRowCellValue(colId));
                    kasaDal.Delete(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen);
                    kasaDal.Save(context);
                    Guncelle();
                    string logSecilen = KasaGridView.GetFocusedRowCellValue(colKasaKodu).ToString();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Kasa Sil -  " + logSecilen,
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }

        private void toolStripMenuItemHareket_Click(object sender, EventArgs e)
        {
            KasaHareket();
        }

        private void KasaHareket()
        {
            if (KasaGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Listelenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(KasaGridView.GetFocusedRowCellValue(colId));
                FrmKasaHareket form = new FrmKasaHareket(secilen);
                form.ShowDialog();
            }
        }

        private void toolStripMenuItemGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}