using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogCariKartConfiguration : EntityTypeConfiguration<TohalLogCariKart>
    {
        public TohalLogCariKartConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_CARI_KART");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.ODevir).HasColumnName("O_DEVIR");

            Property(e => e.OOran).HasColumnName("O_ORAN");

            Property(e => e.OOrtaklikOrani).HasColumnName("O_ORTAKLIK_ORANI");

            Property(e => e.SDevir).HasColumnName("S_DEVIR");

            Property(e => e.SOran).HasColumnName("S_ORAN");

            Property(e => e.SOrtaklikOrani).HasColumnName("S_ORTAKLIK_ORANI");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
