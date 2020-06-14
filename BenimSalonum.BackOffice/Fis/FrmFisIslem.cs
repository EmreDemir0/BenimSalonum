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
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.Tools;
using System.Data.Entity;
using BenimSalonum.Entities.Tables;
using BenimSalonum.BackOffice.Stok;
using BenimSalonum.BackOffice.Cari;
using BenimSalonum.BackOffice.Depo;
using BenimSalonum.BackOffice.Kasa;
using BenimSalonum.BackOffice.Personeller;

namespace BenimSalonum.BackOffice.Fis
{
    public partial class FrmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context = new BenimSalonumContext();

        FisDAL fisDal = new FisDAL();

        StokHareketDAL stokHareketDal = new StokHareketDAL();

        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();

        PersonelHareketDAL personelHareketDal = new PersonelHareketDAL();

        CariDAL cariDal = new CariDAL();

        private Nullable<int> _cariId;

        FisAyarlari ayarlar = new FisAyarlari();

        Entities.Tables.Fis _fisentity = new Entities.Tables.Fis();

        CariBakiye _entityBakiye = new CariBakiye();

        CodeTool kodOlustur;

        string gelenFisKodu;

        KullaniciAyarlari KullaniciAyarlariEntity;
        public FrmFisIslem(string fisKodu = null, string fisTuru = null, int? cariId = null, bool siparisFaturalandir = false, KullaniciAyarlari _kullaniciAyarlariEntity = null)
        {
            //  kodOlustur = new CodeTool(this, CodeTool.Table.Fis);


            InitializeComponent();
            gelenFisKodu = fisKodu;
            kodOlustur = new CodeTool(this, CodeTool.Table.Fis);

            txtMiktar.Font = new Font("Microsoft Sans Serif", 17);
            txtBarkod.Font = new Font("Microsoft Sans Serif", 17);
            txtOdenenTutar.Font = new Font("Microsoft Sans Serif", 10);
            txtOdenmesiGereken.Font = new Font("Microsoft Sans Serif", 10);
            txtIndirimToplam.Font = new Font("Microsoft Sans Serif", 10);
            txtIskontoOran.Font = new Font("Microsoft Sans Serif", 10);
            txtIskontoTutar.Font = new Font("Microsoft Sans Serif", 10);
            txtKdvToplam.Font = new Font("Microsoft Sans Serif", 10);
            txtToplam.Font = new Font("Microsoft Sans Serif", 10);
            txtAcikHesap.Font = new Font("Microsoft Sans Serif", 10);

            context.Depolar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();
            context.Stoklar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();
            context.Kasalar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();

            if (fisKodu != null)
            {
                _fisentity = context.Fisler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisKodu == fisKodu).SingleOrDefault();
                if (siparisFaturalandir)
                {
                    _fisentity.FisTuru = "Toptan Satış Faturası";//BURADA BİR SEÇME ŞANSI VER.
                }
                context.StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisKodu == fisKodu).Load();

