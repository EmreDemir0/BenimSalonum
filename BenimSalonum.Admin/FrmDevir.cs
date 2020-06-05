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
using System.Data.SqlClient;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Tools;
using System.Data.Entity;
using BenimSalonum.Entities.Tools.LoadingTool;

namespace BenimSalonum.Admin
{
    public partial class FrmDevir : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext kaynakContext;

        SqlConnectionStringBuilder connKaynak = new SqlConnectionStringBuilder();

        BenimSalonumContext hedefContext = new BenimSalonumContext();

        SqlConnectionStringBuilder connHedef = new SqlConnectionStringBuilder();

        List<string> dbList;

        CodeTool kodOlustur;

        LoadingTool yukelemeFormu;

        public FrmDevir()
        {
            //Ayrı bir program daha tasarlayıp entity ile içerisinde bütün veritabanlarının listelendiği bir uygulama
            //Veritabanı adlarını depoladığımız bir tablo oluşturulacak. sql sorgusu ile
            // yeni bir tablo güncellemesi geldiğinde bunu anaprogram üzerinden değil
            //ek yazılım ile tablo güncelleme kolon ekleme vb yapılacak.
            //dbcontext alanında otomatik güncelleme alanını açacağız ,tabloları programa otomatik olarak çağıracağız.
            //client tarafında kaynak kodlara güncelleme ile gereklşi alanlar kodlanacak
            //db updati ayrı bir program yapacak.
            //bu sırada seçili olan veri tabanlarında devir işlemini yönetici panelinden elle yapacağız daha sonra dilersek 
            //otomatik işleme dökeceğiz
            // yinede .
            //Tablo adınıda programın açılışında settings ini ye kaydettiği connection stringten al .
            InitializeComponent();
            yukelemeFormu = new LoadingTool(this);

            kodOlustur = new CodeTool(this, CodeTool.Table.Devir);
            connKaynak.DataSource = "DESKTOP-6BQ24TV\\SQLEXPRESS";
            connKaynak.InitialCatalog = "master";
            connKaynak.IntegratedSecurity = true;
            //hedefContext.Database.SqlQuery()
            kaynakContext = new BenimSalonumContext(connKaynak.ConnectionString);
            dbList = kaynakContext.Database.SqlQuery<string>("Select name From master.dbo.sysdatabases Where name like 'BS%'").ToList();
            KaynakDbYukle();
            HedefDbYukle();
        }
        private void KaynakDbYukle()
        {
            foreach (var item in dbList)
            {
                CheckButton buton = new CheckButton
                {
                    Name = item,
                    Text = item,
                    GroupIndex = 1,
                    Height = 100,
                    Width = 100
                };
                buton.Click += KaynakSec;
                flowKaynak.Controls.Add(buton);
            }
        }

        private void KaynakSec(object sender, EventArgs e)
        {
            CheckButton buton = (CheckButton)sender;

            connKaynak.DataSource = "DESKTOP-6BQ24TV\\SQLEXPRESS";
            connKaynak.InitialCatalog = buton.Text;
            connKaynak.UserID = "sa";
            connKaynak.Password = "Emre1502.";

            kaynakContext = new BenimSalonumContext(connKaynak.ConnectionString);
        }

        private void HedefDbYukle()
        {
            SimpleButton yeniEkle = new SimpleButton
            {
                Name = "YeniDonemEkle",
                Text = "Yeni Dönem Ekle",
                Width = 100,
                Height = 100
            };
            yeniEkle.Click += YeniDonemEkle;
            flowHedef.Controls.Add(yeniEkle);

            foreach (var item in dbList)
            {
                CheckButton buton = new CheckButton
                {
                    Name = item,
                    Text = item,
                    GroupIndex = 2,
                    Height = 100,
                    Width = 100
                };
                buton.Click += HedefSec;
                flowHedef.Controls.Add(buton);
            }
        }

