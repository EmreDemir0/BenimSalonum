using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;

namespace BenimSalonum.Entities.Validations
{
    public class PersonelValidator:AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            RuleFor(p => p.PersonelUnvani).NotEmpty().WithMessage("Personel Ünvanı Alanı Boş Olamaz");
            RuleFor(p => p.PersonelKodu).NotEmpty().WithMessage("Personel Kodu Alanı Boş Olamaz");
            RuleFor(p => p.PersonelKodu).IsUnique().WithMessage("Bu Personel Kodu Daha Önce Eklenmiş");
            RuleFor(p => p.PersonelAdi).NotEmpty().WithMessage("Personel Adı Alanı Boş Olamaz");
            RuleFor(p => p.PersonelTc).NotEmpty().WithMessage("Personel TC Alanı Boş Olamaz");
            RuleFor(p => p.PersonelTc).IsUnique().WithMessage("Bu Personel TC Daha Önce Eklenmiş");
            RuleFor(p => p.PersonelGiris).NotEmpty().WithMessage("Personel İşe Giriş Tarihi Belirtilmelidir");
        }
    }
}
