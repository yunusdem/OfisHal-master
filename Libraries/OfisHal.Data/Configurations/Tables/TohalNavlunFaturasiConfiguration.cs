using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalNavlunFaturasiConfiguration : EntityTypeConfiguration<TohalNavlunFaturasi>
    {
        public TohalNavlunFaturasiConfiguration()
        {
            HasKey(e => new { e.HesapHareketiId, e.MakbuzId }, e => e.IsClustered(false));

            ToTable("TOHAL_NAVLUN_FATURASI");

            Property(e => e.HesapHareketiId).HasColumnName("HESAP_HAREKETI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvTevkifatPaydasi).HasColumnName("KDV_TEVKIFAT_PAYDASI");

            Property(e => e.KdvTevkifatPayi).HasColumnName("KDV_TEVKIFAT_PAYI");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.KdvTevkifati).HasColumnName("KDV_TEVKIFATI");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            HasRequired(d => d.HesapHareketi)
                .WithMany(p => p.TohalNavlunFaturasis)
                .HasForeignKey(d => d.HesapHareketiId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.KdvTevkifatTanimi)
                .WithMany(p => p.TohalNavlunFaturasis)
                .HasForeignKey(d => d.KdvTevkifatTanimiId);

            HasRequired(d => d.Makbuz)
                .WithMany(p => p.TohalNavlunFaturasis)
                .HasForeignKey(d => d.MakbuzId)
                .WillCascadeOnDelete(false);
        }
    }
}
