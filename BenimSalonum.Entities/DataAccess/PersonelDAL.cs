using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tools;
using BenimSalonum.Entities.Validations;
using System.Linq;

namespace BenimSalonum.Entities.DataAccess
{
    public class PersonelDAL : EntityReposityoryBase<BenimSalonumContext, Personel, PersonelValidator>
    {
        public object PersonelListele(BenimSalonumContext context)
        {
            var result = context.Personeller.Where(c=> c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GroupJoin(context.Fisler, c => c.Id, c => c.PlasiyerId, (personeller, fis) => new
            {
                personeller.Id,
                personeller.PersonelKodu,
                personeller.PersonelAdi,
                personeller.PersonelUnvani,
                personeller.PersonelTc,
                personeller.PersonelGiris,
                personeller.PersonelCikis,
                personeller.CepTelefonu,
                personeller.Telefon,
                personeller.Il,
                personeller.Ilce,
                personeller.Semt,
                personeller.Adres,
                personeller.Fax,
                personeller.EMail,
                personeller.Web,
                personeller.Aciklama,
                personeller.Durumu,
                personeller.AylikMaas,
                personeller.PrimOrani,
                ToplamSatis = (fis.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0) + (fis.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisTuru == "Toptan Satış Faturası").Sum(c => c.ToplamTutar) ?? 0),
                PrimTutar = (((fis.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0) + (fis.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisTuru == "Toptan Satış Faturası").Sum(c => c.ToplamTutar) ?? 0)) / 100 )* personeller.PrimOrani,
            }).ToList();
            return result;
        }
        public object TariheGorePersonelListele(BenimSalonumContext context,int Ay,int Yil)
        {
            var result = context.Personeller.Where(c=>c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GroupJoin(context.Fisler, c => c.Id, c => c.PlasiyerId, (personeller, fis) => new
            {
                personeller.Id,
                personeller.PersonelKodu,
                personeller.PersonelAdi,
                personeller.PersonelUnvani,
                personeller.PersonelTc,
                personeller.PersonelGiris,
                personeller.PersonelCikis,
                personeller.CepTelefonu,
                personeller.Telefon,
                personeller.Il,
                personeller.Ilce,
                personeller.Semt,
                personeller.Adres,
                personeller.Fax,
                personeller.EMail,
                personeller.Web,
                personeller.Aciklama,
                personeller.Durumu,
                personeller.AylikMaas,
                personeller.PrimOrani,
                ToplamSatis = (fis.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisTuru == "Perakende Satış Faturası" && c.Tarih.Month ==Ay && c.Tarih.Year==Yil).Sum(c => c.ToplamTutar) ?? 0) + (fis.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisTuru == "Toptan Satış Faturası" && c.Tarih.Month == Ay && c.Tarih.Year == Yil).Sum(c => c.ToplamTutar) ?? 0),
                PrimTutar = (((fis.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisTuru == "Perakende Satış Faturası" && c.Tarih.Month == Ay && c.Tarih.Year == Yil).Sum(c => c.ToplamTutar) ?? 0) + (fis.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisTuru == "Toptan Satış Faturası" && c.Tarih.Month == Ay && c.Tarih.Year == Yil).Sum(c => c.ToplamTutar) ?? 0)) / 100) * personeller.PrimOrani,

            }).ToList();
            return result;
        }

        public object PersonelFisToplam(BenimSalonumContext context, int personelId)
        {
            var result = (from c in context.Fisler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.PlasiyerId == personelId)
                          group c by new { c.FisTuru }
                into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              ToplamTutar = grp.Sum(c => c.ToplamTutar)
                          }).ToList();
            return result;
        }
    }
}
