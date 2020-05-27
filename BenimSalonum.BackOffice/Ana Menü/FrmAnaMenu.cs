using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.BackOffice.Ana_Menü;
using System.Net;
using System.Reflection;
using System.Diagnostics;
using BenimSalonum.BackOffice.Stok;
using BenimSalonum.BackOffice.Cari;
using BenimSalonum.BackOffice.Fis;
using BenimSalonum.BackOffice.Stok_Hareketleri;
using BenimSalonum.BackOffice.Kasa_Hareketleri;
using BenimSalonum.BackOffice.İndirim;
using BenimSalonum.BackOffice.Fiyat_Değiştir;
using BenimSalonum.BackOffice.Hızlı_Satış;
using BenimSalonum.BackOffice.Personeller;
using BenimSalonum.BackOffice.Kasa;
using BenimSalonum.BackOffice.Depo;
using BenimSalonum.BackOffice.Ödeme_Türü;
using BenimSalonum.BackOffice.Sms;
using BenimSalonum.BackOffice.Döviz_Kurları;
using BenimSalonum.BackOffice.Ayarlar;
using BenimSalonum.Backup;
using BenimSalonum.Entities.Tools;
using BenimSalonum.Admin;
using BenimSalonum.Reports.Stok;
using BenimSalonum.BackOffice.Raporlar;
using BenimSalonum.Reports.Fatura_ve_Fiş;
using BenimSalonum.BackOffice.Ajanda;
using BenimSalonum.Update;
using BenimSalonum.BackOffice.Tanim;

