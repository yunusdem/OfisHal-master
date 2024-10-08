using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalTeslimatYeriConfiguration : EntityTypeConfiguration<TohalTeslimatYeri>
    {
        public TohalTeslimatYeriConfiguration()
        {
            HasKey(e => e.TeslimatYeriId);

            ToTable("TOHAL_TESLIMAT_YERI");

            Property(e => e.TeslimatYeriId).HasColumnName("TESLIMAT_YERI_ID");

            Property(e => e.Ad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.HksWebSiraNo).HasColumnName("HKS_WEB_SIRA_NO");

            Property(e => e.Tip).HasColumnName("TIP");
        }
    }
}
