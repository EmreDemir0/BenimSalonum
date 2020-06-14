using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;
using BenimSalonum.Entities.Context;
using System.Linq;
using BenimSalonum.Entities.Tools;

namespace BenimSalonum.Entities.Validations
{
    public class StokValidator : AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu Alanı Boş Olamaz");
            RuleFor(p => p.StokKodu).Must(IsUniqueStokKodu).WithMessage("Stok Kodu Daha Önce Eklenmiş");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı Alanı Boş Olamaz").Length(5, 50)
                .WithMessage("Stok Adı Alanı 5 - 50 Karakter Arasında Olabilir");
            RuleFor(p => p.Barkod).NotEmpty().WithMessage("Barkod Alanı Boş Olamaz");
            RuleFor(p => p.Barkod).Must(IsUniqueBarkod).WithMessage("Barkod Daha Önce Eklenmiş");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı 1 Alanı 0'dan Küçük Olamaz");
            RuleFor(p => p.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı 2 Alanı 0'dan Küçük Olamaz");
            RuleFor(p => p.AlisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı 3 Alanı 0'dan Küçük Olamaz");
            RuleFor(p => p.SatisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı 1 Alanı 0'dan Küçük Olamaz");
            RuleFor(p => p.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı 2 Alanı 0'dan Küçük Olamazr");
            RuleFor(p => p.SatisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı 3 Alanı 0'dan Küçük Olamaz");
        }
        private bool IsUniqueStokKodu(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Stoklar.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.StokKodu == arg) == 0;
            }
        }
        private bool IsUniqueBarkod(string arg)
        {
            using (var context = new BenimSalonumContext())
            {
                return context.Stoklar.Count(c => c.KullaniciID == RoleTool.kullaniciEntity.KullaniciID && c.Barkod == arg) == 0;
            }
        }
    }
}
