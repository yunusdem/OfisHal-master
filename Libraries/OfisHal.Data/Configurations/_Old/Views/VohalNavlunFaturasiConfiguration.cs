using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalNavlunFaturasiConfiguration : EntityTypeConfiguration<VohalNavlunFaturasi>
    {
        public VohalNavlunFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_NAVLUN_FATURASI");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.HesapHareketiId).HasColumnName("HESAP_HAREKETI_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvTevkifatPaydasi).HasColumnName("KDV_TEVKIFAT_PAYDASI");

            Property(e => e.KdvTevkifatPayi).HasColumnName("KDV_TEVKIFAT_PAYI");

            Property(e => e.KdvTevkifatTanimiAciklamasi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KDV_TEVKIFAT_TANIMI_ACIKLAMASI");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.KdvTevkifati).HasColumnName("KDV_TEVKIFATI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.MustahsilAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");
        }
    }
}
