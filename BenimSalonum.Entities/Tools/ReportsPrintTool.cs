using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Tables.OtherTables;
using DevExpress.Data.Mask;
using DevExpress.XtraReports.UI;

namespace BenimSalonum.Entities.Tools
{
    public class ReportsPrintTool
    {
        public enum Belge
        {
            BilgiFisi,
            Fatura,
            Diger
        }
        public void RaporYazdir(XtraReport rapor, Belge belge,KullaniciAyarlari entity)
        {
            ReportPrintTool raporYazdir = new ReportPrintTool(rapor);
            
            string yaziciAdi=null;
            string ayar = "0";
            switch (belge)
            {
                case Belge.Fatura:
                    ayar = entity.SatisAyarlari_FaturaYazdirmaAyari;
                    yaziciAdi = entity.SatisAyarlari_FaturaYazici;
                    break;
                case Belge.BilgiFisi:
                    rapor.RequestParameters = false;
                    rapor.Parameters["parameterFirmaAdi"].Value = entity.FirmaAyarlari_FaturaUnvani;
                    raporYazdir.AutoShowParametersPanel = false;
                    ayar = entity.SatisAyarlari_BilgiFisiYazdırmaAyari;
                    yaziciAdi = entity.SatisAyarlari_BilgiFisiYazici;
                    break;
            }

            switch (ayar)
            {
               
                case "Hemen Yazdır":
                    raporYazdir.Print(yaziciAdi);
                    break;
                case "Özelleştirerek Yazdır":
                    raporYazdir.PrintDialog();
                    break;
                case "Önizleme Göstererek Yazdır":
                    raporYazdir.ShowPreviewDialog();
                    break;
            }
        }
    }
}
