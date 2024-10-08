using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrHesapHareketiDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrHesapHareketiDegisiklikTakip>
    {
        public VohalrHesapHareketiDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_HESAP_HAREKETI_DEGISIKLIK_TAKIP");

            Property(e => e.HesapHareketiId).HasColumnName("HESAP_HAREKETI_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

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

            Property(e => e.OHareketTipi).HasColumnName("O_HAREKET_TIPI");

            Property(e => e.OHesapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_HESAP_ADI");

            Property(e => e.OHesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_HESAP_KODU")
                .IsFixedLength();

            Property(e => e.OKdv).HasColumnName("O_KDV");

            Property(e => e.OKdvOrani).HasColumnName("O_KDV_ORANI");

            Property(e => e.OMeblag).HasColumnName("O_MEBLAG");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OTip).HasColumnName("O_TIP");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SHareketTipi).HasColumnName("S_HAREKET_TIPI");

            Property(e => e.SHesapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_HESAP_ADI");

            Property(e => e.SHesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_HESAP_KODU")
                .IsFixedLength();

            Property(e => e.SKdv).HasColumnName("S_KDV");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SMeblag).HasColumnName("S_MEBLAG");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.STip).HasColumnName("S_TIP");

            Property(e => e.TlKurusSayisi).HasColumnName("TL_KURUS_SAYISI");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
