using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambEFaturaEvrakKdvConfiguration : EntityTypeConfiguration<VoambEFaturaEvrakKdv>
    {
        public VoambEFaturaEvrakKdvConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_E_FATURA_EVRAK_KDV");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("KOD");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Matrah).HasColumnName("MATRAH");

            Property(e => e.Oran).HasColumnName("ORAN");
        }
    }
}
