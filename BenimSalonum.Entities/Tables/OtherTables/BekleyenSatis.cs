﻿using System.Collections.Generic;


namespace BenimSalonum.Entities.Tables.OtherTables
{
    public class BekleyenSatis
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public Fis BekleyenFis { get; set; }
        public decimal OdenenTutar { get; set; }
        public List<StokHareket> StokHareketi{ get; set; }
        public List<KasaHareket> KasaHareketi { get; set; }

    }
}
