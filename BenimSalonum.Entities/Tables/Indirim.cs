using System;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
    public class Indirim:IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string StokKodu { get; set; }
        public string Barkod { get; set; }
        public string StokAdi { get; set; }
        public string IndirimTuru { get; set; }
        public Nullable <DateTime> BaslangicTarihi { get; set; }
        public Nullable <DateTime> BitisTarihi { get; set; }
        public decimal IndirimOrani { get; set; }
        public string Aciklama { get; set; }

    }
}
