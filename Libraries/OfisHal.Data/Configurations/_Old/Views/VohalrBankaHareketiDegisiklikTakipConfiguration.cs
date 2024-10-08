using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrBankaHareketiDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrBankaHareketiDegisiklikTakip>
    {
        public VohalrBankaHareketiDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_BANKA_HAREKETI_DEGISIKLIK_TAKIP");

            Property(e => e.BankaHareketiId).HasColumnName("BANKA_HAREKETI_ID");

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

            Property(e => e.OHesapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_HESAP_ADI");

            Property(e => e.OHesapNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_HESAP_NO")
                .IsFixedLength();

            Property(e => e.OIslemTipi).HasColumnName("O_ISLEM_TIPI");

            Property(e => e.OKarsiHesapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_KARSI_HESAP_ADI");

            Property(e => e.OMeblag).HasColumnName("O_MEBLAG");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SHesapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_HESAP_ADI");

            Property(e => e.SHesapNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_HESAP_NO")
                .IsFixedLength();

            Property(e => e.SIslemTipi).HasColumnName("S_ISLEM_TIPI");

            Property(e => e.SKarsiHesapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_KARSI_HESAP_ADI");

            Property(e => e.SMeblag).HasColumnName("S_MEBLAG");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.TlKurusSayisi).HasColumnName("TL_KURUS_SAYISI");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
