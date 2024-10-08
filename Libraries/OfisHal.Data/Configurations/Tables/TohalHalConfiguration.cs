using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalHalConfiguration : EntityTypeConfiguration<TohalHal>
    {
        public TohalHalConfiguration()
        {
            HasKey(e => e.HalId);

            ToTable("TOHAL_HAL");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");
        }
    }
}
