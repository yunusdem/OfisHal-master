using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaFaturaKunyeBildirimListesiConfiguration : EntityTypeConfiguration<VohalAramaFaturaKunyeBildirimListesi>
    {
        public VohalAramaFaturaKunyeBildirimListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_FATURA_KUNYE_BILDIRIM_LISTESI");

            Property(e => e.Durum)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DURUM");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KayitId).HasColumnName("KAYIT_ID");

            Property(e => e.KunyeDurumu)
                .IsRequired()
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("KUNYE_DURUMU");

            Property(e => e.MagazaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAGAZA_ADI");

            Property(e => e.MagazaKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAGAZA_KODU")
                .IsFixedLength();

            Property(e => e.MalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MustahsilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MusteriAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_ADI");

            Property(e => e.MusteriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_KODU")
                .IsFixedLength();

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisFiyati).HasColumnName("SATIS_FIYATI");

            Property(e => e.SatisKunyeId).HasColumnName("SATIS_KUNYE_ID");

            Property(e => e.SatisKunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_KUNYE_NO")
                .IsFixedLength();

            Property(e => e.SatisKunyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_KUNYE_TARIHI");

            Property(e => e.StokFiyati).HasColumnName("STOK_FIYATI");

            Property(e => e.StokKunyeDetayGuid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYE_DETAY_GUID");

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            Property(e => e.StokKunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYE_NO")
                .IsFixedLength();

            Property(e => e.StokKunyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_KUNYE_TARIHI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.UreticiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URETICI_ADI");

            Property(e => e.UretimSekli)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("URETIM_SEKLI");

            Property(e => e.YerAdi)
                .IsRequired()
                .HasMaxLength(606)
                .IsUnicode(false)
                .HasColumnName("YER_ADI");
        }
    }
}
