using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalEFaturaLogConfiguration : EntityTypeConfiguration<TohalEFaturaLog>
    {
        public TohalEFaturaLogConfiguration()
        {
            HasKey(e => e.LogId);

            ToTable("TOHAL_E_FATURA_LOG");

            Property(e => e.LogId).HasColumnName("LOG_ID");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Mesaj)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MESAJ");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
