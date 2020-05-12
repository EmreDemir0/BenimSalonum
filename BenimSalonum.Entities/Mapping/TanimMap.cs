using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.Entities.Mapping
{
    public class TanimMap:EntityTypeConfiguration<Tanim>
    {
        public TanimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Turu).HasMaxLength(15);
            this.Property(p => p.Tanimi).HasMaxLength(30);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Tanimlar");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Turu).HasColumnName("Turu");
            this.Property(p => p.Tanimi).HasColumnName("Tanimi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
