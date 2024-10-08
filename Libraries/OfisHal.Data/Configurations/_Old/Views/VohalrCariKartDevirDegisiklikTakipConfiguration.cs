using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrCariKartDevirDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrCariKartDevirDegisiklikTakip>
    {
        public VohalrCariKartDevirDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_CARI_KART_DEVIR_DEGISIKLIK_TAKIP");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.ODevir).HasColumnName("O_DEVIR");

            Property(e => e.OOran).HasColumnName("O_ORAN");

            Property(e => e.OOrtaklikOrani).HasColumnName("O_ORTAKLIK_ORANI");

            Property(e => e.SDevir).HasColumnName("S_DEVIR");

            Property(e => e.SOran).HasColumnName("S_ORAN");

            Property(e => e.SOrtaklikOrani).HasColumnName("S_ORTAKLIK_ORANI");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
