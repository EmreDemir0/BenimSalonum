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
    public class KasaDAL : EntityReposityoryBase<BenimSalonumContext,Kasa,KasaValidator >
    {
        public object KasaListele(BenimSalonumContext context)
        {
            var result = context.Kasalar.Where(c=> c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GroupJoin(context.KasaHareketleri, c => c.Id, c => c.KasaId, (kasa, kasahareket) =>
                   new
                   {
                       kasa.Id,
                       kasa.KasaKodu,
                       kasa.KasaAdi,
                       kasa.YetkiliAdi,
                       kasa.YetkiliKodu,
                       kasa.Aciklama,
                       KasaGiris = (kasahareket.Where(c=> c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId==kasa.Id && c.Hareket =="Kasa Giriş").Sum(c=>c.Tutar) ?? 0),
                       KasaCikis = (kasahareket.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == kasa.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                       Bakiye = (kasahareket.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == kasa.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)-
                       (kasahareket.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == kasa.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
                   }).ToList();
            return result;
        }
        public object OdemeTuruToplamListele(BenimSalonumContext context,int kasaId)
        {
            var result = (from c in context.KasaHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == kasaId)
                          group c by new { c.OdemeTuru} into grp
                          select new
                          {

                              grp.Key.OdemeTuru.OdemeTuruAdi,
                              KasaGiris = (grp.Where(c=> c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Giriş").Sum(c=>c.Tutar) ?? 0),
                              KasaCikis = (grp.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                              Bakiye = (grp.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) -
                              (grp.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                          }).ToList();
                            return result;
        }
        public object GenelToplamListele(BenimSalonumContext context, int kasaId)
        {
            decimal KasaGiris = context.KasaHareketleri
                .Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == kasaId && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0;
            int KasaGirisKayitSayisi = context.KasaHareketleri
                .Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == kasaId && c.Hareket == "Kasa Giriş").Count();
            decimal KasaCikis = context.KasaHareketleri
                .Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == kasaId && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0;
            int KasaCikisKayitSayisi = context.KasaHareketleri
                .Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaId == kasaId && c.Hareket == "Kasa Çıkış").Count();
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                Bilgi = "Kasa Giriş",
                KayitSayisi = KasaGirisKayitSayisi,
                Tutar = KasaGiris
                },
                new GenelToplam
                {
                Bilgi = "Kasa Çıkış",
                KayitSayisi = KasaCikisKayitSayisi,
                Tutar = KasaCikis
                },
                new GenelToplam
                {
                Bilgi = "Bakiye",
                KayitSayisi = KasaGirisKayitSayisi + KasaCikisKayitSayisi,
                Tutar = KasaGiris - KasaCikis
                },
            };
            return genelToplamlar;
        }
    }
}
