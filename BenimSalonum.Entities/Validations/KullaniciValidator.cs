using FluentValidation;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.Entities.Validations
{
    public class KullaniciValidator : AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Olamaz");
            RuleFor(p => p.Adi).NotEmpty().WithMessage(" Adı Alanı Boş Olamaz");
            RuleFor(p => p.Soyadi).NotEmpty().WithMessage("Soyadı Alanı Boş Olamaz");
            RuleFor(p => p.HatirlatmaSorusu).NotEmpty().WithMessage("Hatırlatma Sorusu Alanı Boş Olamaz");
            RuleFor(p => p.HatirlatmaCevap).NotEmpty().WithMessage("Hatırlatma Cevap Alanı Boş Olamaz");
            RuleFor(p => p.Gorevi).NotEmpty().WithMessage("Görevi Alanı Boş Olamaz");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola Alanı Boş Olamaz");
        }
    }
}
