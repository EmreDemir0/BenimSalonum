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

namespace BenimSalonum.BackOffice.Stok
{
    public partial class FrmStokAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        StokDAL stokDal = new StokDAL();
        private int secilen;
        private string logSecilen;
        ExportTool export;

        public FrmStokAnasayfa()
        {
            InitializeComponent();
            export = new ExportTool(this, gridStok, dropDownButton1);

            RoleTool.RolleriYukle(this);
        }
        public void GetAll()
        {
            StokGridControl.DataSource = stokDal.StokListele(context);
        }

        private void FrmStokAnasayfa_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStok.OptionsView.ShowAutoFilterRow == true)
            {
                gridStok.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStok.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void Duzenle()
        {
            if (gridStok.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Düzenelencek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(gridStok.GetFocusedRowCellValue(colId));

                logSecilen = gridStok.GetFocusedRowCellValue(colStokKodu).ToString();

                FrmStokIslem form = new FrmStokIslem(stokDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen));
                form.ShowDialog();
                if (form.stokkayitedildi)
                {
                    GetAll();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Stok Düzenle - " + logSecilen,
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
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


        private void btnKopyala_Click(object sender, EventArgs e)
        {
            Kopyala();
        }

        private void Kopyala()
        {
            if (gridStok.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Kopyalanacak Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(gridStok.GetFocusedRowCellValue(colId));
                logSecilen = gridStok.GetFocusedRowCellValue(colStokKodu).ToString();


                Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
                stokEntity = stokDal.GetByFilter(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilen);
                FrmStokIslem form = new FrmStokIslem(stokEntity, true);
                form.ShowDialog();
                if (form.stokkayitedildi)
                {
                    GetAll();
                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                        KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                        YapilanIslem = "Stok Kopyala -  " + logSecilen,
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            StokHareket();
        }

        private void StokHareket()
        {
            if (gridStok.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Listenelecek Kayıt Bulunamadı.");
            }
            else
            {
                secilen = Convert.ToInt32(gridStok.GetFocusedRowCellValue(colId));
                string secilenAd = gridStok.GetFocusedRowCellValue(colStokAdi).ToString();
                FrmStokHareket form = new FrmStokHareket(secilen);
                form.ShowDialog();
            }
        }

        private void FrmStokAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
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

        private void StokFilterControl_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            int a = e.ToString().IndexOf("Value", 0, e.ToString().Length - 1);
            if (a != -1)
            {
                StokFilterControl.ApplyFilter();
            }
        }

        private void btnStokFiltre_Click(object sender, EventArgs e)
        {
            StokFilterControl.ApplyFilter();
        }

        private void btnStokFiltreIptal_Click(object sender, EventArgs e)
        {
            StokFilterControl.FilterString = null;
            StokFilterControl.ApplyFilter();
        }

        private void gridStok_RowCountChanged(object sender, EventArgs e)
        {
            int satirsayisi = gridStok.RowCount;
            groupControlMenu.Text = "Buton Menü        Toplam Listelenen Kayıt Sayısı : " + satirsayisi;
        }

        private void toolStripMenuItemEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Ekle()
        {
            FrmStokIslem form = new FrmStokIslem(new Entities.Tables.Stok());
            form.ShowDialog();
            if (form.stokkayitedildi)
            {
                GetAll();
                context.KullaniciLoglari.Add(new KullaniciLog
                {
                    KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                    KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                    YapilanIslem = "Stok Ekle",
                    YapilanIslemTarihi = DateTime.Now
                });
                context.SaveChanges();
            }
        }

        private void toolStripMenuItemDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle();
        }

        private void toolStripMenuItemSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            if (!gridStok.RowCount.Equals(0))
            {
                int secilenSatir = (int)gridStok.GetFocusedRowCellValue(colId);
                logSecilen = gridStok.GetFocusedRowCellValue(colStokKodu).ToString();
                Entities.Tables.StokHareket secilen = new Entities.Tables.StokHareket();

                if (secilen.StokId == secilenSatir)
                {
                    XtraMessageBox.Show("Bu Stoğa Ait Hareketler Bulunmaktadır.Silme İşlemi Gerçekleştirilemez.");
                }
                else
                {
                    if (XtraMessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        stokDal.Delete(context, c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == secilenSatir);
                        stokDal.Save(context);
                        GetAll();
                        context.KullaniciLoglari.Add(new KullaniciLog
                        {
                            KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                            KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                            YapilanIslem = "Stok Sil - " + logSecilen,
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

        private void toolStripMenuItemHareket_Click(object sender, EventArgs e)
        {
            StokHareket();
        }
    }
}