using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogStokHareketiConfiguration : EntityTypeConfiguration<TohalLogStokHareketi>
    {
        public TohalLogStokHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_STOK_HAREKETI");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("O_GIRIS_TARIHI");

            Property(e => e.OKapId).HasColumnName("O_KAP_ID");

            Property(e => e.OKapSayisi).HasColumnName("O_KAP_SAYISI");

            Property(e => e.OMalId).HasColumnName("O_MAL_ID");

            Property(e => e.OMiktar).HasColumnName("O_MIKTAR");

            Property(e => e.OSatilanKap).HasColumnName("O_SATILAN_KAP");

            Property(e => e.OSatilanMiktar).HasColumnName("O_SATILAN_MIKTAR");

            Property(e => e.OStokKunyeId).HasColumnName("O_STOK_KUNYE_ID");

            Property(e => e.OStokTipi).HasColumnName("O_STOK_TIPI");

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("S_GIRIS_TARIHI");

            Property(e => e.SKapId).HasColumnName("S_KAP_ID");

            Property(e => e.SKapSayisi).HasColumnName("S_KAP_SAYISI");

            Property(e => e.SMalId).HasColumnName("S_MAL_ID");

            Property(e => e.SMiktar).HasColumnName("S_MIKTAR");

            Property(e => e.SSatilanKap).HasColumnName("S_SATILAN_KAP");

            Property(e => e.SSatilanMiktar).HasColumnName("S_SATILAN_MIKTAR");

            Property(e => e.SStokKunyeId).HasColumnName("S_STOK_KUNYE_ID");

            Property(e => e.SStokTipi).HasColumnName("S_STOK_TIPI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
