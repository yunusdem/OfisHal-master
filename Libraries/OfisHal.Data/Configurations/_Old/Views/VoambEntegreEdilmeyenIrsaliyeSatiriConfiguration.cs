using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambEntegreEdilmeyenIrsaliyeSatiriConfiguration : EntityTypeConfiguration<VoambEntegreEdilmeyenIrsaliyeSatiri>
    {
        public VoambEntegreEdilmeyenIrsaliyeSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_ENTEGRE_EDILMEYEN_IRSALIYE_SATIRI");

            Property(e => e.IrsaliyeSatiriId).HasColumnName("IRSALIYE_SATIRI_ID");

            Property(e => e.IrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_TARIHI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
