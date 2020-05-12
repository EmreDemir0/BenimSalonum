using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;

namespace BenimSalonum.Entities.Validations
{
   public class KasaValidator:AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu Alanı Boş Olamaz");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa Ad Alanı Boş Olamaz");
            RuleFor(p => p.KasaKodu).IsUnique().WithMessage("Bu Kasa Kodu Daha Önce Eklenmiş");
        }
    }
}
