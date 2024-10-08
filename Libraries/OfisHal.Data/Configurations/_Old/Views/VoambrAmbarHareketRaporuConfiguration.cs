using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrAmbarHareketRaporuConfiguration : EntityTypeConfiguration<VoambrAmbarHareketRaporu>
    {
        public VoambrAmbarHareketRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_AMBAR_HAREKET_RAPORU");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.Ambar)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMBAR");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_TARIHI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Toplam).HasColumnName("TOPLAM");
        }
    }
}
