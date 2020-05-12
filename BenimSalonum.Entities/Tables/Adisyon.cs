using BenimSalonum.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSalonum.Entities.Tables
{
    public class Adisyon : IEntity
    {
        public int Id { get; set; }
        public string KullaniciID { get; set; }
        public string Durum { get; set; }
        public string Hizmet { get; set; }
        public string Urun { get; set; }
        public DateTime TarihSaat { get; set; }
        public decimal ToplamTutar { get; set; }
        public decimal Odeme { get; set; }
        public decimal KalanTutar { get; set; }
        public bool HizmetAldiMi { get; set; }
        public decimal ParaPuan { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual Musteri Musteri { get; set; }
        public string Aciklama { get; set; }
    }
}

