using BenimSalonum.Entities.Interfaces;
using System;

namespace BenimSalonum.Entities.Tables
{
    public class HizliSatisGrup :IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string GrupAdi { get; set; }
    }
}
