using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrCariHareketDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrCariHareketDegisiklikTakip>
    {
        public VohalrCariHareketDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_CARI_HAREKET_DEGISIKLIK_TAKIP");

            Property(e => e.CariHareketId).HasColumnName("CARI_HAREKET_ID");

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

            Property(e => e.OCariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_CARI_AD");

            Property(e => e.OCariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_CARI_KODU")
                .IsFixedLength();

            Property(e => e.OIslemTipi).HasColumnName("O_ISLEM_TIPI");

            Property(e => e.OMeblag).HasColumnName("O_MEBLAG");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OTip).HasColumnName("O_TIP");

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

            Property(e => e.SIslemTipi).HasColumnName("S_ISLEM_TIPI");

            Property(e => e.SMeblag).HasColumnName("S_MEBLAG");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.STip).HasColumnName("S_TIP");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
