using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;

namespace BenimSalonum.Entities.Validations
{
    public class TanimValidator:AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tanım Türü Alanı Boş Olamaz");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanım Adı Alanı Boş Olamaz");
            RuleFor(p => p.Tanimi).IsUnique().WithMessage("Tanım Adı Daha Önce Eklenmiş");


        }
    }
}
