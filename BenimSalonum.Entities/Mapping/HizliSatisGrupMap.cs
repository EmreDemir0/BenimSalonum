using BenimSalonum.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BenimSalonum.Entities.Mapping
{
    public class HizliSatisGrupMap:EntityTypeConfiguration<HizliSatisGrup>
    {
        public HizliSatisGrupMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.GrupAdi).HasMaxLength(20);

            this.ToTable("HizliSatisGruplari");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.GrupAdi).HasColumnName("GrupAdi");        
        }
    }
}
