using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalStokIadeConfiguration : EntityTypeConfiguration<TohalStokIade>
    {
        public TohalStokIadeConfiguration()
        {
            HasKey(e => e.StokIadeId);

            ToTable("TOHAL_STOK_IADE");

            Property(e => e.StokIadeId).HasColumnName("STOK_IADE_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            HasRequired(d => d.StokHareketi)
                .WithMany(p => p.TohalStokIades)
                .HasForeignKey(d => d.StokHareketiId)
                .WillCascadeOnDelete(false);
        }
    }
}
