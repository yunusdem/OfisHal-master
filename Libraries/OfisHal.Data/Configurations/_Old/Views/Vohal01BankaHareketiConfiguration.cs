using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal01BankaHareketiConfiguration : EntityTypeConfiguration<Vohal01BankaHareketi>
    {
        public Vohal01BankaHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_01_BANKA_HAREKETI");

            Property(e => e.Aciklama)
                .HasMaxLength(435)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.HareketTipi).HasColumnName("HAREKET_TIPI");

            Property(e => e.IslemAdi)
                .IsRequired()
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("ISLEM_ADI");

            Property(e => e.IslemTipi).HasColumnName("ISLEM_TIPI");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
