using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaOdenmeyenSatisFaturasiConfiguration : EntityTypeConfiguration<VohalAramaOdenmeyenSatisFaturasi>
    {
        public VohalAramaOdenmeyenSatisFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_ODENMEYEN_SATIS_FATURASI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaToplami).HasColumnName("FATURA_TOPLAMI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
