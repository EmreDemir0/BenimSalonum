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
using System.Diagnostics;
using System.Net;
using System.Reflection;
using BenimSalonum.Entities.Context;

namespace BenimSalonum.BackOffice.Ana_Menü
{
    public partial class FrmAnaMenuBilgi : DevExpress.XtraEditors.XtraForm
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
        public FrmAnaMenuBilgi()
        {
            InitializeComponent();
        }

        private void tileStoklar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmStokAnasayfa == null || frmStokAnasayfa.IsDisposed)
            {
                frmStokAnasayfa = new FrmStokAnasayfa();
                frmStokAnasayfa.MdiParent = this;
                frmStokAnasayfa.Show();
            }
        }

        private void tileCariler_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmCariAnasayfa == null || frmCariAnasayfa.IsDisposed)
            {
                frmCariAnasayfa = new FrmCariAnasayfa();
                frmCariAnasayfa.MdiParent = this;
                frmCariAnasayfa.Show();
            }
        }

        private void tileFaturaFis_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmFisAnasayfa == null || frmFisAnasayfa.IsDisposed)
            {
                frmFisAnasayfa = new FrmFisAnasayfa();
                frmFisAnasayfa.MdiParent = this;
                frmFisAnasayfa.Show();
            }
        }

        private void tileItem40_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmIndirim == null || frmIndirim.IsDisposed)
            {
                frmIndirim = new FrmIndirim();
                frmIndirim.MdiParent = this;
                frmIndirim.Show();
            }
        }

        private void tileDepolar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmDepoAnasayfa == null || frmDepoAnasayfa.IsDisposed)
            {
                frmDepoAnasayfa = new FrmDepoAnasayfa();
                frmDepoAnasayfa.MdiParent = this;
                frmDepoAnasayfa.Show();
            }
        }

        private void tileOzgunRapor_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmOzgunRaporHazirla == null || frmOzgunRaporHazirla.IsDisposed)
            {
                frmOzgunRaporHazirla = new FrmOzgunRaporHazirla();
                frmOzgunRaporHazirla.MdiParent = this;
                frmOzgunRaporHazirla.Show();
            }
        }

        private void tileOdemeTurleri_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmOdemeTuruAnasayfa == null || frmOdemeTuruAnasayfa.IsDisposed)
            {
                frmOdemeTuruAnasayfa = new FrmOdemeTuruAnasayfa();
                frmOdemeTuruAnasayfa.MdiParent = this;
                frmOdemeTuruAnasayfa.Show();
            }
        }

        private void tileRaporlar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmRaporListesi == null || frmRaporListesi.IsDisposed)
            {
                frmRaporListesi = new FrmRaporListesi();
                frmRaporListesi.ShowDialog();
            }
        }

        private void tileAjanda_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmAjanda == null || frmAjanda.IsDisposed)
            {
                frmAjanda = new FrmAjanda();
                frmAjanda.ShowDialog();
            }
        }

        private void tileFrontOffice_ItemClick(object sender, TileItemEventArgs e)
        {
            Process.Start($"{Application.StartupPath}\\BenimSalonum.FrontOffice.exe");
        }

        private void tileKasalar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmKasaAnasayfa == null || frmKasaAnasayfa.IsDisposed)
            {
                frmKasaAnasayfa = new FrmKasaAnasayfa();
                frmKasaAnasayfa.MdiParent = this;
                frmKasaAnasayfa.Show();
            }
        }

        private void tileSms_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmSms == null || frmSms.IsDisposed)
            {
                frmSms = new FrmSms();
                frmSms.MdiParent = this;
                frmSms.Show();
            }
        }

        private void tileEtiket_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmEtiketOlustur == null || frmEtiketOlustur.IsDisposed)
            {
                frmEtiketOlustur = new FrmEtiketOlustur();
                frmEtiketOlustur.ShowDialog();
            }
        }

        private void tileHizliSatis_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmHizliSatis == null || frmHizliSatis.IsDisposed)
            {
                frmHizliSatis = new FrmHizliSatis();
                frmHizliSatis.MdiParent = this;
                frmHizliSatis.Show();
            }
        }

        private void tilePersoneller_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmPersonelAnasayfa == null || frmPersonelAnasayfa.IsDisposed)
            {
                frmPersonelAnasayfa = new FrmPersonelAnasayfa();
                frmPersonelAnasayfa.MdiParent = this;
                frmPersonelAnasayfa.Show();
            }
        }

        private void tileTopluFiyat_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmTopluFiyatDegistir == null || frmTopluFiyatDegistir.IsDisposed)
            {
                frmTopluFiyatDegistir = new FrmTopluFiyatDegistir();
                frmTopluFiyatDegistir.MdiParent = this;
                frmTopluFiyatDegistir.Show();
            }
        }

        private void FisIslem_Click(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form11 = new FrmFisIslem(null, e.Item.Text);
            form11.ShowDialog();
        }

        private void tileAyarlar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmAyarlar == null || frmAyarlar.IsDisposed)
            {
                BenimSalonumContext context = new BenimSalonumContext();
                frmAyarlar = new FrmAyarlar(context.KullaniciAyarlari.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).FirstOrDefault());
                frmAyarlar.MdiParent = this;
                frmAyarlar.Show();
            }
        }

        private void tileDovizKurlari_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmDovizKurlari == null || frmDovizKurlari.IsDisposed)
            {
                frmDovizKurlari = new FrmDovizKurlari();
                frmDovizKurlari.MdiParent = this;
                frmDovizKurlari.Show();
            }
        }

        private void tileGuncelleme_ItemClick(object sender, TileItemEventArgs e)
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

        private void tileYedekleme_ItemClick(object sender, TileItemEventArgs e)
        {
            if (frmBackUp == null || frmBackUp.IsDisposed)
            {
                frmBackUp = new FrmBackup();
                frmBackUp.ShowDialog();
            }
        }
    }
}