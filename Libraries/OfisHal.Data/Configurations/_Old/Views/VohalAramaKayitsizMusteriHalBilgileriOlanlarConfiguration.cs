using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaKayitsizMusteriHalBilgileriOlanlarConfiguration : EntityTypeConfiguration<VohalAramaKayitsizMusteriHalBilgileriOlanlar>
    {
        public VohalAramaKayitsizMusteriHalBilgileriOlanlarConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_KAYITSIZ_MUSTERI_HAL_BILGILERI_OLANLAR");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.EskiSehir)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ESKI_SEHIR");

            Property(e => e.HalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HAL_ADI");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.KayitsizMusteriId).HasColumnName("KAYITSIZ_MUSTERI_ID");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
