using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalEIrsaliyeOrderConfiguration : EntityTypeConfiguration<VohalEIrsaliyeOrder>
    {
        public VohalEIrsaliyeOrderConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_E_IRSALIYE_Order");

            Property(e => e.DepoFisiId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("DEPO_FISI_ID");

            Property(e => e.Id)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ID");

            Property(e => e.IssueDate).HasColumnType("datetime");

            Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");
        }
    }
}
