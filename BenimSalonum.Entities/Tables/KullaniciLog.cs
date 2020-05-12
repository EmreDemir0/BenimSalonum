using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSalonum.Entities.Tables
{
    public class KullaniciLog
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string KullaniciAdi{ get; set; }
        public Nullable<DateTime> SonGirisTarihi { get; set; }
        public string YapilanIslem { get; set; }
        public Nullable<DateTime> YapilanIslemTarihi { get; set; }

        public virtual Kullanici Kullanici { get; set; }

    }
}
