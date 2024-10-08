using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalFiConfiguration : EntityTypeConfiguration<VohalFi>
    {
        public VohalFiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_FIS");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KOD")
                .IsFixedLength();

            Property(e => e.FisId).HasColumnName("FIS_ID");

            Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIS_NO")
                .IsFixedLength();

            Property(e => e.GuncellemeZamani)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.KayitsizMusteriId).HasColumnName("KAYITSIZ_MUSTERI_ID");

            Property(e => e.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OdemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIHI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
