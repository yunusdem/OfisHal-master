using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambSevkIrsaliyesiSatiriConfiguration : EntityTypeConfiguration<VoambSevkIrsaliyesiSatiri>
    {
        public VoambSevkIrsaliyesiSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_SEVK_IRSALIYESI_SATIRI");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarFiyatiId).HasColumnName("AMBAR_FIYATI_ID");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.DizaynAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIZAYN_ADI");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.FaturaNo).HasColumnName("FATURA_NO");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.FiyatListesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FIYAT_LISTESI");

            Property(e => e.Gonderen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GONDEREN");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.GonderenKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GONDEREN_KODU")
                .IsFixedLength();

            Property(e => e.HammaliyeFaturasiId).HasColumnName("HAMMALIYE_FATURASI_ID");

            Property(e => e.HammaliyeFiyati).HasColumnName("HAMMALIYE_FIYATI");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IrsaliyeSatiriId).HasColumnName("IRSALIYE_SATIRI_ID");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
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

            Property(e => e.MuameleBirimFiyat).HasColumnName("MUAMELE_BIRIM_FIYAT");

            Property(e => e.MuameleDahil).HasColumnName("MUAMELE_DAHIL");

            Property(e => e.MuameleDizaynAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUAMELE_DIZAYN_ADI");

            Property(e => e.MuameleDizaynId).HasColumnName("MUAMELE_DIZAYN_ID");

            Property(e => e.MuameleKdv).HasColumnName("MUAMELE_KDV");

            Property(e => e.MuameleKdvOrani).HasColumnName("MUAMELE_KDV_ORANI");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.NavlunIrsaliyeId).HasColumnName("NAVLUN_IRSALIYE_ID");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.PrimSahibi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PRIM_SAHIBI");

            Property(e => e.PrimSahibiId).HasColumnName("PRIM_SAHIBI_ID");

            Property(e => e.PrimSahibiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRIM_SAHIBI_KODU")
                .IsFixedLength();

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.Yazihane)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE");

            Property(e => e.YazihaneId).HasColumnName("YAZIHANE_ID");

            Property(e => e.YazihaneKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_KODU")
                .IsFixedLength();
        }
    }
}
