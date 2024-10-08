using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogBankaHareketiConfiguration : EntityTypeConfiguration<TohalLogBankaHareketi>
    {
        public TohalLogBankaHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_BANKA_HAREKETI");

            Property(e => e.BankaHareketiId).HasColumnName("BANKA_HAREKETI_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OBankaHesabiId).HasColumnName("O_BANKA_HESABI_ID");

            Property(e => e.OCariKartId).HasColumnName("O_CARI_KART_ID");

            Property(e => e.OHesapId).HasColumnName("O_HESAP_ID");

            Property(e => e.OIslemTipi).HasColumnName("O_ISLEM_TIPI");

            Property(e => e.OKarsiBankaHesabiId).HasColumnName("O_KARSI_BANKA_HESABI_ID");

            Property(e => e.OMeblag).HasColumnName("O_MEBLAG");

            Property(e => e.OPosCihaziId).HasColumnName("O_POS_CIHAZI_ID");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SBankaHesabiId).HasColumnName("S_BANKA_HESABI_ID");

            Property(e => e.SCariKartId).HasColumnName("S_CARI_KART_ID");

            Property(e => e.SHesapId).HasColumnName("S_HESAP_ID");

            Property(e => e.SIslemTipi).HasColumnName("S_ISLEM_TIPI");

            Property(e => e.SKarsiBankaHesabiId).HasColumnName("S_KARSI_BANKA_HESABI_ID");

            Property(e => e.SMeblag).HasColumnName("S_MEBLAG");

            Property(e => e.SPosCihaziId).HasColumnName("S_POS_CIHAZI_ID");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
