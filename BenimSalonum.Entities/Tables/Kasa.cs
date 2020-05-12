using System;
using System.Collections.Generic;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
    public class Kasa:IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string KasaKodu { get; set; }
        public string KasaAdi { get; set; }
        public string YetkiliKodu { get; set; }
        public string YetkiliAdi { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<KasaHareket> KasaHareket { get; set; }
    }
}
