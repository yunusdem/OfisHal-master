using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalDevirAyarlariConfiguration : EntityTypeConfiguration<TohalDevirAyarlari>
    {
        public TohalDevirAyarlariConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_DEVIR_AYARLARI");

            Property(e => e.Banka).HasColumnName("BANKA");

            Property(e => e.CekSenet).HasColumnName("CEK_SENET");

            Property(e => e.DevirHareketTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEVIR_HAREKET_TARIHI");

            Property(e => e.FiyatListesi).HasColumnName("FIYAT_LISTESI");

            Property(e => e.HedefVeritabaniAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HEDEF_VERITABANI_ADI");

            Property(e => e.KalanDokum).HasColumnName("KALAN_DOKUM");

            Property(e => e.KayitsizMusteri).HasColumnName("KAYITSIZ_MUSTERI");

            Property(e => e.Magaza).HasColumnName("MAGAZA");

            Property(e => e.MustahsilCari).HasColumnName("MUSTAHSIL_CARI");

            Property(e => e.MustahsilKapCari).HasColumnName("MUSTAHSIL_KAP_CARI");

            Property(e => e.MusteriCari).HasColumnName("MUSTERI_CARI");

            Property(e => e.MusteriKapCari).HasColumnName("MUSTERI_KAP_CARI");

            Property(e => e.MusteriRehinIadeSekli).HasColumnName("MUSTERI_REHIN_IADE_SEKLI");
        }
    }
}
