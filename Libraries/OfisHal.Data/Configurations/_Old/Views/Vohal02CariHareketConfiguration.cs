using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal02CariHareketConfiguration : EntityTypeConfiguration<Vohal02CariHareket>
    {
        public Vohal02CariHareketConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_02_CARI_HAREKET");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.IslemTipi).HasColumnName("ISLEM_TIPI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
