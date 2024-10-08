using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrKisaltmaMalListeDokumuConfiguration : EntityTypeConfiguration<VohalrKisaltmaMalListeDokumu>
    {
        public VohalrKisaltmaMalListeDokumuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_KISALTMA_MAL_LISTE_DOKUMU");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.GrupNoFiyat).HasColumnName("GRUP_NO_FIYAT");

            Property(e => e.Kisaltma).HasColumnName("KISALTMA");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();
        }
    }
}
