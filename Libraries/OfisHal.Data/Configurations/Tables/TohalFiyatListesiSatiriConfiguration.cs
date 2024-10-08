using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalFiyatListesiSatiriConfiguration : EntityTypeConfiguration<TohalFiyatListesiSatiri>
    {
        public TohalFiyatListesiSatiriConfiguration()
        {
            HasKey(e => new { e.FiyatListesiId, e.SatirNo });

            ToTable("TOHAL_FIYAT_LISTESI_SATIRI");

            Property(e => e.FiyatListesiId).HasColumnName("FIYAT_LISTESI_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            HasRequired(d => d.FiyatListesi)
                .WithMany(p => p.TohalFiyatListesiSatiris)
                .HasForeignKey(d => d.FiyatListesiId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Mal)
                .WithMany(p => p.TohalFiyatListesiSatiris)
                .HasForeignKey(d => d.MalId)
                .WillCascadeOnDelete(false);
        }
    }
}
