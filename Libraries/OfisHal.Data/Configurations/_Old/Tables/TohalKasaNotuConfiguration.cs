using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalKasaNotuConfiguration : EntityTypeConfiguration<TohalKasaNotu>
    {
        public TohalKasaNotuConfiguration()
        {
            HasKey(e => e.KasaNotuId);

            ToTable("TOHAL_KASA_NOTU");

            HasIndex(e => e.Tarih)
                .IsUnique();

            Property(e => e.KasaNotuId).HasColumnName("KASA_NOTU_ID");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
