using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalKonyaHalSatisBildirimiConfiguration : EntityTypeConfiguration<VohalKonyaHalSatisBildirimi>
    {
        public VohalKonyaHalSatisBildirimiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_KONYA_HAL_SATIS_BILDIRIMI");

            Property(e => e.BildirimDurumu).HasColumnName("BILDIRIM_DURUMU");

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.BirimId).HasColumnName("BIRIM_ID");

            Property(e => e.DigMudurlukKulAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_MUDURLUK_KUL_ADI");

            Property(e => e.DigMudurlukKulSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIG_MUDURLUK_KUL_SIFRESI");

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

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIRIS_TARIHI");

            Property(e => e.GunCikisMiktari).HasColumnName("GUN_CIKIS_MIKTARI");

            Property(e => e.GunGirisMiktari).HasColumnName("GUN_GIRIS_MIKTARI");

            Property(e => e.HalId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HAL_ID")
                .IsFixedLength();

            Property(e => e.HksMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_MAL_ADI");

            Property(e => e.HksMalCinsiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_MAL_CINSI_ADI");

            Property(e => e.HksMalCinsiId).HasColumnName("HKS_MAL_CINSI_ID");

            Property(e => e.HksMalId).HasColumnName("HKS_MAL_ID");

            Property(e => e.KunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE_NO")
                .IsFixedLength();

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MalSahibi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_SAHIBI");

            Property(e => e.MalSahibiVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAL_SAHIBI_VERGI_NO")
                .IsFixedLength();

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisSaati)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_SAATI");

            Property(e => e.ToplamStokMiktari).HasColumnName("TOPLAM_STOK_MIKTARI");

            Property(e => e.UretimSekli).HasColumnName("URETIM_SEKLI");

            Property(e => e.UretimSekliAciklamasi)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("URETIM_SEKLI_ACIKLAMASI");

            Property(e => e.UretimSekliId).HasColumnName("URETIM_SEKLI_ID");

            Property(e => e.UrunAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URUN_ADI");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
