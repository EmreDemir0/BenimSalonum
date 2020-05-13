using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tools;
using BenimSalonum.Entities.Validations;
using System.Linq;
using System.Linq.Dynamic;

namespace BenimSalonum.Entities.DataAccess
{
   public class KullaniciDAL : EntityReposityoryBase<BenimSalonumContext, Kullanici, KullaniciValidator>
    {
    }
}
