using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalRehinAlinanKaplarConfiguration : EntityTypeConfiguration<VohalRehinAlinanKaplar>
    {
        public VohalRehinAlinanKaplarConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_REHIN_ALINAN_KAPLAR");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KalanMiktar).HasColumnName("KALAN_MIKTAR");

            Property(e => e.KalanTutar).HasColumnName("KALAN_TUTAR");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.MustahsilAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KODU")
                .IsFixedLength();

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
