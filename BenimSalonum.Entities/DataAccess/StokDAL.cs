using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.Tools;
using BenimSalonum.Entities.Validations;
using System.Linq;

namespace BenimSalonum.Entities.DataAccess
{
    public class StokDAL : EntityReposityoryBase<BenimSalonumContext, Stok, StokValidator>
    {
        public object StokListele(BenimSalonumContext context) // stok kartındaki işlemleri class üzerinden hallediyruz
        {
            var tablo = context.Stoklar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                (Stoklar, StokHareketleri) =>
      new                                  //grupjoin 2 tabloyu birbirine bağlar ancak stoklar ana tablo olur
                                           //stok hareketleri ile birine bağlantılı tablo yapabiliriz
      {
          Stoklar.Id,
          Stoklar.Durumu,
          Stoklar.StokKodu,
          Stoklar.StokAdi,
          Stoklar.Barkod,
          Stoklar.BarkodTuru,
          Stoklar.Birimi,
          Stoklar.StokGrubu,
          Stoklar.StokAltGrubu,
          Stoklar.Marka,
          Stoklar.Modeli,
          Stoklar.OzelKod1,
          Stoklar.OzelKod2,
          Stoklar.OzelKod3,
          Stoklar.OzelKod4,
          Stoklar.GarantiSuresi,
          Stoklar.UreticiKodu,
          Stoklar.AlisKdv,
          Stoklar.SatisKdv,
          Stoklar.AlisFiyati1,
          Stoklar.AlisFiyati2,
          Stoklar.AlisFiyati3,
          Stoklar.SatisFiyati1,
          Stoklar.SatisFiyati2,
          Stoklar.SatisFiyati3,
          Stoklar.MinStokMiktari,
          Stoklar.MaxStokMiktari,
          Stoklar.Aciklama,
          StokGiris = StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
          // hareket değişkenini stok girişi çıkısı diye kontrol ederek hareketi stok Girişi olanların
          //toplam tutarını al demek
          StokCikis = StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,

          MevcutStok = (StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar)) ?? 0 -
                       (StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)

      }).ToList();
            return tablo;
        }
        public StokBakiye StokBakiyesi(BenimSalonumContext context, int stokId)
        {
            return new StokBakiye
            {
                StokId = stokId,
                StokGiris = context.StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = context.StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = (context.StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar)) ?? 0 -
                           (context.StokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)
            };
        }
    }

}
