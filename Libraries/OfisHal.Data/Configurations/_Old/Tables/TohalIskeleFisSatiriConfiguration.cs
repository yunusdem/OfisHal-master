using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalIskeleFisSatiriConfiguration : EntityTypeConfiguration<TohalIskeleFisSatiri>
    {
        public TohalIskeleFisSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_ISKELE_FIS_SATIRI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.Darali).HasColumnName("DARALI");

            Property(e => e.FisSatiriId).HasColumnName("FIS_SATIRI_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.FiyatFarki).HasColumnName("FIYAT_FARKI");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.PiyasaFiyati).HasColumnName("PIYASA_FIYATI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
