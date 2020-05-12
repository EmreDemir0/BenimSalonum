using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;

namespace BenimSalonum.Entities.Validations
{
    public class HizliSatisGrupValidator:AbstractValidator<HizliSatisGrup>
    {
        public HizliSatisGrupValidator()
        {
            RuleFor(p => p.GrupAdi).NotEmpty().WithMessage("Grup Adı Alanı Boş Olamaz");

            RuleFor(p => p.GrupAdi).IsUnique().WithMessage("Bu Grup Adı Daha Önce Eklenmiş");
        }
    }
}
