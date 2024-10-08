using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalCariSifatConfiguration : EntityTypeConfiguration<TohalCariSifat>
    {
        public TohalCariSifatConfiguration()
        {
            HasKey(e => e.Id);

            ToTable("TOHAL_CARI_SIFAT");

            HasIndex(e => new { e.CariKartId, e.Sifat })
                .IsUnique();

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Sifat).HasColumnName("SIFAT");

            HasOptional(d => d.CariKart)
                .WithMany(p=> p.TohalCariSifats)
                .HasForeignKey(d => d.CariKartId);

        }
    }
}
