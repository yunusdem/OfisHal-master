using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalAlisTanimlariConfiguration : EntityTypeConfiguration<VohalAlisTanimlari>
    {
        public VohalAlisTanimlariConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.AlsFaturaSiraNo);
            ToTable("VOHAL_ALIS_TANIMLARI");

            Property(e => e.AlsDigerMalKdvOrani).HasColumnName("ALS_DIGER_MAL_KDV_ORANI");

            Property(e => e.AlsFaturaSiraNo).HasColumnName("ALS_FATURA_SIRA_NO");

            Property(e => e.AlsMalBakiyeHesaplamaSekli).HasColumnName("ALS_MAL_BAKIYE_HESAPLAMA_SEKLI");

            Property(e => e.AlsRusumOrani).HasColumnName("ALS_RUSUM_ORANI");

            Property(e => e.AlsSiparisCalismaSekli).HasColumnName("ALS_SIPARIS_CALISMA_SEKLI");
        }
    }
}
