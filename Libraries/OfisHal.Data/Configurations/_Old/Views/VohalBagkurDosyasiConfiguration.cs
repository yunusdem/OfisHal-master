using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalBagkurDosyasiConfiguration : EntityTypeConfiguration<VohalBagkurDosyasi>
    {
        public VohalBagkurDosyasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_BAGKUR_DOSYASI");

            Property(e => e.DosyaId).HasColumnName("DOSYA_ID");

            Property(e => e.DosyaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOSYA_NO");

            Property(e => e.Muhasebelesti).HasColumnName("MUHASEBELESTI");

            Property(e => e.ToplamBagkur).HasColumnName("TOPLAM_BAGKUR");

            Property(e => e.ToplamMalTutari).HasColumnName("TOPLAM_MAL_TUTARI");
        }
    }
}
