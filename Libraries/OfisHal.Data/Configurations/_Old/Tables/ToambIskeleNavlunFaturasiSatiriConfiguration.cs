using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class ToambIskeleNavlunFaturasiSatiriConfiguration : EntityTypeConfiguration<ToambIskeleNavlunFaturasiSatiri>
    {
        public ToambIskeleNavlunFaturasiSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("TOAMB_ISKELE_NAVLUN_FATURASI_SATIRI");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.IrsaliyeSatiriId).HasColumnName("IRSALIYE_SATIRI_ID");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MuameleDahil).HasColumnName("MUAMELE_DAHIL");

            Property(e => e.MuameleFiyati).HasColumnName("MUAMELE_FIYATI");

            Property(e => e.MuameleKdv).HasColumnName("MUAMELE_KDV");

            Property(e => e.MuameleKdvOrani).HasColumnName("MUAMELE_KDV_ORANI");

            Property(e => e.MuameleTutar).HasColumnName("MUAMELE_TUTAR");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.NavlunFiyati).HasColumnName("NAVLUN_FIYATI");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.NavlunTutar).HasColumnName("NAVLUN_TUTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");
        }
    }
}
