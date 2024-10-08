using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalPosCihaziConfiguration : EntityTypeConfiguration<TohalPosCihazi>
    {
        public TohalPosCihaziConfiguration()
        {
            HasKey(e => e.PosCihaziId);

            ToTable("TOHAL_POS_CIHAZI");

            Property(e => e.PosCihaziId).HasColumnName("POS_CIHAZI_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.Devir).HasColumnName("DEVIR");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            HasRequired(d => d.BankaHesabi)
                .WithMany(p => p.TohalPosCihazis)
                .HasForeignKey(d => d.BankaHesabiId)
                .WillCascadeOnDelete(false);
        }
    }
}
