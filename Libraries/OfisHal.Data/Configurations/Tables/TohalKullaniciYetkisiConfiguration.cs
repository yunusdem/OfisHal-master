using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalKullaniciYetkisiConfiguration : EntityTypeConfiguration<TohalKullaniciYetkisi>
    {
        public TohalKullaniciYetkisiConfiguration()
        {
            HasKey(e => new { e.KullaniciId, e.YetkiCinsi });

            ToTable("TOHAL_KULLANICI_YETKISI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.YetkiCinsi).HasColumnName("YETKI_CINSI");

            Property(e => e.CalismaBicimi).HasColumnName("CALISMA_BICIMI");

            HasRequired(d => d.Kullanici)
                .WithMany(p => p.TohalKullaniciYetkisis)
                .HasForeignKey(d => d.KullaniciId)
                .WillCascadeOnDelete(false);
        }
    }
}
