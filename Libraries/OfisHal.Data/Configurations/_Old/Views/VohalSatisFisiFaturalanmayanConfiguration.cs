using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalSatisFisiFaturalanmayanConfiguration : EntityTypeConfiguration<VohalSatisFisiFaturalanmayan>
    {
        public VohalSatisFisiFaturalanmayanConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_SATIS_FISI_FATURALANMAYAN");

            Property(e => e.BirimDara).HasColumnName("BIRIM_DARA");

            Property(e => e.CariAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

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

            Property(e => e.FisId).HasColumnName("FIS_ID");

            Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIS_NO")
                .IsFixedLength();

            Property(e => e.HalKomisyoncusu).HasColumnName("HAL_KOMISYONCUSU");

            Property(e => e.IadeliKap).HasColumnName("IADELI_KAP");

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

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

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

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.UretimSekli).HasColumnName("URETIM_SEKLI");
        }
    }
}
