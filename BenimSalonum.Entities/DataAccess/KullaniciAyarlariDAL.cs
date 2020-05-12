using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.Validations;

namespace BenimSalonum.Entities.DataAccess
{
    public class KullaniciAyarlariDAL : EntityReposityoryBase<BenimSalonumContext, KullaniciAyarlari, KullaniciAyarlariValidator>
    {
    }
}
