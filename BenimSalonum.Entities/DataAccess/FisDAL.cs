using System;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Validations;

namespace BenimSalonum.Entities.DataAccess
{
    public class FisDAL:EntityReposityoryBase<BenimSalonumContext, Fis,FisValidator>
    {
    }
}
