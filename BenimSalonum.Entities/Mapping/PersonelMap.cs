using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using BenimSalonum.Entities.Tables;

namespace BenimSalonum.Entities.Mapping
{
    class PersonelMap : EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.PersonelUnvani).HasMaxLength(25);
            this.Property(p => p.PersonelTc).HasMaxLength(11);
            this.Property(p => p.PersonelKodu).HasMaxLength(15);
            this.Property(p => p.PersonelAdi).HasMaxLength(50);
            this.Property(p => p.PersonelGiris).HasColumnType("datetime");
            this.Property(p => p.PersonelCikis).HasColumnType("datetime");
            this.Property(p => p.CepTelefonu).HasMaxLength(11);
            this.Property(p => p.Telefon).HasMaxLength(11);
            this.Property(p => p.Fax).HasMaxLength(11);
            this.Property(p => p.EMail).HasMaxLength(50);
            this.Property(p => p.Web).HasMaxLength(50);
            this.Property(p => p.Il).HasMaxLength(20);
            this.Property(p => p.Ilce).HasMaxLength(20);
            this.Property(p => p.Semt).HasMaxLength(20);
            this.Property(p => p.Adres).HasMaxLength(100);
            this.Property(p => p.PrimOrani).HasPrecision(12, 2);
            this.Property(p => p.AylikMaas).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Personeller");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.PersonelUnvani).HasColumnName("PersonelUnvani");
            this.Property(p => p.PersonelKodu).HasColumnName("PersonelKodu");
            this.Property(p => p.PersonelAdi).HasColumnName("PersonelAdi");
            this.Property(p => p.PersonelGiris).HasColumnName("PersonelGiris");
            this.Property(p => p.PersonelTc).HasColumnName("PersonelTc");
            this.Property(p => p.PersonelCikis).HasColumnName("PersonelCikis");
            this.Property(p => p.Telefon).HasColumnName("Telefon");
            this.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            this.Property(p => p.Fax).HasColumnName("Fax");
            this.Property(p => p.EMail).HasColumnName("EMail");
            this.Property(p => p.Web).HasColumnName("Web");
            this.Property(p => p.Il).HasColumnName("Il");
            this.Property(p => p.Ilce).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.PrimOrani).HasColumnName("PrimOrani");
            this.Property(p => p.AylikMaas).HasColumnName("AylikMaas");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
