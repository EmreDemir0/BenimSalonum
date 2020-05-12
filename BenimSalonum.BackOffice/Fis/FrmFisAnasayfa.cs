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
using BenimSalonum.Reports.Fatura_ve_Fiş;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.BackOffice.Fis
{
    public partial class FrmFisAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        public FrmFisAnasayfa()
        {
            InitializeComponent();
        }
        public void ListeleFisler()
        {
            FislerGridControl.DataSource = fisDal.GetALL(context);
        }
        private void Duzenle()
        {
            Entities.Tables.Fis secilen = (Entities.Tables.Fis)FislerGridView.GetFocusedRow();
            if (secilen.FisTuru == "Fiş Ödemesi")
            {
                FrmFisIslem form =
    new FrmFisIslem(secilen.FisBaglantiKodu, null);
                form.ShowDialog();
            }
            else
            {
                FrmFisIslem form =
    new FrmFisIslem(secilen.FisKodu, null);
                form.ShowDialog();
            }
        }
        private void Sil()
        {
            if (FislerGridView.RowCount.Equals(0))
            {
                XtraMessageBox.Show("Silinecek Kayıt Bulunamadı.");
            }
            else
            {
                Entities.Tables.Fis secilen = (Entities.Tables.Fis)FislerGridView.GetFocusedRow();
                if (!string.IsNullOrEmpty(secilen.FisBaglantiKodu))
                {
                    if (MessageBox.Show($"Bu Fiş ile birlikte bağlantılı olan {secilen.FisBaglantiKodu} kodlu fişte silinecektir. Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        fisDal.Delete(context, c => c.FisKodu == secilen.FisBaglantiKodu);
                        fisDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                        kasaHareketDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                        stokHareketDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                        fisDal.Save(context);
                        ListeleFisler();

                        string logSecilen = FislerGridView.GetFocusedRowCellValue(colFisKodu).ToString();
                        context.KullaniciLoglari.Add(new KullaniciLog
                        {
                            KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                            KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                            YapilanIslem = "Fiş & Fatura Sil" + logSecilen,
                            YapilanIslemTarihi = DateTime.Now
                        });
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı",
                                            MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        fisDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                        kasaHareketDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                        stokHareketDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                        fisDal.Save(context);
                        ListeleFisler();

                        string logSecilen = FislerGridView.GetFocusedRowCellValue(colFisKodu).ToString();
                        context.KullaniciLoglari.Add(new KullaniciLog
                        {
                            KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                            KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                            YapilanIslem = "Fiş & Fatura Sil" + logSecilen,
                            YapilanIslemTarihi = DateTime.Now
                        });
                        context.SaveChanges();
                    }
                }
            }
        }
        private void FaturayaCevir()
        {
            Entities.Tables.Fis secilen = (Entities.Tables.Fis)FislerGridView.GetFocusedRow();
            if (!secilen.FisTuru.Contains("Sipariş Fişi"))
            {
                XtraMessageBox.Show("Faturalandırmak İstediğiniz Fiş Bir Sipariş Fişi Değildir.");
            }
            else
            {
                FrmFisIslem form = new FrmFisIslem(secilen.FisKodu, null, siparisFaturalandir: true);
                form.ShowDialog();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFisAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnCariFiltre_Click(object sender, EventArgs e)
        {
            FislerFilterControl.ApplyFilter();
        }

        private void BtnCariFiltreIptal_Click(object sender, EventArgs e)
        {
            FislerFilterControl.FilterString = null;
            FislerFilterControl.ApplyFilter();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (FislerGridView.OptionsView.ShowAutoFilterRow == true)
            {
                FislerGridView.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                FislerGridView.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void FislerFilterControl_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            int a = e.ToString().IndexOf("Value", 0, e.ToString().Length - 1);
            if (a != -1)
            {
                FislerFilterControl.ApplyFilter();
            }
        }

        private void FrmFisAnasayfa_Load(object sender, EventArgs e)
        {
            ListeleFisler();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ListeleFisler();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();

        }
        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Caption);
            form.ShowDialog();
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            popupFaturalar.ShowPopup(barManager1, MousePosition);
        }

        private void btnFaturaCevir_Click(object sender, EventArgs e)
        {
            FaturayaCevir();
        }

        private void toolStripMenuItemEkle_Click(object sender, EventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, "Toptan Satış Faturası");
            form.ShowDialog();
        }

        private void toolStripMenuItemDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle();
        }

        private void toolStripMenuItemSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void toolStripMenuItemGuncelle_Click(object sender, EventArgs e)
        {
            ListeleFisler();
        }

        private void toolStripMenuItemCevir_Click(object sender, EventArgs e)
        {
            FaturayaCevir();
        }

        private void toolStripMenuItemYazdir_Click(object sender, EventArgs e)
        {
            string secilen = FislerGridView.GetFocusedRowCellValue(colFisKodu).ToString();
            ReportsPrintTool yazdir = new ReportsPrintTool();
            rptFatura fatura = new rptFatura(secilen);
            yazdir.RaporYazdir(fatura, ReportsPrintTool.Belge.Fatura);
        }
    }

}