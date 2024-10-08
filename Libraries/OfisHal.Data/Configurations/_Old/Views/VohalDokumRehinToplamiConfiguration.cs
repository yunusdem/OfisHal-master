using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalDokumRehinToplamiConfiguration : EntityTypeConfiguration<VohalDokumRehinToplami>
    {
        public VohalDokumRehinToplamiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_DOKUM_REHIN_TOPLAMI");

            Property(e => e.KapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.KapTutari).HasColumnName("KAP_TUTARI");

            Property(e => e.KesilenKapMiktari).HasColumnName("KESILEN_KAP_MIKTARI");

            Property(e => e.KesilenKapTutari).HasColumnName("KESILEN_KAP_TUTARI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");
        }
    }
}
