using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalOdenenSatisFaturasiConfiguration : EntityTypeConfiguration<VohalOdenenSatisFaturasi>
    {
        public VohalOdenenSatisFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ODENEN_SATIS_FATURASI");

            Property(e => e.CariHareketId).HasColumnName("CARI_HAREKET_ID");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
