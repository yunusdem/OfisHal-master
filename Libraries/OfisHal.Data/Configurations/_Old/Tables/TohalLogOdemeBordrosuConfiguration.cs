using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogOdemeBordrosuConfiguration : EntityTypeConfiguration<TohalLogOdemeBordrosu>
    {
        public TohalLogOdemeBordrosuConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_ODEME_BORDROSU");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OBankaHesabiId).HasColumnName("O_BANKA_HESABI_ID");

            Property(e => e.OBordroNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_BORDRO_NO")
                .IsFixedLength();

            Property(e => e.OCariKartId).HasColumnName("O_CARI_KART_ID");

            Property(e => e.OIslemTuru).HasColumnName("O_ISLEM_TURU");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SBankaHesabiId).HasColumnName("S_BANKA_HESABI_ID");

            Property(e => e.SBordroNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_BORDRO_NO")
                .IsFixedLength();

            Property(e => e.SCariKartId).HasColumnName("S_CARI_KART_ID");

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
