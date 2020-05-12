using BenimSalonum.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSalonum.Entities.Tables
{
    public class Musteri : IEntity
    {
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriCeptelefonu { get; set; }
        public string MusteriCinsiyeti { get; set; }
        public string MusteriEposta { get; set; }
        public Nullable<DateTime> dogumTarihi { get; set; }
        public string MusteriAciklama { get; set; }
        public int PersonelId { get; set; }
        public virtual ICollection<KasaHareket> KasaHareket { get; set; }
        public virtual ICollection<Adisyon> Adisyon { get; set; }
    }
}
