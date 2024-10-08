using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrFaturaMasrafiConfiguration : EntityTypeConfiguration<VohalrFaturaMasrafi>
    {
        public VohalrFaturaMasrafiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_FATURA_MASRAFI");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.Masraf).HasColumnName("MASRAF");
        }
    }
}
