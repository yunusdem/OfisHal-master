using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalMalHksBagiConfiguration : EntityTypeConfiguration<TohalMalHksBagi>
    {
        public TohalMalHksBagiConfiguration()
        {
            HasKey(e => new { e.MalId, e.HksMalId });

            ToTable("TOHAL_MAL_HKS_BAGI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.HksMalId).HasColumnName("HKS_MAL_ID");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            HasRequired(d => d.HksMal)
                .WithMany(p => p.TohalMalHksBagis)
                .HasForeignKey(d => d.HksMalId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Mal)
                .WithMany(p => p.TohalMalHksBagis)
                .HasForeignKey(d => d.MalId)
                .WillCascadeOnDelete(false);
        }
    }
}
