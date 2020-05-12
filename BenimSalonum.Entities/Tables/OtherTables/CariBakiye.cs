using System;


namespace BenimSalonum.Entities.Tables.OtherTables
{
    public class CariBakiye

    {
        public string KullaniciID { get; set; }
        public int CariId { get; set; }
        public decimal RiskLimiti { get; set; }
        public decimal Alacak { get; set; }
        public decimal Borc { get; set; }
        public decimal Bakiye { get; set; }
    }
}
