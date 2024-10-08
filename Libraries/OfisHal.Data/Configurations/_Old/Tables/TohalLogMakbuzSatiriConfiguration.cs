using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogMakbuzSatiriConfiguration : EntityTypeConfiguration<TohalLogMakbuzSatiri>
    {
        public TohalLogMakbuzSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_MAKBUZ_SATIRI");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OKapSayisi).HasColumnName("O_KAP_SAYISI");

            Property(e => e.OKdvOrani).HasColumnName("O_KDV_ORANI");

            Property(e => e.OMalId).HasColumnName("O_MAL_ID");

            Property(e => e.OMiktar).HasColumnName("O_MIKTAR");

            Property(e => e.OSatisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("O_SATIS_TARIHI");

            Property(e => e.OTutar).HasColumnName("O_TUTAR");

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SKapSayisi).HasColumnName("S_KAP_SAYISI");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SMalId).HasColumnName("S_MAL_ID");

            Property(e => e.SMiktar).HasColumnName("S_MIKTAR");

            Property(e => e.SSatisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("S_SATIS_TARIHI");

            Property(e => e.STutar).HasColumnName("S_TUTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
