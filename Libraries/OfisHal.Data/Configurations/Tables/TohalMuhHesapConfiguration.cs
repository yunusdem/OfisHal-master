using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalMuhHesapConfiguration : EntityTypeConfiguration<TohalMuhHesap>
    {
        public TohalMuhHesapConfiguration()
        {
            HasKey(e => e.MuhHesapId, e => e.IsClustered(false));

            ToTable("TOHAL_MUH_HESAP");

            HasIndex(e => e.Kod)
                .IsUnique();

            Property(e => e.MuhHesapId).HasColumnName("MUH_HESAP_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Hakkinda)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HAKKINDA");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tur).HasColumnName("TUR");
        }
    }
}
