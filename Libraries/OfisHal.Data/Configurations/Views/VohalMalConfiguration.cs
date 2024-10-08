using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalMalConfiguration : EntityTypeConfiguration<VohalMal>
    {
        public VohalMalConfiguration()
        {
            HasKey(e => e.MalId);
            //HasNoKey();

            ToTable("VOHAL_MAL");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AlisHesapId).HasColumnName("ALIS_HESAP_ID");

            Property(e => e.AlisHesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ALIS_HESAP_KODU")
                .IsFixedLength();

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.DigerAdId).HasColumnName("DIGER_AD_ID");

            Property(e => e.DigerAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIGER_ADI");

            Property(e => e.FaturaBirimi).HasColumnName("FATURA_BIRIMI");

            Property(e => e.GrupNo).HasColumnName("GRUP_NO");

            Property(e => e.GtipNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GTIP_NO")
                .IsFixedLength();

            Property(e => e.HksMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_MAL_ADI");

            Property(e => e.HksMalAdiId).HasColumnName("HKS_MAL_ADI_ID");

            Property(e => e.HksMalCinsi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_MAL_CINSI");

            Property(e => e.HksMalCinsiId).HasColumnName("HKS_MAL_CINSI_ID");

            Property(e => e.HksMalId).HasColumnName("HKS_MAL_ID");

            Property(e => e.HksMalKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HKS_MAL_KODU")
                .IsFixedLength();

            Property(e => e.HksUrunCinsiId).HasColumnName("HKS_URUN_CINSI_ID");

            Property(e => e.KapIcindekiMiktari).HasColumnName("KAP_ICINDEKI_MIKTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvTevkifatPaydasi).HasColumnName("KDV_TEVKIFAT_PAYDASI");

            Property(e => e.KdvTevkifatPayi).HasColumnName("KDV_TEVKIFAT_PAYI");

            Property(e => e.KdvTevkifatTanimiAciklamasi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KDV_TEVKIFAT_TANIMI_ACIKLAMASI");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.KdvTevkifatUygulamaAltSiniri).HasColumnName("KDV_TEVKIFAT_UYGULAMA_ALT_SINIRI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.OrtalamaKilo).HasColumnName("ORTALAMA_KILO");

            Property(e => e.SatisHesapId).HasColumnName("SATIS_HESAP_ID");

            Property(e => e.SatisHesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_HESAP_KODU")
                .IsFixedLength();

            Property(e => e.SonKullanmaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SON_KULLANMA_TARIHI");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.UretimSekli).HasColumnName("URETIM_SEKLI");
        }
    }
}
