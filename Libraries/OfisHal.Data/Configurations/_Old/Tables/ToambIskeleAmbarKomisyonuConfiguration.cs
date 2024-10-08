using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class ToambIskeleAmbarKomisyonuConfiguration : EntityTypeConfiguration<ToambIskeleAmbarKomisyonu>
    {
        public ToambIskeleAmbarKomisyonuConfiguration()
        {
            //HasNoKey();

            ToTable("TOAMB_ISKELE_AMBAR_KOMISYONU");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarId).HasColumnName("AMBAR_ID");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");
        }
    }
}
