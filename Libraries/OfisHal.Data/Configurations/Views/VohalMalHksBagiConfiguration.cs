using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalMalHksBagiConfiguration : EntityTypeConfiguration<VohalMalHksBagi>
    {
        public VohalMalHksBagiConfiguration()
        {
            HasKey(e => e.HksMalId);
            //HasNoKey();

            ToTable("VOHAL_MAL_HKS_BAGI");

            Property(e => e.HksMalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_MAL_ADI");

            Property(e => e.HksMalCinsiAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_MAL_CINSI_ADI");

            Property(e => e.HksMalCinsiId).HasColumnName("HKS_MAL_CINSI_ID");

            Property(e => e.HksMalId).HasColumnName("HKS_MAL_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            Property(e => e.UretimSekli).HasColumnName("URETIM_SEKLI");

            Property(e => e.UretimSekliAciklamasi)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("URETIM_SEKLI_ACIKLAMASI");
        }
    }
}
