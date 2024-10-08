using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrAmbarEkstreConfiguration : EntityTypeConfiguration<VoambrAmbarEkstre>
    {
        public VoambrAmbarEkstreConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_AMBAR_EKSTRE");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Alacak).HasColumnName("ALACAK");

            Property(e => e.Borc).HasColumnName("BORC");

            Property(e => e.EvrakNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EVRAK_NO");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TIP");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
