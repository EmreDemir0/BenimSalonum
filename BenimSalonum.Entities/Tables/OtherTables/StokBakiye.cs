using System;

namespace BenimSalonum.Entities.Tables.OtherTables
{
    public class StokBakiye
    {
        public string KullaniciID { get; set; }
        public int StokId { get; set; }
        public decimal StokGiris { get; set; }
        public decimal StokCikis { get; set; }
        public decimal MevcutStok { get; set; }
    }
}
