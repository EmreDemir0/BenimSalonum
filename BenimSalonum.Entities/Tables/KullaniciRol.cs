using BenimSalonum.Entities.Interfaces;
using System;

namespace BenimSalonum.Entities.Tables
{
    public class KullaniciRol : IEntity
    {
        public string KullaniciID { get; set; }
        public int Id { get; set; }
        public int RootId { get; set; }
        public int ParentId { get; set; }
        public string KullaniciAdi { get; set; }
        public string FormAdi { get; set; }
        public string KontrolAdi { get; set; }
        public bool Yetki { get; set; }
    }
}
