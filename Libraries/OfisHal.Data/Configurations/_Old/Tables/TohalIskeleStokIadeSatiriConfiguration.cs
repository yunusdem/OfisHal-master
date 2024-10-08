using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalIskeleStokIadeSatiriConfiguration : EntityTypeConfiguration<TohalIskeleStokIadeSatiri>
    {
        public TohalIskeleStokIadeSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_ISKELE_STOK_IADE_SATIRI");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.StokHareketId).HasColumnName("STOK_HAREKET_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
