using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalFiyatListesiConfiguration : EntityTypeConfiguration<TohalFiyatListesi>
    {
        public TohalFiyatListesiConfiguration()
        {
            HasKey(e => e.FiyatListesiId);

            ToTable("TOHAL_FIYAT_LISTESI");

            Property(e => e.FiyatListesiId).HasColumnName("FIYAT_LISTESI_ID");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");
        }
    }
}
