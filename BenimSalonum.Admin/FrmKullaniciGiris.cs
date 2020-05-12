using BenimSalonum.Entities.Context;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using BenimSalonum.Entities.Tools;
using System.Diagnostics;
using BenimSalonum.Entities.Tables;
using System.Net;
using System.Reflection;
using System.Data.SqlClient;

namespace BenimSalonum.Admin
{
    public partial class FrmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        public bool girisBasarili = false;
        public FrmKullaniciGiris()
        {
            InitializeComponent();

            if (!InternetKontrol())
            {
                if (MessageBox.Show("İnternet Bağlantınız Bulunmamaktadır. Bu Yüzden Uygulama Kapatılacaktır.", "Uyarı", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            //SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            //sqlConnectionStringBuilder.ConnectionString = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataBaseAyarlari_BaglantiCumlesi);


            //if (!ConnectionTool.CheckConnection(sqlConnectionStringBuilder.ConnectionString))
            //{
            //    FrmBaglantiAyarlari frmBaglantiAyarlari = new FrmBaglantiAyarlari();
            //    frmBaglantiAyarlari.ShowDialog();

            //}

            //BURAYA VERİ TABANI İLE EŞ ZAMANLI ÇALIŞAN EĞER DB ERİŞİM VARSA BU USERİN STRİNGİNİ DB İLE SETTİNGS.İNİ DEKİNİ KIYASLA FARKLIYSA DB DEKİNİ AL SETTİNG İNİ İPTAL OLAMIYORU ÇÜNKÜ CONTEXTE OKUTMAK İÇİN DEĞİŞKEN KULLANMAYI DENE
            //DEĞİŞKENİDE FORM GENELİNDE ATA VE PARAMETRE OLARAK GÖNDER. DENE.

            WebClient indir = new WebClient();
            string programVersion = Assembly.Load("BenimSalonum.BackOffice").GetName().Version.ToString();

            string guncelVersion = indir.DownloadString("http://localhost/version.txt");

            if (programVersion != guncelVersion)
            {
                if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrol)))
                {
                    if (MessageBox.Show(
                            "Programın yeni bir sürümü mevcut. Güncellemek ister misiniz ?",
                            "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start($"{Application.StartupPath}\\BenimSalonum.Update.exe");
                        foreach (var process in Process.GetProcessesByName("BenimSalonum.BackOffice"))
                        {
                            process.CloseMainWindow();
                            process.Kill();
                        }
                    }
                    else
                    {
                        foreach (var process in Process.GetProcessesByName("BenimSalonum.BackOffice"))
                        {
                            process.CloseMainWindow();
                            process.Kill();
                        }
                    }
                }
            }

            txtKullaniciAdi.Text = "Yönetici";
            txtParola.Text = "12345";


            using (var context = new BenimSalonumContext())
            {
                context.Database.CreateIfNotExists();

                if (!context.Kullanicilar.Any(c => c.KullaniciAdi == "Yönetici"))
                {
                    context.Kullanicilar.Add(new Kullanici
                    {
                        Durumu = true,
                        KullaniciAdi = "Yönetici",
                        Parola = "12345"
                    });
                    context.Kodlar.Add(new Kod
                    {
                        Tablo = "Fis",
                        OnEki = "FO",
                        SonDeger = 1
                    });
                    context.Kodlar.Add(new Kod
                    {
                        Tablo = "Fis",
                        OnEki = "FİS",
                        SonDeger = 1
                    });
                    context.SaveChanges();
                }
            }
        }

        public bool InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUnuttum_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullaniciAdi.Text))
            {
                FrmParolaUnuttum form = new FrmParolaUnuttum(txtKullaniciAdi.Text);
                form.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Kayıtlı Kullanıcı Bulunamadı veya Kullanıcı Adı Alanı Boş.");
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(c =>c.KullaniciAdi == txtKullaniciAdi.Text && c.Parola == txtParola.Text))
            {
                girisBasarili = true;
                bool aktif = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text).Aktif;

                string sonGiris = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text).SonGirisTarihi.ToString();

                if (aktif)
                {
                    MessageBox.Show("Bu Kullanıcı Daha Önceden Oturum Açmış. " + "\n" + txtKullaniciAdi.Text + " - " + sonGiris);
                    context = new BenimSalonumContext();
                }
                else
                {
                    context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text).Aktif = true;
                    context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text).SonGirisTarihi = DateTime.Now;

                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID=context.Kullanicilar.SingleOrDefault(c=>c.KullaniciAdi==txtKullaniciAdi.Text).KullaniciID,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        SonGirisTarihi = DateTime.Now,
                        YapilanIslem = "Oturum Açma",
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                    RoleTool.kullaniciEntity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text);
                    this.Close();
                }
            }
            else
            {
                XtraMessageBox.Show("Girilen Kullanıcı Adı veya Parola Yanlış.");
                txtParola.Text = null;
            }
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            FrmSistemYonetici form = new FrmSistemYonetici();
            form.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKullanicilar newfrm = new FrmKullanicilar();
            newfrm.ShowDialog();
        }
    }
}
