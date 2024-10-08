using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class ToambSevkIrsaliyesiSatiriConfiguration : EntityTypeConfiguration<ToambSevkIrsaliyesiSatiri>
    {
        public ToambSevkIrsaliyesiSatiriConfiguration()
        {
            HasKey(e => e.IrsaliyeSatiriId);

            ToTable("TOAMB_SEVK_IRSALIYESI_SATIRI");

            Property(e => e.IrsaliyeSatiriId).HasColumnName("IRSALIYE_SATIRI_ID");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarFiyatiId).HasColumnName("AMBAR_FIYATI_ID");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.HammaliyeFiyati).HasColumnName("HAMMALIYE_FIYATI");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

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

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.YazihaneId).HasColumnName("YAZIHANE_ID");

            HasOptional(d => d.AmbarFiyati)
                .WithMany(p => p.ToambSevkIrsaliyesiSatiris)
                .HasForeignKey(d => d.AmbarFiyatiId);

            HasOptional(d => d.Dizayn)
                .WithMany(p => p.ToambSevkIrsaliyesiSatiriDizayns)
                .HasForeignKey(d => d.DizaynId);

            HasOptional(d => d.Gonderen)
                .WithMany(p => p.ToambSevkIrsaliyesiSatiriGonderens)
                .HasForeignKey(d => d.GonderenId);

            HasRequired(d => d.Irsaliye)
                .WithMany(p => p.ToambSevkIrsaliyesiSatiris)
                .HasForeignKey(d => d.IrsaliyeId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Kap)
                .WithMany(p => p.ToambSevkIrsaliyesiSatiris)
                .HasForeignKey(d => d.KapId);

            HasRequired(d => d.Mal)
                .WithMany(p => p.ToambSevkIrsaliyesiSatiris)
                .HasForeignKey(d => d.MalId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.MuameleDizayn)
                .WithMany(p => p.ToambSevkIrsaliyesiSatiriMuameleDizayns)
                .HasForeignKey(d => d.MuameleDizaynId);

            HasOptional(d => d.PrimSahibi)
                .WithMany(p => p.ToambSevkIrsaliyesiSatiriPrimSahibis)
                .HasForeignKey(d => d.PrimSahibiId);

            HasRequired(d => d.Yazihane)
                .WithMany(p => p.ToambSevkIrsaliyesiSatiriYazihanes)
                .HasForeignKey(d => d.YazihaneId)
                .WillCascadeOnDelete(false);
        }
    }
}
