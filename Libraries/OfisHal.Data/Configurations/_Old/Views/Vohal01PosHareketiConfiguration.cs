using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal01PosHareketiConfiguration : EntityTypeConfiguration<Vohal01PosHareketi>
    {
        public Vohal01PosHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_01_POS_HAREKETI");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(301)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.HareketTipi).HasColumnName("HAREKET_TIPI");

            Property(e => e.IslemAdi)
                .IsRequired()
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ISLEM_ADI");

            Property(e => e.IslemKodu)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ISLEM_KODU");

            Property(e => e.IslemTipi).HasColumnName("ISLEM_TIPI");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.PosCihaziId).HasColumnName("POS_CIHAZI_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
