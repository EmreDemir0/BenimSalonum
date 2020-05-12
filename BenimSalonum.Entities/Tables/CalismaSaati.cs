using BenimSalonum.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSalonum.Entities.Tables
{
    public class CalismaSaati : IEntity
    {
        public int Id { get; set; }
        public string KullaniciID { get; set; }
        public Nullable<DateTime> iseBaslamaSaati { get; set; }
        public Nullable<DateTime> isBitisSaati { get; set; }
        public int RandevuAraligi { get; set; }
    }
}
