using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;

namespace BenimSalonum.Entities.Validations
{
   public class KodValidator:AbstractValidator<Kod>
    {
        public KodValidator()
        {
            RuleFor(p => p.OnEki).IsUnique().WithMessage("Bu Ön Ek Daha Önce Eklenmiş");
        }
    }
}
