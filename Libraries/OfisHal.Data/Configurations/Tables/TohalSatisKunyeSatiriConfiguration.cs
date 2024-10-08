using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalSatisKunyeSatiriConfiguration : EntityTypeConfiguration<TohalSatisKunyeSatiri>
    {
        public TohalSatisKunyeSatiriConfiguration()
        {
            HasKey(e => e.SatisKunyeSatiriId);

            ToTable("TOHAL_SATIS_KUNYE_SATIRI");

            Property(e => e.SatisKunyeSatiriId).HasColumnName("SATIS_KUNYE_SATIRI_ID");

            Property(e => e.AliciCariKartId).HasColumnName("ALICI_CARI_KART_ID");

            Property(e => e.AliciEposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALICI_EPOSTA");

            Property(e => e.AliciKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ALICI_KODU")
                .IsFixedLength();

            Property(e => e.AliciSifatAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALICI_SIFAT_ADI");

            Property(e => e.AliciSifatKodu).HasColumnName("ALICI_SIFAT_KODU");

            Property(e => e.AliciTelefonNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ALICI_TELEFON_NO");

            Property(e => e.AliciUnvani)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALICI_UNVANI");

            Property(e => e.AliciVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ALICI_VERGI_NO")
                .IsFixedLength();

            Property(e => e.AliciYurtdisi).HasColumnName("ALICI_YURTDISI");

            Property(e => e.BildirimciSifatAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_SIFAT_ADI");

            Property(e => e.BildirimciSifatKodu).HasColumnName("BILDIRIMCI_SIFAT_KODU");

            Property(e => e.BildirimciTurAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_TUR_ADI");

            Property(e => e.BildirimciTurKodu).HasColumnName("BILDIRIMCI_TUR_KODU");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.GyAracPlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GY_ARAC_PLAKA_NO")
                .IsFixedLength();

            Property(e => e.GyBeldeAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GY_BELDE_ADI");

            Property(e => e.GyBeldeId).HasColumnName("GY_BELDE_ID");

            Property(e => e.GyBelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GY_BELGE_NO")
                .IsFixedLength();

            Property(e => e.GyIlAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GY_IL_ADI");

            Property(e => e.GyIlId).HasColumnName("GY_IL_ID");

            Property(e => e.GyIlceAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GY_ILCE_ADI");

            Property(e => e.GyIlceId).HasColumnName("GY_ILCE_ID");

            Property(e => e.GyIsletmeTuruAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GY_ISLETME_TURU_ADI");

            Property(e => e.GyIsletmeTuruId).HasColumnName("GY_ISLETME_TURU_ID");

            Property(e => e.GyIsyeriId).HasColumnName("GY_ISYERI_ID");

            Property(e => e.GyIsyeriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GY_ISYERI_KODU")
                .IsFixedLength();

            Property(e => e.MalAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalBirimAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAL_BIRIM_ADI")
                .IsFixedLength();

            Property(e => e.MalBirimId).HasColumnName("MAL_BIRIM_ID");

            Property(e => e.MalCinsiAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAL_CINSI_ADI");

            Property(e => e.MalCinsiId).HasColumnName("MAL_CINSI_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MalNiteligi).HasColumnName("MAL_NITELIGI");

            Property(e => e.MalNiteligiAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAL_NITELIGI_ADI");

            Property(e => e.MalSatisFiyati).HasColumnName("MAL_SATIS_FIYATI");

            Property(e => e.MalUretimBeldeAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAL_URETIM_BELDE_ADI");

            Property(e => e.MalUretimBeldeId).HasColumnName("MAL_URETIM_BELDE_ID");

            Property(e => e.MalUretimIlAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAL_URETIM_IL_ADI");

            Property(e => e.MalUretimIlId).HasColumnName("MAL_URETIM_IL_ID");

            Property(e => e.MalUretimIlceAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAL_URETIM_ILCE_ADI");

            Property(e => e.MalUretimIlceId).HasColumnName("MAL_URETIM_ILCE_ID");

            Property(e => e.MalUretimSekli).HasColumnName("MAL_URETIM_SEKLI");

            Property(e => e.MalUretimSekliAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAL_URETIM_SEKLI_ADI");

            Property(e => e.ReferansKunyeId).HasColumnName("REFERANS_KUNYE_ID");

            Property(e => e.ReferansKunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REFERANS_KUNYE_NO")
                .IsFixedLength();

            Property(e => e.SatisKunyeId).HasColumnName("SATIS_KUNYE_ID");

            Property(e => e.SatisKunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_KUNYE_NO")
                .IsFixedLength();

            Property(e => e.TakipId).HasColumnName("TAKIP_ID");

            Property(e => e.TakipNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAKIP_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
