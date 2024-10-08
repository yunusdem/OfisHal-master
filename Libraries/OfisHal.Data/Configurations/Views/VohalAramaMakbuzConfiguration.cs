using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalAramaMakbuzConfiguration : EntityTypeConfiguration<VohalAramaMakbuz>
    {
        public VohalAramaMakbuzConfiguration()
        {
            HasKey(e => e.MakbuzId);

            ToTable("VOHAL_ARAMA_MAKBUZ");

            Property(e => e.AdStokTarih)
                .HasMaxLength(210)
                .IsUnicode(false)
                .HasColumnName("AD_STOK_TARIH");

            Property(e => e.AdTarih)
                .HasMaxLength(210)
                .IsUnicode(false)
                .HasColumnName("AD_TARIH");

            Property(e => e.BekleyenHareketSayisi).HasColumnName("BEKLEYEN_HAREKET_SAYISI");

            Property(e => e.CariAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KODU")
                .IsFixedLength();

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.KodStokTarih)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KOD_STOK_TARIH")
                .IsFixedLength();

            Property(e => e.KodTarih)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KOD_TARIH")
                .IsFixedLength();

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalinGelisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("MALIN_GELIS_TARIHI");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");
        }
    }
}
