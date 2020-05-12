using BenimSalonum.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace BenimSalonum.Entities.Tables
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        public string KullaniciID { get; set; }
        public bool Aktif { get; set; }
        public bool Durumu { get; set; }
        public string KullaniciAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Gorevi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string HatirlatmaCevap { get; set; }
        public Nullable<DateTime> KayitTarihi { get; set; }
        public Nullable<DateTime> SonGirisTarihi { get; set; }
        public virtual ICollection<KullaniciLog> KullaniciLog { get; set; }
    }
}
