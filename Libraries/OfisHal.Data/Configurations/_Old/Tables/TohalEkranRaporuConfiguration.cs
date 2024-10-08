using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalEkranRaporuConfiguration : EntityTypeConfiguration<TohalEkranRaporu>
    {
        public TohalEkranRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_EKRAN_RAPORU");

            Property(e => e.EkranTuru).HasColumnName("EKRAN_TURU");

            Property(e => e.GorunumAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GORUNUM_ADI");

            Property(e => e.RaporDosyaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RAPOR_DOSYA_ADI");

            Property(e => e.RaporTuru).HasColumnName("RAPOR_TURU");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");
        }
    }
}
