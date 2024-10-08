using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalSiparisSatiriConfiguration : EntityTypeConfiguration<TohalSiparisSatiri>
    {
        public TohalSiparisSatiriConfiguration()
        {
            HasKey(e => e.SiparisSatiriId);

            ToTable("TOHAL_SIPARIS_SATIRI");

            Property(e => e.SiparisSatiriId).HasColumnName("SIPARIS_SATIRI_ID");

            Property(e => e.MalBirimi).HasColumnName("MAL_BIRIMI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            HasRequired(d => d.Mal)
                .WithMany(p => p.TohalSiparisSatiris)
                .HasForeignKey(d => d.MalId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Siparis)
                .WithMany(p => p.TohalSiparisSatiris)
                .HasForeignKey(d => d.SiparisId)
                .WillCascadeOnDelete(false);
        }
    }
}