        private void YeniDonemEkle(object sender, EventArgs e)
        {
            SimpleButton butonDonem = (SimpleButton)sender;
            FrmDonemSec form = new FrmDonemSec();
            form.ShowDialog();
            if (!dbList.Contains("BS" + form.donem))
            {
                if (!string.IsNullOrEmpty(form.donem))
                {
                    yukelemeFormu.AnimasyonBaslat();
                    dbList.Add("BS" + form.donem);
                    CheckButton buton = new CheckButton
                    {
                        Name = "BS" + form.donem,
                        //Text = item.Replace("BS", ""),
                        Text = "BS" + form.donem,
                        GroupIndex = 2,
                        Height = 100,
                        Width = 100
                    };
                    buton.Click += HedefSec;
                    flowHedef.Controls.Add(buton);

                    connHedef.DataSource = "DESKTOP-6BQ24TV\\SQLEXPRESS";
                    connHedef.InitialCatalog = buton.Text;
                    connHedef.UserID = "sa";
                    connHedef.Password = "Emre1502.";

                    hedefContext = new BenimSalonumContext(connHedef.ConnectionString, true);

                    hedefContext.Database.CreateIfNotExists();
                    if (!hedefContext.Kullanicilar.Any(c => c.KullaniciAdi == "Yönetici"))
                    {
                        hedefContext.Kullanicilar.Add(new Kullanici
                        {
                            Durumu = true,
                            KullaniciID = "1",
                            KullaniciAdi = "Yönetici",
                            Parola = "12345"
                        });
                        hedefContext.Kodlar.Add(new Kod
                        {
                            Tablo = "Fis",
                            OnEki = "FO",
                            SonDeger = 0
                        });
                        hedefContext.Kodlar.Add(new Kod
                        {
                            Tablo = "Fis",
                            OnEki = "FİS",
                            SonDeger = 0
                        });
                        hedefContext.Depolar.Add(new Depo
                        {
                            KullaniciID = "1",
                            DepoAdi = "Depo",
                            DepoKodu = "01",
                        });
                        hedefContext.OdemeTurleri.Add(new OdemeTuru
                        {
                            KullaniciID = "1",
                            OdemeTuruAdi = "Nakit",
                            OdemeTuruKodu = "01",
                        });
                        hedefContext.Kasalar.Add(new Kasa
                        {
                            KullaniciID = "1",
                            KasaAdi = "AnaKasa",
                            KasaKodu = "01",
                        });
                        hedefContext.Personeller.Add(new Personel
                        {
                            Durumu = true,
                            KullaniciID = "1",
                            PersonelAdi = "Deneme Personeli",
                            PersonelKodu = "01",
                            PersonelGiris = DateTime.Now
                        });
                        hedefContext.KullaniciAyarlari.Add(new KullaniciAyarlari
                        {
                            KullaniciID = "1",
                            GenelAyarlar_GuncellemeKontrol=true
                        });
                        hedefContext.Tanimlar.Add(new Tanim
                        {
                            KullaniciID = "1",
                            Turu = "CariGrubu",
                            Tanimi = "Müşteri"
                        });
                        hedefContext.Tanimlar.Add(new Tanim
                        {
                            KullaniciID = "1",
                            Turu = "CariGrubu",
                            Tanimi = "Firma"
                        });
                        hedefContext.Tanimlar.Add(new Tanim
                        {
                            KullaniciID = "1",
                            Turu = "CariGrubu",
                            Tanimi = "Cari"
                        });
                        hedefContext.SaveChanges();
                    }
                    yukelemeFormu.AnimasyonBitir();
                }
            }
            else
            {
                XtraMessageBox.Show("Seçilen Dönem Zaten Oluşturulmuştur.");
            }
        }

        private void HedefSec(object sender, EventArgs e)
        {
            CheckButton buton = (CheckButton)sender;

            connHedef.DataSource = "DESKTOP-6BQ24TV\\SQLEXPRESS";
            connHedef.InitialCatalog = buton.Text;
            connHedef.UserID = "sa";
            connHedef.Password = "Emre1502.";

            hedefContext = new BenimSalonumContext(connHedef.ConnectionString);
        }

