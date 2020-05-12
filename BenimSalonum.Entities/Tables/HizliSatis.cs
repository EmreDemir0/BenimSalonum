using System;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
    public class HizliSatis:IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string Barkod { get; set; }
        public string UrunAdi { get; set; }
        public int GrupId { get; set; }
    }
}
