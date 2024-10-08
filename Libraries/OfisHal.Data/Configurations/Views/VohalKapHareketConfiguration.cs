using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalKapHareketConfiguration : EntityTypeConfiguration<VohalKapHareket>
    {
        public VohalKapHareketConfiguration()
        {
            //HasNoKey();
            HasKey(e=>e.KapHareketId);
            ToTable("VOHAL_KAP_HAREKET");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AdTarih)
                .HasMaxLength(210)
                .IsUnicode(false)
                .HasColumnName("AD_TARIH");

            Property(e => e.CariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_AD");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KOD")
                .IsFixedLength();

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EKLEYEN_KULLANICI_ADI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaRefNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FATURA_REF_NO");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEYEN_KULLANICI_ADI");

            Property(e => e.IslenecegiHesap).HasColumnName("ISLENECEGI_HESAP");

            Property(e => e.KapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapHareketId).HasColumnName("KAP_HAREKET_ID");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KartTipi).HasColumnName("KART_TIPI");

            Property(e => e.KodTarih)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KOD_TARIH")
                .IsFixedLength();

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.RehinFisiId).HasColumnName("REHIN_FISI_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
