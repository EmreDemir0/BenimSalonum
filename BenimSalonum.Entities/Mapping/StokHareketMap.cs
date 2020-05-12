using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.Entities.Mapping
{
    public class StokHareketMap:EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(p=> p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(15);
            this.Property(p => p.Hareket).HasMaxLength(30);
            this.Property(p => p.Miktar).HasPrecision(12,3);
            this.Property(p => p.BirimFiyati).HasPrecision(12, 2);
            this.Property(p => p.IndirimOrani).HasPrecision(12, 2);
            this.Property(p => p.SeriNo).HasMaxLength(20);
            this.Property(p => p.Tarih).HasColumnType("datetime");
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("StokHareketleri");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.StokId).HasColumnName("StokId");
            this.Property(p => p.Miktar).HasColumnName("Miktar");
            this.Property(p => p.Kdv).HasColumnName("Kdv");
            this.Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(p => p.DepoId).HasColumnName("DepoId");
            this.Property(p => p.SeriNo).HasColumnName("SeriNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

            this.HasRequired(c => c.Stok).WithMany(c => c.StokHareket).HasForeignKey(c => c.StokId);
            this.HasRequired(c => c.Depo).WithMany(c => c.StokHareket).HasForeignKey(c => c.DepoId);
        }
    }
}
