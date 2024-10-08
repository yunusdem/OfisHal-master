using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogCariHareketConfiguration : EntityTypeConfiguration<TohalLogCariHareket>
    {
        public TohalLogCariHareketConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_CARI_HAREKET");

            Property(e => e.CariHareketId).HasColumnName("CARI_HAREKET_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OCariKartId).HasColumnName("O_CARI_KART_ID");

            Property(e => e.OIslemTipi).HasColumnName("O_ISLEM_TIPI");

            Property(e => e.OMeblag).HasColumnName("O_MEBLAG");

            Property(e => e.ORefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_REF_NO")
                .IsFixedLength();

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OTip).HasColumnName("O_TIP");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SCariKartId).HasColumnName("S_CARI_KART_ID");

            Property(e => e.SIslemTipi).HasColumnName("S_ISLEM_TIPI");

            Property(e => e.SMeblag).HasColumnName("S_MEBLAG");

            Property(e => e.SRefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_REF_NO")
                .IsFixedLength();

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
