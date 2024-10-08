using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalDokumDefteriBaskiConfiguration : EntityTypeConfiguration<VohalDokumDefteriBaski>
    {
        public VohalDokumDefteriBaskiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_DOKUM_DEFTERI_BASKI");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");
        }
    }
}
