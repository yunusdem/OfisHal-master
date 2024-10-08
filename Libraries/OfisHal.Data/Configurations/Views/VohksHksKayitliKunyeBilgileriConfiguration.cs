using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohksHksKayitliKunyeBilgileriConfiguration : EntityTypeConfiguration<VohksHksKayitliKunyeBilgileri>
    {
        public VohksHksKayitliKunyeBilgileriConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.KunyeNo);
            ToTable("VOHKS_HKS_KAYITLI_KUNYE_BILGILERI");

            Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO")
                .IsFixedLength();

            Property(e => e.BildirimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BILDIRIM_TARIHI");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.BildirimciAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_ADI");

            Property(e => e.BildirimciId).HasColumnName("BILDIRIMCI_ID");

            Property(e => e.BildirimciVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_VERGI_NO")
                .IsFixedLength();

            Property(e => e.GidecekIsyeriId).HasColumnName("GIDECEK_ISYERI_ID");

            Property(e => e.HksMalId).HasColumnName("HKS_MAL_ID");

            Property(e => e.HksMalinAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HKS_MALIN_ADI");

            Property(e => e.IslemeAlinmaZamani)
                .HasColumnType("datetime")
                .HasColumnName("ISLEME_ALINMA_ZAMANI");

            Property(e => e.KalanMiktar).HasColumnName("KALAN_MIKTAR");

            Property(e => e.KapKalanMiktar).HasColumnName("KAP_KALAN_MIKTAR");

            Property(e => e.KiloKalanMiktar).HasColumnName("KILO_KALAN_MIKTAR");

            Property(e => e.KunyeId).HasColumnName("KUNYE_ID");

            Property(e => e.KunyeKayitli).HasColumnName("KUNYE_KAYITLI");

            Property(e => e.KunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE_NO")
                .IsFixedLength();

            Property(e => e.MalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.MalinCinsKodNo).HasColumnName("MALIN_CINS_KOD_NO");

            Property(e => e.MalinCinsi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MALIN_CINSI");

            Property(e => e.MalinMiktari).HasColumnName("MALIN_MIKTARI");

            Property(e => e.MalinSahibiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_SAHIBI_ADI");

            Property(e => e.MalinSahibiId).HasColumnName("MALIN_SAHIBI_ID");

            Property(e => e.MalinSahibiVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MALIN_SAHIBI_VERGI_NO")
                .IsFixedLength();

            Property(e => e.MalinSatisFiyati).HasColumnName("MALIN_SATIS_FIYATI");

            Property(e => e.MalinTuru)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MALIN_TURU");

            Property(e => e.MalinTuruKodNo).HasColumnName("MALIN_TURU_KOD_NO");

            Property(e => e.MiktarBirimId).HasColumnName("MIKTAR_BIRIM_ID");

            Property(e => e.MiktarBirimiAd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MIKTAR_BIRIMI_AD")
                .IsFixedLength();

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.RusumMiktari).HasColumnName("RUSUM_MIKTARI");

            Property(e => e.Sifat).HasColumnName("SIFAT");

            Property(e => e.StokHareketiVar).HasColumnName("STOK_HAREKETI_VAR");

            Property(e => e.TeslimatYeri)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TESLIMAT_YERI");

            Property(e => e.TeslimatYeriId).HasColumnName("TESLIMAT_YERI_ID");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.UreticiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URETICI_ADI");

            Property(e => e.UreticiId).HasColumnName("URETICI_ID");

            Property(e => e.UreticiVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("URETICI_VERGI_NO")
                .IsFixedLength();
        }
    }
}
