using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal00MusteriOdemeAraciRiskListesiConfiguration : EntityTypeConfiguration<Vohal00MusteriOdemeAraciRiskListesi>
    {
        public Vohal00MusteriOdemeAraciRiskListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_00_MUSTERI_ODEME_ARACI_RISK_LISTESI");

            Property(e => e.BankaId).HasColumnName("BANKA_ID");

            Property(e => e.CariAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.IlkCariAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILK_CARI_ADI");

            Property(e => e.IlkCariKartId).HasColumnName("ILK_CARI_KART_ID");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.OdemeAraciNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.OdemeAraciSahibi).HasColumnName("ODEME_ARACI_SAHIBI");

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.VadeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VADE_TARIHI");
        }
    }
}
