using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalbFirmamizConfiguration : EntityTypeConfiguration<VohalbFirmamiz>
    {
        public VohalbFirmamizConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALB_FIRMAMIZ");

            Property(e => e.Unvanimiz)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVANIMIZ");
        }
    }
}
