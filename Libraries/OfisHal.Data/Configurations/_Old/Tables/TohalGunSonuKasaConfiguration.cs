using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalGunSonuKasaConfiguration : EntityTypeConfiguration<TohalGunSonuKasa>
    {
        public TohalGunSonuKasaConfiguration()
        {
            HasKey(e => e.Tarih);

            ToTable("TOHAL_GUN_SONU_KASA");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Alacak).HasColumnName("ALACAK");

            Property(e => e.Borc).HasColumnName("BORC");
        }
    }
}
