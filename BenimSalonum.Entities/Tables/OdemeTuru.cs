using System;
using System.Collections.Generic;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
    public class OdemeTuru:IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string OdemeTuruKodu { get; set; }
        public string OdemeTuruAdi { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<KasaHareket> KasaHareket { get; set; }
    }
}
