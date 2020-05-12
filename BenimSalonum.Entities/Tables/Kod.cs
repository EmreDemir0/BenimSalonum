using BenimSalonum.Entities.Interfaces;
using System;

namespace BenimSalonum.Entities.Tables
{
    public class Kod : IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string Tablo { get; set; }
        public string OnEki { get; set; }
        public int SonDeger { get; set; }
    }
}
