using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalGridConfiguration : EntityTypeConfiguration<TohalGrid>
    {
        public TohalGridConfiguration()
        {
            HasKey(e => new { e.GridId, e.Tip, e.KolonSatirNo });

            ToTable("TOHAL_GRID");

            Property(e => e.GridId).HasColumnName("GRID_ID");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.KolonSatirNo).HasColumnName("KOLON_SATIR_NO");

            Property(e => e.SiralamaKolonu).HasColumnName("SIRALAMA_KOLONU");

            Property(e => e.Uzunluk).HasColumnName("UZUNLUK");
        }
    }
}
