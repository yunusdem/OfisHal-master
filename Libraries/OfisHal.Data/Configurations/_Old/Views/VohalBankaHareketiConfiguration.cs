using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalBankaHareketiConfiguration : EntityTypeConfiguration<VohalBankaHareketi>
    {
        public VohalBankaHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_BANKA_HAREKETI");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.BankaHareketiId).HasColumnName("BANKA_HAREKETI_ID");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.CariAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

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

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapAdiTarih)
                .HasMaxLength(210)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI_TARIH");

            Property(e => e.HesapNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO")
                .IsFixedLength();

            Property(e => e.HesapNoTarih)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO_TARIH")
                .IsFixedLength();

            Property(e => e.IslemTipi).HasColumnName("ISLEM_TIPI");

            Property(e => e.KarsiBankaHesabiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KARSI_BANKA_HESABI_ADI");

            Property(e => e.KarsiBankaHesabiId).HasColumnName("KARSI_BANKA_HESABI_ID");

            Property(e => e.KasaHesapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KASA_HESAP_ADI");

            Property(e => e.KasaHesapId).HasColumnName("KASA_HESAP_ID");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.PosCihaziAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POS_CIHAZI_ADI");

            Property(e => e.PosCihaziId).HasColumnName("POS_CIHAZI_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
