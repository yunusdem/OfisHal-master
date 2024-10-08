using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalNumeratorConfiguration : EntityTypeConfiguration<TohalNumerator>
    {
        public TohalNumeratorConfiguration()
        {
            HasKey(e => e.Tur);

            ToTable("TOHAL_NUMERATOR");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.Baslangic).HasColumnName("BASLANGIC");

            Property(e => e.Bitis).HasColumnName("BITIS");

            Property(e => e.Onek)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ONEK")
                .IsFixedLength();

            Property(e => e.OnuneSifirKoy).HasColumnName("ONUNE_SIFIR_KOY");

            Property(e => e.Uzunluk).HasColumnName("UZUNLUK");
        }
    }
}
