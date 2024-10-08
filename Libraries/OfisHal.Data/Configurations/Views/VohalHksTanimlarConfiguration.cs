using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalHksTanimlarConfiguration : EntityTypeConfiguration<VohalHksTanimlar>
    {
        public VohalHksTanimlarConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.SatBildirimTuru);
            ToTable("VOHAL_HKS_TANIMLAR");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeHksId).HasColumnName("BELDE_HKS_ID");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

            Property(e => e.DigGidecegiYerTipi).HasColumnName("DIG_GIDECEGI_YER_TIPI");

            Property(e => e.DigHksAdetSiniri).HasColumnName("DIG_HKS_ADET_SINIRI");

            Property(e => e.DigHksBildirimSekli).HasColumnName("DIG_HKS_BILDIRIM_SEKLI");

            Property(e => e.DigHksCalismaSekli).HasColumnName("DIG_HKS_CALISMA_SEKLI");

            Property(e => e.DigHksKiloSiniri).HasColumnName("DIG_HKS_KILO_SINIRI");

            Property(e => e.DigHksSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIG_HKS_SIFRESI");

            Property(e => e.DigKunyeBarkoduYazdir).HasColumnName("DIG_KUNYE_BARKODU_YAZDIR");

            Property(e => e.DigKunyeGecerlilikTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DIG_KUNYE_GECERLILIK_TARIHI");

            Property(e => e.DigKunyeTakibiVar).HasColumnName("DIG_KUNYE_TAKIBI_VAR");

            Property(e => e.DigKunyeyiOtomatikGonder).HasColumnName("DIG_KUNYEYI_OTOMATIK_GONDER");

            Property(e => e.DigMarkaninKunyeTakibiVar).HasColumnName("DIG_MARKANIN_KUNYE_TAKIBI_VAR");

            Property(e => e.DigSatinAlaninSifati).HasColumnName("DIG_SATIN_ALANIN_SIFATI");

            Property(e => e.DigSifati).HasColumnName("DIG_SIFATI");

            Property(e => e.DigWebKullanicisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_WEB_KULLANICISI");

            Property(e => e.DigWebSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIG_WEB_SIFRESI");

            Property(e => e.DokBildirimTuru).HasColumnName("DOK_BILDIRIM_TURU");

            Property(e => e.HksBildirimBelediyeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_BILDIRIM_BELEDIYE_ADI");

            Property(e => e.HksDigerKunyeleriKullan).HasColumnName("HKS_DIGER_KUNYELERI_KULLAN");

            Property(e => e.HksKiloKapKarisik).HasColumnName("HKS_KILO_KAP_KARISIK");

            Property(e => e.HksKiloKunyesiOncelikli).HasColumnName("HKS_KILO_KUNYESI_ONCELIKLI");

            Property(e => e.HksKunyeBakiyesiDusmeSekli).HasColumnName("HKS_KUNYE_BAKIYESI_DUSME_SEKLI");

            Property(e => e.HksKunyeSecAcilsin).HasColumnName("HKS_KUNYE_SEC_ACILSIN");

            Property(e => e.HksSatirCogalabilir).HasColumnName("HKS_SATIR_COGALABILIR");

            Property(e => e.HksSatirDetayiVar).HasColumnName("HKS_SATIR_DETAYI_VAR");

            Property(e => e.HksServisAdresi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_SERVIS_ADRESI");

            Property(e => e.HksStokCalismaSekli).HasColumnName("HKS_STOK_CALISMA_SEKLI");

            Property(e => e.HksVarsayilanDegerAtansin).HasColumnName("HKS_VARSAYILAN_DEGER_ATANSIN");

            Property(e => e.HksVarsayilanPlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HKS_VARSAYILAN_PLAKA_NO")
                .IsFixedLength();

            Property(e => e.IlAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL_ADI");

            Property(e => e.IlHksId).HasColumnName("IL_HKS_ID");

            Property(e => e.IlId).HasColumnName("IL_ID");

            Property(e => e.IlceAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE_ADI");

            Property(e => e.IlceHksId).HasColumnName("ILCE_HKS_ID");

            Property(e => e.IlceId).HasColumnName("ILCE_ID");

            Property(e => e.SatBildirimTuru).HasColumnName("SAT_BILDIRIM_TURU");
        }
    }
}
