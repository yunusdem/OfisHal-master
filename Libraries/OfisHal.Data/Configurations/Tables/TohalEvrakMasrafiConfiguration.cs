using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class TohalEvrakMasrafiConfiguration : EntityTypeConfiguration<TohalEvrakMasrafi>
    {
        public TohalEvrakMasrafiConfiguration()
        {
            //HasNoKey();

            HasKey(e => new { e.HesapId, e.SatirNo });

            ToTable("TOHAL_EVRAK_MASRAFI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.KapFiyati).HasColumnName("KAP_FIYATI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KesintiOrani).HasColumnName("KESINTI_ORANI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.Muhatap).HasColumnName("MUHATAP");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            HasOptional(d => d.Fatura)
                .WithMany()
                .HasForeignKey(d => d.FaturaId);

            HasRequired(d => d.Hesap)
                .WithMany()
                .HasForeignKey(d => d.HesapId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Irsaliye)
                .WithMany()
                .HasForeignKey(d => d.IrsaliyeId);

            HasOptional(d => d.Kap)
                .WithMany()
                .HasForeignKey(d => d.KapId);

            HasOptional(d => d.Makbuz)
                .WithMany()
                .HasForeignKey(d => d.MakbuzId);

            HasOptional(d => d.Siparis)
                .WithMany()
                .HasForeignKey(d => d.SiparisId);
        }
    }
}
