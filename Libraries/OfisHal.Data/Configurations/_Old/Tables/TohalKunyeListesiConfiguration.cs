using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalKunyeListesiConfiguration : EntityTypeConfiguration<TohalKunyeListesi>
    {
        public TohalKunyeListesiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_KUNYE_LISTESI");

            Property(e => e.SatirId).HasColumnName("SATIR_ID");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
