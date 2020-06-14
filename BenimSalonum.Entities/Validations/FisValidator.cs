using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;
using BenimSalonum.Entities.Context;
using System.Linq;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.Validations
{
    public class FisValidator : AbstractValidator<Fis>
    {
        public FisValidator()
        {
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Alanı Boş Olamaz");
            RuleFor(p => p.FisKodu).Must(IsUniqueFisKodu).WithMessage("Fiş Kodu Daha Önceden Kullanılmış");
        }
        private bool IsUniqueFisKodu(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Fisler.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.FisKodu == arg) == 0;
            }
        }
    }
}
