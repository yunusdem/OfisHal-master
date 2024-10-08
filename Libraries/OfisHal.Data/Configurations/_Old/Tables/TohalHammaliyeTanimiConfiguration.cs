using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalHammaliyeTanimiConfiguration : EntityTypeConfiguration<TohalHammaliyeTanimi>
    {
        public TohalHammaliyeTanimiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_HAMMALIYE_TANIMI");

            Property(e => e.AltSinir).HasColumnName("ALT_SINIR");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.UstSinir).HasColumnName("UST_SINIR");
        }
    }
}
