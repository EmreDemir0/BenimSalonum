using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;
using BenimSalonum.Entities.Context;
using System.Linq;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.Validations
{
    public class PersonelValidator:AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            RuleFor(p => p.PersonelUnvani).NotEmpty().WithMessage("Personel Ünvanı Alanı Boş Olamaz");
            RuleFor(p => p.PersonelKodu).NotEmpty().WithMessage("Personel Kodu Alanı Boş Olamaz");
            RuleFor(p => p.PersonelKodu).Must(IsUniquePersonelKodu).WithMessage("Bu Personel Kodu Daha Önce Eklenmiş");
            RuleFor(p => p.PersonelAdi).NotEmpty().WithMessage("Personel Adı Alanı Boş Olamaz");
            RuleFor(p => p.PersonelTc).NotEmpty().WithMessage("Personel TC Alanı Boş Olamaz");
            RuleFor(p => p.PersonelTc).Must(IsUniquePersonelTc).WithMessage("Bu Personel TC Daha Önce Eklenmiş");
            RuleFor(p => p.PersonelGiris).NotEmpty().WithMessage("Personel İşe Giriş Tarihi Belirtilmelidir");
        }
        private bool IsUniquePersonelKodu(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Personeller.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.PersonelKodu == arg) == 0;
            }
        }
        private bool IsUniquePersonelTc(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Personeller.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.PersonelTc == arg) == 0;
            }
        }
    }
}
