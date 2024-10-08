using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class ToambNavlunFaturaSatiriConfiguration : EntityTypeConfiguration<ToambNavlunFaturaSatiri>
    {
        public ToambNavlunFaturaSatiriConfiguration()
        {
            HasKey(e => e.NavlunFaturaSatiriId);

            ToTable("TOAMB_NAVLUN_FATURA_SATIRI");

            Property(e => e.NavlunFaturaSatiriId).HasColumnName("NAVLUN_FATURA_SATIRI_ID");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.IrsaliyeSatiriId).HasColumnName("IRSALIYE_SATIRI_ID");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

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

            HasOptional(d => d.GeldigiYer)
                .WithMany(p => p.ToambNavlunFaturaSatiris)
                .HasForeignKey(d => d.GeldigiYerId);

            HasOptional(d => d.Gonderen)
                .WithMany(p => p.ToambNavlunFaturaSatiris)
                .HasForeignKey(d => d.GonderenId);

            HasOptional(d => d.IrsaliyeSatiri)
                .WithMany(p => p.ToambNavlunFaturaSatiris)
                .HasForeignKey(d => d.IrsaliyeSatiriId);

            HasOptional(d => d.Kap)
                .WithMany(p => p.ToambNavlunFaturaSatiris)
                .HasForeignKey(d => d.KapId);

            HasRequired(d => d.Mal)
                .WithMany(p => p.ToambNavlunFaturaSatiris)
                .HasForeignKey(d => d.MalId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.NavlunFaturasi)
                .WithMany(p => p.ToambNavlunFaturaSatiris)
                .HasForeignKey(d => d.NavlunFaturasiId)
                .WillCascadeOnDelete(false);
        }
    }
}
