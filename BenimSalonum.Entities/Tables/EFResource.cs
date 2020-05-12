using System;
using System.ComponentModel.DataAnnotations;

namespace BenimSalonum.Entities.Tables
{
    public class EFResource
    {
        [Key()]
        public int UniqueID { get; set; }
        public int ResourceID { get; set; }
        public string ResourceName { get; set; }
        public int Color { get; set; }
        public string KullaniciID { get; set; }
    }
}
