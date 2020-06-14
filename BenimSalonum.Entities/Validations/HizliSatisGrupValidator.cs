using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;
using BenimSalonum.Entities.Context;
using System.Linq;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.Validations
{
    public class HizliSatisGrupValidator:AbstractValidator<HizliSatisGrup>
    {
        public HizliSatisGrupValidator()
        {
            RuleFor(p => p.GrupAdi).NotEmpty().WithMessage("Grup Adı Alanı Boş Olamaz");

            RuleFor(p => p.GrupAdi).Must(IsUniqueGrupAdi).WithMessage("Bu Grup Adı Daha Önce Eklenmiş");
        }
        private bool IsUniqueGrupAdi(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Cariler.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.CariKodu == arg) == 0;
            }
        }
    }
}
