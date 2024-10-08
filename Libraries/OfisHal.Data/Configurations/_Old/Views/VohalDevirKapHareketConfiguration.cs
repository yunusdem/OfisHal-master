using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalDevirKapHareketConfiguration : EntityTypeConfiguration<VohalDevirKapHareket>
    {
        public VohalDevirKapHareketConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_DEVIR_KAP_HAREKET");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariTip).HasColumnName("CARI_TIP");

            Property(e => e.KapId).HasColumnName("KAP_ID");
        }
    }
}
