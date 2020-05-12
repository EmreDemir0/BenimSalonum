using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;

namespace BenimSalonum.Entities.Validations
{
    public class OdemeTuruValidator:AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Ödeme Kodu Alanı Boş Olamaz");
            RuleFor(p => p.OdemeTuruKodu).IsUnique().WithMessage("Bu Ödeme Kodu Daha Önce Eklenmiş");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Ödeme Türü Adı Alanı Boş Olamaz");
        }
    }
}
