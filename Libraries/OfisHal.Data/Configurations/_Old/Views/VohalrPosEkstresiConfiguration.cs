using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrPosEkstresiConfiguration : EntityTypeConfiguration<VohalrPosEkstresi>
    {
        public VohalrPosEkstresiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_POS_EKSTRESI");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(301)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.CihazAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CIHAZ_ADI");

            Property(e => e.CihazKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CIHAZ_KODU")
                .IsFixedLength();

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
