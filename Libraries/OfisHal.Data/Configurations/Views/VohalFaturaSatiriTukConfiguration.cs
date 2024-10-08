using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalFaturaSatiriTukConfiguration : EntityTypeConfiguration<VohalFaturaSatiriTuk>
    {
        public VohalFaturaSatiriTukConfiguration()
        {
            HasKey(e => e.FaturaSatiriId);
            //HasNoKey();

            ToTable("VOHAL_FATURA_SATIRI_TUK");

            Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AlisFatSatId).HasColumnName("ALIS_FAT_SAT_ID");

            Property(e => e.AmbalajMarkasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMBALAJ_MARKASI");

            Property(e => e.AmbalajTipiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMBALAJ_TIPI_KODU")
                .IsFixedLength();

            Property(e => e.BirimDara).HasColumnName("BIRIM_DARA");

            Property(e => e.CariAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CiroPrimi).HasColumnName("CIRO_PRIMI");

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.Darali).HasColumnName("DARALI");

            Property(e => e.DigerMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIGER_MAL_ADI");

            Property(e => e.EFaturaUneceKisaltma)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_UNECE_KISALTMA");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.FisSatiriId).HasColumnName("FIS_SATIRI_ID");

            Property(e => e.FiyatListesiId).HasColumnName("FIYAT_LISTESI_ID");

            Property(e => e.GtipNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GTIP_NO")
                .IsFixedLength();

            Property(e => e.Guid)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");

            Property(e => e.HalKomisyoncusu).HasColumnName("HAL_KOMISYONCUSU");

            Property(e => e.IadeliKap).HasColumnName("IADELI_KAP");

            Property(e => e.Iskonto).HasColumnName("ISKONTO");

            Property(e => e.IskontoHesaplanmasin).HasColumnName("ISKONTO_HESAPLANMASIN");

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.IskontoPayi).HasColumnName("ISKONTO_PAYI");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapFiyati).HasColumnName("KAP_FIYATI");

            Property(e => e.KapIcindekiMalMiktari).HasColumnName("KAP_ICINDEKI_MAL_MIKTARI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvTevkifatPaydasi).HasColumnName("KDV_TEVKIFAT_PAYDASI");

            Property(e => e.KdvTevkifatPayi).HasColumnName("KDV_TEVKIFAT_PAYI");

            Property(e => e.KdvTevkifatTanimiAciklamasi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KDV_TEVKIFAT_TANIMI_ACIKLAMASI");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.KdvTevkifatUygulamaAltSiniri).HasColumnName("KDV_TEVKIFAT_UYGULAMA_ALT_SINIRI");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.KunyeMiktari).HasColumnName("KUNYE_MIKTARI");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalBirimi)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("MAL_BIRIMI");

            Property(e => e.MalFiyati).HasColumnName("MAL_FIYATI");

            Property(e => e.MalHksId).HasColumnName("MAL_HKS_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKapFiyati).HasColumnName("MAL_KAP_FIYATI");

            Property(e => e.MalKdvOrani).HasColumnName("MAL_KDV_ORANI");

            Property(e => e.MalKdvTevkifatTanimiId).HasColumnName("MAL_KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MalOrtalamaKilo).HasColumnName("MAL_ORTALAMA_KILO");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.MustahsilAdiVkn)
                .IsRequired()
                .HasMaxLength(227)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI_VKN");

            Property(e => e.RehinKabiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REHIN_KABI_ADI");

            Property(e => e.RehinKabiId).HasColumnName("REHIN_KABI_ID");

            Property(e => e.RehinKabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REHIN_KABI_KODU")
                .IsFixedLength();

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumAlinmasin).HasColumnName("RUSUM_ALINMASIN");

            Property(e => e.RusumHesaplanmasin).HasColumnName("RUSUM_HESAPLANMASIN");

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisKunyeId).HasColumnName("SATIS_KUNYE_ID");

            Property(e => e.SatisKunyeSayisi).HasColumnName("SATIS_KUNYE_SAYISI");

            Property(e => e.SatisKunyesi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_KUNYESI")
                .IsFixedLength();

            Property(e => e.SatisTipi).HasColumnName("SATIS_TIPI");

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            Property(e => e.StokKunyeSayisi).HasColumnName("STOK_KUNYE_SAYISI");

            Property(e => e.StokKunyesi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYESI")
                .IsFixedLength();

            Property(e => e.StokKunyesiFiyati).HasColumnName("STOK_KUNYESI_FIYATI");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.TutarHesaplanmasin).HasColumnName("TUTAR_HESAPLANMASIN");

            Property(e => e.UretimSekli).HasColumnName("URETIM_SEKLI");

            Property(e => e.Yukleme).HasColumnName("YUKLEME");
        }
    }
}
