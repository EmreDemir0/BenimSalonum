using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using BenimSalonum.Entities.Interfaces;
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.DataAccess
{
    public class CariDAL : EntityReposityoryBase<BenimSalonumContext, Cari, CariValidator>
    {
        public object CariListele(BenimSalonumContext context)
        {
            var result = context.Cariler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID).GroupJoin(context.Fisler, c => c.Id, c => c.CariId, (cariler, fisler) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.EMail,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiNo,
                cariler.VergiDairesi,
                cariler.IskontoOrani,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                Alacak = fisler.Sum(c => c.Alacak) ?? 0,
                Borc = fisler.Sum(c => c.Borc) ?? 0,
                Bakiye = fisler.Select(c => (decimal?)(c.Alacak ?? 0 - c.Borc ?? 0)).Sum() ?? 0
            }).ToList();
            return result;
        }
        public object CariFisAyrinti(BenimSalonumContext context, int cariId)
        {
            return (from fis in context.Fisler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.CariId == cariId)
                    select new
                    {
                        fis.Id,
                        fis.FisKodu,
                        fis.FisTuru,
                        fis.BelgeNo,
                        fis.Tarih,
                        fis.IskontoOrani,
                        fis.IskontoTutar,
                        fis.Aciklama,
                        fis.Alacak,
                        fis.Borc,
                        Bakiye = context.Fisler.OrderBy(c => c.Tarih).ThenBy(c => c.Id)
                       .Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.CariId == cariId && c.Tarih <= fis.Tarih && c.Id <= fis.Id)
                       .Select(c => (decimal?)(c.Alacak ?? 0 - c.Borc ?? 0))
                       .Sum() ?? 0
                    }).OrderBy(c => c.Tarih).ToList();
        }
        public object CariFisGenelToplam(BenimSalonumContext context, int cariId)
        {//gelen carikodu ile fişler tablosundaki verileri yeni bir tablo olusturma

            var result = (from c in context.Fisler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.CariId == cariId)
                          group c by new { c.FisTuru }
                          into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              Tutar = grp.Sum(c => c.Alacak ?? c.Borc)
                          }).ToList();
            return result;
        }
        public object CariGenelToplam(BenimSalonumContext context, int cariId)
        {
            decimal alacak = context.Fisler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.CariId == cariId).Sum(c => c.Alacak) ?? 0;

            decimal borc = context.Fisler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.CariId == cariId).Sum(c => c.Borc) ?? 0; ;

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                Bilgi = "Alacak",
                Tutar = alacak
                },
                new GenelToplam
                {
                Bilgi = "Borç",
                Tutar = borc
                },
                new GenelToplam
                {
                Bilgi = "Bakiye",
                Tutar = alacak-borc
                },
            };
            return genelToplamlar;
        }
        public CariBakiye CariBakiyesi(BenimSalonumContext context, int cariId)
        {
            decimal alacak = context.Fisler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.CariId == cariId).Sum(c => c.Alacak) ?? 0;

            decimal borc = context.Fisler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.CariId == cariId).Sum(c => c.Borc) ?? 0; ;

            CariBakiye entity = new CariBakiye
            {
                CariId = cariId,
                RiskLimiti = Convert.ToDecimal(context.Cariler.SingleOrDefault(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Id == cariId).RiskLimiti),
                Alacak = alacak,
                Borc = borc,
                Bakiye = alacak - borc
            };
            return entity;
        }
        public object CariTelefonlari(BenimSalonumContext context)
        {
            var result = (from c in context.Cariler.Where(c=>c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID)
                          select new
                          {
                              c.CariKodu,
                              c.CariAdi,
                              c.CepTelefonu
                          }).ToList();
            return result;
        }

    }
}

