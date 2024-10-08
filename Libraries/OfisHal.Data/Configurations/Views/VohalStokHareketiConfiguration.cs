using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalStokHareketiConfiguration : EntityTypeConfiguration<VohalStokHareketi>
    {
        public VohalStokHareketiConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.StokHareketiId);
            ToTable("VOHAL_STOK_HAREKETI");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIRIS_TARIHI");

            Property(e => e.Iadeli).HasColumnName("IADELI");

            Property(e => e.KalanMiktar).HasColumnName("KALAN_MIKTAR");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatilanKap).HasColumnName("SATILAN_KAP");

            Property(e => e.SatilanMiktar).HasColumnName("SATILAN_MIKTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            Property(e => e.StokKunyesi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYESI")
                .IsFixedLength();

            Property(e => e.StokKunyesiFiyati).HasColumnName("STOK_KUNYESI_FIYATI");

            Property(e => e.StokTipi).HasColumnName("STOK_TIPI");
        }
    }
}
