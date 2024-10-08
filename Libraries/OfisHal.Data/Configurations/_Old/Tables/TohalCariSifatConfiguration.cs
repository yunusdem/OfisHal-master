using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalCariSifatConfiguration : EntityTypeConfiguration<TohalCariSifat>
    {
        public TohalCariSifatConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_CARI_SIFAT");

            HasIndex(e => new { e.CariKartId, e.Sifat })
                .IsUnique();

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Sifat).HasColumnName("SIFAT");

            HasOptional(d => d.CariKart)
                .WithMany()
                .HasForeignKey(d => d.CariKartId);
        }
    }
}
