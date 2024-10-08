using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalHaliOlmayanKayitsizMusterilerConfiguration : EntityTypeConfiguration<VohalHaliOlmayanKayitsizMusteriler>
    {
        public VohalHaliOlmayanKayitsizMusterilerConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_HALI_OLMAYAN_KAYITSIZ_MUSTERILER");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EskiSehir)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ESKI_SEHIR");

            Property(e => e.HalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HAL_ADI");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KOD");
        }
    }
}
