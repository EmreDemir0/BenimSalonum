
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tools;
using BenimSalonum.Entities.Validations;
using System.Linq;


namespace BenimSalonum.Entities.DataAccess
{
    public class DepoDAL : EntityReposityoryBase<BenimSalonumContext, Depo, DepoValidator>
    {
        public object DepoBazindaStokListele(BenimSalonumContext context, int stokId)
        {
            var result = context.Depolar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GroupJoin(context.StokHareketleri.Where(c => c.StokId == stokId), c => c.Id, c => c.DepoId, (depolar, stokHareketleri) => new
            {
                depolar.DepoKodu,
                depolar.DepoAdi,
                depolar.YetkiliKodu,
                depolar.YetkiliAdi,
                depolar.Il,
                depolar.Ilce,
                depolar.Semt,
                depolar.Adres,
                depolar.Telefon,
                depolar.Id,
                StokGiris = stokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = stokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok = (stokHareketleri.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Hareket == "Stok Giriş").Sum(c => c.Miktar)) ?? 0 -
            (stokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)
            }).ToList();
            return result;
        }
        public object DepoListele(BenimSalonumContext context)
        {
            var result = (from c in context.Depolar.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID) select c).AsEnumerable().Select(c => new
            {
                c.DepoKodu,
                c.DepoAdi,
                c.YetkiliKodu,
                c.YetkiliAdi,
                c.Aciklama
            }).ToList();
            return result;
        }
    }
    }
    

