using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.DataAccess;
using DevExpress.DataAccess.ObjectBinding;

namespace BenimSalonum.Reports.Stok
{
    public partial class rptUrunBazliStokHareketleri : DevExpress.XtraReports.UI.XtraReport
    {//STOK GİRİŞ VEYA ÇIKIŞ OLARAK FİŞ TUTARLARINI LİSTEYEN RAPOR
        public rptUrunBazliStokHareketleri()
        {
            InitializeComponent();
            BenimSalonumContext context = new BenimSalonumContext();

            StokHareketDAL stokHareketDal = new StokHareketDAL();

            ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = stokHareketDal.GetALL(context) };
            this.DataSource = stokDataSource;

            colFisKodu.DataBindings.Add("Text", this.DataAdapter, "FisKodu");
            colHareket.DataBindings.Add("Text", this.DataAdapter, "Hareket");
            colBirimFiyat.DataBindings.Add("Text", this.DataAdapter, "BirimFiyati");
            colMiktar.DataBindings.Add("Text", this.DataAdapter, "Miktar", "{0:C2}");
            colKdv.DataBindings.Add("Text", this.DataAdapter, "Kdv", "{0:'%'0}");
            colIndirim.DataBindings.Add("Text", this.DataAdapter, "IndirimOrani", "{0:'%'0}");

            CalculatedField calcIndirimtutari = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimtutari);
            calcIndirimtutari.Name = "IndirimTutari";
            calcIndirimtutari.Expression = "(([BirimFiyati]*[Miktar])/100)*[IndirimOrani]";

            CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            calcTutar.Expression = "(([BirimFiyati]*[Miktar])-[IndirimTutari])";

            colIndirimTutari.DataBindings.Add("Text", null, "IndirimTutari", "{0:C2}");
            colToplamTutar.DataBindings.Add("Text", null, "Tutar", "{0:C2}");

            XRSummary sumIndirimTutari = new XRSummary();
            sumIndirimTutari.Func = SummaryFunc.Sum;
            sumIndirimTutari.Running = SummaryRunning.Group;
            sumIndirimTutari.FormatString = "{0:C2}";

            XRSummary sumToplamTutar = new XRSummary();
            sumToplamTutar.Func = SummaryFunc.Sum;
            sumToplamTutar.Running = SummaryRunning.Group;
            sumToplamTutar.FormatString = "{0:C2}";

            lblToplamIndirim.Summary = sumIndirimTutari;
            lblGenelToplam.Summary = sumToplamTutar;

            lblToplamIndirim.DataBindings.Add("Text",null,"IndirimTutari");
            lblGenelToplam.DataBindings.Add("Text", null, "Tutar");

        }
    }
}
