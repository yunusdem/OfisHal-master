using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrFaturaSatiriToplamlarConfiguration : EntityTypeConfiguration<VohalrFaturaSatiriToplamlar>
    {
        public VohalrFaturaSatiriToplamlarConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_FATURA_SATIRI_TOPLAMLAR");

            Property(e => e.Aciklama)
                .HasMaxLength(177)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
