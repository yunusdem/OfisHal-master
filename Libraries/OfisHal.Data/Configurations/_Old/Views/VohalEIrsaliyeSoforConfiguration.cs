using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalEIrsaliyeSoforConfiguration : EntityTypeConfiguration<VohalEIrsaliyeSofor>
    {
        public VohalEIrsaliyeSoforConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_E_IRSALIYE_SOFOR");

            Property(e => e.DepoFisiId).HasColumnName("DEPO_FISI_ID");

            Property(e => e.ShipmentDriverName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Shipment_DriverName");

            Property(e => e.ShipmentDriverNationalityId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Shipment_DriverNationalityID");

            Property(e => e.ShipmentDriverTitle)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Shipment_DriverTitle");
        }
    }
}
