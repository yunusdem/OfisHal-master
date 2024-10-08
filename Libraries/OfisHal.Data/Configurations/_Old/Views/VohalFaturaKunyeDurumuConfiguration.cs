using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalFaturaKunyeDurumuConfiguration : EntityTypeConfiguration<VohalFaturaKunyeDurumu>
    {
        public VohalFaturaKunyeDurumuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_FATURA_KUNYE_DURUMU");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.MagazaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAGAZA_ADI");

            Property(e => e.MusteriAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_ADI");

            Property(e => e.SatirSayisi).HasColumnName("SATIR_SAYISI");

            Property(e => e.SatisKunyeSayisi).HasColumnName("SATIS_KUNYE_SAYISI");

            Property(e => e.StokKunyeSayisi).HasColumnName("STOK_KUNYE_SAYISI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
