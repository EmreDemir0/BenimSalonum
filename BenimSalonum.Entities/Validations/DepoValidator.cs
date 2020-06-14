using System.Linq;
using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Extensions.FluentValidation;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.Validations
{
    public class DepoValidator:AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu Alanı Boş Olamaz");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo Adı Alanı Boş Olamaz"); 
            RuleFor(p => p.DepoKodu).Must(IsUniqueDepoKodu).WithMessage("Bu Depo Kodu Daha Önce Eklenmiş");
            RuleFor(p => p.DepoKodu).IsUnique().WithMessage("Bu Depo Kodu Daha Önce Eklenmiş");
        }

        private bool IsUniqueDepoKodu(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Depolar.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.DepoKodu == arg) == 0;
            }
        }
    }
}
