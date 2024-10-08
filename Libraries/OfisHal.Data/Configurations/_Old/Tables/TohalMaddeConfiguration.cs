using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalMaddeConfiguration : EntityTypeConfiguration<TohalMadde>
    {
        public TohalMaddeConfiguration()
        {
            HasKey(e => new { e.GrupNo, e.SiraNo });

            ToTable("TOHAL_MADDE");

            Property(e => e.GrupNo).HasColumnName("GRUP_NO");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");
        }
    }
}
