using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrAmbarListeDokumuConfiguration : EntityTypeConfiguration<VoambrAmbarListeDokumu>
    {
        public VoambrAmbarListeDokumuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_AMBAR_LISTE_DOKUMU");

            Property(e => e.GonderenAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GONDEREN_AD");

            Property(e => e.GonderenKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GONDEREN_KOD")
                .IsFixedLength();

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_TARIHI");

            Property(e => e.IstasyonAd)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ISTASYON_AD");

            Property(e => e.IstasyonKod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISTASYON_KOD")
                .IsFixedLength();

            Property(e => e.Kap).HasColumnName("KAP");

            Property(e => e.Mal)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL");

            Property(e => e.PlakaNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.YazihaneAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_AD");

            Property(e => e.YazihaneKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_KOD")
                .IsFixedLength();
        }
    }
}
