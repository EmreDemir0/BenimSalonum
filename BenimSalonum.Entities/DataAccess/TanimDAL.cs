﻿using BenimSalonum.Entities.Context;
using BenimSalonum.Entities.Repositories;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Validations;

namespace BenimSalonum.Entities.DataAccess
{
    public class TanimDAL : EntityReposityoryBase<BenimSalonumContext, Tanim,TanimValidator>
    {
    }
}
