using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaKunyesiAlinamayanlarConfiguration : EntityTypeConfiguration<VohalAramaKunyesiAlinamayanlar>
    {
        public VohalAramaKunyesiAlinamayanlarConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_KUNYESI_ALINAMAYANLAR");

            Property(e => e.EvrakId).HasColumnName("EVRAK_ID");

            Property(e => e.EvrakNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EVRAK_NO")
                .IsFixedLength();

            Property(e => e.EvrakTuru)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("EVRAK_TURU");

            Property(e => e.IslemTuru)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ISLEM_TURU");

            Property(e => e.IstekZamani)
                .HasColumnType("datetime")
                .HasColumnName("ISTEK_ZAMANI");
        }
    }
}
