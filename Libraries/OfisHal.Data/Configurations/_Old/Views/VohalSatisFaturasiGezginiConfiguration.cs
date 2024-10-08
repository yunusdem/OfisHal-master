using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalSatisFaturasiGezginiConfiguration : EntityTypeConfiguration<VohalSatisFaturasiGezgini>
    {
        public VohalSatisFaturasiGezginiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_SATIS_FATURASI_GEZGINI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.FaturaId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.Guid)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
