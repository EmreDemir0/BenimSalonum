using FluentValidation;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Extensions.FluentValidation;

namespace BenimSalonum.Entities.Validations
{
   public class CariValidator:AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu Alanı Boş Olamaz");
            RuleFor(p => p.CariKodu).IsUnique().WithMessage("Bu Cari Kodu Daha Önce Eklenmiş");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı Alanı Boş Olamaz").Length(5, 50)
                .WithMessage("Stok Adı Alanı 5 - 50 Karakter Arasında Olabilir");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Alanı Boş Olamaz");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto Oranı 0'dan Küçük Olamaz");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti Alanı 0'dan Küçük Olamaz");
        }
    }
}
