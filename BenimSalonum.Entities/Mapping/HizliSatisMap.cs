using BenimSalonum.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BenimSalonum.Entities.Mapping
{
    public class HizliSatisMap:EntityTypeConfiguration<HizliSatis>
    {
        public HizliSatisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Barkod).HasMaxLength(20);
            this.Property(p => p.UrunAdi).HasMaxLength(50);
            this.Property(p => p.GrupId);

            this.ToTable("HizliSatislar");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.UrunAdi).HasColumnName("UrunAdi");
            this.Property(p=>p.GrupId).HasColumnName("GrupId");

        }
    }
}
