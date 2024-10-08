using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalMuhFisSatiriConfiguration : EntityTypeConfiguration<TohalMuhFisSatiri>
    {
        public TohalMuhFisSatiriConfiguration()
        {
            HasKey(e => new { e.MuhFisId, e.SatirNo });

            ToTable("TOHAL_MUH_FIS_SATIRI");

            Property(e => e.MuhFisId).HasColumnName("MUH_FIS_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.MuhHesapId).HasColumnName("MUH_HESAP_ID");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.YevmiyeSatirNo).HasColumnName("YEVMIYE_SATIR_NO");

            HasRequired(d => d.MuhFis)
                .WithMany(p => p.TohalMuhFisSatiris)
                .HasForeignKey(d => d.MuhFisId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.MuhHesap)
                .WithMany(p => p.TohalMuhFisSatiris)
                .HasForeignKey(d => d.MuhHesapId)
                .WillCascadeOnDelete(false);
        }
    }
}
