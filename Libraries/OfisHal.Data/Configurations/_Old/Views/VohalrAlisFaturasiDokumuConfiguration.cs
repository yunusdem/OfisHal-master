using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrAlisFaturasiDokumuConfiguration : EntityTypeConfiguration<VohalrAlisFaturasiDokumu>
    {
        public VohalrAlisFaturasiDokumuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ALIS_FATURASI_DOKUMU");

            Property(e => e.Degistirildi).HasColumnName("DEGISTIRILDI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaToplami).HasColumnName("FATURA_TOPLAMI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.MasrafTutari).HasColumnName("MASRAF_TUTARI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.Veresiye).HasColumnName("VERESIYE");
        }
    }
}
