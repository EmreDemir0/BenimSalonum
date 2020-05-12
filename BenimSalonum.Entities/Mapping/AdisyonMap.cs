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
    public class AdisyonMap : EntityTypeConfiguration<Adisyon>
    {
        public AdisyonMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Durum).HasMaxLength(15);
            this.Property(p => p.Hizmet).HasMaxLength(50);
            this.Property(p => p.Urun).HasMaxLength(50);
            this.Property(p => p.TarihSaat).HasColumnType("datetime");
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.KalanTutar).HasPrecision(12, 2);
            this.Property(p => p.Odeme).HasPrecision(12, 2);
            this.Property(p => p.ParaPuan).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Adisyonlar");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durum).HasColumnName("Durum");
            this.Property(p => p.Hizmet).HasColumnName("Hizmet");
            this.Property(p => p.Urun).HasColumnName("Urun");
            this.Property(p => p.TarihSaat).HasColumnName("TarihSaat");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.Odeme).HasColumnName("Odeme");
            this.Property(p => p.KalanTutar).HasColumnName("KalanTutar");
            this.Property(p => p.HizmetAldiMi).HasColumnName("HizmetAldiMi");
            this.Property(p => p.ParaPuan).HasColumnName("ParaPuan");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
