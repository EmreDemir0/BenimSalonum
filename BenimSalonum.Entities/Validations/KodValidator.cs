using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;
using BenimSalonum.Entities.Context;
using System.Linq;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.Validations
{
   public class KodValidator:AbstractValidator<Kod>
    {
        public KodValidator()
        {
           RuleFor(p => p.OnEki).Must(IsUniqueKod).WithMessage("Bu Ön Ek Daha Önce Eklenmiş");
        }
        private bool IsUniqueKod(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Kodlar.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OnEki == arg) == 0;
            }
        }
    }
}
