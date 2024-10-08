using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalIskeleObSatiriConfiguration : EntityTypeConfiguration<TohalIskeleObSatiri>
    {
        public TohalIskeleObSatiriConfiguration()
        {
            HasKey(x => x.Id);

            ToTable("TOHAL_ISKELE_OB_SATIRI");

            Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.BankaId).HasColumnName("BANKA_ID");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.OdemeAraciId).HasColumnName("ODEME_ARACI_ID");

            Property(e => e.OdemeAraciNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_NO");

            Property(e => e.OdemeAraciSahibi).HasColumnName("ODEME_ARACI_SAHIBI");

            Property(e => e.OdemeAraciTuru).HasColumnName("ODEME_ARACI_TURU");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Id).HasColumnName("ID");

            Property(e => e.VadeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VADE_TARIHI");
        }
    }
}
