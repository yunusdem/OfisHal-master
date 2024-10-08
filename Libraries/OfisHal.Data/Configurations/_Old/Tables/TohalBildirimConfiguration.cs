using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalBildirimConfiguration : EntityTypeConfiguration<TohalBildirim>
    {
        public TohalBildirimConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_BILDIRIM");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.DonenAlanDegeri)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DONEN_ALAN_DEGERI");

            Property(e => e.Durumu).HasColumnName("DURUMU");

            Property(e => e.EvrakId).HasColumnName("EVRAK_ID");
        }
    }
}
