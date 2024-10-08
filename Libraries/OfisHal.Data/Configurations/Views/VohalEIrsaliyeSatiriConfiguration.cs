using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalEIrsaliyeSatiriConfiguration : EntityTypeConfiguration<VohalEIrsaliyeSatiri>
    {
        public VohalEIrsaliyeSatiriConfiguration()
        {
            //HasNoKey();

            HasKey(x => x.Id);

            ToTable("VOHAL_E_IRSALIYE_SATIRI");

            Property(e => e.BuyersItemIdentification)
                .HasMaxLength(200)
                .IsUnicode(false);

            Property(e => e.CurrencyCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            Property(e => e.Dara)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DARA");

            Property(e => e.Darali)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DARALI");

            Property(e => e.DeliveredQuantity)
                .HasMaxLength(15)
                .IsUnicode(false);

            Property(e => e.DeliveredQuantityUnit)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            Property(e => e.DepoFisiId).HasColumnName("DEPO_FISI_ID");

            Property(e => e.Id).HasColumnName("ID");

            Property(e => e.ItemCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();

            Property(e => e.ItemName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            Property(e => e.Kap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KAP");

            Property(e => e.MalHksId).HasColumnName("MAL_HKS_ID");

            Property(e => e.OrderId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OrderID");

            Property(e => e.OrderIssueDate).HasColumnType("datetime");

            Property(e => e.OrderLineId).HasColumnName("OrderLineID");

            Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");
        }
    }
}
