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
using DevExpress.Internal;
using DevExpress.XtraEditors.Drawing;
using BenimSalonum.Entities.Tools.LoadingTool;
using BenimSalonum.Entities.Tables.OtherTables;

namespace BenimSalonum.Admin
{
    public partial class FrmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();
        public bool girisBasarili = false;
        List<string> dbList = new List<string>();
        LoadingTool animasyon;

        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

        public FrmKullaniciGiris()
        {
            InitializeComponent();
            animasyon = new LoadingTool(this);
            //güncellemeleri giriş butonuna bastığında yapabilirsin yada direkt olarak herkes güncellesin.
            //zaten offline çalısmıyor internet varsada güncellesin.

            if (!InternetKontrol())
            {
                if (MessageBox.Show("İnternet Bağlantınız Bulunmamaktadır. Bu Yüzden Uygulama Kapatılacaktır.", "Uyarı", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            txtKullaniciAdi.Text = "Yönetici";
            txtParola.Text = "12345";

            dbListele();
            dbOlustur();

        }

        private void dbListele()
        {
            try
            {
                connectionStringBuilder.DataSource = "DESKTOP-6BQ24TV\\SQLEXPRESS";
                connectionStringBuilder.IntegratedSecurity = true;
                connectionStringBuilder.InitialCatalog = "master";
                context = new BenimSalonumContext(connectionStringBuilder.ConnectionString);

                dbList = context.Database.SqlQuery<string>("Select name From master.dbo.sysdatabases Where name like 'BS%'").ToList();
                foreach (var item in dbList)
                {
                    cmbDonem.Properties.Items.Add(item);
                }
                cmbDonem.SelectedIndex = 0;
            }
            catch (Exception)
            {
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
        void dbOlustur()
        {
            if (dbList.Count == 0)
            {
                FrmDonemSec form = new FrmDonemSec();
                form.ShowDialog();
                if (!String.IsNullOrEmpty(form.donem))
                {
                    connectionStringBuilder.DataSource = "DESKTOP-6BQ24TV\\SQLEXPRESS";
                    connectionStringBuilder.IntegratedSecurity = true;
                    connectionStringBuilder.InitialCatalog = "BS" + form.donem;
                    context = new BenimSalonumContext(connectionStringBuilder.ConnectionString, true);
                    animasyon.AnimasyonBaslat();
                    context.Database.CreateIfNotExists();
                    if (!context.Kullanicilar.Any(c => c.KullaniciAdi == "Yönetici"))
                    {
                        context.Kullanicilar.Add(new Kullanici
                        {
                            Durumu = true,
                            KullaniciID = "1",
                            KullaniciAdi = "Yönetici",
                            Parola = "12345"
                        });
                        context.Kodlar.Add(new Kod
                        {
                            KullaniciID = "1",
                            Tablo = "Fis",
                            OnEki = "FO",
                            SonDeger = 0
                        });
                        context.Kodlar.Add(new Kod
                        {
                            KullaniciID = "1",
                            Tablo = "Fis",
                            OnEki = "FİS",
                            SonDeger = 0
                        });
                        context.Depolar.Add(new Depo
                        {
                            KullaniciID = "1",
                            DepoAdi="Depo",
                            DepoKodu ="01",                        
                        });
                        context.OdemeTurleri.Add(new OdemeTuru
                        {
                            KullaniciID = "1",
                            OdemeTuruAdi = "Nakit",
                            OdemeTuruKodu = "01",
                        });
                        context.Kasalar.Add(new Kasa
                        {
                            KullaniciID = "1",
                            KasaAdi = "AnaKasa",
                            KasaKodu = "01",
                        });
                        context.Personeller.Add(new Personel
                        {
                            Durumu = true,
                            KullaniciID = "1",
                            PersonelAdi = "Deneme Personeli",
                            PersonelKodu = "01",
                            PersonelGiris=DateTime.Now
                        });
                        context.KullaniciAyarlari.Add(new KullaniciAyarlari
                        {
                            KullaniciID = "1",
                            GenelAyarlar_GuncellemeKontrol = true
                        });
                        context.Tanimlar.Add(new Tanim
                        {
                            KullaniciID = "1",
                            Turu = "CariGrubu",
                            Tanimi = "Müşteri"
                        });
                        context.Tanimlar.Add(new Tanim
                        {
                            KullaniciID = "1",
                            Turu = "CariGrubu",
                            Tanimi = "Firma"
                        });
                        context.Tanimlar.Add(new Tanim
                        {
                            KullaniciID = "1",
                            Turu = "CariGrubu",
                            Tanimi = "Cari"
                        });
                        context.SaveChanges();                      
                    }

                    dbListele();
                    animasyon.AnimasyonBitir();
                }
            }
        }
        private void btnUnuttum_Click(object sender, EventArgs e)
        {
            connectionStringBuilder.InitialCatalog = cmbDonem.Text;
            connectionStringBuilder.IntegratedSecurity = true;

            context = new BenimSalonumContext(connectionStringBuilder.ConnectionString);
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

            if (cmbDonem.Properties.Items.Count == 0 && string.IsNullOrEmpty(cmbDonem.Text))
            {
                XtraMessageBox.Show("Seçili Bir Dönem Bulunamadı.");
                return;
            }


            connectionStringBuilder.InitialCatalog = cmbDonem.Text;
            connectionStringBuilder.IntegratedSecurity = true;


            context = new BenimSalonumContext(connectionStringBuilder.ConnectionString);

            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.Parola == txtParola.Text))
            {
                girisBasarili = true;
                bool aktif = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text).Aktif;

                string sonGiris = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text).SonGirisTarihi.ToString();

                if (aktif)
                {
                    MessageBox.Show("Bu Kullanıcı Daha Önceden Oturum Açmış. " + "\n" + txtKullaniciAdi.Text + " - " + sonGiris);
                }
                else
                {
                    context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text).Aktif = true;
                    context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text).SonGirisTarihi = DateTime.Now;

                    context.KullaniciLoglari.Add(new KullaniciLog
                    {
                        KullaniciID = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text).KullaniciID,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        SonGirisTarihi = DateTime.Now,
                        YapilanIslem = "Oturum Açma",
                        YapilanIslemTarihi = DateTime.Now
                    });
                    context.SaveChanges();
                    RoleTool.kullaniciEntity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text);

                    //GÜNCELLEME

                    WebClient indir = new WebClient();
                    string programVersion = Assembly.Load("BenimSalonum.BackOffice").GetName().Version.ToString();
                    string guncelVersion = indir.DownloadString("http://localhost/version.txt");
                    if (programVersion != guncelVersion)
                    {
                        bool guncelleme = context.KullaniciAyarlari.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GenelAyarlar_GuncellemeKontrol;
                        if (guncelleme)
                        {
                            if (MessageBox.Show(
                                    "Programın yeni bir sürümü mevcut. Güncelleme işlemi başlatılacaktır.",
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
            try
            {
                connectionStringBuilder.InitialCatalog = cmbDonem.Text;
                connectionStringBuilder.IntegratedSecurity = true;


                context = new BenimSalonumContext(connectionStringBuilder.ConnectionString);

                if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.Parola == txtParola.Text))
                {
                    RoleTool.kullaniciEntity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text);

                    context = new BenimSalonumContext();
                    FrmKullaniciIslem frmKullanicilar = new FrmKullaniciIslem(context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text));
                    frmKullanicilar.ShowDialog();
                }
            }
            catch (Exception)
            {
            }

        }
    }
}
