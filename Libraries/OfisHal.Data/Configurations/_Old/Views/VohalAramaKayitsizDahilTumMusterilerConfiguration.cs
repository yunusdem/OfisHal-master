using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaKayitsizDahilTumMusterilerConfiguration : EntityTypeConfiguration<VohalAramaKayitsizDahilTumMusteriler>
    {
        public VohalAramaKayitsizDahilTumMusterilerConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_KAYITSIZ_DAHIL_TUM_MUSTERILER");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(213)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
