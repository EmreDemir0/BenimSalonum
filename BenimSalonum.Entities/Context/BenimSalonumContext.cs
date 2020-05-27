using BenimSalonum.Entities.Mapping;
using BenimSalonum.Entities.Migrations;
using BenimSalonum.Entities.Tables;
using BenimSalonum.Entities.Tables.OtherTables;
using BenimSalonum.Entities.Tools;
using System.Data.Entity;

namespace BenimSalonum.Entities.Context
{
    public class BenimSalonumContext : DbContext
    {
        public BenimSalonumContext() : base("BenimSalonumContext")
        {//SettingsTool.AyarOku(SettingsTool.Ayarlar.DataBaseAyarlari_BaglantiCumlesi) ?? "BenimSalonumContext"
            Database.SetInitializer<BenimSalonumContext>(new MigrateDatabaseToLatestVersion<BenimSalonumContext, Configuration>());
        }
        public BenimSalonumContext(string connString,bool olustur =false) : base(connString)
        {
            if (olustur)
            {
                Database.SetInitializer<BenimSalonumContext>(new MigrateDatabaseToLatestVersion<BenimSalonumContext, Configuration>());
            }
        }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Indirim> Indirimler { get; set; }
        public DbSet<HizliSatis> HizliSatislar { get; set; }
        public DbSet<HizliSatisGrup> HizliSatisGruplari { get; set; }
        public DbSet<PersonelHareket> PersonelHareketleri { get; set; }
        public DbSet<EFAppointment> EFAppointments { get; set; }
        public DbSet<EFResource> EFResources { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciLog> KullaniciLoglari { get; set; }
        public DbSet<KullaniciRol> KullaniciRolleri { get; set; }
        public DbSet<Kod> Kodlar { get; set; }

        public DbSet<Adisyon> Adisyonlar { get; set; }
        public DbSet<CalismaSaati> CalismaSaatleri { get; set; }
        public DbSet<KullaniciAyarlari> KullaniciAyarlari { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<BenimSalonumContext>(null);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new FisMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new KasaHareketMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new PersonelHareketMap());
            modelBuilder.Configurations.Add(new IndirimMap());
            modelBuilder.Configurations.Add(new HizliSatisMap());
            modelBuilder.Configurations.Add(new HizliSatisGrupMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciLogMap());
            modelBuilder.Configurations.Add(new KullaniciRolMap());
            modelBuilder.Configurations.Add(new KodMap());

            modelBuilder.Configurations.Add(new AdisyonMap());
            modelBuilder.Configurations.Add(new CalismaSaatiMap());
            modelBuilder.Configurations.Add(new MusteriMap());
            modelBuilder.Configurations.Add(new KullaniciAyarlariMap());
        }
    }
}
