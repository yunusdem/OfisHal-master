using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaKayitsizMusteriIlIlceBeldeBilgileriOlanlarConfiguration : EntityTypeConfiguration<VohalAramaKayitsizMusteriIlIlceBeldeBilgileriOlanlar>
    {
        public VohalAramaKayitsizMusteriIlIlceBeldeBilgileriOlanlarConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_KAYITSIZ_MUSTERI_IL_ILCE_BELDE_BILGILERI_OLANLAR");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

            Property(e => e.IlAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL_ADI");

            Property(e => e.IlId).HasColumnName("IL_ID");

            Property(e => e.IlceAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE_ADI");

            Property(e => e.IlceId).HasColumnName("ILCE_ID");

            Property(e => e.KayitsizMusteriId).HasColumnName("KAYITSIZ_MUSTERI_ID");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.YerId).HasColumnName("YER_ID");
        }
    }
}
