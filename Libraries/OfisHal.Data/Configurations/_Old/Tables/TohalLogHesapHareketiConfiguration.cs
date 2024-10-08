using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogHesapHareketiConfiguration : EntityTypeConfiguration<TohalLogHesapHareketi>
    {
        public TohalLogHesapHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_HESAP_HAREKETI");

            Property(e => e.HesapHareketiId).HasColumnName("HESAP_HAREKETI_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OHareketTipi).HasColumnName("O_HAREKET_TIPI");

            Property(e => e.OHesapId).HasColumnName("O_HESAP_ID");

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

            Property(e => e.SHesapId).HasColumnName("S_HESAP_ID");

            Property(e => e.SKdv).HasColumnName("S_KDV");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SMeblag).HasColumnName("S_MEBLAG");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.STip).HasColumnName("S_TIP");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
