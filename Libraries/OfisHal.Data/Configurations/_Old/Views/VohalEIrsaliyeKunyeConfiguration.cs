using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalEIrsaliyeKunyeConfiguration : EntityTypeConfiguration<VohalEIrsaliyeKunye>
    {
        public VohalEIrsaliyeKunyeConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_E_IRSALIYE_KUNYE");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.DepoFisiId).HasColumnName("DEPO_FISI_ID");

            Property(e => e.Id).HasColumnName("ID");

            Property(e => e.KunyeNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE_NO")
                .IsFixedLength();
        }
    }
}
