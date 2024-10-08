using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalIskeleNavlunFaturasiConfiguration : EntityTypeConfiguration<TohalIskeleNavlunFaturasi>
    {
        public TohalIskeleNavlunFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_ISKELE_NAVLUN_FATURASI");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvTevkifatPaydasi).HasColumnName("KDV_TEVKIFAT_PAYDASI");

            Property(e => e.KdvTevkifatPayi).HasColumnName("KDV_TEVKIFAT_PAYI");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.KdvTevkifati).HasColumnName("KDV_TEVKIFATI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");
        }
    }
}
