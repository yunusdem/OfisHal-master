using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrCekSenetDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrCekSenetDegisiklikTakip>
    {
        public VohalrCekSenetDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_CEK_SENET_DEGISIKLIK_TAKIP");

            Property(e => e.DegisenSatirSayisi).HasColumnName("DEGISEN_SATIR_SAYISI");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OBordroNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_BORDRO_NO")
                .IsFixedLength();

            Property(e => e.OCariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_CARI_AD");

            Property(e => e.OCariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_CARI_KODU")
                .IsFixedLength();

            Property(e => e.OIslemTuru).HasColumnName("O_ISLEM_TURU");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SBordroNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_BORDRO_NO")
                .IsFixedLength();

            Property(e => e.SCariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_CARI_AD");

            Property(e => e.SCariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_CARI_KODU")
                .IsFixedLength();

            Property(e => e.SIslemTuru).HasColumnName("S_ISLEM_TURU");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
