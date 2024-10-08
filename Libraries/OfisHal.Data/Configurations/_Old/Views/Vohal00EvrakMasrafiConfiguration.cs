using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal00EvrakMasrafiConfiguration : EntityTypeConfiguration<Vohal00EvrakMasrafi>
    {
        public Vohal00EvrakMasrafiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_00_EVRAK_MASRAFI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");
        }
    }
}
