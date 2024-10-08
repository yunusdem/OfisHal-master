using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalAramaKapConfiguration : EntityTypeConfiguration<VohalAramaKap>
    {
        public VohalAramaKapConfiguration()
        {
            HasKey(e => e.KapId);
            //HasNoKey();

            ToTable("VOHAL_ARAMA_KAP");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Durum)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DURUM");

            Property(e => e.KapId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("KAP_ID");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();
        }
    }
}