        private void toggleStokAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleStokAktar.IsOn)
            {
                toggleStokHareketAktar.Enabled = true;
                toggleStokGirisCikisAktar.Enabled = true;
                toggleStokIndirimAktar.Enabled = true;
                toggleStokHizliSatisAktar.Enabled = true;
            }
            else
            {
                toggleStokHareketAktar.Enabled = false;
                toggleStokGirisCikisAktar.Enabled = false;
                toggleStokIndirimAktar.Enabled = false;
                toggleStokHizliSatisAktar.Enabled = false;
            }
        }

        private void toggleCariAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleCariAktar.IsOn)
            {
                toggleCariBakiyeAktar.Enabled = true;
                toggleCariBorcAlacakAktar.Enabled = true;
            }
            else
            {
                toggleCariBakiyeAktar.Enabled = false;
                toggleCariBorcAlacakAktar.Enabled = false;
            }
        }

        private void toggleKasaAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleKasaAktar.IsOn)
            {
                lookUpKasaKodu.Enabled = true;
            }
            else
            {
                lookUpKasaKodu.Enabled = false;
            }
        }

        private void toggleDepoAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleDepoAktar.IsOn)
            {
                lookUpDepoKodu.Enabled = true;
            }
            else
            {
                lookUpDepoKodu.Enabled = false;
            }
        }

        private void toggleOdemeTuruAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleOdemeTuruAktar.IsOn)
            {
                lookUpOdemeTuruKodu.Enabled = true;
            }
            else
            {
                lookUpOdemeTuruKodu.Enabled = false;
            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            DevirYap();
        }
        private void DevirYap()
        {
            //OdemeTuru Aktarımı
            OdemeTuru yeniOdeme = new OdemeTuru();

            if (toggleOdemeTuruAktar.IsOn)
            {
                foreach (var item in kaynakContext.OdemeTurleri.AsNoTracking().ToList())
                {
                    hedefContext.OdemeTurleri.Add(item);
                }
            }
            else
            {
                yeniOdeme.OdemeTuruKodu = "001";
                yeniOdeme.OdemeTuruAdi = "Nakit";
                hedefContext.OdemeTurleri.Add(yeniOdeme);
            }
            //Kasa Aktarımı
            Kasa yeniKasa = new Kasa();

            if (toggleKasaAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kasalar.AsNoTracking().ToList())
                {
                    hedefContext.Kasalar.Add(item);
                }
            }
            else
            {
                yeniKasa.KasaKodu = "001";
                yeniKasa.KasaAdi = "Merkez Kasa";
                hedefContext.Kasalar.Add(yeniKasa);
            }

            //Depo Aktarımı
            Depo yeniDepo = new Depo();

            if (toggleDepoAktar.IsOn)
            {
                foreach (var item in kaynakContext.Depolar.AsNoTracking().ToList())
                {
                    hedefContext.Depolar.Add(item);
                }
            }
            else
            {
                yeniDepo.DepoKodu = "001";
                yeniDepo.DepoAdi = "Merkez Depo";
                hedefContext.Depolar.Add(yeniDepo);
            }

            hedefContext.SaveChanges();
            //Tanım Aktarımı
            if (toggleTanimlariAktar.IsOn)
            {
                foreach (var item in kaynakContext.Tanimlar.AsNoTracking().ToList())
                {
                    hedefContext.Tanimlar.Add(item);
                }
            }
            //Kod Aktarımı
            if (toggleKodlariAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kodlar.AsNoTracking().ToList())
                {
                    hedefContext.Kodlar.Add(item);
                }
            }
            //Ajanda Aktarımı
            if (toggleAjandaAktar.IsOn)
            {
                foreach (var item in kaynakContext.EFAppointments.AsNoTracking().ToList())
                {
                    hedefContext.EFAppointments.Add(item);
                }
                foreach (var item in kaynakContext.EFResources.AsNoTracking().ToList())
                {
                    hedefContext.EFResources.Add(item);
                }
            }
            //Kullanıcı Aktarımı
            if (toggleKullaniciAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kullanicilar.AsNoTracking().ToList())
                {
                    hedefContext.Kullanicilar.Add(item);
                }
                foreach (var item in kaynakContext.KullaniciRolleri.AsNoTracking().ToList())
                {
                    hedefContext.KullaniciRolleri.Add(item);
                }
            }
            //Kod Aktarımı
            if (toggleKodlariAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kodlar.AsNoTracking().ToList())
                {
                    hedefContext.Kodlar.Add(item);
                }
            }

            //Stok Aktarımı
            if (toggleStokAktar.IsOn)
            {
                StokDAL stokDal = new StokDAL();
                //iNDİRİM AKTARIMI
                if (toggleStokIndirimAktar.IsOn)
                {
                    foreach (var itemIndirim in kaynakContext.Indirimler.AsNoTracking().ToList())
                    {
                        hedefContext.Indirimler.Add(itemIndirim);
                    }
                }
                // HİZLİ SATIŞLAR AKTARIMI 
                if (toggleStokHizliSatisAktar.IsOn)
                {
                    foreach (var itemHizliSatisGrup in kaynakContext.HizliSatisGruplari.AsNoTracking().ToList())
                    {
                        hedefContext.HizliSatisGruplari.Add(itemHizliSatisGrup);
                    }
                    foreach (var itemHizliSatis in kaynakContext.HizliSatislar.AsNoTracking().ToList())
                    {
                        hedefContext.HizliSatislar.Add(itemHizliSatis);
                    }
                }

                foreach (var item in kaynakContext.Stoklar.AsNoTracking().ToList())
                {
                    hedefContext.Stoklar.Add(item);

                    if (toggleStokHareketAktar.IsOn && toggleStokGirisCikisAktar.IsOn)
                    {
                        StokBakiye bakiye = stokDal.StokBakiyesi(kaynakContext, item.Id);

                        if (bakiye.MevcutStok != 0)
                        {
                            Fis stokDevirFisi = new Fis();
                            StokHareket hareketGiris = new StokHareket();


                            //STOK GİRİŞ
                            stokDevirFisi.FisTuru = "Stok Devir Fişi";
                            stokDevirFisi.FisKodu = kodOlustur.yeniDevirFisiOlustur();
                            stokDevirFisi.Tarih = DateTime.Now;
                            stokDevirFisi.ToplamTutar = bakiye.StokGiris * item.AlisFiyati1; // bu gereksiz olabilr.
                            hedefContext.Fisler.Add(stokDevirFisi);

                            hareketGiris.StokId = item.Id;
                            hareketGiris.Hareket = "Stok Giriş";
                            hareketGiris.Miktar = bakiye.StokGiris;
                            hareketGiris.FisKodu = stokDevirFisi.FisKodu;
                            hareketGiris.BirimFiyati = item.AlisFiyati1;
                            hareketGiris.Kdv = item.AlisKdv;
                            hareketGiris.Tarih = DateTime.Now;
                            hareketGiris.DepoId = toggleDepoAktar.IsOn ? Convert.ToInt32(lookUpDepoKodu.EditValue) : yeniDepo.Id;
                            //Clone aldığımızda problem olmaması için. sadece kaydı ifledik.
                            if (bakiye.StokGiris > 0)
                            {
                                hedefContext.StokHareketleri.Add(hareketGiris);
                            }

                            //STOK ÇIKIŞ
                            if (bakiye.StokCikis > 0)
                            {

                                Fis StokCikisDevir = stokDevirFisi.Clone();
                                StokCikisDevir.FisKodu = kodOlustur.yeniDevirFisiOlustur();
                                StokCikisDevir.ToplamTutar = bakiye.StokCikis * item.SatisFiyati1;
                                hedefContext.Fisler.Add(StokCikisDevir);

                                StokHareket hareketCikis = hareketGiris.Clone();
                                hareketCikis.FisKodu = StokCikisDevir.FisKodu;
                                hareketCikis.Hareket = "Stok Çıkış";
                                hareketCikis.Miktar = bakiye.StokCikis;
                                hareketCikis.BirimFiyati = item.SatisFiyati1;
                                hareketCikis.Kdv = item.SatisKdv;
                                hedefContext.StokHareketleri.Add(hareketCikis);
                            }
                        }
                    }
                }
            }

            //CARİ DEVİR İŞLEMLERİ
            if (toggleCariAktar.IsOn)
            {


                foreach (var item in kaynakContext.Cariler.AsNoTracking().ToList())
                {
                    CariDAL cariDal = new CariDAL();
                    CariBakiye bakiye = cariDal.CariBakiyesi(kaynakContext, item.Id);
                    hedefContext.Cariler.Add(item);
                    if (toggleCariBakiyeAktar.IsOn && toggleCariBorcAlacakAktar.IsOn)
                    {
                        if (bakiye.Bakiye != 0)
                        {
                            Fis cariDevir = new Fis();
                            cariDevir.CariId = item.Id;
                            cariDevir.FisTuru = "Cari Devir Fişi";
                            cariDevir.Tarih = DateTime.Now;
                            cariDevir.FisKodu = kodOlustur.yeniDevirFisiOlustur();
                            cariDevir.ToplamTutar = Math.Abs(bakiye.Bakiye);
                            if (bakiye.Bakiye < 0)
                            {
                                cariDevir.Borc = Math.Abs(bakiye.Bakiye);
                                cariDevir.Alacak = null;
                                hedefContext.Fisler.Add(cariDevir);

                                KasaHareket kasaBorc = new KasaHareket();
                                kasaBorc.FisKodu = cariDevir.FisKodu;
                                kasaBorc.CariId = item.Id;
                                kasaBorc.Hareket = "Kasa Çıkış";
                                kasaBorc.KasaId = toggleKasaAktar.IsOn ? Convert.ToInt32(lookUpKasaKodu.EditValue) : yeniKasa.Id;
                                kasaBorc.OdemeTuruId = toggleOdemeTuruAktar.IsOn ? Convert.ToInt32(lookUpOdemeTuruKodu.EditValue) : yeniOdeme.Id;
                                kasaBorc.Tarih = DateTime.Now;
                                kasaBorc.Tutar = Math.Abs(bakiye.Bakiye);
                                hedefContext.KasaHareketleri.Add(kasaBorc);
                            }
                            else
                            {
                                cariDevir.Borc = null;
                                cariDevir.Alacak = Math.Abs(bakiye.Bakiye); ;
                                hedefContext.Fisler.Add(cariDevir);

                                KasaHareket kasaAlacak = new KasaHareket();
                                kasaAlacak.FisKodu = cariDevir.FisKodu;
                                kasaAlacak.CariId = item.Id;
                                kasaAlacak.Hareket = "Kasa Giriş";
                                kasaAlacak.KasaId = toggleKasaAktar.IsOn ? Convert.ToInt32(lookUpKasaKodu.EditValue) : yeniKasa.Id;
                                kasaAlacak.OdemeTuruId = toggleOdemeTuruAktar.IsOn ? Convert.ToInt32(lookUpOdemeTuruKodu.EditValue) : yeniOdeme.Id;
                                kasaAlacak.Tarih = DateTime.Now;
                                kasaAlacak.Tutar = Math.Abs(bakiye.Bakiye);
                                hedefContext.KasaHareketleri.Add(kasaAlacak);
                            }
                        }
                    }
                    else if (toggleCariBakiyeAktar.IsOn && !toggleCariBorcAlacakAktar.IsOn)
                    {
                        if (bakiye.Alacak != 0)
                        {
                            Fis alacakFis = new Fis();
                            alacakFis.CariId = item.Id;
                            alacakFis.FisTuru = "Cari Devir Fişi";
                            alacakFis.Tarih = DateTime.Now;
                            alacakFis.FisKodu = kodOlustur.yeniDevirFisiOlustur();
                            alacakFis.Alacak = Math.Abs(bakiye.Bakiye);
                            alacakFis.Borc = null;
                            alacakFis.ToplamTutar = bakiye.Alacak;

                            hedefContext.Fisler.Add(alacakFis);

                            KasaHareket alacak = new KasaHareket();
                            alacak.FisKodu = alacakFis.FisKodu;
                            alacak.CariId = item.Id;
                            alacak.Hareket = "Kasa Giriş";
                            alacak.KasaId = toggleKasaAktar.IsOn ? Convert.ToInt32(lookUpKasaKodu.EditValue) : yeniKasa.Id;
                            alacak.OdemeTuruId = toggleOdemeTuruAktar.IsOn ? Convert.ToInt32(lookUpOdemeTuruKodu.EditValue) : yeniOdeme.Id;
                            alacak.Tarih = DateTime.Now;
                            alacak.Tutar = Math.Abs(bakiye.Alacak);
                            hedefContext.KasaHareketleri.Add(alacak);
                        }
                        if (bakiye.Borc != 0)
                        {
                            Fis borcFis = new Fis();
                            borcFis.CariId = item.Id;
                            borcFis.FisTuru = "Cari Devir Fişi";
                            borcFis.Tarih = DateTime.Now;
                            borcFis.FisKodu = kodOlustur.yeniDevirFisiOlustur();
                            borcFis.Alacak = null;
                            borcFis.Borc = bakiye.Borc;
                            borcFis.ToplamTutar = bakiye.Alacak;

                            hedefContext.Fisler.Add(borcFis);

                            KasaHareket kasaBorc = new KasaHareket();
                            kasaBorc.FisKodu = borcFis.FisKodu;
                            kasaBorc.CariId = item.Id;
                            kasaBorc.Hareket = "Kasa Çıkış";
                            kasaBorc.KasaId = toggleKasaAktar.IsOn ? Convert.ToInt32(lookUpKasaKodu.EditValue) : yeniKasa.Id;
                            kasaBorc.OdemeTuruId = toggleOdemeTuruAktar.IsOn ? Convert.ToInt32(lookUpOdemeTuruKodu.EditValue) : yeniOdeme.Id;
                            kasaBorc.Tarih = DateTime.Now;
                            kasaBorc.Tutar = Math.Abs(bakiye.Alacak);
                            hedefContext.KasaHareketleri.Add(kasaBorc);
                        }
                    }
                }
            }
            if (toggleCariPersonelleriAktar.IsOn)
            {
                foreach (var item in kaynakContext.Personeller.AsNoTracking().ToList())
                {
                    hedefContext.Personeller.Add(item);
                }
            }

            hedefContext.SaveChanges();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == wizardPage2 && e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                lookUpDepoKodu.Properties.DataSource = kaynakContext.Depolar.AsNoTracking().ToList();
                lookUpKasaKodu.Properties.DataSource = kaynakContext.Kasalar.AsNoTracking().ToList();
                lookUpOdemeTuruKodu.Properties.DataSource = kaynakContext.OdemeTurleri.AsNoTracking().ToList();
            }
        }

        private void wizardControl1_FinishClick_1(object sender, CancelEventArgs e)
        {
            DevirYap();
        }
    }
}