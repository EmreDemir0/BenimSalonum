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
using BenimSalonum.BackOffice.Fis;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.BackOffice.Personeller
{
    public partial class FrmPersonelAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        PersonelDAL personelDal = new PersonelDAL();
        int secilen;
        ExportTool export;
        public FrmPersonelAnasayfa()
        {
            InitializeComponent();
            export = new ExportTool(this, PersonellerGridView, dropDownButton1);
        }
        private void Listele()
        {
            PersonellerGridControl.DataSource = personelDal.PersonelListele(context);
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

        private void FrmPersonelAnasayfa_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            {
                if (PersonellerGridView.OptionsView.ShowAutoFilterRow == true)
                {
                    PersonellerGridView.OptionsView.ShowAutoFilterRow = false;
                }
                else
                {
                    PersonellerGridView.OptionsView.ShowAutoFilterRow = true;
                }
            }
        }

        private void btnCariFiltre_Click(object sender, EventArgs e)
        {
            PersonellerFilterControl.ApplyFilter();

        }

        private void btnCariFiltreIptal_Click(object sender, EventArgs e)
        {
            PersonellerFilterControl.FilterString = null;
            PersonellerFilterControl.ApplyFilter();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();

        }

        private void FrmPersonelAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void PersonellerFilterControl_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            int a = e.ToString().IndexOf("Value", 0, e.ToString().Length - 1);
            if (a != -1)
            {
                PersonellerFilterControl.ApplyFilter();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle();
        }

        private void btnPersonelHareket_Click(object sender, EventArgs e)
        {
            PersonelHareket();
        }

        private void btnHakedis_Click(object sender, EventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, "Hakediş Fişi");
            form.ShowDialog();
        }

        private void toolStripMenuItemEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Ekle()
        {
            FrmPersonelIslem form = new FrmPersonelIslem(new Entities.Tables.Personel());
            form.ShowDialog();
            if (form.kayitedildi)
            {
                Listele();
                context.KullaniciLoglari.Add(new KullaniciLog
                {
                    KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                    KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                    YapilanIslem = "Personel Ekle ",
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
            if (PersonellerGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Düzenlenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(PersonellerGridView.GetFocusedRowCellValue(colId));
                FrmPersonelIslem form = new FrmPersonelIslem(personelDal.GetByFilter(context, c =>c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen));
                form.ShowDialog();
                if (form.kayitedildi)
                {
                    Listele();
                    string logSecilen = PersonellerGridView.GetFocusedRowCellValue(colPersonelKodu).ToString();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Personel Düzenle -  " + logSecilen,
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
            if (PersonellerGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Silinecek Kayıt Bulunamadı.");
            }
            else
            {
                if (XtraMessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    secilen = Convert.ToInt32(PersonellerGridView.GetFocusedRowCellValue(colId));
                    personelDal.Delete(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen);
                    personelDal.Save(context);
                    Listele();
                    string logSecilen = PersonellerGridView.GetFocusedRowCellValue(colPersonelKodu).ToString();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Personel Sil -  " + logSecilen,
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }

        private void toolStripMenuItemHareket_Click(object sender, EventArgs e)
        {
            PersonelHareket();
        }

        private void PersonelHareket()
        {
            if (PersonellerGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Listelenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(PersonellerGridView.GetFocusedRowCellValue(colId));
                FrmPersonelHareket form = new FrmPersonelHareket(secilen);
                form.ShowDialog();
            }
        }

        private void toolStripMenuItemGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}