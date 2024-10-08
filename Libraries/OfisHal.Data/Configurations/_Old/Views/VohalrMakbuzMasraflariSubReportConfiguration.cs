using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMakbuzMasraflariSubReportConfiguration : EntityTypeConfiguration<VohalrMakbuzMasraflariSubReport>
    {
        public VohalrMakbuzMasraflariSubReportConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MAKBUZ_MASRAFLARI_SUB_REPORT");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(204)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MakbuzMasrafi).HasColumnName("MAKBUZ_MASRAFI");

            Property(e => e.Oran).HasColumnName("ORAN");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
