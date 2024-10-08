using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrStokHareketiDegisiklikConfiguration : EntityTypeConfiguration<VohalrStokHareketiDegisiklik>
    {
        public VohalrStokHareketiDegisiklikConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_STOK_HAREKETI_DEGISIKLIK");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_KAP_ADI");

            Property(e => e.OKapId).HasColumnName("O_KAP_ID");

            Property(e => e.OKapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_KAP_KODU")
                .IsFixedLength();

            Property(e => e.OKapSayisi).HasColumnName("O_KAP_SAYISI");

            Property(e => e.OMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_MAL_ADI");

            Property(e => e.OMalId).HasColumnName("O_MAL_ID");

            Property(e => e.OMalKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O_MAL_KODU")
                .IsFixedLength();

            Property(e => e.OMiktar).HasColumnName("O_MIKTAR");

            Property(e => e.OSatilanKap).HasColumnName("O_SATILAN_KAP");

            Property(e => e.OSatilanMiktar).HasColumnName("O_SATILAN_MIKTAR");

            Property(e => e.OStokTipi).HasColumnName("O_STOK_TIPI");

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_KAP_ADI");

            Property(e => e.SKapId).HasColumnName("S_KAP_ID");

            Property(e => e.SKapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_KAP_KODU")
                .IsFixedLength();

            Property(e => e.SKapSayisi).HasColumnName("S_KAP_SAYISI");

            Property(e => e.SMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_MAL_ADI");

            Property(e => e.SMalId).HasColumnName("S_MAL_ID");

            Property(e => e.SMalKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_MAL_KODU")
                .IsFixedLength();

            Property(e => e.SMiktar).HasColumnName("S_MIKTAR");

            Property(e => e.SSatilanKap).HasColumnName("S_SATILAN_KAP");

            Property(e => e.SSatilanMiktar).HasColumnName("S_SATILAN_MIKTAR");

            Property(e => e.SStokTipi).HasColumnName("S_STOK_TIPI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
