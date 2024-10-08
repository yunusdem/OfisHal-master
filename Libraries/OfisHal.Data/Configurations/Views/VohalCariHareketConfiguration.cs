using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalCariHareketConfiguration : EntityTypeConfiguration<VohalCariHareket>
    {
        public VohalCariHareketConfiguration()
        {
            HasKey(e => e.CariHareketId);
            //HasNoKey();

            ToTable("VOHAL_CARI_HAREKET");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Aciklama2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA2");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AdTarih)
                .HasMaxLength(210)
                .IsUnicode(false)
                .HasColumnName("AD_TARIH");

            Property(e => e.CariHareketId).HasColumnName("CARI_HAREKET_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EKLEYEN_KULLANICI_ADI");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEYEN_KULLANICI_ADI");

            Property(e => e.IslemTipi).HasColumnName("ISLEM_TIPI");

            Property(e => e.KarsiCariKartAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KARSI_CARI_KART_ADI");

            Property(e => e.KarsiCariKartId).HasColumnName("KARSI_CARI_KART_ID");

            Property(e => e.KartTipi).HasColumnName("KART_TIPI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.KodTarih)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KOD_TARIH")
                .IsFixedLength();

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.PosCihaziAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POS_CIHAZI_ADI");

            Property(e => e.PosCihaziId).HasColumnName("POS_CIHAZI_ID");

            Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF_NO")
                .IsFixedLength();

            Property(e => e.RiskSiniri).HasColumnName("RISK_SINIRI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.VeresiyeSiniri).HasColumnName("VERESIYE_SINIRI");
        }
    }
}
