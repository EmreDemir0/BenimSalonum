using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tools;
using BenimSalonum.Entities.Validations;
using System;
using System.Linq;

namespace BenimSalonum.Entities.DataAccess
{
    public class IndirimDAL : EntityReposityoryBase<BenimSalonumContext, Indirim, IndirimValidator>
    {
        public object IndirimListele(BenimSalonumContext context)
        {
            var result = (from c in context.Indirimler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID) select c).AsEnumerable().Select(c => new
            {
                IndirimAktif = Aktif(c.IndirimTuru, Convert.ToDateTime(c.BitisTarihi), c.Durumu),
                c.Durumu,
                c.StokKodu,
                c.Barkod,
                c.StokAdi,
                c.IndirimTuru,
                c.BaslangicTarihi,
                c.BitisTarihi,
                c.IndirimOrani,
                c.Aciklama,
                c.Id,
            }).ToList();
            return result;
        }
        public decimal StokIndirimi(BenimSalonumContext context, string StokKodu)
        {
            decimal sonuc = 0;
            var result = (from c in context.Indirimler.Where(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.StokKodu == StokKodu) select c).AsEnumerable().Select(c => new
            {
                IndirimAktif = Aktif(c.IndirimTuru, Convert.ToDateTime(c.BitisTarihi), c.Durumu),
                c.IndirimOrani
            }).SingleOrDefault();
            if (result != null && result.IndirimAktif == true)
            {
                sonuc = result.IndirimOrani;
            }
            return sonuc;
        }
        bool Aktif(string IndirimTuru, DateTime BitisTarihi, bool Durum)
        {
            bool result = false;
            if (Durum)
            {
                if (IndirimTuru == "Süresiz")
                {
                    result = true;
                }
                else
                {
                    if (DateTime.Now <= BitisTarihi)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
