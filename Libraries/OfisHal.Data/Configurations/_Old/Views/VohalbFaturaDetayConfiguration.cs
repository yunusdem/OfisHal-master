using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalbFaturaDetayConfiguration : EntityTypeConfiguration<VohalbFaturaDetay>
    {
        public VohalbFaturaDetayConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALB_FATURA_DETAY");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.EFaturaNot)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_NOT");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.Veresiye).HasColumnName("VERESIYE");

            Property(e => e.VeresiyeTahsilEdilen).HasColumnName("VERESIYE_TAHSIL_EDILEN");
        }
    }
}
