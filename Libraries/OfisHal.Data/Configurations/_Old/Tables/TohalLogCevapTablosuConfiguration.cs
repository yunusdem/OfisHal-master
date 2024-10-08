using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogCevapTablosuConfiguration : EntityTypeConfiguration<TohalLogCevapTablosu>
    {
        public TohalLogCevapTablosuConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_CEVAP_TABLOSU");

            Property(e => e.DonenAlanAdi)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("DONEN_ALAN_ADI");

            Property(e => e.DonenAlanDegeri)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("DONEN_ALAN_DEGERI");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.HataKodu).HasColumnName("HATA_KODU");

            Property(e => e.HataMesaji)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("HATA_MESAJI");

            Property(e => e.SatirId).HasColumnName("SATIR_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");
        }
    }
}
