using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.Entities.Mapping
{
    public class IndirimMap:EntityTypeConfiguration<Indirim>
    {
        public IndirimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(15);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.Barkod).HasMaxLength(20);
            this.Property(p => p.IndirimOrani).HasPrecision(12,2);
            this.Property(p => p.BitisTarihi).HasColumnType("datetime");
            this.Property(p => p.BaslangicTarihi).HasColumnType("datetime");
            this.Property(p => p.IndirimTuru).HasMaxLength(15);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Indirimler");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.IndirimTuru).HasColumnName("IndirimTuru");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(p => p.BitisTarihi).HasColumnName("BitisTarihi");
            this.Property(p => p.BaslangicTarihi).HasColumnName("BaslangicTarihi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
