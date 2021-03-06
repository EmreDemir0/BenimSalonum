﻿using System;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
    public class PersonelHareket : IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Unvani { get; set; }
        public string PersonelKodu { get; set; }
        public string PersonelAdi { get; set; }
        public string TcKimlikNo { get; set; }
        public DateTime Donemi { get; set; }
        public decimal PrimOrani { get; set; }
        public decimal ToplamSatis { get; set; }
        public decimal AylikMaas { get; set; }
        public string Aciklama { get; set; }
    }
}
