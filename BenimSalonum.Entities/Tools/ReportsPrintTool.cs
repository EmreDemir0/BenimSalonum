using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void RaporYazdir(XtraReport rapor, Belge belge)
        {
            ReportPrintTool raporYazdir = new ReportPrintTool(rapor);
            
            string yaziciAdi=null;
            int ayar = 0;
            switch (belge)
            {
                case Belge.Fatura:
                    ayar = Convert.ToInt32(
                        SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);
                    break;
                case Belge.BilgiFisi:
                    rapor.RequestParameters = false;
                    rapor.Parameters["parameterFirmaAdi"].Value = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_FirmaAdi);
                    raporYazdir.AutoShowParametersPanel = false;
                    ayar = Convert.ToInt32(
                        SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdırmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);
                    break;
            }

            switch (ayar)
            {
                case 0:
                    raporYazdir.Print(yaziciAdi);
                    break;
                case 1:
                    raporYazdir.PrintDialog();
                    break;
                case 2:
                    raporYazdir.ShowPreviewDialog();
                    break;
            }
        }
    }
}
