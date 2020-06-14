using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BenimSalonum.Entities.Context;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using BenimSalonum.Admin;
using BenimSalonum.BackOffice.Cari;
using BenimSalonum.BackOffice.Depo;
using BenimSalonum.BackOffice.Fis;
using BenimSalonum.BackOffice.Kasa;
using BenimSalonum.BackOffice.Stok;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.Tools;
using System.Data.Entity;
using BenimSalonum.Reports.Fatura_ve_Fiş;


namespace BenimSalonum.FrontOffice
{
    public partial class FrmFrontOffice : DevExpress.XtraEditors.XtraForm
    {
        BenimSalonumContext context;

        FisDAL fisDal = new FisDAL();

        StokHareketDAL stokHareketDal = new StokHareketDAL();

        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();

        CariBakiye _entityBakiye = new CariBakiye(); CariDAL cariDal = new CariDAL();

        Fis _fisentity = new Fis();

        ExchangeTool doviz = new ExchangeTool();

        private int odemeTuruId;

        private decimal eskiFiyat = 0;

        private bool tekParca = false;

        private int bekleyenSatisId = 0;

        private int cagirilanSatisId = -1;

        private List<BekleyenSatis> _bekleyenSatis = new List<BekleyenSatis>();

        private Nullable<int> _cariId;

        CodeTool kodolustur;

        public FrmFrontOffice()
        {
            InitializeComponent();

            FrmKullaniciGiris girisForm = new FrmKullaniciGiris();
            girisForm.ShowDialog();
            context = new BenimSalonumContext();

            kodolustur = new CodeTool(this, CodeTool.Table.Fis);

            context.Stoklar.Load();
            context.Depolar.Load();
            context.Cariler.Load();

            gridcontStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();

            gridcontKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();

            gridLookUpEdit1.Properties.DataSource = doviz.DovizKuruCek();

            ButonlariYukle();

            txtIslem.Text = "SATIŞ";

            this.WindowState = FormWindowState.Maximized;

            kodolustur.barButonOlustur();
        }
        private void HizliSatis_Click(object sender, EventArgs e)
        {
            var buton = sender as SimpleButton;
            Stok entity;
            entity = context.Stoklar.SingleOrDefault(c => c.Barkod == buton.Name);
            if (entity != null)
            {
                if (StokKontrol(entity))
                {
                    stokHareketDal.AddOrUpDate(context, StokSec(entity));
                    Toplamlar();
                }
            }
            else
            {
                MessageBox.Show("Aradığınız barkod numarası ürünler arasında bulunamadı.");
            }

            txtMiktar.Value = 1;
        }

        private void ButonlariYukle()
        {
            foreach (var hizliSatisGrup in context.HizliSatisGruplari.ToList())
            {
                XtraTabPage page = new XtraTabPage { Name = hizliSatisGrup.Id.ToString(), Text = hizliSatisGrup.GrupAdi };
                FlowLayoutPanel panel = new FlowLayoutPanel();

                panel.Dock = DockStyle.Fill;
                page.Controls.Add(panel);

                foreach (var hizliSatis in context.HizliSatislar.Where(c => c.GrupId == hizliSatisGrup.Id).ToList())
                {
                    SimpleButton button = new SimpleButton
                    {
                        Name = hizliSatis.Barkod,
                        Text = hizliSatis.UrunAdi,
                        Height = 150,
                        Width = 150
                    };
                    button.Click += HizliSatis_Click;
                    panel.Controls.Add(button);
                }
                xtraTabControl1.TabPages.Add(page);
            }

            var AcikHesapButon = new SimpleButton
            {
                Name = "AcikHesap",
                Text = "Açık Hesap",
                Height = 42,
                Width = 125
            }; AcikHesapButon.Click += AcikHesap_Click;
            flowOdemeTurleri.Controls.Add(AcikHesapButon);

            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Tag = item.Id,
                    Text = item.OdemeTuruAdi,
                    Height = 42,
                    Width = 125
                }; buton.Click += OdemeEkle_Click;

