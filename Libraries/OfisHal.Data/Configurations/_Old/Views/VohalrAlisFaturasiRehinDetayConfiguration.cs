using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrAlisFaturasiRehinDetayConfiguration : EntityTypeConfiguration<VohalrAlisFaturasiRehinDetay>
    {
        public VohalrAlisFaturasiRehinDetayConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ALIS_FATURASI_REHIN_DETAY");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Kap)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP")
                .IsFixedLength();

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
