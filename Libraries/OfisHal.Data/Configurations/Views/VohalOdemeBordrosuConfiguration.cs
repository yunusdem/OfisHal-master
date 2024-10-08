using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalOdemeBordrosuConfiguration : EntityTypeConfiguration<VohalOdemeBordrosu>
    {
        public VohalOdemeBordrosuConfiguration()
        {
            //HasNoKey();
            HasKey(x => x.OdemeBordrosuId);

            ToTable("VOHAL_ODEME_BORDROSU");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Ad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.BankaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BANKA_ADI");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.BankaId).HasColumnName("BANKA_ID");

            Property(e => e.BordroNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BORDRO_NO")
                .IsFixedLength();

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Devir).HasColumnName("DEVIR");

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
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO")
                .IsFixedLength();

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.KartTipi).HasColumnName("KART_TIPI");

            Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.SubeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SUBE_ADI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
