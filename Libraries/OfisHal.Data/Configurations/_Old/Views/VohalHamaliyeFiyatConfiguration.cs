using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalHamaliyeFiyatConfiguration : EntityTypeConfiguration<VohalHamaliyeFiyat>
    {
        public VohalHamaliyeFiyatConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_HAMALIYE_FIYAT");

            Property(e => e.BirimFiyat).HasColumnName("BIRIM_FIYAT");

            Property(e => e.SinirDeger).HasColumnName("SINIR_DEGER");

            Property(e => e.Tur).HasColumnName("TUR");
        }
    }
}
