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
    public class KullaniciLogMap : EntityTypeConfiguration<KullaniciLog>
    {
        public KullaniciLogMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.YapilanIslem).HasMaxLength(50);
            this.Property(p => p.KullaniciAdi).HasMaxLength(15);


            this.ToTable("KullaniciLoglari");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(p => p.YapilanIslem).HasColumnName("YapilanIslem");
            this.Property(p => p.YapilanIslemTarihi).HasColumnName("YapilanIslemTarihi");
            this.Property(p => p.SonGirisTarihi).HasColumnName("SonGirisTarihi");
        }
    }
}
