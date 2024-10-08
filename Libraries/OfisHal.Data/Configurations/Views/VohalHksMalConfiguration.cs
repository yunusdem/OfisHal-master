using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalHksMalConfiguration : EntityTypeConfiguration<VohalHksMal>
    {
        public VohalHksMalConfiguration()
        {
            HasKey(e => e.MalCinsiHksId);
            //HasNoKey();

            ToTable("VOHAL_HKS_MAL");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalAdiHksId).HasColumnName("MAL_ADI_HKS_ID");

            Property(e => e.MalAdiId).HasColumnName("MAL_ADI_ID");

            Property(e => e.MalCinsi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_CINSI");

            Property(e => e.MalCinsiHksId).HasColumnName("MAL_CINSI_HKS_ID");

            Property(e => e.MalCinsiId).HasColumnName("MAL_CINSI_ID");

            Property(e => e.UretimSekli).HasColumnName("URETIM_SEKLI");

            Property(e => e.UretimSekliAciklamasi)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("URETIM_SEKLI_ACIKLAMASI");
        }
    }
}
