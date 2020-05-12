using System;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
    public class KasaHareket : IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public int KasaId { get; set; }
        public int OdemeTuruId { get; set; }
        public Nullable<int> CariId { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public string Aciklama { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Kasa Kasa { get; set; }
        public virtual OdemeTuru OdemeTuru { get; set; }
        public virtual Cari Cari { get; set; }
    }
}
