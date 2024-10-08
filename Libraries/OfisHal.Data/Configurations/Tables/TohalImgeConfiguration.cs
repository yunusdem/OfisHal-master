using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalImgeConfiguration : EntityTypeConfiguration<TohalImge>
    {
        public TohalImgeConfiguration()
        {
            HasKey(e => new { e.SahipTuru, e.SahipId });

            ToTable("TOHAL_IMGE");

            Property(e => e.SahipTuru).HasColumnName("SAHIP_TURU");

            Property(e => e.SahipId).HasColumnName("SAHIP_ID");

            Property(e => e.Imge)
                .IsRequired()
                .HasColumnType("image")
                .HasColumnName("IMGE");
        }
    }
}
