using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalAramaRehinHesabiOlmayanMusterilerConfiguration : EntityTypeConfiguration<VohalAramaRehinHesabiOlmayanMusteriler>
    {
        public VohalAramaRehinHesabiOlmayanMusterilerConfiguration()
        {
            HasKey(e => e.CariKartId);
            //HasNoKey();

            ToTable("VOHAL_ARAMA_REHIN_HESABI_OLMAYAN_MUSTERILER");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
