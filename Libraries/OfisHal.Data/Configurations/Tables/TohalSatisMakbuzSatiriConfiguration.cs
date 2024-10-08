using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalSatisMakbuzSatiriConfiguration : EntityTypeConfiguration<TohalSatisMakbuzSatiri>
    {
        public TohalSatisMakbuzSatiriConfiguration()
        {
            HasKey(e => new { e.FaturaSatiriId, e.SatirNo });

            ToTable("TOHAL_SATIS_MAKBUZ_SATIRI");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            HasRequired(d => d.FaturaSatiri)
                .WithMany(p => p.TohalSatisMakbuzSatiris)
                .HasForeignKey(d => d.FaturaSatiriId)
                .WillCascadeOnDelete(false);
        }
    }
}
