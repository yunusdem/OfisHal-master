using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalHesapConfiguration : EntityTypeConfiguration<TohalHesap>
    {
        public TohalHesapConfiguration()
        {
            HasKey(e => e.HesapId);

            ToTable("TOHAL_HESAP");

            HasIndex(e => e.Kod)
                .IsUnique();

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.IscilikAdetKatsayisi).HasColumnName("ISCILIK_ADET_KATSAYISI");

            Property(e => e.IscilikKiloKatsayisi).HasColumnName("ISCILIK_KILO_KATSAYISI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KesintiOrani).HasColumnName("KESINTI_ORANI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MuhHesapId).HasColumnName("MUH_HESAP_ID");

            Property(e => e.RehinDevri).HasColumnName("REHIN_DEVRI");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.YilsonuDevri).HasColumnName("YILSONU_DEVRI");

            HasOptional(d => d.MuhHesap)
                .WithMany(p => p.TohalHesaps)
                .HasForeignKey(d => d.MuhHesapId);
        }
    }
}
