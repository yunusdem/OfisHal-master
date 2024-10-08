using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalBankaHesabiConfiguration : EntityTypeConfiguration<VohalBankaHesabi>
    {
        public VohalBankaHesabiConfiguration()
        {
            HasKey(e => e.BankaHesabiId);
            //HasNoKey();

            ToTable("VOHAL_BANKA_HESABI");

            Property(e => e.BankaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BANKA_ADI");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.BankaId).HasColumnName("BANKA_ID");

            Property(e => e.Devir).HasColumnName("DEVIR");

            Property(e => e.EFaturadaGozuksun).HasColumnName("E_FATURADA_GOZUKSUN");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();

            Property(e => e.HesapNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO")
                .IsFixedLength();

            Property(e => e.Iban)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IBAN");

            Property(e => e.MuhHesapId).HasColumnName("MUH_HESAP_ID");

            Property(e => e.SubeAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SUBE_ADI");
        }
    }
}
