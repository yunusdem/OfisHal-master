using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalDigerAdConfiguration : EntityTypeConfiguration<TohalDigerAd>
    {
        public TohalDigerAdConfiguration()
        {
            HasKey(e => e.DigerAdId);

            ToTable("TOHAL_DIGER_AD");

            Property(e => e.DigerAdId).HasColumnName("DIGER_AD_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.UzakSistemId).HasColumnName("UZAK_SISTEM_ID");
        }
    }
}
