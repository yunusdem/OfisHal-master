using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaDokumKunyeBildirimListesiConfiguration : EntityTypeConfiguration<VohalAramaDokumKunyeBildirimListesi>
    {
        public VohalAramaDokumKunyeBildirimListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_DOKUM_KUNYE_BILDIRIM_LISTESI");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.Durum)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DURUM");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KayitId).HasColumnName("KAYIT_ID");

            Property(e => e.KunyeDurumu)
                .IsRequired()
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("KUNYE_DURUMU");

            Property(e => e.KunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE_NO")
                .IsFixedLength();

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MustahsilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KODU")
                .IsFixedLength();

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");
        }
    }
}
