using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal00CariRehinEkstreConfiguration : EntityTypeConfiguration<Vohal00CariRehinEkstre>
    {
        public Vohal00CariRehinEkstreConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_00_CARI_REHIN_EKSTRE");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.KesilmeyenDahilRehinTutari).HasColumnName("KESILMEYEN_DAHIL_REHIN_TUTARI");

            Property(e => e.RehinMiktari).HasColumnName("REHIN_MIKTARI");

            Property(e => e.RehinTutari).HasColumnName("REHIN_TUTARI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
