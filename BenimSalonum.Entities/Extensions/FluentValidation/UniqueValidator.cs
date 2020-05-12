using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Interfaces;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;


namespace BenimSalonum.Entities.Extensions.FluentValidation
{
    public class UniqueValidator<Tentity> : PropertyValidator
        where Tentity : class, IEntity, new()
    {
        public UniqueValidator() : base("Girdiğiniz {PropertyName} Kayıtlarda Mevcut")
        {
        }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            using (var benimSalonumContext = new BenimSalonumContext())
            {
                var dataId = context.Instance.GetType().GetProperty("Id").GetValue(context.Instance);//düzenle dediğimizde hata vermemesi için.
                var result = benimSalonumContext.Set<Tentity>().Where($"{context.PropertyName}==@0 And Id!=@1", context.PropertyValue, dataId).Any();
                return !result;
            }
        }
    }
}
