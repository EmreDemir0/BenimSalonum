using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;
using BenimSalonum.Entities.Context;
using System.Linq;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.Validations
{
   public class KasaValidator:AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu Alanı Boş Olamaz");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa Ad Alanı Boş Olamaz");
            RuleFor(p => p.KasaKodu).Must(IsUniqueKasaKodu).WithMessage("Bu Kasa Kodu Daha Önce Eklenmiş");
        }
        private bool IsUniqueKasaKodu(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Kasalar.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.KasaKodu == arg) == 0;
            }
        }
    }
}
