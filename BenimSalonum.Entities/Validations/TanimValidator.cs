using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;
using BenimSalonum.Entities.Context;
using System.Linq;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.Validations
{
    public class TanimValidator : AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tanım Türü Alanı Boş Olamaz");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanım Adı Alanı Boş Olamaz");
            RuleFor(p => p.Tanimi).Must(IsUniqueTanimi).WithMessage("Tanım Adı Daha Önce Eklenmiş");
        }
        private bool IsUniqueTanimi(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Tanimlar.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Tanimi == arg) == 0;
            }
        }
    }
}
