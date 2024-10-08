using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalEFaturaEvrakKdvConfiguration : EntityTypeConfiguration<VohalEFaturaEvrakKdv>
    {
        public VohalEFaturaEvrakKdvConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_E_FATURA_EVRAK_KDV");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Matrah).HasColumnName("MATRAH");

            Property(e => e.Oran).HasColumnName("ORAN");
        }
    }
}
