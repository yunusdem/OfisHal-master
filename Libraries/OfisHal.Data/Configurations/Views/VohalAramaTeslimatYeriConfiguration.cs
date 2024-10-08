using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalAramaTeslimatYeriConfiguration : EntityTypeConfiguration<VohalAramaTeslimatYeri>
    {
        public VohalAramaTeslimatYeriConfiguration()
        {
            HasKey(e => e.TeslimatYeriId);
            //HasNoKey();

            ToTable("VOHAL_ARAMA_TESLIMAT_YERI");

            Property(e => e.Ad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.HksWebSiraNo).HasColumnName("HKS_WEB_SIRA_NO");

            Property(e => e.TeslimatYeriId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("TESLIMAT_YERI_ID");

            Property(e => e.Tip)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TIP");
        }
    }
}
