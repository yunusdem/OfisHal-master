using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class TohalIskeleRehinFisiConfiguration : EntityTypeConfiguration<TohalIskeleRehinFisi>
    {
        public TohalIskeleRehinFisiConfiguration()
        {
            HasKey(e => e.SatirGuid);
            //HasNoKey();

            ToTable("TOHAL_ISKELE_REHIN_FISI");

            Property(e => e.ElleDegistirildi).HasColumnName("ELLE_DEGISTIRILDI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.SatirGuid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SATIR_GUID");

            Property(e => e.SatirId).HasColumnName("SATIR_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
