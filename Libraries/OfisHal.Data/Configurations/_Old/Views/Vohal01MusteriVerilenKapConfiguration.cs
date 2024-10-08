using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal01MusteriVerilenKapConfiguration : EntityTypeConfiguration<Vohal01MusteriVerilenKap>
    {
        public Vohal01MusteriVerilenKapConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_01_MUSTERI_VERILEN_KAP");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
