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
    public class StokHareketDAL : EntityReposityoryBase<BenimSalonumContext, StokHareket, StokHareketValidator>
    {
        public object GetGenelStok(BenimSalonumContext context, int stokId)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.StokId == stokId)
                          group c by new { c.Hareket } into g
                          select new

                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              Toplam = g.Sum(c => c.Miktar)
                          }).ToList();
            return result;
        }
        public object GetDepoStok(BenimSalonumContext context, int stokId)
        {
            var result = context.Depolar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GroupJoin(context.StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.StokId == stokId), c => c.Id, c => c.DepoId, (depolar, stokHareketleri) => new
            {
                depolar.DepoKodu,
                depolar.DepoAdi,
                StokGiris = stokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = stokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = (stokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar)) ?? 0 - (stokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)
            }).ToList();
            return result;
        }
        public object DepoStokListele(BenimSalonumContext context, int depoId) // stok kartındaki işlemleri class üzerinden hallediyruz
        {
            var tablo = context.Stoklar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GroupJoin(context.StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.DepoId == depoId), c => c.Id, c => c.StokId, (Stoklar, StokHareketleri) =>
           new                                  //grupjoin 2 tabloyu birbirine bağlar ancak stoklar ana tablo olur
                                                //stok hareketleri ile birine bağlantılı tablo yapabiliriz
           {
               Stoklar.StokAdi,
               Stoklar.Barkod,

               StokGiris = StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
               //// hareket değişkenini stok girişi çıkısı diye kontrol ederek hareketi stok Girişi olanların
               ////toplam tutarını al demek
               StokCikis = StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
               MevcutStok = (StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar)) ?? 0 - (StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)

           }).ToList();
            return tablo;
        }
        public object DepoIstatistikListele(BenimSalonumContext context, int depoId)
        {

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                Bilgi = "Stok Giriş",
                KayitSayisi = context.StokHareketleri.Where(c=>c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID&&c.Siparis == false &&c.DepoId == depoId && c.Hareket == "Stok Giriş").Count(),
                Tutar = context.StokHareketleri.Where(c=>c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID&&c.Siparis == false &&c.DepoId == depoId && c.Hareket == "Stok Giriş").Sum(c=>c.Miktar) ?? 0
                },
                new GenelToplam
                {
                Bilgi = "Stok Çıkış",
                KayitSayisi = context.StokHareketleri.Where(c=>c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID&&c.Siparis == false &&c.DepoId == depoId && c.Hareket == "Stok Çıkış").Count(),
                Tutar = context.StokHareketleri.Where(c=>c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID&&c.Siparis == false &&c.DepoId == depoId && c.Hareket == "Stok Çıkış").Sum(c=>c.Miktar) ?? 0
                },
            };
            return genelToplamlar;
        }
    }
}

