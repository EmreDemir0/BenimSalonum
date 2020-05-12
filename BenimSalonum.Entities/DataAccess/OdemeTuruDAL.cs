using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.Tools;
using BenimSalonum.Entities.Validations;
using System.Collections.Generic;
using System.Linq;


namespace BenimSalonum.Entities.DataAccess
{
    public class OdemeTuruDAL : EntityReposityoryBase<BenimSalonumContext, OdemeTuru, OdemeTuruValidator>
    {
        public object OdemeTuruListele(BenimSalonumContext context)
        {
            var result = context.OdemeTurleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GroupJoin(context.KasaHareketleri, c => c.Id, c => c.OdemeTuruId, (odemeturu, kasahareket) =>
                    new
                    {
                        odemeturu.Id,
                        odemeturu.OdemeTuruKodu,
                        odemeturu.OdemeTuruAdi,
                        odemeturu.Aciklama,
                        KasaGiris = (kasahareket.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == odemeturu.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                        KasaCikis = (kasahareket.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == odemeturu.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                        Bakiye = (kasahareket.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == odemeturu.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) -
                        (kasahareket.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == odemeturu.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)

                    }).ToList();
            return result;
        }
        public object KasaToplamListele(BenimSalonumContext context, int odemeTuruId)
        {
            var result = (from c in context.KasaHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == odemeTuruId)
                          group c by new { c.Kasa } into grp
                          select new
                          {

                              grp.Key.Kasa.KasaKodu,
                              grp.Key.Kasa.KasaAdi,
                              KasaGiris = (grp.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == grp.Key.Kasa.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                              KasaCikis = (grp.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == grp.Key.Kasa.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                              Bakiye = (grp.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == grp.Key.Kasa.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) -
                              (grp.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == grp.Key.Kasa.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                          }).ToList();
            return result;
        }
        public object GenelToplamListele(BenimSalonumContext context, int odemeTuruId)
        {
            decimal OdemeGiris = context.KasaHareketleri
                .Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == odemeTuruId && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0;
            int OdemeGirisKayitSayisi = context.KasaHareketleri
                .Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == odemeTuruId && c.Hareket == "Kasa Giriş").Count();
            decimal OdemeCikis = context.KasaHareketleri
                .Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == odemeTuruId && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0;
            int OdemeCikisKayitSayisi = context.KasaHareketleri
                .Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == odemeTuruId && c.Hareket == "Kasa Çıkış").Count();
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                Bilgi = "Kasa Giriş",
                KayitSayisi = OdemeGirisKayitSayisi,
                Tutar = OdemeGiris
                },
                new GenelToplam
                {
                Bilgi = "Kasa Çıkış",
                KayitSayisi = OdemeCikisKayitSayisi,
                Tutar = OdemeCikis
                },
                new GenelToplam
                {
                Bilgi = "Bakiye",
                KayitSayisi = OdemeCikisKayitSayisi + OdemeGirisKayitSayisi,
                Tutar = OdemeGiris - OdemeCikis
                },
            };
            return genelToplamlar;

        }
    }
}
