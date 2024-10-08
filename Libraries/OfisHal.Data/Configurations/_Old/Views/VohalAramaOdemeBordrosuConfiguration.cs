using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaOdemeBordrosuConfiguration : EntityTypeConfiguration<VohalAramaOdemeBordrosu>
    {
        public VohalAramaOdemeBordrosuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_ODEME_BORDROSU");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Ad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.BordroNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BORDRO_NO")
                .IsFixedLength();

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
