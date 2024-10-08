using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalAramaKunyeConfiguration : EntityTypeConfiguration<VohalAramaKunye>
    {
        public VohalAramaKunyeConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.KunyeId);
            ToTable("VOHAL_ARAMA_KUNYE");

            Property(e => e.Kunye)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE")
                .IsFixedLength();

            Property(e => e.KunyeId).HasColumnName("KUNYE_ID");

            Property(e => e.MalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Marka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.MustahsilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.Tur).HasColumnName("TUR");
        }
    }
}
