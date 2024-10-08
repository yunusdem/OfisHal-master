using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAntalyaHalSatisBildirimiConfiguration : EntityTypeConfiguration<VohalAntalyaHalSatisBildirimi>
    {
        public VohalAntalyaHalSatisBildirimiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ANTALYA_HAL_SATIS_BILDIRIMI");

            Property(e => e.Agirlik).HasColumnName("AGIRLIK");

            Property(e => e.AraToplam).HasColumnName("ARA_TOPLAM");

            Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO")
                .IsFixedLength();

            Property(e => e.BildirimDurumu).HasColumnName("BILDIRIM_DURUMU");

            Property(e => e.BirimAdi)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("BIRIM_ADI");

            Property(e => e.CariAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.DigFirmaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_FIRMA_ADI");

            Property(e => e.DigMudurlukKulAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_MUDURLUK_KUL_ADI");

            Property(e => e.DigMudurlukKulSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIG_MUDURLUK_KUL_SIFRESI");

            Property(e => e.DigVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.DigYazihaneNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_YAZIHANE_NO")
                .IsFixedLength();

            Property(e => e.DonenAlanDegeri)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DONEN_ALAN_DEGERI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTipi)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FATURA_TIPI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.HksUrunAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_URUN_ADI");

            Property(e => e.HksUrunKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HKS_URUN_KODU")
                .IsFixedLength();

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.IskontoToplami).HasColumnName("ISKONTO_TOPLAMI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvTutari).HasColumnName("KDV_TUTARI");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.OnBildirimDurumu).HasColumnName("ON_BILDIRIM_DURUMU");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisKunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_KUNYE_NO")
                .IsFixedLength();

            Property(e => e.StokKunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYE_NO")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.UretimSekliAdi)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("URETIM_SEKLI_ADI");

            Property(e => e.UretimSekliKodu)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("URETIM_SEKLI_KODU");

            Property(e => e.UrunCinsiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URUN_CINSI_ADI");

            Property(e => e.UrunCinsiHksId).HasColumnName("URUN_CINSI_HKS_ID");

            Property(e => e.UrunCinsiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("URUN_CINSI_KODU")
                .IsFixedLength();

            Property(e => e.UrunHksId).HasColumnName("URUN_HKS_ID");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
