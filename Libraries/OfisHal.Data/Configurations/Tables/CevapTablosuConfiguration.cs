using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class CevapTablosuConfiguration : EntityTypeConfiguration<CevapTablosu>
    {
        public CevapTablosuConfiguration()
        {
            HasKey(e => e.Guid);

            ToTable("CEVAP_TABLOSU");

            HasIndex(e => e.Guid);

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.SatirId).HasColumnName("SATIR_ID");

            Property(e => e.DonenAlanAdi)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("DONEN_ALAN_ADI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.DonenAlanDegeri)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DONEN_ALAN_DEGERI");

            Property(e => e.HataKodu).HasColumnName("HATA_KODU");

            Property(e => e.HataMesaji)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("HATA_MESAJI");
        }
    }
}
