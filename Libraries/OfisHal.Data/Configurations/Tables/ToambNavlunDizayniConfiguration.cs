using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class ToambNavlunDizayniConfiguration : EntityTypeConfiguration<ToambNavlunDizayni>
    {
        public ToambNavlunDizayniConfiguration()
        {
            HasKey(e => e.DizaynId);

            ToTable("TOAMB_NAVLUN_DIZAYNI");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.DosyaAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DOSYA_ADI");

            Property(e => e.EArsivFaturasiOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_ARSIV_FATURASI_ON_EKI")
                .IsFixedLength();

            Property(e => e.EArsivFaturasiSiraNo).HasColumnName("E_ARSIV_FATURASI_SIRA_NO");

            Property(e => e.EFaturaOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ON_EKI")
                .IsFixedLength();

            Property(e => e.EFaturaSiraNo).HasColumnName("E_FATURA_SIRA_NO");

            Property(e => e.Numerator).HasColumnName("NUMERATOR");
        }
    }
}
