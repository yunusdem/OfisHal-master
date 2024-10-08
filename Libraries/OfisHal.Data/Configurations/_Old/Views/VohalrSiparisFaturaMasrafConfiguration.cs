using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSiparisFaturaMasrafConfiguration : EntityTypeConfiguration<VohalrSiparisFaturaMasraf>
    {
        public VohalrSiparisFaturaMasrafConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SIPARIS_FATURA_MASRAF");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");
        }
    }
}
