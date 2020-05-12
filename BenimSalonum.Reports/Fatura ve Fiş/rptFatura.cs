using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.DataAccess;
using DevExpress.DataAccess.ObjectBinding;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.Reports.Fatura_ve_Fiş
{
    public partial class rptFatura : DevExpress.XtraReports.UI.XtraReport
    {
        public rptFatura(string fisKodu)
        {
            InitializeComponent();
            BenimSalonumContext context = new BenimSalonumContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == fisKodu);
            StokHareket stokBilgi = stokHareketDal.GetByFilter(context, c => c.FisKodu == fisKodu);

            ObjectDataSource stokHareketDataSource = new ObjectDataSource { DataSource = stokHareketDal.GetALL(context,c=>c.FisKodu==fisKodu) };
            this.DataSource = stokHareketDataSource;

            //CARİ-FİŞ BİLGİ  {Cari bilgilerini fişten çekemezsin caridal dan al. }
            colCariAdi.Text = fisBilgi.FaturaUnvani;
            colAdres.Text = fisBilgi.Adres;
            colVergiDairesi.Text = fisBilgi.VergiDairesi;
            colVergiNo.Text = fisBilgi.VergiNo;
            colTelefon.Text = fisBilgi.Cari.Telefon;
            colEmail.Text = fisBilgi.Cari.EMail;
            colFisNo.Text = fisBilgi.FisKodu;
            colTarih.Text = fisBilgi.Tarih.ToString();
            lblAdresBilgi.Text = fisBilgi.Semt + "\\" + fisBilgi.Ilce + "\\" + fisBilgi.Il;
            //ÜRÜN
            colStokKodu.Text = stokBilgi.Stok.StokKodu;
            colStokAdi.Text = stokBilgi.Stok.StokAdi;


            colMiktar.Text = stokBilgi.Miktar.ToString(); ;
            colKdv.Text = stokBilgi.Miktar.ToString();
            colBirimFiyat.Text = stokBilgi.BirimFiyati.ToString();
            colIndirimOrani.Text = stokBilgi.IndirimOrani.ToString();
            colIskontroOrani.Text = fisBilgi.IskontoOrani.ToString();
            colIskontoToplam.Text = fisBilgi.IskontoTutar.ToString();


            CalculatedField calcSatirTutar = new CalculatedField();
            this.CalculatedFields.Add(calcSatirTutar);
            calcSatirTutar.Name = "SatirToplam";
            calcSatirTutar.Expression = "([BirimFiyati]*[Miktar])";
            

            CalculatedField calcKdvTutari = new CalculatedField();
            this.CalculatedFields.Add(calcKdvTutari);
            calcKdvTutari.Name = "KdvTutari";
            calcKdvTutari.Expression = "(([BirimFiyati]*[Miktar]-[IndirimTutari])/100)*[Kdv]";

            CalculatedField calcIndirimTutari = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimTutari);
            calcIndirimTutari.Name = "IndirimTutari";
            calcIndirimTutari.Expression = "(([BirimFiyati]*[Miktar])/100)*[IndirimOrani]";


            CalculatedField calcGenelToplam = new CalculatedField();
            this.CalculatedFields.Add(calcGenelToplam);
            calcGenelToplam.Name = "GenelToplam";
            calcGenelToplam.Expression = "[SatirToplam]-[IndirimTutari]-[IskontoTutar]+[KdvTutari]";

            colTutar.DataBindings.Add("Text", null, "SatirToplam");
            colIndirim.DataBindings.Add("Text",null,"IndirimTutari");

            XRSummary sumAraToplam = new XRSummary();
            sumAraToplam.Func = SummaryFunc.Sum;
            sumAraToplam.Running = SummaryRunning.Report;
            sumAraToplam.FormatString = "{0:C2}";

            XRSummary sumKdvToplam = new XRSummary();
            sumKdvToplam.Func = SummaryFunc.Sum;
            sumKdvToplam.Running = SummaryRunning.Report;
            sumKdvToplam.FormatString = "{0:C2}";

            XRSummary sumIndirimToplam = new XRSummary();
            sumIndirimToplam.Func = SummaryFunc.Sum;
            sumIndirimToplam.Running = SummaryRunning.Report;
            sumIndirimToplam.FormatString = "{0:C2}";

            XRSummary sumGenelToplam = new XRSummary();
            sumGenelToplam.Func = SummaryFunc.Sum;
            sumGenelToplam.Running = SummaryRunning.Report;
            sumGenelToplam.FormatString = "{0:C2}";


            colAraToplam.DataBindings.Add("Text", null, "SatirToplam", "{0:C2}");
            colKdvToplam.DataBindings.Add("Text", null, "KdvTutari", "{0:C2}");
            colIndirimToplam.DataBindings.Add("Text", null, "IndirimTutari", "{0:C2}");
            colGenelToplam.DataBindings.Add("Text", null, "GenelToplam", "{0:C2}");
        }
    }
}
