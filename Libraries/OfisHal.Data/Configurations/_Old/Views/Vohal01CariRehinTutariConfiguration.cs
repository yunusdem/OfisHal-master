using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal01CariRehinTutariConfiguration : EntityTypeConfiguration<Vohal01CariRehinTutari>
    {
        public Vohal01CariRehinTutariConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_01_CARI_REHIN_TUTARI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.KesilmeyenDahilRehinTutari).HasColumnName("KESILMEYEN_DAHIL_REHIN_TUTARI");

            Property(e => e.RehinMiktari).HasColumnName("REHIN_MIKTARI");

            Property(e => e.RehinTutari).HasColumnName("REHIN_TUTARI");
        }
    }
}
