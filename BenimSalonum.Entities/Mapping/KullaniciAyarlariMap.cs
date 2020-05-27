using BenimSalonum.Entities.Tables.OtherTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSalonum.Entities.Mapping
{
    class KullaniciAyarlariMap : EntityTypeConfiguration<KullaniciAyarlari>
    {
        public KullaniciAyarlariMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.KullaniciID).HasMaxLength(15);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //
            //
            this.Property(p => p.smsAyarlari_KullaniciAdi).HasMaxLength(50);
            this.Property(p => p.smsAyarlari_KullaniciNo).HasMaxLength(50);
            this.Property(p => p.smsAyarlari_Parola).HasMaxLength(50);
            this.Property(p => p.smsAyarlari_Orjinator).HasMaxLength(50);
            ///
            this.Property(p => p.SatisAyarlari_VarsayilanDepo).HasMaxLength(15);
            this.Property(p => p.SatisAyarlari_VarsayilanKasa).HasMaxLength(15);
            this.Property(p => p.SatisAyarlari_FaturaYazdirmaAyari).HasMaxLength(50);
            this.Property(p => p.SatisAyarlari_BilgiFisiYazdırmaAyari).HasMaxLength(50);
            this.Property(p => p.SatisAyarlari_FaturaYazici).HasMaxLength(50);
            this.Property(p => p.SatisAyarlari_BilgiFisiYazici).HasMaxLength(50);
            this.Property(p => p.SatisAyarlari_FisKodu).HasMaxLength(50);
            ///
            this.Property(p => p.YedeklemeAyarlari_YedeklemeKonumu).HasMaxLength(100);
            this.Property(p => p.DataBaseAyarlari_BaglantiCumlesi).HasMaxLength(100);
            ////
            ///    
            this.Property(p => p.FirmaAyarlari_FirmaAdi).HasMaxLength(50);
            this.Property(p => p.FirmaAyarlari_FaturaUnvani).HasMaxLength(50);
            this.Property(p => p.FirmaAyarlari_VergiDairesi).HasMaxLength(50);
            this.Property(p => p.FirmaAyarlari_VergiNo).HasMaxLength(50);
            this.Property(p => p.FirmaAyarlari_Adres).HasMaxLength(200);
            this.Property(p => p.FirmaAyarlari_Eposta).HasMaxLength(50);

            this.ToTable("KullaniciAyarlari");

            this.Property(p => p.KullaniciID).HasColumnName("KullaniciID");
            this.Property(p => p.Id).HasColumnName("Id");

            this.Property(p => p.GenelAyarlar_GuncellemeKontrol).HasColumnName("GenelAyarlar_GuncellemeKontrol");

            this.Property(p => p.smsAyarlari_KullaniciAdi).HasColumnName("smsAyarlari_KullaniciAdi");
            this.Property(p => p.smsAyarlari_KullaniciNo).HasColumnName("smsAyarlari_KullaniciNo");
            this.Property(p => p.smsAyarlari_Parola).HasColumnName("smsAyarlari_Parola");
            this.Property(p => p.smsAyarlari_Orjinator).HasColumnName("smsAyarlari_Orjinator");

            this.Property(p => p.SatisAyarlari_VarsayilanDepo).HasColumnName("SatisAyarlari_VarsayilanDepo");
            this.Property(p => p.SatisAyarlari_VarsayilanKasa).HasColumnName("SatisAyarlari_VarsayilanKasa");
            this.Property(p => p.SatisAyarlari_FaturaYazdirmaAyari).HasColumnName("SatisAyarlari_FaturaYazdirmaAyari");
            this.Property(p => p.SatisAyarlari_BilgiFisiYazdırmaAyari).HasColumnName("SatisAyarlari_BilgiFisiYazdırmaAyari");
            this.Property(p => p.SatisAyarlari_FaturaYazici).HasColumnName("SatisAyarlari_FaturaYazici");
            this.Property(p => p.SatisAyarlari_BilgiFisiYazici).HasColumnName("SatisAyarlari_BilgiFisiYazici");
            this.Property(p => p.SatisAyarlari_FisKodu).HasColumnName("SatisAyarlari_FisKodu");

            this.Property(p => p.YedeklemeAyarlari_YedeklemeKonumu).HasColumnName("YedeklemeAyarlari_YedeklemeKonumu");
            this.Property(p => p.DataBaseAyarlari_BaglantiCumlesi).HasColumnName("DataBaseAyarlari_BaglantiCumlesi");

            this.Property(p => p.FirmaAyarlari_FirmaAdi).HasColumnName("FirmaAyarlari_FirmaAdi");
            this.Property(p => p.FirmaAyarlari_FaturaUnvani).HasColumnName("FirmaAyarlari_FaturaUnvani");
            this.Property(p => p.FirmaAyarlari_VergiDairesi).HasColumnName("FirmaAyarlari_VergiDairesi");
            this.Property(p => p.FirmaAyarlari_VergiNo).HasColumnName("FirmaAyarlari_VergiNo");
            this.Property(p => p.FirmaAyarlari_Adres).HasColumnName("FirmaAyarlari_Adres");
            this.Property(p => p.FirmaAyarlari_Eposta).HasColumnName("FirmaAyarlari_Eposta");
        }
    }
}
