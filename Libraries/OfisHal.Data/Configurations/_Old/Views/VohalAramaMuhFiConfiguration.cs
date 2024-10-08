using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaMuhFiConfiguration : EntityTypeConfiguration<VohalAramaMuhFi>
    {
        public VohalAramaMuhFiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_MUH_FIS");

            Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIS_NO")
                .IsFixedLength();

            Property(e => e.FisTuru)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FIS_TURU");

            Property(e => e.Hakkinda)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HAKKINDA");

            Property(e => e.Konu).HasColumnName("KONU");

            Property(e => e.MuhFisId).HasColumnName("MUH_FIS_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.YevmiyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YEVMIYE_NO")
                .IsFixedLength();
        }
    }
}
