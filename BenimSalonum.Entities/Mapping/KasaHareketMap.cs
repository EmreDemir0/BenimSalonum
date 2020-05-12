using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.Entities.Mapping
{
    public class KasaHareketMap:EntityTypeConfiguration<KasaHareket>
    {
        public KasaHareketMap()
        {
            this.HasKey(p=> p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(15);
            this.Property(p => p.Hareket).HasMaxLength(30);
          this.Property(p => p.Tarih).HasColumnType("datetime");
            this.Property(p => p.Tutar).HasPrecision(12,2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("KasaHareketleri");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.KasaId).HasColumnName("KasaId");
            this.Property(p => p.OdemeTuruId).HasColumnName("OdemeTuruId");
            this.Property(p => p.CariId).HasColumnName("CariId");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Tutar).HasColumnName("Tutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

            this.HasRequired(c => c.Kasa).WithMany(c => c.KasaHareket).HasForeignKey(c => c.KasaId);
            this.HasRequired(c => c.OdemeTuru).WithMany(c => c.KasaHareket).HasForeignKey(c => c.OdemeTuruId);
            this.HasOptional(c => c.Cari).WithMany(c => c.KasaHareket).HasForeignKey(c => c.CariId);

        }
    }
}
