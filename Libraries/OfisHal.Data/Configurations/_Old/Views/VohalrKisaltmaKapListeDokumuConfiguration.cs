using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrKisaltmaKapListeDokumuConfiguration : EntityTypeConfiguration<VohalrKisaltmaKapListeDokumu>
    {
        public VohalrKisaltmaKapListeDokumuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_KISALTMA_KAP_LISTE_DOKUMU");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.GrupNoFiyat).HasColumnName("GRUP_NO_FIYAT");

            Property(e => e.Kisaltma)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("KISALTMA");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();
        }
    }
}