namespace BenimSalonum.BackOffice
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FrmStokAnasayfa frmStokAnasayfa;
        FrmCariAnasayfa frmCariAnasayfa;
        FrmKasaAnasayfa frmKasaAnasayfa;
        FrmDepoAnasayfa frmDepoAnasayfa;
        FrmOdemeTuruAnasayfa frmOdemeTuruAnasayfa;
        FrmTanim frmTanim;
        FrmFisAnasayfa frmFisAnasayfa;
        FrmAnaMenuBilgi frmAnaMenuBilgi;
        FrmStokHareketleri frmStokHareketleri;
        FrmKasaHareketleri frmKasaHareketleri;
        FrmTopluFiyatDegistir frmTopluFiyatDegistir;
        FrmPersonelAnasayfa frmPersonelAnasayfa;
        FrmIndirim frmIndirim;
        FrmRaporListesi frmRaporListesi;
        FrmRaporDuzenle frmRaporDuzenle;
        FrmAjanda frmAjanda;
        FrmSms frmSms;
        FrmHizliSatis frmHizliSatis;
        FrmDovizKurlari frmDovizKurlari;
        FrmAyarlar frmAyarlar;
        FrmUpdate frmUpdate;
        FrmBackup frmBackUp;
        FrmEtiketOlustur frmEtiketOlustur;
        FrmOzgunRaporHazirla frmOzgunRaporHazirla;
        public static bool HakkindaAcikmi = false;
        public static bool YardimAcikmi = false;
        public static bool MesajYazAcikmi = false;
        public static bool WebSitemizAcikmi = false;
        public FrmAnaMenu()
        {
            FrmKullaniciGiris frmKullaniciGiris = new FrmKullaniciGiris();
            frmKullaniciGiris.ShowDialog();

            if (frmKullaniciGiris.girisBasarili)
            {
                InitializeComponent();
            }
            else
            {
                foreach (var process in Process.GetProcessesByName("BenimSalonum.BackOffice"))
                {
                    process.CloseMainWindow();
                    process.Kill();
                }
            }
            FrmDovizKurlari frm = new FrmDovizKurlari();
            frm.timerDoviz.Enabled = true;
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            if (frmAnaMenuBilgi == null || frmAnaMenuBilgi.IsDisposed)
            {
                frmAnaMenuBilgi = new FrmAnaMenuBilgi();
                frmAnaMenuBilgi.MdiParent = this;
                frmAnaMenuBilgi.Show();
            }

            RoleTool.RolleriYukle(ribbonControlAnaMenu);
            try
            {
                barKullaniciAdi.Caption = $"Giriş Yapan Kullanıcı : {RoleTool.kullaniciEntity.KullaniciAdi + "ID : " + RoleTool.kullaniciEntity.KullaniciID}";
            }
            catch (Exception)
            {
            }

        }
        BenimSalonumContext context = new BenimSalonumContext();
        CariDAL cariDal = new CariDAL();



        private void barButtonStok_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmStokAnasayfa == null || frmStokAnasayfa.IsDisposed)
            {
                frmStokAnasayfa = new FrmStokAnasayfa();
                frmStokAnasayfa.MdiParent = this;
                frmStokAnasayfa.Show();
            }
        }

        private void barButtonCari_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmCariAnasayfa == null || frmCariAnasayfa.IsDisposed)
            {
                frmCariAnasayfa = new FrmCariAnasayfa();
                frmCariAnasayfa.MdiParent = this;
                frmCariAnasayfa.Show();
            }
        }

        private void barButtonFisFatura_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmFisAnasayfa == null || frmFisAnasayfa.IsDisposed)
            {
                frmFisAnasayfa = new FrmFisAnasayfa();
                frmFisAnasayfa.MdiParent = this;
                frmFisAnasayfa.Show();
            }
        }

        private void barButtonStokHareket_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmStokHareketleri == null || frmStokHareketleri.IsDisposed)
            {
                frmStokHareketleri = new FrmStokHareketleri();
                frmStokHareketleri.MdiParent = this;
                frmStokHareketleri.Show();
            }
        }

        private void barButtonKasaHareket_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmKasaHareketleri == null || frmKasaHareketleri.IsDisposed)
            {
                frmKasaHareketleri = new FrmKasaHareketleri();
                frmKasaHareketleri.MdiParent = this;
                frmKasaHareketleri.Show();
            }
        }

        private void barButtonFrontOffice_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start($"{Application.StartupPath}\\BenimSalonum.FrontOffice.exe");
        }

        private void barButtonIndirim_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmIndirim == null || frmIndirim.IsDisposed)
            {
                frmIndirim = new FrmIndirim();
                frmIndirim.MdiParent = this;
                frmIndirim.Show();
            }
        }

        private void barButtonTopluFiyat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmTopluFiyatDegistir == null || frmTopluFiyatDegistir.IsDisposed)
            {
                frmTopluFiyatDegistir = new FrmTopluFiyatDegistir();
                frmTopluFiyatDegistir.MdiParent = this;
                frmTopluFiyatDegistir.Show();
            }
        }

        private void barButtonHizliSatisAyar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmHizliSatis == null || frmHizliSatis.IsDisposed)
            {
                frmHizliSatis = new FrmHizliSatis();
                frmHizliSatis.MdiParent = this;
                frmHizliSatis.Show();
            }
        }

        private void barButtonPersonel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmPersonelAnasayfa == null || frmPersonelAnasayfa.IsDisposed)
            {
                frmPersonelAnasayfa = new FrmPersonelAnasayfa();
                frmPersonelAnasayfa.MdiParent = this;
                frmPersonelAnasayfa.Show();
            }
        }

        private void barButtonKasa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmKasaAnasayfa == null || frmKasaAnasayfa.IsDisposed)
            {
                frmKasaAnasayfa = new FrmKasaAnasayfa();
                frmKasaAnasayfa.MdiParent = this;
                frmKasaAnasayfa.Show();
            }
        }

        private void barButtonDepo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmDepoAnasayfa == null || frmDepoAnasayfa.IsDisposed)
            {
                frmDepoAnasayfa = new FrmDepoAnasayfa();
                frmDepoAnasayfa.MdiParent = this;
                frmDepoAnasayfa.Show();
            }
        }

        private void barButtonOdemeTuru_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmOdemeTuruAnasayfa == null || frmOdemeTuruAnasayfa.IsDisposed)
            {
                frmOdemeTuruAnasayfa = new FrmOdemeTuruAnasayfa();
                frmOdemeTuruAnasayfa.MdiParent = this;
                frmOdemeTuruAnasayfa.Show();
            }
        }

        private void barButtonSms_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmSms == null || frmSms.IsDisposed)
            {
                frmSms = new FrmSms(context.KullaniciAyarlari.FirstOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID));
                frmSms.MdiParent = this;
                frmSms.Show();
            }
        }

        private void barButtonDovizKur_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmDovizKurlari == null || frmDovizKurlari.IsDisposed)
            {
                frmDovizKurlari = new FrmDovizKurlari();
                frmDovizKurlari.MdiParent = this;
                frmDovizKurlari.Show();
            }
        }
        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem form11 = new FrmFisIslem(null, e.Item.Caption, _kullaniciAyarlariEntity: context.KullaniciAyarlari.FirstOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID));
            form11.ShowDialog();
        }

        private void barButtonAyar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmAyarlar == null || frmAyarlar.IsDisposed)
            {
                frmAyarlar = new FrmAyarlar(context.KullaniciAyarlari.FirstOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID));
                frmAyarlar.MdiParent = this;
                frmAyarlar.Show();
            }
        }

        private void barButtonYedek_ItemClick(object sender, ItemClickEventArgs e)
        {
            //  Process.Start($"{Application.StartupPath}\\BenimSalonum.BackUp.exe");
            if (frmBackUp == null || frmBackUp.IsDisposed)
            {
                frmBackUp = new FrmBackup();
                frmBackUp.ShowDialog();
            }
        }

        private void barButtonGuncelleme_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebClient indir = new WebClient();
            string programVersion = Assembly.Load("BenimSalonum.BackOffice").GetName().Version.ToString();
            string guncelVersion = indir.DownloadString("http://localhost/version.txt");
            if (programVersion != guncelVersion)
            {
                if (frmUpdate == null || frmUpdate.IsDisposed)
                {
                    frmUpdate = new FrmUpdate();
                    frmUpdate.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Programınız Güncel.");
            }
        }

        private void barButtonRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmRaporListesi == null || frmRaporListesi.IsDisposed)
            {
                frmRaporListesi = new FrmRaporListesi();
                frmRaporListesi.ShowDialog();
            }
        }

        private void barButtonRaporDuzenle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmRaporDuzenle == null || frmRaporDuzenle.IsDisposed)
            {
                frmRaporDuzenle = new FrmRaporDuzenle();
                frmRaporDuzenle.ShowDialog();
            }
        }

        private void barButtonOzgunRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmOzgunRaporHazirla == null || frmOzgunRaporHazirla.IsDisposed)
            {
                frmOzgunRaporHazirla = new FrmOzgunRaporHazirla();
                frmOzgunRaporHazirla.MdiParent = this;
                frmOzgunRaporHazirla.Show();
            }
        }

        private void barButtonEtiket_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmEtiketOlustur == null || frmEtiketOlustur.IsDisposed)
            {
                frmEtiketOlustur = new FrmEtiketOlustur();
                frmEtiketOlustur.ShowDialog();
            }
        }

        private void barButtonAjanda_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmAjanda == null || frmAjanda.IsDisposed)
            {
                frmAjanda = new FrmAjanda();
                frmAjanda.ShowDialog();
            }
        }

        private void FrmAnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == RoleTool.kullaniciEntity.KullaniciAdi).Aktif = false;
            context.SaveChanges();
        }
    }
}


