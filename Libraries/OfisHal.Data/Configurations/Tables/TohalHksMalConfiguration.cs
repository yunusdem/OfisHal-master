using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalHksMalConfiguration : EntityTypeConfiguration<TohalHksMal>
    {
        public TohalHksMalConfiguration()
        {
            HasKey(e => e.HksMalId);

            ToTable("TOHAL_HKS_MAL");

            Property(e => e.HksMalId).HasColumnName("HKS_MAL_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.HksUrunKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HKS_URUN_KODU")
                .IsFixedLength();

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.UretimSekli).HasColumnName("URETIM_SEKLI");

            Property(e => e.UstId).HasColumnName("UST_ID");

            HasOptional(d => d.Ust)
                .WithMany(p => p.InverseUst)
                .HasForeignKey(d => d.UstId);
        }
    }
}
