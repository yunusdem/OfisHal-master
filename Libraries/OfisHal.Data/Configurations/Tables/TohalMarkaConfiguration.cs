using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalMarkaConfiguration : EntityTypeConfiguration<TohalMarka>
    {
        public TohalMarkaConfiguration()
        {
            HasKey(e => e.MarkaId);

            ToTable("TOHAL_MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Kapandi).HasColumnName("KAPANDI");
        }
    }
}
