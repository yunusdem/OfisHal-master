using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalOdemeAraciConfiguration : EntityTypeConfiguration<TohalOdemeAraci>
    {
        public TohalOdemeAraciConfiguration()
        {
            HasKey(e => e.OdemeAraciId);

            ToTable("TOHAL_ODEME_ARACI");

            HasIndex(e => new { e.OdemeAraciNo, e.Tur })
                .IsUnique();

            Property(e => e.OdemeAraciId).HasColumnName("ODEME_ARACI_ID");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.BankaId).HasColumnName("BANKA_ID");

            Property(e => e.BaskasinaAit).HasColumnName("BASKASINA_AIT");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.OdemeAraciNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.VadeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VADE_TARIHI");

            HasOptional(d => d.BankaHesabi)
                .WithMany(p => p.TohalOdemeAracis)
                .HasForeignKey(d => d.BankaHesabiId);

            HasOptional(d => d.Banka)
                .WithMany(p => p.TohalOdemeAracis)
                .HasForeignKey(d => d.BankaId);
        }
    }
}
