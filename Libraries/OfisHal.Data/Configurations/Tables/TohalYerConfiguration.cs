using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalYerConfiguration : EntityTypeConfiguration<TohalYer>
    {
        public TohalYerConfiguration()
        {
            HasKey(e => e.YerId);

            ToTable("TOHAL_YER");

            Property(e => e.YerId).HasColumnName("YER_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.UstId).HasColumnName("UST_ID");

            HasOptional(d => d.Ust)
                .WithMany(p => p.InverseUst)
                .HasForeignKey(d => d.UstId);
        }
    }
}
