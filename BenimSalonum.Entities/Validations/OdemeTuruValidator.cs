using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;
using BenimSalonum.Entities.Context;
using System.Linq;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.Validations
{
    public class OdemeTuruValidator:AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Ödeme Kodu Alanı Boş Olamaz");
            RuleFor(p => p.OdemeTuruKodu).Must(IsUniqueOdemeTuruKodu).WithMessage("Bu Ödeme Kodu Daha Önce Eklenmiş");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Ödeme Türü Adı Alanı Boş Olamaz");
        }
        private bool IsUniqueOdemeTuruKodu(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.OdemeTurleri.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.OdemeTuruKodu == arg) == 0;
            }
        }
    }
}
