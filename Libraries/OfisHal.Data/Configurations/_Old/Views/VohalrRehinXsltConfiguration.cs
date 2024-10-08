using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrRehinXsltConfiguration : EntityTypeConfiguration<VohalrRehinXslt>
    {
        public VohalrRehinXsltConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_REHIN_XSLT");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.FiyatKurusSayisi).HasColumnName("FIYAT_KURUS_SAYISI");

            Property(e => e.KapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MustasilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTASIL_ADI");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
