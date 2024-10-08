using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalBuBeldeyeBagliOlmayanMustahsillerConfiguration : EntityTypeConfiguration<VohalBuBeldeyeBagliOlmayanMustahsiller>
    {
        public VohalBuBeldeyeBagliOlmayanMustahsillerConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_BU_BELDEYE_BAGLI_OLMAYAN_MUSTAHSILLER");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EskiSehir)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ESKI_SEHIR");

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

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.YerId).HasColumnName("YER_ID");
        }
    }
}
