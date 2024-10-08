using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class IstekTablosuBagkurConfiguration : EntityTypeConfiguration<IstekTablosuBagkur>
    {
        public IstekTablosuBagkurConfiguration()
        {
            HasKey(e => e.Guid);

            ToTable("ISTEK_TABLOSU_BAGKUR");

            Property(e => e.Guid)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
                .HasColumnName("GUID");

            Property(e => e.Durum).HasColumnName("DURUM");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.IslemeAlinmaZamani)
                .HasColumnType("datetime")
                .HasColumnName("ISLEME_ALINMA_ZAMANI");

            Property(e => e.Istek)
                .HasMaxLength(2000)
                .HasColumnName("ISTEK");

            Property(e => e.IstekZamani)
                .HasColumnType("datetime")
                .HasColumnName("ISTEK_ZAMANI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.VeriTabani)
                .HasMaxLength(100)
                .HasColumnName("VERI_TABANI");
        }
    }
}
