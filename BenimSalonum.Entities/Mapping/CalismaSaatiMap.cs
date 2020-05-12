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
    public class CalismaSaatiMap : EntityTypeConfiguration<CalismaSaati>
    {
        public CalismaSaatiMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.iseBaslamaSaati).HasColumnType("datetime");
            this.Property(p => p.isBitisSaati).HasColumnType("datetime");

            this.ToTable("CalismaSaatleri");
            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.iseBaslamaSaati).HasColumnName("iseBaslamaSaati");
            this.Property(p => p.isBitisSaati).HasColumnName("isBitisSaati");
            this.Property(p => p.RandevuAraligi).HasColumnName("RandevuAraligi");
        }
    }
}
