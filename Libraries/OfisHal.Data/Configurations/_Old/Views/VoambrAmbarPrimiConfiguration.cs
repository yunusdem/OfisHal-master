using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrAmbarPrimiConfiguration : EntityTypeConfiguration<VoambrAmbarPrimi>
    {
        public VoambrAmbarPrimiConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_AMBAR_PRIMI");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.PlakaNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
