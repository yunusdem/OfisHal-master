using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaMalKabulConfiguration : EntityTypeConfiguration<VohalAramaMalKabul>
    {
        public VohalAramaMalKabulConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_MAL_KABUL");

            Property(e => e.FisId).HasColumnName("FIS_ID");

            Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIS_NO")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
