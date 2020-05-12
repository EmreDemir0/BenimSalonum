using System;
using BenimSalonum.Entities.Interfaces;

namespace BenimSalonum.Entities.Tables
{
    public class Tanim : IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public string Turu { get; set; }
        public string Tanimi { get; set; }
        public string Aciklama { get; set; }
    }
}
