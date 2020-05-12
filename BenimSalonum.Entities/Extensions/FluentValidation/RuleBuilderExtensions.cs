using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Extensions.FluentValidation
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilderOptions<Tentity,object>IsUnique<Tentity>(this IRuleBuilder<Tentity,object> ruleBuilder)
            where Tentity:class,IEntity,new()
        {
            return ruleBuilder.SetValidator(new UniqueValidator<Tentity>());
        }
    }
}
