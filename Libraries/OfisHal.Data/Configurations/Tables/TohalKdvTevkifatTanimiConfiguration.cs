using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalKdvTevkifatTanimiConfiguration : EntityTypeConfiguration<TohalKdvTevkifatTanimi>
    {
        public TohalKdvTevkifatTanimiConfiguration()
        {
            HasKey(e => e.KdvTevkifatTanimiId);

            ToTable("TOHAL_KDV_TEVKIFAT_TANIMI");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Pay).HasColumnName("PAY");

            Property(e => e.Payda).HasColumnName("PAYDA");

            Property(e => e.UygulamaAltSiniri).HasColumnName("UYGULAMA_ALT_SINIRI");
        }
    }
}
