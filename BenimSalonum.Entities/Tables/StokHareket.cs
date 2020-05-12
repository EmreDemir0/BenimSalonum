using System;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
   public class StokHareket:IEntity
    {
        public StokHareket Clone()
        {
            StokHareket hareket = new StokHareket();
            hareket.KullaniciID = this.KullaniciID;
            hareket.FisKodu = this.FisKodu;
            hareket.Hareket = this.Hareket;
            hareket.StokId = this.StokId;
            hareket.Miktar = this.Miktar;
            hareket.Kdv = this.Kdv;
            hareket.BirimFiyati = this.BirimFiyati;
            hareket.IndirimOrani = this.IndirimOrani;
            hareket.DepoId = this.DepoId;
            hareket.Depo = this.Depo;
            hareket.SeriNo = this.SeriNo;
            hareket.Tarih = this.Tarih;
            hareket.Aciklama = this.Aciklama;
            hareket.Siparis = this.Siparis;

            return hareket;
        }
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public int StokId { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public int Kdv { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<decimal> IndirimOrani { get; set; }
        public int DepoId { get; set; }
        public string SeriNo { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public string Aciklama { get; set; }
        public bool Siparis { get; set; }
        public virtual Stok Stok { get; set; }
        public virtual Depo Depo { get; set; }
    }
}
