using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;

namespace BenimSalonum.Entities.Validations
{
    public class FisValidator:AbstractValidator<Fis>
    {
        public FisValidator()
        {
           // RuleFor(p => pFaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Alanı Boş Olamaz");
            RuleFor(p => p.FisKodu).IsUnique().WithMessage("Bu Fiş Kodu Daha Önce Eklenmiş");
        }
    }
}
