using BenimSalonum.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSalonum.Entities.Tables.OtherTables
{
    public class KullaniciAyarlari : IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        //
        public bool GenelAyarlar_GuncellemeKontrol { get; set; }
        //sms
        public string smsAyarlari_KullaniciAdi { get; set; }
        public string smsAyarlari_KullaniciNo { get; set; }
        public string smsAyarlari_Parola { get; set; }
        public string smsAyarlari_Orjinator { get; set; }

        //satis ayarlari
        public int SatisAyarlari_VarsayilanDepo { get; set; }
        public int SatisAyarlari_VarsayilanKasa { get; set; }
        public int SatisAyarlari_FaturaYazdirmaAyari { get; set; }
        public int SatisAyarlari_BilgiFisiYazdırmaAyari { get; set; }
        public string SatisAyarlari_FaturaYazici { get; set; }
        public string SatisAyarlari_BilgiFisiYazici { get; set; }
        public string SatisAyarlari_FisKodu { get; set; }


        //DB
        public string YedeklemeAyarlari_YedeklemeKonumu { get; set; }
        public string DataBaseAyarlari_BaglantiCumlesi { get; set; }


        //Firma
        public string FirmaAyarlari_FirmaAdi { get; set; }
        public string FirmaAyarlari_FaturaUnvani { get; set; }
        public string FirmaAyarlari_VergiDairesi { get; set; }
        public string FirmaAyarlari_VergiNo { get; set; }
        public string FirmaAyarlari_Adres { get; set; }
        public string FirmaAyarlari_Eposta { get; set; }

    }
}
