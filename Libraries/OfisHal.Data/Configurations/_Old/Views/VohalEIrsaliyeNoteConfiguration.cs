using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalEIrsaliyeNoteConfiguration : EntityTypeConfiguration<VohalEIrsaliyeNote>
    {
        public VohalEIrsaliyeNoteConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_E_IRSALIYE_NOTE");

            Property(e => e.DepoFisiId).HasColumnName("DEPO_FISI_ID");

            Property(e => e.Notes).HasMaxLength(1024);

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");
        }
    }
}
