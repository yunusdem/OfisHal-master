using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalIskeleKullanilanKunyeConfiguration : EntityTypeConfiguration<TohalIskeleKullanilanKunye>
    {
        public TohalIskeleKullanilanKunyeConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_ISKELE_KULLANILAN_KUNYE");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.FaturaSatiriNo).HasColumnName("FATURA_SATIRI_NO");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.KunyeSatirId).HasColumnName("KUNYE_SATIR_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisKunyeId).HasColumnName("SATIS_KUNYE_ID");

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");
        }
    }
}
