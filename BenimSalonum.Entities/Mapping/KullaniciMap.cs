using BenimSalonum.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BenimSalonum.Entities.Mapping
{
    public class KullaniciMap : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            this.Property(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.KullaniciAdi).HasMaxLength(15);
            this.Property(p => p.Adi).HasMaxLength(20);
            this.Property(p => p.Soyadi).HasMaxLength(20);
            this.Property(p => p.HatirlatmaSorusu).HasMaxLength(50);
            this.Property(p => p.HatirlatmaCevap).HasMaxLength(20);
            this.Property(p => p.Gorevi).HasMaxLength(20);
            this.Property(p => p.Parola).HasMaxLength(32);//parolayı şifreli olarak tutmak için

            this.ToTable("Kullanicilar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.Aktif).HasColumnName("Aktif");
            this.Property(p => p.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(p => p.Adi).HasColumnName("Adi");
            this.Property(p => p.Soyadi).HasColumnName("Soyadi");
            this.Property(p => p.HatirlatmaSorusu).HasColumnName("HatirlatmaSorusu");
            this.Property(p => p.HatirlatmaCevap).HasColumnName("HatirlatmaCevap");
            this.Property(p => p.Gorevi).HasColumnName("Gorevi");
            this.Property(p => p.Parola).HasColumnName("Parola");
            this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.SonGirisTarihi).HasColumnName("SonGirisTarihi");
        }
    }
}
