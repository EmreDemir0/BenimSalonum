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
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.BackOffice.Cari
{
    public partial class FrmCariAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        CariDAL cariDal = new CariDAL();
        private Nullable<int> secilen;
        string logSecilen;

        ExportTool export;
        public FrmCariAnasayfa()
        {
            InitializeComponent();
            export = new ExportTool(this, CariGridView, dropDownButton1);
            RoleTool.RolleriYukle(this);

        }
        public void GetAll()
        {
            CariGridControl.DataSource = cariDal.CariListele(context);
        }

        private void btnCariFiltre_Click(object sender, EventArgs e)
        {
            CariFilterControl.ApplyFilter();
        }

        private void btnCariFiltreIptal_Click(object sender, EventArgs e)
        {
            CariFilterControl.FilterString = null;
            CariFilterControl.ApplyFilter();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (CariGridView.OptionsView.ShowAutoFilterRow == true)
            {
                CariGridView.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                CariGridView.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void FrmCariAnasayfa_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
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

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            Kopyala();
        }

        private void CariFilterControl_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            int a = e.ToString().IndexOf("Value", 0, e.ToString().Length - 1);
            if (a != -1)
            {
                CariFilterControl.ApplyFilter();
            }
        }

        private void btnCariHareket_Click(object sender, EventArgs e)
        {
            CariHareket();

        }

        private void CariGridView_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = CariGridView.RowCount;
            groupControl2.Text = "Buton Menü        Toplam Listelenen Kayıt Sayısı : " + satirsayisi;
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

        private void toolStripMenuItemEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Ekle()
        {
            FrmCariIslem form = new FrmCariIslem(new Entities.Tables.Cari());
            form.ShowDialog();
            if (form.kayitedildi)
            {
                GetAll();
                context.KullaniciLoglari.Add(new KullaniciLog
                {
                    KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                    KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                    YapilanIslem = "Cari Ekle ",
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
            if (CariGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Düzenlenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(CariGridView.GetFocusedRowCellValue(colId));
                logSecilen = CariGridView.GetFocusedRowCellValue(colCariKodu).ToString();

                FrmCariIslem form = new FrmCariIslem(cariDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen));
                form.ShowDialog();
                if (form.kayitedildi)
                {
                    GetAll();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Cari Düzenle -  " + logSecilen,
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
            if (!CariGridView.RowCount.Equals(0))
            {
                int secilenSatir = (int)CariGridView.GetFocusedRowCellValue(colId);
                logSecilen = CariGridView.GetFocusedRowCellValue(colCariKodu).ToString();

                Entities.Tables.Fis secilen = new Entities.Tables.Fis();

                if (secilen.CariId == secilenSatir)
                {
                    XtraMessageBox.Show("Bu Cariye Ait Hareketler Bulunmaktadır.Silme İşlemi Gerçekleştirilemez.");
                }
                else
                {
                    if (XtraMessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cariDal.Delete(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilenSatir);
                        cariDal.Save(context);
                        GetAll();
                        GetAll();
                        context.KullaniciLoglari.Add(new KullaniciLog
                        {
                            KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                            KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                            YapilanIslem = "Cari Sil -  " + logSecilen,
                            YapilanIslemTarihi = DateTime.Now
                        });
                        context.SaveChanges();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Silinecek Kayıt Bulunamadı.");
            }
        }

        private void toolStripMenuItemKopyala_Click(object sender, EventArgs e)
        {
            Kopyala();
        }

        private void Kopyala()
        {
            if (CariGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Kopyalanacak Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(CariGridView.GetFocusedRowCellValue(colId));


                Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
                cariEntity = cariDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen);
                FrmCariIslem form = new FrmCariIslem(cariEntity, true);
                form.ShowDialog();
                if (form.kayitedildi)
                {
                    GetAll();
                    logSecilen = CariGridView.GetFocusedRowCellValue(colCariKodu).ToString();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Cari Kopyala -  " + logSecilen,
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }

        private void toolStripMenuItemHareket_Click(object sender, EventArgs e)
        {
            CariHareket();
        }

        private void CariHareket()
        {

            if (CariGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Listelenecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(CariGridView.GetFocusedRowCellValue(colId));
                FrmCariHareket form = new FrmCariHareket(Convert.ToInt32(secilen));
                form.ShowDialog();
            }
        }

        private void toolStripMenuItemGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}