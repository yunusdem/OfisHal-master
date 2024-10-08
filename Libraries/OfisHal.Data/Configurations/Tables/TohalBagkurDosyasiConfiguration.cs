using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalBagkurDosyasiConfiguration : EntityTypeConfiguration<TohalBagkurDosyasi>
    {
        public TohalBagkurDosyasiConfiguration()
        {
            HasKey(e => e.DosyaId);

            ToTable("TOHAL_BAGKUR_DOSYASI");

            Property(e => e.DosyaId).HasColumnName("DOSYA_ID");

            Property(e => e.DosyaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOSYA_NO");

            Property(e => e.Muhasebelesti).HasColumnName("MUHASEBELESTI");
        }
    }
}
