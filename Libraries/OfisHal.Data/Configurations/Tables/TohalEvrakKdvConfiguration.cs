using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class TohalEvrakKdvConfiguration : EntityTypeConfiguration<TohalEvrakKdv>
    {
        public TohalEvrakKdvConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.Matrah);

            ToTable("TOHAL_EVRAK_KDV");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvTahakkuku).HasColumnName("KDV_TAHAKKUKU");

            Property(e => e.KdvTevkifatPaydasi).HasColumnName("KDV_TEVKIFAT_PAYDASI");

            Property(e => e.KdvTevkifatPayi).HasColumnName("KDV_TEVKIFAT_PAYI");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.KdvTevkifati).HasColumnName("KDV_TEVKIFATI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Matrah).HasColumnName("MATRAH");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.Oran).HasColumnName("ORAN");

            Property(e => e.SevkIrsaliyesiId).HasColumnName("SEVK_IRSALIYESI_ID");

            HasOptional(d => d.Fatura)
                .WithMany()
                .HasForeignKey(d => d.FaturaId);

            HasOptional(d => d.Makbuz)
                .WithMany()
                .HasForeignKey(d => d.MakbuzId);

            HasOptional(d => d.NavlunFaturasi)
                .WithMany()
                .HasForeignKey(d => d.NavlunFaturasiId);

            HasOptional(d => d.SevkIrsaliyesi)
                .WithMany()
                .HasForeignKey(d => d.SevkIrsaliyesiId);
        }
    }
}
