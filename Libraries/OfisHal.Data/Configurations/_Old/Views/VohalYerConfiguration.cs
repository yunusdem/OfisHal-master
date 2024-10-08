using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalYerConfiguration : EntityTypeConfiguration<VohalYer>
    {
        public VohalYerConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_YER");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

            Property(e => e.BeldeTuru).HasColumnName("BELDE_TURU");

            Property(e => e.IlAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL_ADI");

            Property(e => e.IlId).HasColumnName("IL_ID");

            Property(e => e.IlTuru).HasColumnName("IL_TURU");

            Property(e => e.IlceAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE_ADI");

            Property(e => e.IlceId).HasColumnName("ILCE_ID");

            Property(e => e.IlceTuru).HasColumnName("ILCE_TURU");
        }
    }
}