                if (string.IsNullOrEmpty(_fisentity.FisBaglantiKodu))
                {
                    context.KasaHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisKodu == _fisentity.FisKodu).Load();
                }
                else
                {
                    context.KasaHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisKodu == _fisentity.FisBaglantiKodu).Load();
                }
                // context.KasaHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisKodu == fisKodu).Load();
                context.PersonelHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisKodu == fisKodu).Load();

                toggleBakiyeTuru.IsOn =
                    context.KasaHareketleri.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisKodu == fisKodu && c.Hareket == "Kasa Giriş") == 0;
                if (_fisentity.CariId != null)
                {
                    _entityBakiye = this.cariDal.CariBakiyesi(context, Convert.ToInt32(_fisentity.CariId));
                    lblAlacak.Text = _entityBakiye.Alacak.ToString("C2");
                    lblBakiye.Text = _entityBakiye.Bakiye.ToString("C2");
                    lblBorc.Text = _entityBakiye.Borc.ToString("C2");
                    txtCariAdi.Text = _fisentity.Cari.CariAdi;
                    txtCariKodu.Text = _fisentity.Cari.CariKodu;
                    txtIskontoOran.Value = (decimal)_fisentity.IskontoOrani;
                }
                else
                {
                    timer1.Enabled = true;
                }
            }
            else
            {
                _fisentity.FisTuru = fisTuru;
                timer1.Enabled = true;
                KullaniciAyarlariEntity = _kullaniciAyarlariEntity;
            }

            // timer1.Enabled = false;
            //txtTarih.DateTime = DateTime.Now;


            txtFisTuru.DataBindings.Add("Text", _fisentity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);//verinin üstüne tıklandıgında
            txtKod.DataBindings.Add("Text", _fisentity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);//kaybolmasını engelliyor
            txtTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBelgeNo.DataBindings.Add("Text", _fisentity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);

            txtFaturaUnvani.DataBindings.Add("Text", _fisentity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _fisentity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _fisentity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _fisentity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _fisentity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _fisentity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _fisentity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _fisentity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);

            cmbAy.Month = DateTime.Now.Month;
            for (int i = DateTime.Now.Year - 2; i <= DateTime.Now.Year + 2; i++)
            {
                cmbYil.Properties.Items.Add(i);
            }

            cmbYil.Text = DateTime.Now.Year.ToString();

            gridControlStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridControlKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            gridControlPersonelHareket.DataSource = context.PersonelHareketleri.Local.ToBindingList();



            FisAyar();
            Toplamlar();
            OdenenTutarGuncelle();
            ButonlariYukle();
            kodOlustur.barButonOlustur();
        }
        private void ButonlariYukle()
        {
            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Tag = item.Id,
                    Text = item.OdemeTuruAdi,
                    Height = 42,
                    Width = 125
                };
                buton.Click += OdemeEkle_Click;
                flowOdemeTurleri.Controls.Add(buton);
            }
            var PersonelSecimIptal = new CheckButton
            {
                Name = "Yok",
                Text = "Yok",
                GroupIndex = 1,
                Height = 42,
                Width = 125,
                Checked = _fisentity.PlasiyerId == null
            };
            PersonelSecimIptal.Click += PersonelYukle_Click;
            flowPersonel.Controls.Add(PersonelSecimIptal);

            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.Id.ToString(),
                    Text = item.PersonelAdi,
                    GroupIndex = 1,
                    Height = 42,
                    Width = 125,
                    Checked = item.Id == _fisentity.PlasiyerId
                };
                buton.Click += PersonelYukle_Click;
                flowPersonel.Controls.Add(buton);
            }
        }
        private void PersonelYukle_Click(object sender, EventArgs e)
        {
            var buton = sender as CheckButton;
            if (buton.Name == "Yok")
            {
                _fisentity.PlasiyerId = null;
            }
            else
            {
                _fisentity.PlasiyerId = Convert.ToInt32(buton.Name);
            }
        }
        private void FisAyar()
        {
            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.BakiyeTuru = "Alacak";
                    lblBaslik.Appearance.ImageIndex = 0;
                    navPersonelIslem.Dispose();
                    break;
                case "Perakende Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.BakiyeTuru = "Borç";
                    lblBaslik.Appearance.ImageIndex = 1;
                    navPersonelIslem.Dispose();
                    break;
                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.BakiyeTuru = "Borç";
                    lblBaslik.Appearance.ImageIndex = 2;
                    navPersonelIslem.Dispose();
                    break;
                case "Alış İade Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.BakiyeTuru = "Borç ";
                    lblBaslik.Appearance.ImageIndex = 3;
                    navPersonelIslem.Dispose();
                    break;
                case "Satış İade Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.BakiyeTuru = "Alacak";
                    lblBaslik.Appearance.ImageIndex = 4;
                    navPersonelIslem.Dispose();
                    break;
                case "Sayım Fazlası Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    lblBaslik.Appearance.ImageIndex = 5;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    break;
                case "Sayım Eksiği Fişi":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    lblBaslik.Appearance.ImageIndex = 6;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    break;
                case "Stok Devir Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    lblBaslik.Appearance.ImageIndex = 7;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    break;
                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    ayarlar.BakiyeTuru = "Alacak";
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    panelOdeme.Visible = false;
                    panelIskonto.Visible = false;
                    labelControlKdv.Visible = false;
                    txtKdvToplam.Visible = false;
                    panelToplam.Top = 20;
                    nav2.SelectedPage = navOdemeEkrani;
                    break;
                case "Ödeme Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    ayarlar.BakiyeTuru = "Borç";
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    panelOdeme.Visible = false;
                    panelIskonto.Visible = false;
                    labelControlKdv.Visible = false;
                    txtKdvToplam.Visible = false;
                    nav2.SelectedPage = navOdemeEkrani;
                    break;
                case "Cari Devir Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    panelOdeme.Visible = false;
                    panelIskonto.Visible = false;
                    labelControlKdv.Visible = false;
                    txtKdvToplam.Visible = false;
                    panelToplam.Top = 20;
                    //BUNU ARAŞTIR//panelCariDevir.Visible = true;
                    nav2.SelectedPage = navOdemeEkrani;
                    txtKod.Width = 186;
                    break;
                case "Hakediş Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    navSatisEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPlasiyerBilgi.Dispose();
                    panelIskonto.Visible = false;
                    labelControlKdv.Visible = false;
                    txtKdvToplam.Visible = false;
                    nav2.SelectedPage = navPersonelIslem;
                    break;
                case "Sipariş Fişi(Alınan)":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();

                    break;
                case "Sipariş Fişi(Verilen)":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    break;
            }
        }
        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);

            if (ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                FrmOdemeEkrani form = new FrmOdemeEkrani(Convert.ToInt32(buton.Tag));

                form.ShowDialog();
                if (form.entity != null)
                {
                    kasaHareketDal.AddOrUpDate(context, form.entity);
                    OdenenTutarGuncelle();
                }
            }
            else
            {
                if (txtOdenmesiGereken.Value <= 0)
                {
                    MessageBox.Show("Ödenmesi gereken tutar zaten ödenmiş durumdadır.");
                }
                else
                {
                    if (txtFisTuru.Text != "Hakediş Fişi")
                    {
                        KasaHareket entityKasaHareket = new KasaHareket
                        {
                            OdemeTuruId = Convert.ToInt32(buton.Tag),
                            KasaId = Convert.ToInt32(context.KullaniciAyarlari.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).SatisAyarlari_VarsayilanKasa),
                            Tarih = DateTime.Now,
                            Tutar = txtOdenmesiGereken.Value
                        };
                        kasaHareketDal.AddOrUpDate(context, entityKasaHareket);
                        OdenenTutarGuncelle();
                    }
                    else
                    {
                        for (int i = 0; i < gridViewPersonelHareket.RowCount; i++)
                        {
                            KasaHareket entityKasaHareket = new KasaHareket
                            {
                                //Burayı Kontrol Et. Sıkıntı Olacak.
                                CariId = _cariId,//kasa harekete personel ve cari diye ayrım yapılabilir yada personelde bir cari gibi kayıt edebiliriz personel tablosunda cari türünü personel yapabiliriz.
                                //cari türüne personel ekleyip seçerekte yapabiliriz.
                                //en mantıklısı cari ve personeli birleştirmek mantıklı olacaktır.
                                OdemeTuruId = Convert.ToInt32(buton.Tag),
                                KasaId = Convert.ToInt32(context.KullaniciAyarlari.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).SatisAyarlari_VarsayilanKasa),
                                Tarih = DateTime.Now,
                                Tutar = Convert.ToDecimal(gridViewPersonelHareket.GetRowCellValue(i, colOdenecekTutar)),
                                Aciklama = $"{gridViewPersonelHareket.GetRowCellValue(i, colPersonelKodu).ToString()} - {gridViewPersonelHareket.GetRowCellValue(i, colPersonelAdi).ToString()} || Aylık Maaş : {Convert.ToDecimal(gridViewPersonelHareket.GetRowCellValue(i, colAylikMaas)).ToString("C2")} || Prim Tutarı : {Convert.ToDecimal(gridViewPersonelHareket.GetRowCellValue(i, colPrimTutari)).ToString("C2")}"

                            };
                            kasaHareketDal.AddOrUpDate(context, entityKasaHareket);
                        }
                        OdenenTutarGuncelle();
                    }
                }
            }
        }
        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            if (ayarlar.SatisEkrani || _fisentity.FisTuru == "Hakediş Fişi")
            {
                txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
            }
            else
            {
                txtToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            }
        }

        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            IndirimDAL indirimDal = new IndirimDAL();

            stokHareket.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
            stokHareket.StokId = entity.Id;
            stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);
            stokHareket.DepoId = Convert.ToInt32(context.KullaniciAyarlari.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).SatisAyarlari_VarsayilanDepo);
            stokHareket.BirimFiyati = new[] { "Alış Faturası", "Alış İade Faturası" }.Contains(txtFisTuru.Text) ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.Miktar = txtMiktar.Value;
            stokHareket.Tarih = DateTime.Now;
            stokHareket.Kdv = entity.SatisKdv;

            return stokHareket;
        }
        private void btnStokSecc_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();

            if (form.Secildi)
            {
                int index = gridStokHareket.RowCount;
                string stokKoduSatir = "0";
                decimal miktar = 0;

                if (index == 0)
                {
                    stokHareketDal.AddOrUpDate(context, StokSec(form.secilen.First()));
                    Toplamlar();
                }
                else
                {
                    for (int i = 0; i < index; i++)
                    {
                        stokKoduSatir = gridStokHareket.GetRowCellValue(i, "Stok.StokKodu").ToString();
                        if (stokKoduSatir.ToString() == form.secilen.First().StokKodu.ToString())
                        {
                            miktar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "Miktar"));
                            gridStokHareket.SetRowCellValue(i, "Miktar", miktar + 1);
                            gridStokHareket.DeleteRow(index);

                            Toplamlar();
                            break;
                        }
                        else
                        {
                            stokHareketDal.AddOrUpDate(context, StokSec(form.secilen.First()));
                            Toplamlar();
                        }
                    }
                }
            }
            Toplamlar();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok entity;
                entity = context.Stoklar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity != null)
                {
                    int index = gridStokHareket.RowCount;
                    string stokKoduSatir = "0";
                    decimal miktar = 0;
                    if (index == 0)
                    {
                        stokHareketDal.AddOrUpDate(context, StokSec(entity));
                        Toplamlar();
                    }
                    else
                    {
                        for (int i = 0; i < index; i++)
                        {
                            stokKoduSatir = gridStokHareket.GetRowCellValue(i, "Stok.StokKodu").ToString();
                            if (stokKoduSatir.ToString() == entity.StokKodu.ToString())
                            {
                                miktar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "Miktar"));
                                gridStokHareket.SetRowCellValue(i, "Miktar", miktar + 1);
                                gridStokHareket.DeleteRow(index);

                                Toplamlar();
                                break;
                            }
                            else
                            {
                                stokHareketDal.AddOrUpDate(context, StokSec(entity));
                                Toplamlar();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Aradığınız barkod numarası ürünler arasında bulunamadı.");
                }
                txtBarkod.Text = null;
            }
        }

        private void BtnCariTemizle_Click(object sender, EventArgs e)
        {
            _cariId = null;
            _fisentity.CariId = null;
            txtCariKodu.Text = null;
            txtCariAdi.Text = null;
            txtFaturaUnvani.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTelefonu.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtSemt.Text = null;
            txtAdres.Text = null;
            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.Secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                _entityBakiye = this.cariDal.CariBakiyesi(context, entity.Id);
                _cariId = entity.Id;
                _fisentity.CariId = entity.Id;
                txtCariKodu.Text = entity.CariKodu;
                txtCariAdi.Text = entity.CariAdi;
                txtFaturaUnvani.Text = entity.FaturaUnvani;
                txtVergiDairesi.Text = entity.VergiDairesi;
                txtVergiNo.Text = entity.VergiNo;
                txtCepTelefonu.Text = entity.CepTelefonu;
                txtIl.Text = entity.Il;
                txtIlce.Text = entity.Ilce;
                txtSemt.Text = entity.Semt;
                txtAdres.Text = entity.Adres;
                lblAlacak.Text = _entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = _entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = _entityBakiye.Bakiye.ToString("C2");
            }
        }
        private void Toplamlar()
        {
            gridStokHareket.UpdateSummary();
            gridViewPersonelHareket.UpdateSummary();

            txtIskontoTutar.Value = ((Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) * txtIskontoOran.Value) / 100);

            if (_fisentity.FisTuru == "Hakediş Fişi")
            {
                txtToplam.Value = Convert.ToDecimal(colOdenecekTutar.SummaryItem.SummaryValue);
            }
            else
            {
                txtToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoTutar.Value;
            }
            txtToplam.Value += txtKdvToplam.Value;
            txtOdenmesiGereken.Value = (txtToplam.Value) - txtOdenenTutar.Value;
            txtKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
        }

        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Toplamlar();

        }

        private void repoDepoSecim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                FrmDepoSec form = new FrmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId)));
                form.ShowDialog();
                if (form.secildi)
                {
                    gridStokHareket.SetFocusedRowCellValue(colDepoId, form.secilen.Id);
                    context.ChangeTracker.DetectChanges();
                    gridStokHareket.RefreshRow(gridStokHareket.FocusedRowHandle);
                }
            }
        }

        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int fiyatSecilen = Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId));
            Entities.Tables.Stok fiyatEntity = context.Stoklar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == fiyatSecilen).SingleOrDefault();
            barFiyat1.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati1 ?? 0 : fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = txtFisTuru.Text == "Alış Faturası"
                ? fiyatEntity.AlisFiyati2 ?? 0
                : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = txtFisTuru.Text == "Alış Faturası"
                ? fiyatEntity.AlisFiyati3 ?? 0
                : fiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);

            radialFiyat.ShowPopup(MousePosition);
        }
        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)

        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNo form = new FrmSeriNo(veri);
            form.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                Toplamlar();
            }
        }

        private void repoKasaAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSec form = new FrmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                gridKasaHareket.SetFocusedRowCellValue(colKasaId, form.entity.Id);
                context.ChangeTracker.DetectChanges();
                gridKasaHareket.RefreshRow(gridKasaHareket.FocusedRowHandle);
            }
        }

        private void repoKhSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridKasaHareket.DeleteSelectedRows();
                OdenenTutarGuncelle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_fisentity.FisTuru == "Cari Devir Fişi")
            {
                if (toggleBakiyeTuru.IsOn)
                {
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                }
                else
                {
                    ayarlar.KasaHareketi = "Kasa Giriş";
                }
            }

            string message = null;
            int hata = 0;
            if (gridStokHareket.RowCount == 0 && ayarlar.SatisEkrani == true)
            {
                message += "Satış Ekranında eklenmiş bir ürün bulunamadı." + System.Environment.NewLine;
                hata++;
            }

            if (_fisentity.CariId == null && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += txtFisTuru.Text + " türünde cari seçimi zorunludur." + System.Environment.NewLine;
                hata++;
            }

            if (gridKasaHareket.RowCount == 0 && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += "Herhangi bir ödeme bulunamadı." + System.Environment.NewLine;
                hata++;
            }

            if (txtKod.Text == "")
            {
                message += "Fiş Kodu alanı boş geçilemez." + System.Environment.NewLine;
                hata++;
            }

            //if (txtOdenmesiGereken.Value != 0 && ayarlar.OdemeEkrani == true && String.IsNullOrEmpty(txtCariKodu.Text) && txtFisTuru.Text != "Hakediş Fişi")
            //{
            //    message += "Ödenmesi gereken tutar ödenmemiş görünüyor. Ödenmeyen kısmı açık hesaba aktarabilmeniz için Cari seçmeniz gerekmektedir." + System.Environment.NewLine;
            //    hata++;
            //}

            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }

            if (txtOdenmesiGereken.Value != 0 && ayarlar.OdemeEkrani == true)

            {
                if (MessageBox.Show($"Ödemenin {txtOdenmesiGereken.Value.ToString("C2")} tutarındaki kısmı açık hesap bakiyesi olarak kaydedilecektir. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İsteğiniz üzerine işlem iptal edildi.");
                    return;
                }
            }


            ///////////////////////////////////////////////////////////
            ///
          //  context.StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();

            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = stokVeri.Tarih == null
                    ? Convert.ToDateTime(txtTarih.DateTime)
                    : Convert.ToDateTime(stokVeri.Tarih);
                stokVeri.FisKodu = txtKod.Text;
                stokVeri.Hareket = ayarlar.StokHareketi;
                stokVeri.Siparis = txtFisTuru.Text.Contains("Sipariş Fişi") ? stokVeri.Siparis = true : stokVeri.Siparis = false;
                stokVeri.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
            }
            context.PersonelHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();
            foreach (var itemHareket in context.PersonelHareketleri.Local.ToList())
            {
                itemHareket.FisKodu = txtKod.Text;
            }

            if (ayarlar.BakiyeTuru == "Borç")
            {
                _fisentity.Borc = txtToplam.Value;
            }
            else if (ayarlar.BakiyeTuru == "Alacak")
            {
                _fisentity.Alacak = txtToplam.Value;
            }


            _fisentity.ToplamTutar = txtToplam.Value;
            _fisentity.IskontoOrani = txtIskontoOran.Value;
            _fisentity.IskontoTutar = txtIskontoTutar.Value;
            _fisentity.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;

            if (string.IsNullOrEmpty(_fisentity.Tarih.ToString()))
            {
                _fisentity.Tarih = DateTime.Now;
            }

            fisDal.AddOrUpDate(context, _fisentity);
            if (ayarlar.OdemeEkrani)
            {
                if (txtOdenenTutar.Value != 0)
                {

                    Entities.Tables.Fis fisOdeme = new Entities.Tables.Fis();

                    if (string.IsNullOrEmpty(_fisentity.FisBaglantiKodu))
                    {
                        fisOdeme = _fisentity.Clone();
                        fisOdeme.FisTuru = "Fiş Ödemesi";
                        fisOdeme.Id = -1;//sonradan
                        fisOdeme.Aciklama = _fisentity.FisKodu + " <= Nolu Faturaya Ait Ödeme Fişi";
                        fisOdeme.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                        fisOdeme.FisBaglantiKodu = _fisentity.FisKodu;
                        fisOdeme.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
                        kodOlustur.FisKoduArttir();
                    }
                    else
                    {
                        fisOdeme = context.Fisler.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisKodu == _fisentity.FisBaglantiKodu);
                    }
                    /// sonradan
                    /// 
                    if (fisOdeme != null)
                    {
                        _fisentity.FisBaglantiKodu = fisOdeme.FisKodu;

                    }

                    if (ayarlar.BakiyeTuru == "Borç")
                    {
                        fisOdeme.Alacak = txtOdenenTutar.Value;
                        fisOdeme.Borc = null;
                    }
                    else if (ayarlar.BakiyeTuru == "Alacak")
                    {
                        fisOdeme.Borc = txtOdenenTutar.Value;
                        fisOdeme.Alacak = null;

                    }

                    //if (txtOdenmesiGereken.Value != 0 && ayarlar.OdemeEkrani == true)
                    //{
                    //    XtraMessageBox.Show("Ödenmesi gereken tutar ödenmemiş görünüyor");
                    //    return;
                    //}
                    //    context.KasaHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).Load();
                    foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
                    {
                        kasaVeri.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
                        kasaVeri.Tarih = kasaVeri.Tarih == null
                            ? Convert.ToDateTime(txtTarih.DateTime)
                            : Convert.ToDateTime(kasaVeri.Tarih);
                        kasaVeri.FisKodu = fisOdeme.FisKodu;
                        kasaVeri.Hareket = ayarlar.KasaHareketi;

                        if (txtFisTuru.Text != "Hakediş Fişi")
                        {
                            kasaVeri.CariId = _cariId;
                        }
                    }
                    fisOdeme.ToplamTutar = txtOdenenTutar.Value;
                    fisDal.AddOrUpDate(context, fisOdeme);
                }
            }

            context.KullaniciLoglari.Add(new KullaniciLog
            {
                KullaniciID = RoleTool.kullaniciEntity.KullaniciID,
                KullaniciAdi = RoleTool.kullaniciEntity.KullaniciAdi,
                YapilanIslem = "Fiş & Fatura Ekle & Düzenle" + txtKod.Text,
                YapilanIslemTarihi = DateTime.Now
            });

            kodOlustur.KodArttirma();
            context.SaveChanges();
            this.Close();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show(
                        "Satış Ekranına eklenmiş ürünler var. Bu işlemi iptal edip formu kapatmak istediğinize emin misiniz?",
                        "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnPersonelSec_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime(Convert.ToInt32(cmbYil.Text), cmbAy.Month, 1);
            MessageBox.Show(time.ToString());
            FrmPersonelSec form = new FrmPersonelSec(time);
            form.ShowDialog();
            if (form.Secildi)
            {
                foreach (var itemhHareket in form.secilen.ToList())
                {
                    if (context.PersonelHareketleri.Local.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Donemi == time && c.PersonelKodu == itemhHareket.PersonelKodu) == 0)
                    {
                        personelHareketDal.AddOrUpDate(context, itemhHareket);
                    }
                }
                Toplamlar();
            }
        }



        private void btnAnlikTarih_Click(object sender, EventArgs e)
        {
            txtTarih.DateTime = DateTime.Now;
        }

        private void gridStokHareket_RowCountChanged(object sender, EventArgs e)
        {
            Toplamlar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTarih.DateTime = DateTime.Now;
        }

        private void txtCariKodu_TextChanged(object sender, EventArgs e)
        {
            if (txtFisTuru.Text.Contains("Toptan Satış Faturası") || txtFisTuru.Text.Contains("Perakende Satış Faturası"))
            {
                if (string.IsNullOrEmpty(gelenFisKodu) || gelenFisKodu == "")
                {
                    txtIskontoOran.Value = Convert.ToDecimal(context.Cariler.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.CariKodu == txtCariKodu.Text).IskontoOrani);
                    txtIskontoOran.Focus();
                    Toplamlar();
                }
            }

        }

        private void txtIskontoOran_TextChanged(object sender, EventArgs e)
        {
            Toplamlar();
        }
    }
}