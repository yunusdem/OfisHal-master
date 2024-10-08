using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalIskeleEvrakMasrafiConfiguration : EntityTypeConfiguration<TohalIskeleEvrakMasrafi>
    {
        public TohalIskeleEvrakMasrafiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_ISKELE_EVRAK_MASRAFI");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.KapFiyati).HasColumnName("KAP_FIYATI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KesintiOrani).HasColumnName("KESINTI_ORANI");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.Muhatap).HasColumnName("MUHATAP");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");
        }
    }
}
