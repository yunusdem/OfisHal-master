using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrNavlunFaturaSatiriToplamlarConfiguration : EntityTypeConfiguration<VoambrNavlunFaturaSatiriToplamlar>
    {
        public VoambrNavlunFaturaSatiriToplamlarConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_NAVLUN_FATURA_SATIRI_TOPLAMLAR");

            Property(e => e.Aciklama)
                .HasMaxLength(62)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
