using OfisHal.Core.Domain;
using OfisHal.Web.Models;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace OfisHal.Data.Context
{
    public partial class Db : DbContext
    {
        public Db() : base("name=Db")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
            Database.SetInitializer<Db>(null);
            Database.Initialize(false);
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<TohalBagkurDosyasi> TohalBagkurDosyasis { get; set; }
        public virtual DbSet<TohalBankaHareketi> TohalBankaHareketis { get; set; }
        public virtual DbSet<TohalBankaHesabi> TohalBankaHesabis { get; set; }
        public virtual DbSet<TohalCariHareket> TohalCariHarekets { get; set; }
        public virtual DbSet<TohalCariSifat> TohalCariSifats { get; set; }
        public virtual DbSet<TohalCariKart> TohalCariKarts { get; set; }
        public virtual DbSet<TohalDigerAd> TohalDigerAds { get; set; }
        public virtual DbSet<TohalFatura> TohalFaturas { get; set; }
        public virtual DbSet<TohalFaturaSatiri> TohalFaturaSatiris { get; set; }
        public virtual DbSet<TohalFi> TohalFis { get; set; }
        public virtual DbSet<TohalFiyatListesi> TohalFiyatListesis { get; set; }
        public virtual DbSet<TohalGibKullanici> TohalGibKullanicis { get; set; }
        public virtual DbSet<TohalHal> TohalHals { get; set; }
        public virtual DbSet<TohalHesap> TohalHesaps { get; set; }
        public virtual DbSet<TohalHksMal> TohalHksMals { get; set; }
        public virtual DbSet<TohalIskeleFaturaSatiri> TohalIskeleFaturaSatiris { get; set; }
        public virtual DbSet<TohalKap> TohalKaps { get; set; }
        public virtual DbSet<TohalKapHareket> TohalKapHarekets { get; set; }
        public virtual DbSet<TohalKdvTevkifatTanimi> TohalKdvTevkifatTanimis { get; set; }
        public virtual DbSet<TohalKullanici> TohalKullanicis { get; set; }
        public virtual DbSet<TohalKunye> TohalKunyes { get; set; }
        public virtual DbSet<TohalMagaza> TohalMagazas { get; set; }
        public virtual DbSet<TohalMal> TohalMals { get; set; }
        public virtual DbSet<TohalMarka> TohalMarkas { get; set; }
        public virtual DbSet<TohalMakbuz> TohalMakbuzs { get; set; }
        public virtual DbSet<TohalMuhHesap> TohalMuhHesaps { get; set; }
        public virtual DbSet<TohalPosCihazi> TohalPosCihazis { get; set; }
        public virtual DbSet<TohalRehinFisi> TohalRehinFisis { get; set; }
        public virtual DbSet<TohalSipari> TohalSiparis { get; set; }
        public virtual DbSet<TohalTabloMaddesi> TohalTabloMaddesis { get; set; }
        public virtual DbSet<TohalTanim> TohalTanims { get; set; }
        public virtual DbSet<TohalTeslimatYeri> TohalTeslimatYeris { get; set; }
        public virtual DbSet<TohalYazici> TohalYazicis { get; set; }
        public virtual DbSet<TohalYer> TohalYers { get; set; }
        public virtual DbSet<TohalStokHareketi> TohalStokHareketis { get; set; }
        public virtual DbSet<TohalSiparisSatiri> TohalSiparisSatiris { get; set; }
        public virtual DbSet<TohalSatisMakbuzSatiri> TohalSatisMakbuzSatiris { get; set; }
        public virtual DbSet<TohalRaporParamDegeri> TohalRaporParamDegeris { get; set; }
        public virtual DbSet<TohalOdemeBordrosu> TohalOdemeBordrosus { get; set; }
        public virtual DbSet<TohalOdemeAraci> TohalOdemeAracis { get; set; }
        public virtual DbSet<TohalNavlunFaturasi> TohalNavlunFaturasis { get; set; }
        public virtual DbSet<TohalMuhFisSatiri> TohalMuhFisSatiris { get; set; }
        public virtual DbSet<TohalMalHksBagi> TohalMalHksBagis { get; set; }
        public virtual DbSet<TohalMakbuzSatiri> TohalMakbuzSatiris { get; set; }
        public virtual DbSet<TohalKullanilanKunye> TohalKullanilanKunyes { get; set; }
        public virtual DbSet<TohalKullaniciYetkisi> TohalKullaniciYetkisis { get; set; }
        public virtual DbSet<TohalKayitsizMusteri> TohalKayitsizMusteris { get; set; }
        public virtual DbSet<TohalHesapHareketi> TohalHesapHareketis { get; set; }
        public virtual DbSet<TohalFisSatiri> TohalFisSatiris { get; set; }
        public virtual DbSet<TohalFiyatListesiSatiri> TohalFiyatListesiSatiris { get; set; }
        public virtual DbSet<TohalObSatiri> TohalObSatiris { get; set; }
        public virtual DbSet<TohalStokIade> TohalStokIades { get; set; }
        public virtual DbSet<TohalSatisKunyeSatiri> TohalSatisKunyeSatiris { get; set; }
        public virtual DbSet<TohalMuhFi> TohalMuhFis { get; set; }

        public virtual DbSet<ToambSevkIrsaliyesi> ToambSevkIrsaliyesis { get; set; }
        public virtual DbSet<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiris { get; set; }
        public virtual DbSet<ToambNavlunFaturaSatiri> ToambNavlunFaturaSatiris { get; set; }
        public virtual DbSet<ToambNavlunFaturasi> ToambNavlunFaturasis { get; set; }
        public virtual DbSet<ToambAmbarFiyati> ToambAmbarFiyatis { get; set; }
        public virtual DbSet<ToambNavlunDizayni> ToambNavlunDizaynis { get; set; }

        public virtual DbSet<TohalEvrakKdv> TohalEvrakKdvs { get; set; }

        public virtual DbSet<TohalIskeleStokHareketi> TohalIskeleStokHareketis { get; set; }
        public virtual DbSet<TohalIskeleRehinFisi> TohalIskeleRehinFisis { get; set; }
        public virtual DbSet<TohalIskeleMakbuzSatiri> TohalIskeleMakbuzSatiris { get; set; }

        public virtual DbSet<TohksIskeleKunyeListesi> TohksIskeleKunyeListesis { get; set; }
        public virtual DbSet<TohksKayitliKunyeListesi> TohksKayitliKunyeListesis { get; set; }
        public virtual DbSet<TohalIskeleEvrakMasrafi> TohalIskeleEvrakMasrafis { get; set; }

        public virtual DbSet<TohalEvrakMasrafi> TohalEvrakMasrafis { get; set; }
        public virtual DbSet<CevapTablosu> CevapTablosus { get; set; }
        public virtual DbSet<TohalDokumDefteri> TohalDokumDefteris { get; set; }

        public virtual DbSet<TohalNumerator> TohalNumerators { get; set; }
        public virtual DbSet<TohalImge> TohalImges { get; set; }
        public virtual DbSet<TohalIskeleObSatiri> TohalIskeleObSatiris { get; set; }
        /*
        public virtual DbSet<CevapTablosuBagkur> CevapTablosuBagkurs { get; set; }
        public virtual DbSet<IstekTablosu> IstekTablosus { get; set; }
        public virtual DbSet<IstekTablosuBagkur> IstekTablosuBagkurs { get; set; }
        public virtual DbSet<ToambAmbarKomisyonu> ToambAmbarKomisyonus { get; set; }
        public virtual DbSet<ToambIskeleAmbarKomisyonu> ToambIskeleAmbarKomisyonus { get; set; }
        public virtual DbSet<ToambIskeleNavlunFaturasiSatiri> ToambIskeleNavlunFaturasiSatiris { get; set; }
        public virtual DbSet<ToambIskeleSevkIrsaliyesiSatiri> ToambIskeleSevkIrsaliyesiSatiris { get; set; }
        public virtual DbSet<ToambLogNavlunFaturasi> ToambLogNavlunFaturasis { get; set; }
        public virtual DbSet<ToambLogSevkIrsaliyesi> ToambLogSevkIrsaliyesis { get; set; }
        public virtual DbSet<TohalBildirim> TohalBildirims { get; set; }
 
        public virtual DbSet<TohalDevirAyarlari> TohalDevirAyarlaris { get; set; }

        public virtual DbSet<TohalEFaturaLog> TohalEFaturaLogs { get; set; }
        public virtual DbSet<TohalEkranRaporu> TohalEkranRaporus { get; set; }


        public virtual DbSet<TohalGrid> TohalGrids { get; set; }
        public virtual DbSet<TohalGunSonuKasa> TohalGunSonuKasas { get; set; }
        public virtual DbSet<TohalHamaliyeFiyat> TohalHamaliyeFiyats { get; set; }
        public virtual DbSet<TohalHammaliyeTanimi> TohalHammaliyeTanimis { get; set; }

       
        public virtual DbSet<TohalIskeleFisSatiri> TohalIskeleFisSatiris { get; set; }
        public virtual DbSet<TohalIskeleGibKullanici> TohalIskeleGibKullanicis { get; set; }
        public virtual DbSet<TohalIskeleKullanilanKunye> TohalIskeleKullanilanKunyes { get; set; }

        public virtual DbSet<TohalIskeleMuhFisSatiri> TohalIskeleMuhFisSatiris { get; set; }
        public virtual DbSet<TohalIskeleNavlunFaturasi> TohalIskeleNavlunFaturasis { get; set; }



        public virtual DbSet<TohalIskeleStokIadeSatiri> TohalIskeleStokIadeSatiris { get; set; }
        public virtual DbSet<TohalKasaNotu> TohalKasaNotus { get; set; }
        public virtual DbSet<TohalKunyeDetay> TohalKunyeDetays { get; set; }
        public virtual DbSet<TohalKunyeListesi> TohalKunyeListesis { get; set; }
        public virtual DbSet<TohalLogBankaHareketi> TohalLogBankaHareketis { get; set; }
        public virtual DbSet<TohalLogCariHareket> TohalLogCariHarekets { get; set; }
        public virtual DbSet<TohalLogCariKart> TohalLogCariKarts { get; set; }
        public virtual DbSet<TohalLogCevapTablosu> TohalLogCevapTablosus { get; set; }
        public virtual DbSet<TohalLogDokumDefteri> TohalLogDokumDefteris { get; set; }
        public virtual DbSet<TohalLogEvrakMasrafi> TohalLogEvrakMasrafis { get; set; }
        public virtual DbSet<TohalLogFatura> TohalLogFaturas { get; set; }
        public virtual DbSet<TohalLogFaturaSatiri> TohalLogFaturaSatiris { get; set; }
        public virtual DbSet<TohalLogHesapHareketi> TohalLogHesapHareketis { get; set; }
        public virtual DbSet<TohalLogIstekTablosu> TohalLogIstekTablosus { get; set; }
        public virtual DbSet<TohalLogKapHareket> TohalLogKapHarekets { get; set; }
        public virtual DbSet<TohalLogMakbuz> TohalLogMakbuzs { get; set; }
        public virtual DbSet<TohalLogMakbuzSatiri> TohalLogMakbuzSatiris { get; set; }
        public virtual DbSet<TohalLogObSatiri> TohalLogObSatiris { get; set; }
        public virtual DbSet<TohalLogOdemeBordrosu> TohalLogOdemeBordrosus { get; set; }
        public virtual DbSet<TohalLogRehinFisi> TohalLogRehinFisis { get; set; }
        public virtual DbSet<TohalLogStokHareketi> TohalLogStokHareketis { get; set; }
        public virtual DbSet<TohalMadde> TohalMaddes { get; set; }
        public virtual DbSet<TohalMuhasebeTanimi> TohalMuhasebeTanimis { get; set; }
        public virtual DbSet<TohalVeriAlmaSablonSatiri> TohalVeriAlmaSablonSatiris { get; set; }
*/

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region SaveChanges Overrides
        public override Task<int> SaveChangesAsync() => SaveChangesAsync(CancellationToken.None);

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            try
            {
                return base.SaveChangesAsync(cancellationToken);
            }
            catch (DbEntityValidationException e)
            {
                throw new FormattedDbEntityValidationException(e);
            }
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                throw new FormattedDbEntityValidationException(e);
            }
        }
        #endregion
    }
}
