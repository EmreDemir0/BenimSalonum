using System;
using System.Collections.Generic;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
    public class Fis : IEntity
    {
        public Fis Clone()
        {
            Fis yeniFis = new Fis();
            yeniFis.KullaniciID = this.KullaniciID;
            yeniFis.FisKodu = this.FisKodu;
            yeniFis.FisBaglantiKodu = this.FisBaglantiKodu;
            yeniFis.FisTuru = this.FisTuru;
            yeniFis.CariId = this.CariId;
            yeniFis.FaturaUnvani = this.FaturaUnvani;
            yeniFis.CepTelefonu = this.CepTelefonu;
            yeniFis.Il = this.Il;
            yeniFis.Ilce = this.Ilce;
            yeniFis.Semt = this.Semt;
            yeniFis.Adres = this.Adres;
            yeniFis.VergiDairesi = this.VergiDairesi;
            yeniFis.VergiNo = this.VergiNo;
            yeniFis.BelgeNo = this.BelgeNo;
            yeniFis.Tarih = this.Tarih;
            yeniFis.PlasiyerId = this.PlasiyerId;
            yeniFis.IskontoOrani = this.IskontoOrani;
            yeniFis.IskontoTutar = this.IskontoTutar;
            yeniFis.Alacak = this.Alacak;
            yeniFis.Borc = this.Borc;
            yeniFis.ToplamTutar = this.ToplamTutar;
            yeniFis.Aciklama = this.Aciklama;
            yeniFis.FisBaglantiKodu = this.FisBaglantiKodu;
            return yeniFis;
        }
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        public Nullable<int> CariId { get; set; }
        public string FaturaUnvani { get; set; }
        public string CepTelefonu { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string BelgeNo { get; set; }
        public DateTime Tarih { get; set; }
        public int? PlasiyerId { get; set; }
        public decimal? IskontoOrani { get; set; }
        public decimal? IskontoTutar { get; set; }
        public Nullable<decimal> Alacak { get; set; }
        public Nullable<decimal> Borc { get; set; }
        public decimal? ToplamTutar { get; set; }
        public string Aciklama { get; set; }
        public string FisBaglantiKodu { get; set; }

        public virtual Cari Cari { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
