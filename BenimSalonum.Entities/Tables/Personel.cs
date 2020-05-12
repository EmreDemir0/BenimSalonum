using BenimSalonum.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace BenimSalonum.Entities.Tables
{
    public class Personel : IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string PersonelUnvani { get; set; }
        public string PersonelKodu { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelTc { get; set; }
        public Nullable<DateTime> PersonelGiris { get; set; }
        public Nullable<DateTime> PersonelCikis { get; set; }
        public string CepTelefonu { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string Web { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public Nullable<decimal> AylikMaas { get; set; }
        public Nullable<decimal> PrimOrani { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<Fis> Fis { get; set; }
        public virtual ICollection<Adisyon> Adisyon { get; set; }
    }

}
