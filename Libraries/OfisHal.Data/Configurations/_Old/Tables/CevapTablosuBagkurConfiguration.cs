using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class CevapTablosuBagkurConfiguration : EntityTypeConfiguration<CevapTablosuBagkur>
    {
        public CevapTablosuBagkurConfiguration()
        {
            HasKey(e => new { e.Guid, e.SatirNo });

            ToTable("CEVAP_TABLOSU_BAGKUR");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Cevap)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("CEVAP");

            Property(e => e.HataKodu).HasColumnName("HATA_KODU");

            Property(e => e.HataMesaji)
                .HasMaxLength(2000)
                .HasColumnName("HATA_MESAJI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
        }
    }
}
