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
            kodOlustur = new CodeTool(this, CodeTool.Table.Fis);
            connKaynak.DataSource = "(localdb)";
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
                    //Text = item.Replace("BS",""),
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

            connKaynak.DataSource = "DESKTOP-DBCCIPQ";
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
                    //Text = item.Replace("BS",""),
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
            CheckButton butonDonem = (CheckButton)sender;
            FrmDonemSec form = new FrmDonemSec();
            form.ShowDialog();
            if (!dbList.Contains("BS" + form.donem))
            {
                if (!string.IsNullOrEmpty(form.donem))
                {
                    dbList.Add("BS" + form.donem);
                    CheckButton buton = new CheckButton
                    {
                        Name = "BS" + form.donem,
                        //Text = item.Replace("BS",""),
                        Text = "BS" + form.donem,
                        GroupIndex = 2,
                        Height = 100,
                        Width = 100
                    };
                    buton.Click += HedefSec;
                    flowHedef.Controls.Add(buton);

                    connHedef.DataSource = "DESKTOP-DBCCIPQ";
                    connHedef.InitialCatalog = buton.Text;
                    connHedef.UserID = "sa";
                    connHedef.Password = "Emre1502.";

                    hedefContext = new BenimSalonumContext(connHedef.ConnectionString);

                    hedefContext.Database.CreateIfNotExists();
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

            connHedef.DataSource = "DESKTOP-DBCCIPQ";
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
            //Kasa Aktarımı
            if (toggleKasaAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kasalar.AsNoTracking().ToList())
                {
                    hedefContext.Kasalar.Add(item);
                }
            }
            else
            {
                Kasa yeniKasa = new Kasa();
                yeniKasa.KasaKodu = "001";
                yeniKasa.KasaAdi = "Merkez Kasa";
                hedefContext.Kasalar.Add(yeniKasa);
            }
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

            //Depo Aktarımı
            if (toggleDepoAktar.IsOn)
            {
                foreach (var item in kaynakContext.Depolar.AsNoTracking().ToList())
                {
                    hedefContext.Depolar.Add(item);
                }
            }
            else
            {
                Depo yeniDepo = new Depo();
                yeniDepo.DepoKodu = "001";
                yeniDepo.DepoAdi = "Merkez Depo";
                hedefContext.Depolar.Add(yeniDepo);
            }
            //OdemeTuru Aktarımı
            if (toggleOdemeTuruAktar.IsOn)
            {
                foreach (var item in kaynakContext.OdemeTurleri.AsNoTracking().ToList())
                {
                    hedefContext.OdemeTurleri.Add(item);
                }
            }
            else
            {
                OdemeTuru yeniOdeme = new OdemeTuru();
                yeniOdeme.OdemeTuruKodu = "001";
                yeniOdeme.OdemeTuruAdi = "Nakit";
                hedefContext.OdemeTurleri.Add(yeniOdeme);
            }
            //Stok Aktarımı
            if (toggleStokAktar.IsOn)
            {
                StokDAL stokDal = new StokDAL();


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
                            stokDevirFisi.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
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
                            hareketGiris.DepoId = toggleDepoAktar.IsOn ? Convert.ToInt32(lookUpDepoKodu.EditValue) : 1;
                            //Clone aldığımızda problem olmaması için. sadece kaydı ifledik.
                            if (bakiye.StokGiris > 0)
                            {
                                hedefContext.StokHareketleri.Add(hareketGiris);
                            }

                            //STOK ÇIKIŞ
                            if (bakiye.StokCikis > 0)
                            {

                                Fis StokCikisDevir = stokDevirFisi.Clone();
                                StokCikisDevir.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
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

    }
}