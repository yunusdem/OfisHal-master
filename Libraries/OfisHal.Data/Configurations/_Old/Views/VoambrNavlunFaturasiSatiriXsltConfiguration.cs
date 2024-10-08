using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrNavlunFaturasiSatiriXsltConfiguration : EntityTypeConfiguration<VoambrNavlunFaturasiSatiriXslt>
    {
        public VoambrNavlunFaturasiSatiriXsltConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_NAVLUN_FATURASI_SATIRI_XSLT");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.GeldigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.Gonderen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GONDEREN");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalBirimi)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("MAL_BIRIMI");

            Property(e => e.NavlunFaturaSatiriId).HasColumnName("NAVLUN_FATURA_SATIRI_ID");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.PlakaNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
