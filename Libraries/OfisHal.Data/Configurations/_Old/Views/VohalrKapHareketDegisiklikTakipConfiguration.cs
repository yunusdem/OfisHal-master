using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrKapHareketDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrKapHareketDegisiklikTakip>
    {
        public VohalrKapHareketDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_KAP_HAREKET_DEGISIKLIK_TAKIP");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KapHareketId).HasColumnName("KAP_HAREKET_ID");

            Property(e => e.KartTipi).HasColumnName("KART_TIPI");

            Property(e => e.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OCariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_CARI_AD");

            Property(e => e.OCariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_CARI_KODU")
                .IsFixedLength();

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OIslenecegiHesap).HasColumnName("O_ISLENECEGI_HESAP");

            Property(e => e.OKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_KAP_ADI");

            Property(e => e.OKapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_KAP_KODU")
                .IsFixedLength();

            Property(e => e.OMiktar).HasColumnName("O_MIKTAR");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OTip).HasColumnName("O_TIP");

            Property(e => e.OTutar).HasColumnName("O_TUTAR");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SCariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_CARI_AD");

            Property(e => e.SCariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_CARI_KODU")
                .IsFixedLength();

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SIslenecegiHesap).HasColumnName("S_ISLENECEGI_HESAP");

            Property(e => e.SKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_KAP_ADI");

            Property(e => e.SKapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_KAP_KODU")
                .IsFixedLength();

            Property(e => e.SMiktar).HasColumnName("S_MIKTAR");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.STip).HasColumnName("S_TIP");

            Property(e => e.STutar).HasColumnName("S_TUTAR");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
