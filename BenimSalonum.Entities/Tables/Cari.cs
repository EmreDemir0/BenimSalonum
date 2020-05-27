﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
     public class Cari:IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string CariTuru { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string YetkiliKisi { get; set; }
        public string FaturaUnvani { get; set; }
        public string CepTelefonu { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string Web { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public string CariGrubu { get; set; }
        public string CariAltGrubu { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string TicaretSicilNo { get; set; }
        public string MersisNo { get; set; }
        public Nullable<decimal> IskontoOrani { get; set; }
        public Nullable<decimal> RiskLimiti { get; set; }
        public decimal AlisOzelFiyati { get; set; }
        public decimal SatisOzelFiyati { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<KasaHareket> KasaHareket { get; set; }
        public virtual ICollection<Fis> Fis { get; set; }
    }
}
