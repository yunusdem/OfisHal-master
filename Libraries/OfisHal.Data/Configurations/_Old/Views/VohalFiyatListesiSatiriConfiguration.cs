using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalFiyatListesiSatiriConfiguration : EntityTypeConfiguration<VohalFiyatListesiSatiri>
    {
        public VohalFiyatListesiSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_FIYAT_LISTESI_SATIRI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.FiyatListesiId).HasColumnName("FIYAT_LISTESI_ID");

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");
        }
    }
}
