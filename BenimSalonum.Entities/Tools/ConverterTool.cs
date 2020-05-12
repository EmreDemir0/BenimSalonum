
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.DataAccess;
using BenimSalonum.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSalonum.Entities.Tools
{
    public static class ConverterTool
    {
        public static StokHareket StokToStokHareket(BenimSalonumContext context,
            Entities.Tables.Stok entity,
                decimal miktar)

        {
            StokHareket stokHareket = new StokHareket();
            IndirimDAL indirimDal = new IndirimDAL();
            stokHareket.StokId = entity.Id;
            stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);
            stokHareket.DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo));
            //stokHareket.BirimFiyati = txtFisTuru.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.Miktar = miktar;
            stokHareket.Tarih = DateTime.Now;
            stokHareket.Kdv = entity.SatisKdv;
            return stokHareket;
        }

        public static decimal StringToDecimal(string ifade,string ondalikAyrac)
        {
            string ondalikKarakter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString();
            return Convert.ToDecimal(ifade.Replace(ondalikAyrac,ondalikKarakter));
        }
    }
}
