using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalVeriAlmaSablonSatiriConfiguration : EntityTypeConfiguration<TohalVeriAlmaSablonSatiri>
    {
        public TohalVeriAlmaSablonSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_VERI_ALMA_SABLON_SATIRI");

            Property(e => e.HedefAlanTipi).HasColumnName("HEDEF_ALAN_TIPI");

            Property(e => e.KaynakKolonNo).HasColumnName("KAYNAK_KOLON_NO");

            Property(e => e.SablonId).HasColumnName("SABLON_ID");

            HasRequired(d => d.Sablon)
                .WithMany()
                .HasForeignKey(d => d.SablonId)
                .WillCascadeOnDelete(false);
        }
    }
}
