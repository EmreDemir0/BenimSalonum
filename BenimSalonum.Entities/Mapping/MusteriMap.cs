using BenimSalonum.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSalonum.Entities.Mapping
{
    public class MusteriMap : EntityTypeConfiguration<Musteri>
    {
        public MusteriMap()
        {
            this.HasKey(p => p.MusteriID);
            this.Property(p => p.MusteriID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MusteriAdi).HasMaxLength(50);
            this.Property(p => p.MusteriCeptelefonu).HasMaxLength(11);
            this.Property(p => p.MusteriEposta).HasMaxLength(50);
            this.Property(p => p.dogumTarihi).HasColumnType("datetime");
            this.Property(p => p.MusteriAciklama).HasMaxLength(50);


            this.ToTable("Musteriler");
            this.Property(p => p.MusteriID).HasColumnName("MusteriID");
            this.Property(p => p.MusteriAdi).HasColumnName("MusteriAdi");
            this.Property(p => p.MusteriCeptelefonu).HasColumnName("MusteriCeptelefonu");
            this.Property(p => p.MusteriCinsiyeti).HasColumnName("MusteriCinsiyeti");
            this.Property(p => p.MusteriEposta).HasColumnName("MusteriEposta");
            this.Property(p => p.dogumTarihi).HasColumnName("dogumTarihi");
            this.Property(p => p.MusteriAciklama).HasColumnName("MusteriAciklama");
            this.Property(p => p.PersonelId).HasColumnName("PersonelId");
        }
    }
}
