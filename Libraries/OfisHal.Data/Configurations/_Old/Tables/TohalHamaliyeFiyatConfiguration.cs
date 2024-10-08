using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalHamaliyeFiyatConfiguration : EntityTypeConfiguration<TohalHamaliyeFiyat>
    {
        public TohalHamaliyeFiyatConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_HAMALIYE_FIYAT");

            Property(e => e.BirimFiyat).HasColumnName("BIRIM_FIYAT");

            Property(e => e.SinirDeger).HasColumnName("SINIR_DEGER");

            Property(e => e.Tur).HasColumnName("TUR");
        }
    }
}
