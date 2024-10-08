using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalMuhFiConfiguration : EntityTypeConfiguration<VohalMuhFi>
    {
        public VohalMuhFiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_MUH_FIS");

            Property(e => e.DigerDokumanTipiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIGER_DOKUMAN_TIPI_ADI");

            Property(e => e.DigerDokumanTipiId).HasColumnName("DIGER_DOKUMAN_TIPI_ID");

            Property(e => e.DokumanNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUMAN_NO")
                .IsFixedLength();

            Property(e => e.DokumanTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOKUMAN_TARIHI");

            Property(e => e.DokumanTipi).HasColumnName("DOKUMAN_TIPI");

            Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIS_NO")
                .IsFixedLength();

            Property(e => e.Hakkinda)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HAKKINDA");

            Property(e => e.Konu).HasColumnName("KONU");

            Property(e => e.MuhFisId).HasColumnName("MUH_FIS_ID");

            Property(e => e.OdemeSekli).HasColumnName("ODEME_SEKLI");

            Property(e => e.SahipId).HasColumnName("SAHIP_ID");

            Property(e => e.SahipTuru).HasColumnName("SAHIP_TURU");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.YevmiyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YEVMIYE_NO")
                .IsFixedLength();
        }
    }
}
