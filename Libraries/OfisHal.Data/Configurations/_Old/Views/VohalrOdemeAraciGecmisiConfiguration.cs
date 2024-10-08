using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrOdemeAraciGecmisiConfiguration : EntityTypeConfiguration<VohalrOdemeAraciGecmisi>
    {
        public VohalrOdemeAraciGecmisiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ODEME_ARACI_GECMISI");

            Property(e => e.BordroNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BORDRO_NO")
                .IsFixedLength();

            Property(e => e.Durumu)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DURUMU");

            Property(e => e.Muhatap)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUHATAP");

            Property(e => e.OdemeAraciId).HasColumnName("ODEME_ARACI_ID");

            Property(e => e.OdemeAraciNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
