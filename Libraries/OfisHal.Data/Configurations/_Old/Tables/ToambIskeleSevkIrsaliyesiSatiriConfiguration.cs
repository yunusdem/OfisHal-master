using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class ToambIskeleSevkIrsaliyesiSatiriConfiguration : EntityTypeConfiguration<ToambIskeleSevkIrsaliyesiSatiri>
    {
        public ToambIskeleSevkIrsaliyesiSatiriConfiguration()
        {
            ToTable("TOAMB_ISKELE_SEVK_IRSALIYESI_SATIRI");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarFiyatiId).HasColumnName("AMBAR_FIYATI_ID");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.HammaliyeFiyati).HasColumnName("HAMMALIYE_FIYATI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MuameleBirimFiyat).HasColumnName("MUAMELE_BIRIM_FIYAT");

            Property(e => e.MuameleDahil).HasColumnName("MUAMELE_DAHIL");

            Property(e => e.MuameleDizaynId).HasColumnName("MUAMELE_DIZAYN_ID");

            Property(e => e.MuameleKdv).HasColumnName("MUAMELE_KDV");

            Property(e => e.MuameleKdvOrani).HasColumnName("MUAMELE_KDV_ORANI");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.PrimSahibiId).HasColumnName("PRIM_SAHIBI_ID");

            Property(e => e.SatirId).HasColumnName("SATIR_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
