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
    public partial class rptBilgiFisi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBilgiFisi(string fisKodu)
        {
            InitializeComponent();
            BenimSalonumContext context = new BenimSalonumContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == fisKodu);
            StokHareket stokBilgi = stokHareketDal.GetByFilter(context, c => c.FisKodu == fisKodu);

            ObjectDataSource stokHareketDataSource = new ObjectDataSource { DataSource = stokHareketDal.GetALL(context, c => c.FisKodu == fisKodu) };
            this.DataSource = stokHareketDataSource;

            lblFisKodu.Text = fisBilgi.FisKodu;
            lblTarih.Text = fisBilgi.Tarih.ToString();
            lblPersonelAdi.Text = fisBilgi.Personel.PersonelAdi;
            
            decimal TutarEx =Convert.ToDecimal(stokBilgi.BirimFiyati * stokBilgi.Miktar);
            decimal indirimEx = Convert.ToDecimal(((stokBilgi.BirimFiyati*stokBilgi.Miktar)/100)*stokBilgi.IndirimOrani);
            xrRichText1.Text = stokBilgi.Stok.Barkod +" - "+ " ( "+stokBilgi.Miktar +" "+ stokBilgi.Stok.Birimi + " X " + stokBilgi.BirimFiyati + " = " +TutarEx.ToString()+" ) ";
            xrRichText2.Text = stokBilgi.Stok.StokAdi ;
            xrRichText3.Text = indirimEx.ToString();

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

            decimal genelEx = (decimal)fisBilgi.ToplamTutar;

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

            colIskontroOrani.Text = fisBilgi.IskontoOrani.ToString();
            colIskontoToplam.Text = fisBilgi.IskontoTutar.ToString();

            colAraToplam.DataBindings.Add("Text", null, "SatirToplam", "{0:C2}");
            colKdvToplam.DataBindings.Add("Text", null, "KdvTutari", "{0:C2}");
            colIndirimToplam.DataBindings.Add("Text", null, "IndirimTutari", "{0:C2}");

            colGenelToplam.Text = genelEx.ToString();
        }

    }
}
