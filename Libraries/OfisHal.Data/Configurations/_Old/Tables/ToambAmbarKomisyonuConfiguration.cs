using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class ToambAmbarKomisyonuConfiguration : EntityTypeConfiguration<ToambAmbarKomisyonu>
    {
        public ToambAmbarKomisyonuConfiguration()
        {
            HasKey(e => new { e.SatirNo, e.IrsaliyeId, e.AmbarId });

            ToTable("TOAMB_AMBAR_KOMISYONU");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarId).HasColumnName("AMBAR_ID");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            HasRequired(d => d.Ambar)
                .WithMany()
                .HasForeignKey(d => d.AmbarId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Irsaliye)
                .WithMany()
                .HasForeignKey(d => d.IrsaliyeId)
                .WillCascadeOnDelete(false);
        }
    }
}