                flowOdemeTurleri.Controls.Add(buton);
            }

            var PersonelSecimIptal = new CheckButton
            {
                Name = "Yok",
                Text = "Yok",
                GroupIndex = 1,
                Height = 90,
                Width = flowPersonel.Width - 5,
                Checked = true
            };
            PersonelSecimIptal.Click += PersonelYukle_Click;
            flowPersonel.Controls.Add(PersonelSecimIptal);

            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi,
                    Tag = item.Id,
                    GroupIndex = 1,
                    Height = 90,
                    Width = flowPersonel.Width - 5,
                    Checked = false
                };

                buton.Click += PersonelYukle_Click;
                flowPersonel.Controls.Add(buton);
            }
        }
        private void AcikHesap_Click(object sender, EventArgs e)
        {
            odemeTuruId = -1;
            radialOdeme.ShowPopup(MousePosition);
        }
        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);

            string kasaKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);

            if (chkOdemeBol.Checked)
            {
                if (txtOdenmesiGereken.Value == 0)
                {
                    MessageBox.Show("Ödenmesi gereken tutar zaten ödenmiş.");
                }
                else
                {
                    FrmOdemeEkrani form = new FrmOdemeEkrani(Convert.ToInt32(buton.Tag), txtOdenmesiGereken.Value);
                    form.ShowDialog();
                    if (form.entity != null)
                    {
                        kasaHareketDal.AddOrUpDate(context, form.entity);
                        OdenenTutarGuncelle();
                    }
                }
            }
            else
            {
                odemeTuruId = Convert.ToInt32(buton.Tag);
                tekParca = true;
                radialOdeme.ShowPopup(MousePosition);
            }
        }
        private void SatisBeklet()
        {
            if (gridStokHareket.RowCount == 0)
            {
                MessageBox.Show("Satış bekletebilmeniz için ürün eklemeniz gerekmektedir.");
                return;
            }

            int BekleyenId;
            BekleyenSatis satis;

            if (cagirilanSatisId != -1)
            {
                BekleyenId = cagirilanSatisId;
                satis = _bekleyenSatis.SingleOrDefault(c => c.Id == BekleyenId);
                var buton = (SimpleButton)flowBekleyenSatislar.Controls.Find(Convert.ToString(BekleyenId), false).SingleOrDefault();
                buton.Text = txtCariKodu.Text + " - " + txtCariAdi.Text + "\n" + context.StokHareketleri.Local.Count +
                             " adet ürün eklendi." + "\n" + txtToplam.Value.ToString("C2");
            }
            else
            {
                BekleyenId = bekleyenSatisId;
                satis = new BekleyenSatis();
                satis.BekleyenFis = new Fis();
                satis.Id = BekleyenId;
                SimpleButton BekleyenButon = new SimpleButton
                {
                    Name = bekleyenSatisId.ToString(),
                    Text = txtCariKodu.Text + " - " + txtCariAdi.Text + "\n" + "\n" + context.StokHareketleri.Local.Count + " adet ürün eklendi." + "\n" + txtToplam.Value.ToString("C2"),
                    Height = 120,
                    Width = flowBekleyenSatislar.Width - 5
                };

                BekleyenButon.Click += BekleyenSatis_Click;
                flowBekleyenSatislar.Controls.Add(BekleyenButon);
                bekleyenSatisId++;
            }

            satis.BekleyenFis.CariId = _fisentity.CariId;
            satis.BekleyenFis.Cari = _fisentity.Cari;
            satis.BekleyenFis.Aciklama = txtAciklama.Text;
            satis.BekleyenFis.Adres = txtAdres.Text;
            satis.BekleyenFis.BelgeNo = txtBelgeNo.Text;
            satis.BekleyenFis.CepTelefonu = txtCepTelefonu.Text;

            satis.BekleyenFis.FaturaUnvani = txtFaturaUnvani.Text;
            satis.BekleyenFis.FisTuru = _fisentity.FisTuru; satis.BekleyenFis.Il = txtIl.Text;
            satis.BekleyenFis.Ilce = txtIlce.Text;
            satis.BekleyenFis.Semt = txtSemt.Text;
            satis.BekleyenFis.PlasiyerId = _fisentity.PlasiyerId;
            satis.BekleyenFis.VergiDairesi = txtVergiDairesi.Text;
            satis.BekleyenFis.VergiNo = txtVergiNo.Text;
            satis.BekleyenFis.IskontoOrani = txtIskontoOran.Value;


            satis.StokHareketi = context.StokHareketleri.Local.ToList();
            satis.KasaHareketi = context.KasaHareketleri.Local.ToList();

            CheckButton personelButonYok = (CheckButton)flowPersonel.Controls.Find("Yok", false).SingleOrDefault();

            personelButonYok.Checked = true;

            if (cagirilanSatisId == -1)
            {
                _bekleyenSatis.Add(satis);
            }
            cagirilanSatisId = -1;

            FisTemizle();

            txtKod.Text = kodolustur.yeniFrontOfficeKodOlustur();
            kodolustur.FisKoduArttir();
        }

        private void FisiKaydet(ReportsPrintTool.Belge belge)
        {
            Toplamlar();

            OdenenTutarGuncelle();

            string message = null;

            int hata = 0;

            if (gridStokHareket.RowCount == 0)

            {
                message += "Satış Ekranında eklenmiş bir ürün bulunamadı." + System.Environment.NewLine;
                hata++;
            }

            if (gridKasaHareket.RowCount == 0 && chkOdemeBol.Checked && String.IsNullOrEmpty(txtCariKodu.Text))
            {
                message += "Herhangi bir ödeme bulunamadı." + System.Environment.NewLine;
                hata++;
            }

            if (txtKod.Text == "")

            {
                message += "Fiş Kodu alanı boş geçilemez." + System.Environment.NewLine;
                hata++;
            }

            if (txtOdenmesiGereken.Value != 0 && String.IsNullOrEmpty(txtCariKodu.Text) && tekParca == false)
            {
                message += "Ödenmesi gereken tutar ödenmemiş görünüyor. Ödenmeyen kısmı açık hesaba aktarabilmeniz için Cari seçmeniz gerekmektedir." + System.Environment.NewLine;
                hata++;
            }

            if (String.IsNullOrEmpty(txtCariKodu.Text) && (_entityBakiye.Bakiye - txtOdenmesiGereken.Value) < 0 && ((_entityBakiye.Bakiye - txtOdenmesiGereken.Value) * -1) > _entityBakiye.RiskLimiti && tekParca == false)
            {
                message += "Cari risk limiti aşılıyor. Satış yapılamaz." + System.Environment.NewLine;
                hata++;
            }
            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }


            if (chkOdemeBol.Checked && txtOdenmesiGereken.Value != 0)
            {
                if (MessageBox.Show($"Ödemenin {txtOdenmesiGereken.Value.ToString("C2")} tutarındaki kısmı açık hesap bakiyesi olarak kaydedilecektir. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İsteğiniz üzerine işlem iptal edildi.");
                    return;
                }
            }

            _fisentity.FisTuru = txtIslem.Text == "İADE" ? "Satış İade Faturası" : "Perakende Satış Faturası";

            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = DateTime.Now;
                stokVeri.FisKodu = txtKod.Text;
                stokVeri.Hareket = txtIslem.Text == "İADE" ? "Stok Giriş" : "Stok Çıkış";
            }

            foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
            {
                kasaVeri.Tarih = DateTime.Now;
                kasaVeri.FisKodu = txtKod.Text;
                kasaVeri.Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş";
                kasaVeri.CariId = _cariId;
            }
            _fisentity.KullaniciID = RoleTool.kullaniciEntity.KullaniciID;
            _fisentity.FisKodu = txtKod.Text;
            _fisentity.BelgeNo = txtBelgeNo.Text;
            _fisentity.Aciklama = txtAciklama.Text;
            _fisentity.FaturaUnvani = txtFaturaUnvani.Text;
            _fisentity.CepTelefonu = txtCepTelefonu.Text;
            _fisentity.Il = txtIl.Text;
            _fisentity.Ilce = txtIlce.Text;
            _fisentity.Semt = txtSemt.Text;
            _fisentity.Adres = txtAdres.Text;
            _fisentity.VergiDairesi = txtVergiDairesi.Text;
            _fisentity.VergiNo = txtVergiNo.Text;
            _fisentity.ToplamTutar = txtToplam.Value;
            _fisentity.IskontoOrani = txtIskontoOran.Value;
            _fisentity.IskontoTutar = txtIskontoTutar.Value;
            _fisentity.Tarih = DateTime.Now;


            fisDal.AddOrUpDate(context, _fisentity);

            int kasaId = Convert.ToInt32(context.KullaniciAyarlari.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).SatisAyarlari_VarsayilanKasa);

            if (txtOdenen.Value > 0)
            {
                Fis odemeFisi = _fisentity.Clone();
                odemeFisi.FisTuru = "Fiş Ödemesi";
                odemeFisi.FisKodu = kodolustur.YeniFisOdemeKoduOlustur();

                _fisentity.FisBaglantiKodu = odemeFisi.FisKodu;
                odemeFisi.FisBaglantiKodu = _fisentity.FisKodu;

                odemeFisi.ToplamTutar = tekParca ? txtToplam.Value : txtOdenenTutar.Value;

                if (txtIslem.Text == "SATIŞ")
                {
                    _fisentity.Borc = txtToplam.Value;
                    odemeFisi.Alacak = tekParca ? txtToplam.Value : txtOdenenTutar.Value;
                    odemeFisi.Borc = null;
                    _fisentity.Alacak = null;
                }
                else
                {
                    _fisentity.Alacak = txtToplam.Value;
                    odemeFisi.Borc = tekParca ? txtToplam.Value : txtOdenenTutar.Value;
                    odemeFisi.Alacak = null;
                    _fisentity.Borc = null;
                }
                fisDal.AddOrUpDate(context, odemeFisi);
            }//ödeme 0 sa yapılan if yeni koydum test et


            if (!chkOdemeBol.Checked && odemeTuruId != -1)
            {
                kasaHareketDal.AddOrUpDate(context, new KasaHareket
                {
                    CariId = _cariId,
                    FisKodu = txtKod.Text,
                    Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş",
                    KasaId = kasaId,
                    OdemeTuruId = odemeTuruId,
                    Tarih = DateTime.Now,
                    Tutar = txtToplam.Value
                });
                OdenenTutarGuncelle();
            }
            try
            {
                context.SaveChanges();
            }
            catch (Exception )
            {
            }


            chkOdemeBol.Checked = false;

            radialOdeme.HidePopup();


            switch (belge)
            {
                case ReportsPrintTool.Belge.Fatura:

                    ReportsPrintTool yazdir = new ReportsPrintTool();
                    rptFatura fatura = new rptFatura(txtKod.Text);
                    yazdir.RaporYazdir(fatura, belge, context.KullaniciAyarlari.FirstOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID)); break;
                case ReportsPrintTool.Belge.BilgiFisi:
                    ReportsPrintTool yazdirBilgiFisi = new ReportsPrintTool();
                    rptBilgiFisi bilgiFisi = new rptBilgiFisi(txtKod.Text);
                    yazdirBilgiFisi.RaporYazdir(bilgiFisi, belge, context.KullaniciAyarlari.FirstOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID));
                    break;
            }

            if (cagirilanSatisId != -1)
            {
                var secilen = _bekleyenSatis.SingleOrDefault(c => c.Id == cagirilanSatisId);
                _bekleyenSatis.Remove(secilen); flowBekleyenSatislar.Controls.Find(Convert.ToString(cagirilanSatisId), false).SingleOrDefault().Dispose();
                cagirilanSatisId = -1;
            }

            FisTemizle();
            kodolustur.FisKoduArttir();
            txtKod.Text = kodolustur.yeniFrontOfficeKodOlustur();
            tekParca = false;
            
        }

        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();

            txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);

            txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;

        }

        private void FisTemizle()
        {
            txtKod.Text = null;
            txtIskontoOran.Value = 0;

            CariTemizle();

            txtBelgeNo.Text = null;

            txtAciklama.Text = null;

            var cikarilacakKayit = context.ChangeTracker.Entries()

                .Where(c => c.Entity is KasaHareket || c.Entity is StokHareket || c.Entity is Fis).ToList();

            foreach (var kayit in cikarilacakKayit)
            {
                context.Entry(kayit.Entity).State = EntityState.Detached;
            }
            _fisentity = new Fis();

            Toplamlar();

            OdenenTutarGuncelle();
        }

        private void CariTemizle()
        {
            txtCariKodu.Text = null;

            txtCariAdi.Text = null;

            _fisentity.CariId = null;

            txtFaturaUnvani.Text = null;

            txtVergiDairesi.Text = null;

            txtVergiNo.Text = null;

            txtCepTelefonu.Text = null;

            txtIl.Text = null;

            txtIlce.Text = null;

            txtSemt.Text = null;

            txtAdres.Text = null;

            lblRiskLimiti.Text = "Görüntülenemiyor";

            lblAlacak.Text = "Görüntülenemiyor";

            lblBorc.Text = "Görüntülenemiyor";

            lblBakiye.Text = "Görüntülenemiyor";
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
                _fisentity.PlasiyerId = Convert.ToInt32(buton.Tag);
            }
        }

        private void BekleyenSatis_Click(object sender, EventArgs e)
        {
            var buton = sender as SimpleButton;
            BekleyenSatisYukle(Convert.ToInt32(buton.Name));
        }

        private void btnSatisBeklet_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount == 0)
            {
                MessageBox.Show("Satış bekletebilmeniz için ürün eklemeniz gerekmektedir.");
                return;
            }

            int BekleyenId;
            BekleyenSatis satis;

            if (cagirilanSatisId != -1)
            {
                BekleyenId = cagirilanSatisId;

                satis = _bekleyenSatis.SingleOrDefault(c => c.Id == BekleyenId);

                var buton = (SimpleButton)flowBekleyenSatislar.Controls.Find(Convert.ToString(BekleyenId), false).SingleOrDefault();
                buton.Text = txtCariKodu.Text + " - " + txtCariAdi.Text + "\n" + context.StokHareketleri.Local.Count +
                             " adet ürün eklendi." + "\n" + txtToplam.Value.ToString("C2");
            }
            else
            {
                BekleyenId = bekleyenSatisId;
                satis = new BekleyenSatis();
                satis.BekleyenFis = new Fis();
                satis.Id = BekleyenId;

                SimpleButton BekleyenButon = new SimpleButton
                {
                    Name = bekleyenSatisId.ToString(),
                    Text = txtCariKodu.Text + " - " + txtCariAdi.Text + "\n" + "\n" + context.StokHareketleri.Local.Count + " adet ürün eklendi." + "\n" + txtToplam.Value.ToString("C2"),
                    Height = 120,
                    Width = flowBekleyenSatislar.Width - 5
                };

                BekleyenButon.Click += BekleyenSatis_Click;
                flowBekleyenSatislar.Controls.Add(BekleyenButon);
                bekleyenSatisId++;
            }

            satis.BekleyenFis.CariId = _fisentity.CariId;
            satis.BekleyenFis.Cari = _fisentity.Cari;
            satis.BekleyenFis.Aciklama = txtAciklama.Text;
            satis.BekleyenFis.Adres = txtAdres.Text;
            satis.BekleyenFis.BelgeNo = txtBelgeNo.Text;
            satis.BekleyenFis.CepTelefonu = txtCepTelefonu.Text;
            satis.BekleyenFis.FaturaUnvani = txtFaturaUnvani.Text;
            satis.BekleyenFis.FisTuru = _fisentity.FisTuru; satis.BekleyenFis.Il = txtIl.Text;
            satis.BekleyenFis.Ilce = txtIlce.Text;
            satis.BekleyenFis.Semt = txtSemt.Text;
            satis.BekleyenFis.PlasiyerId = _fisentity.PlasiyerId;
            satis.BekleyenFis.VergiDairesi = txtVergiDairesi.Text;
            satis.BekleyenFis.VergiNo = txtVergiNo.Text;
            satis.BekleyenFis.IskontoOrani = txtIskontoOran.Value;

            satis.StokHareketi = context.StokHareketleri.Local.ToList();
            satis.KasaHareketi = context.KasaHareketleri.Local.ToList();

            CheckButton personelButonYok = (CheckButton)flowPersonel.Controls.Find("Yok", false).SingleOrDefault();

            personelButonYok.Checked = true;

            if (cagirilanSatisId == -1)
            {
                _bekleyenSatis.Add(satis);
            }

            cagirilanSatisId = -1;

            FisTemizle();
        }

        private void btnBeklet_Click(object sender, EventArgs e)
        {
            SatisBeklet();
        }
        private void BekleyenSatisYukle(int id)
        {
            if (cagirilanSatisId == -1 && gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Bekleyen satışı çağırmadan önce mevcutta olan satışı beklemeye almak ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SatisBeklet();
                }
            }

            FisTemizle();
            var SatisBilgisi = _bekleyenSatis.SingleOrDefault(c => c.Id == id);

            _fisentity.CariId = SatisBilgisi.BekleyenFis.CariId;

            var cariBilgi = context.Cariler.SingleOrDefault(c => c.Id == _fisentity.CariId);

            if (cariBilgi != null)
            {
                _entityBakiye = cariDal.CariBakiyesi(context, Convert.ToInt32(SatisBilgisi.BekleyenFis.CariId));
                lblRiskLimiti.Text = _entityBakiye.RiskLimiti.ToString("C2");
                lblAlacak.Text = _entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = _entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = _entityBakiye.Bakiye.ToString("C2"); txtCariKodu.Text = cariBilgi.CariKodu;
                txtCariAdi.Text = cariBilgi.CariAdi;
            }
            _fisentity.PlasiyerId = SatisBilgisi.BekleyenFis.PlasiyerId;

            var personelBilgi = context.Personeller.SingleOrDefault(c => c.Id == _fisentity.PlasiyerId);


            if (personelBilgi != null)
            {
                CheckButton personelButon = (CheckButton)flowPersonel.Controls.Find(personelBilgi.PersonelKodu, false).SingleOrDefault();
                personelButon.Checked = true;
            }
            else
            {
                CheckButton personelButonYok = (CheckButton)flowPersonel.Controls.Find("Yok", false).SingleOrDefault();

                personelButonYok.Checked = true;

            }


            txtBelgeNo.Text = SatisBilgisi.BekleyenFis.BelgeNo;
            txtAciklama.Text = SatisBilgisi.BekleyenFis.Aciklama;
            txtFaturaUnvani.Text = SatisBilgisi.BekleyenFis.FaturaUnvani;
            txtCepTelefonu.Text = SatisBilgisi.BekleyenFis.CepTelefonu;
            txtIl.Text = SatisBilgisi.BekleyenFis.Il; txtIlce.Text = SatisBilgisi.BekleyenFis.Ilce;
            txtSemt.Text = SatisBilgisi.BekleyenFis.Semt;
            txtAdres.Text = SatisBilgisi.BekleyenFis.Adres;
            txtVergiDairesi.Text = SatisBilgisi.BekleyenFis.VergiDairesi;
            txtVergiNo.Text = SatisBilgisi.BekleyenFis.VergiNo;
            txtToplam.Value = Convert.ToDecimal(SatisBilgisi.BekleyenFis.ToplamTutar);
            txtIskontoOran.Value = Convert.ToDecimal(SatisBilgisi.BekleyenFis.IskontoOrani);
            txtIskontoTutar.Value = Convert.ToDecimal(SatisBilgisi.BekleyenFis.IskontoTutar);

            foreach (var item in SatisBilgisi.StokHareketi)
            {
                context.StokHareketleri.Local.Add(item);
            }

            foreach (var item in SatisBilgisi.KasaHareketi)
            {
                context.KasaHareketleri.Local.Add(item);
            }
            cagirilanSatisId = id;

            Toplamlar();

            OdenenTutarGuncelle();

        }

        private void FrmFrontOffice_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.Secildi)
            {
                if (StokKontrol(form.secilen.SingleOrDefault()))
                {
                    stokHareketDal.AddOrUpDate(context, StokSec(form.secilen.SingleOrDefault()));
                    Toplamlar();
                }
            }
        }
        private bool StokKontrol(Stok entity)
        {
            var MevcutStok = context.StokHareketleri.Where(c => c.Hareket == "Stok Giriş" && c.StokId == entity.Id).Sum(c => c.Miktar) ?? 0 -
                             context.StokHareketleri.Where(c => c.Hareket == "Stok Çıkış" && c.StokId == entity.Id).Sum(c => c.Miktar) ?? 0;

            if (txtIslem.Text == "SATIŞ" && entity.MinStokMiktari > MevcutStok - (txtMiktar.Value + context.StokHareketleri.Local.Where(c => c.StokId == entity.Id).Sum(c => c.Miktar)))
            {
                MessageBox.Show("Satışını yapmak istediğiniz stok minimum düzeydedir. Satış yapabilmek için stok yükseltmelisiniz.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            IndirimDAL indirimDal = new IndirimDAL();

            stokHareket.StokId = entity.Id;

            stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);

            stokHareket.DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo));

            stokHareket.BirimFiyati = _fisentity.FisTuru == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;

            stokHareket.Miktar = txtMiktar.Value;
            stokHareket.Tarih = DateTime.Now;
            stokHareket.Kdv = entity.SatisKdv;
            return stokHareket;
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
                lblRiskLimiti.Text = _entityBakiye.RiskLimiti.ToString("C2");
                lblAlacak.Text = _entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = _entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = _entityBakiye.Bakiye.ToString("C2");
            }
        }
        private void Toplamlar()
        {
            gridStokHareket.UpdateSummary();
            txtIskontoTutar.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * txtIskontoOran.Value;
            txtToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoTutar.Value;
            txtKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
            txtAraToplam.Value = txtToplam.Value - txtKdvToplam.Value;
            txtParaUstu.Value = txtOdenen.Value - txtToplam.Value;
            txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
        }

        private void repositorySil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                Toplamlar();
            }
        }

        private void repositoryDepoSecim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                FrmDepoSec form = new FrmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId)));
                form.ShowDialog();
                if (form.secildi)
                {
                    gridStokHareket.SetFocusedRowCellValue(colDepoId, form.secilen.Id);
                    context.ChangeTracker.DetectChanges();
                }
            }
        }

        private void repositorySeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNo form = new FrmSeriNo(veri, false);
            form.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }

        private void repositoryBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok fiyatEntity = context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();
            barFiyat1.Tag = _fisentity.FisTuru == "Alış Faturası"
                ? fiyatEntity.AlisFiyati1 ?? 0
                : fiyatEntity.SatisFiyati1 ?? 0;

            barFiyat2.Tag = _fisentity.FisTuru == "Alış Faturası"
                ? fiyatEntity.AlisFiyati2 ?? 0
                : fiyatEntity.SatisFiyati2 ?? 0;

            barFiyat3.Tag = _fisentity.FisTuru == "Alış Faturası"
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

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Mevcut satışı iptal etmek istediğinize emin misiniz?", "Uyarı",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _fisentity.FisKodu = null;
                    _fisentity.BelgeNo = null;
                    _fisentity.Aciklama = null;
                    //btnCariTemizle_Click(sender, e);
                    context.StokHareketleri.Local.Clear();
                }
            }
            else
            {
                MessageBox.Show("Mevcutta bir işlem bulunamadı.");
            }
        }

        private void btnSatirSil_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gridStokHareket.DeleteSelectedRows();
                    Toplamlar();
                }
            }
        }

        private void btnIade_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkIade.Checked)
            {
                txtIslem.Text = "İADE";
                txtIslem.BackColor = Color.Red;
            }
            else
            {
                txtIslem.Text = "SATIŞ";
                txtIslem.BackColor = Color.Green;
            }
        }
        private void ParaEkle(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            txtOdenen.Value += ConverterTool.StringToDecimal(buton.Tag.ToString(), ".");
            Toplamlar();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok entity;
                entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity != null)
                {
                    if (StokKontrol(entity))
                    {
                        stokHareketDal.AddOrUpDate(context, StokSec(entity));
                        Toplamlar();
                    }
                }
                else
                {
                    MessageBox.Show("Aradığınız barkod numarası ürünler arasında bulunamadı.");
                }
                txtBarkod.Text = null;
            }
        }

        private void txtIskontoOran_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }

        private void chkOdemeBol_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOdemeBol.Checked)
            {
                navigationFrame1.SelectedPage = navOdeme;
                flowOdemeTurleri.Controls.Find("AcikHesap", false).SingleOrDefault().Enabled = false;
            }
            else
            {
                navigationFrame1.SelectedPage = navStokHareket;
                flowOdemeTurleri.Controls.Find("AcikHesap", false).SingleOrDefault().Enabled = true;
            }
        }
        private void btnIslemBitir_Click(object sender, EventArgs e)
        {
            radialOdeme.ShowPopup(MousePosition);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisiKaydet(ReportsPrintTool.Belge.BilgiFisi);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FisiKaydet(ReportsPrintTool.Belge.Diger);
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisiKaydet(ReportsPrintTool.Belge.Fatura);
        }

        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridStokHareket.FocusedColumn == colMiktar)
            {
                txtMiktar.Value = 0;
                string barkod = gridStokHareket.GetFocusedRowCellValue(colBarkod).ToString();
                if (!StokKontrol(context.Stoklar.SingleOrDefault(c => c.Barkod == barkod)))
                {
                    gridStokHareket.SetFocusedRowCellValue(colMiktar, eskiFiyat);
                };
                txtMiktar.Value = 1;
            }
            Toplamlar();
            OdenenTutarGuncelle();
        }

        private void gridStokHareket_ShownEditor(object sender, EventArgs e)
        {
            if (gridStokHareket.FocusedColumn == colMiktar)
            {
                eskiFiyat = (decimal)gridStokHareket.GetFocusedRowCellValue(colMiktar);
            }
        }

        private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtDovizTutar.Value = txtToplam.Value / Convert.ToDecimal(gridLookUpEdit1View.GetFocusedRowCellValue(colBanknoteSelling));
            }
            catch (Exception)
            {
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

        private void repoKasaAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSec form = new FrmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                gridKasaHareket.SetFocusedRowCellValue(colKasaKodu, form.entity.KasaKodu);
                gridKasaHareket.SetFocusedRowCellValue(colKasaAdi, form.entity.KasaAdi);
            }
        }

        private void btnOdemeBitir_Click(object sender, EventArgs e)
        {
            radialOdeme.ShowPopup(MousePosition);
        }

        private void btnStokSecc_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.Secildi)
            {
                if (StokKontrol(form.secilen.SingleOrDefault()))
                {
                    stokHareketDal.AddOrUpDate(context, StokSec(form.secilen.SingleOrDefault()));
                    Toplamlar();
                }
            }
        }

        private void FrmFrontOffice_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == RoleTool.kullaniciEntity.KullaniciAdi).Aktif = false;
            context.SaveChanges();
        }
    }
}
