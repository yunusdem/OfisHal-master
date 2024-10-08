using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalTabloMaddesiConfiguration : EntityTypeConfiguration<TohalTabloMaddesi>
    {
        public TohalTabloMaddesiConfiguration()
        {
            HasKey(e => e.TabloMaddesiId);

            ToTable("TOHAL_TABLO_MADDESI");

            Property(e => e.TabloMaddesiId).HasColumnName("TABLO_MADDESI_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.Kisaltma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KISALTMA");

            Property(e => e.Tur).HasColumnName("TUR");
        }
    }
}
