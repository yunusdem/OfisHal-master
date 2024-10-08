using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalKullanilanKunyeConfiguration : EntityTypeConfiguration<TohalKullanilanKunye>
    {
        public TohalKullanilanKunyeConfiguration()
        {
            HasKey(e => e.KunyeSatirId);

            ToTable("TOHAL_KULLANILAN_KUNYE");

            Property(e => e.KunyeSatirId).HasColumnName("KUNYE_SATIR_ID");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisKunyeId).HasColumnName("SATIS_KUNYE_ID");

            Property(e => e.SatisKunyeSatiriId).HasColumnName("SATIS_KUNYE_SATIRI_ID");

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            HasOptional(d => d.FaturaSatiri)
                .WithMany(p => p.TohalKullanilanKunyes)
                .HasForeignKey(d => d.FaturaSatiriId);

            HasOptional(d => d.SatisKunye)
                .WithMany(p => p.TohalKullanilanKunyeSatisKunyes)
                .HasForeignKey(d => d.SatisKunyeId);

            HasOptional(d => d.SatisKunyeSatiri)
                .WithMany(p => p.TohalKullanilanKunyes)
                .HasForeignKey(d => d.SatisKunyeSatiriId);

            HasOptional(d => d.StokKunye)
                .WithMany(p => p.TohalKullanilanKunyeStokKunyes)
                .HasForeignKey(d => d.StokKunyeId);
        }
    }
}
