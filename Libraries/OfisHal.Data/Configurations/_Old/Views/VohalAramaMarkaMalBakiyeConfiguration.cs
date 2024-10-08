using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaMarkaMalBakiyeConfiguration : EntityTypeConfiguration<VohalAramaMarkaMalBakiye>
    {
        public VohalAramaMarkaMalBakiyeConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_MARKA_MAL_BAKIYE");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu).HasColumnName("KAP_KODU");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.KayitId).HasColumnName("KAYIT_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.MustahsilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");
        }
    }
}
