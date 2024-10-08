using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalRehindekiKaplarConfiguration : EntityTypeConfiguration<VohalRehindekiKaplar>
    {
        public VohalRehindekiKaplarConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_REHINDEKI_KAPLAR");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KalanMiktar).HasColumnName("KALAN_MIKTAR");

            Property(e => e.KalanTutar).HasColumnName("KALAN_TUTAR");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.MusteriAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_ADI");

            Property(e => e.MusteriKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_KODU")
                .IsFixedLength();

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
