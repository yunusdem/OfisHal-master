using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrYazihaneListesiConfiguration : EntityTypeConfiguration<VoambrYazihaneListesi>
    {
        public VoambrYazihaneListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_YAZIHANE_LISTESI");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Tel1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL1");

            Property(e => e.Tel2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL2");
        }
    }
}
