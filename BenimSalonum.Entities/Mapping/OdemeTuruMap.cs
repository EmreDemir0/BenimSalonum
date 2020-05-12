using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.Entities.Mapping
{
    public class OdemeTuruMap:EntityTypeConfiguration<OdemeTuru>
    {
        public OdemeTuruMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OdemeTuruKodu).HasMaxLength(15);
            this.Property(p => p.OdemeTuruAdi).HasMaxLength(50);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("OdemeTurleri");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            this.Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
