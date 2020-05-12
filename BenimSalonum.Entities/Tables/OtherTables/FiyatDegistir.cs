using System;

namespace BenimSalonum.Entities.Tables.OtherTables
{
   public class FiyatDegistir
    {
        public string KullaniciID { get; set; }
        public string FiyatTuru { get; set; }
        public string KolonAdi { get; set; }
        public bool Degistir  { get; set; }
        public string DegisimTuru { get; set; } //% veya Tl
        public string DegisimYonu { get; set; }//yukselt alcalt
        public decimal Degeri { get; set; }
    }
}
