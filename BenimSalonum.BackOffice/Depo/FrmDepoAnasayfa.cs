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
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Depo
{
    public partial class FrmDepoAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        DepoDAL depoDal = new DepoDAL();
        private int secilen;
        ExportTool export;
        public FrmDepoAnasayfa()
        {
            InitializeComponent();
            export = new ExportTool(this, DepoGridView, dropDownButton1);
        }
        public void Listele()
        {
            DepoGridControl.DataSource = depoDal.GetALL(context);
        }

        private void FrmDepoAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmDepoAnasayfa_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (DepoGridView.OptionsView.ShowAutoFilterRow == true)
            {
                DepoGridView.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                DepoGridView.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnCariFiltre_Click(object sender, EventArgs e)
        {
            DepoFilterControl.ApplyFilter();

        }

        private void btnCariFiltreIptal_Click(object sender, EventArgs e)
        {
            DepoFilterControl.FilterString = null;
            DepoFilterControl.ApplyFilter();
        }

        private void DepoFilterControl_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            int a = e.ToString().IndexOf("Value", 0, e.ToString().Length - 1);
            if (a != -1)
            {
                DepoFilterControl.ApplyFilter();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle();
        }

        private void btnDepoHareket_Click(object sender, EventArgs e)
        {
            DepoHareket();
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

        private void DepoGridView_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = DepoGridView.RowCount;
            groupControl2.Text = "Buton Menü        Toplam Listelenen Kayıt Sayısı : " + satirsayisi;
        }

        private void toolStripMenuItemEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Ekle()
        {
            FrmDepoIslem form = new FrmDepoIslem(new Entities.Tables.Depo());
            form.ShowDialog();
            if (form.kayitedildi)
            {
                Listele();
                context.KullaniciLoglari.Add(new KullaniciLog
                {
                    KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                    KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                    SonGirisTarihi = DateTime.Now,
                    YapilanIslem = "Depo Ekle" ,
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
            if (DepoGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Düzenlenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(DepoGridView.GetFocusedRowCellValue(colId));
                FrmDepoIslem form = new FrmDepoIslem(depoDal.GetByFilter(context, c => c.Id == secilen));
                form.ShowDialog();
                if (form.kayitedildi)
                {
                    Listele();
                    string logSecilen = DepoGridView.GetFocusedRowCellValue(colDepoKodu).ToString();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Depo Düzenle -  "+logSecilen,
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
            if (DepoGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Silinecek Kayıt Bulunamadı.");
            }
            else
            {
                if (XtraMessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    secilen = Convert.ToInt32(DepoGridView.GetFocusedRowCellValue(colId));
                    depoDal.Delete(context, c => c.Id == secilen);
                    depoDal.Save(context);
                    Listele();

                    string logSecilen = DepoGridView.GetFocusedRowCellValue(colDepoKodu).ToString();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Depo Sil -  "+logSecilen,
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }

        private void toolStripMenuItemHareket_Click(object sender, EventArgs e)
        {
            DepoHareket();
        }

        private void DepoHareket()
        {
            if (DepoGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Listelenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(DepoGridView.GetFocusedRowCellValue(colId));
                FrmDepoHareket form = new FrmDepoHareket(secilen);
                form.ShowDialog();
            }
        }

        private void toolStripMenuItemGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}