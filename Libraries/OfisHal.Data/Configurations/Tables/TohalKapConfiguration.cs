using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalKapConfiguration : EntityTypeConfiguration<TohalKap>
    {
        public TohalKapConfiguration()
        {
            HasKey(e => e.KapId);

            ToTable("TOHAL_KAP");

            HasIndex(e => e.Kod)
                .IsUnique();

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AlisHesapId).HasColumnName("ALIS_HESAP_ID");

            Property(e => e.AmbalajMarkasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMBALAJ_MARKASI");

            Property(e => e.AmbalajTipiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMBALAJ_TIPI_KODU")
                .IsFixedLength();

            Property(e => e.BirimFiyati).HasColumnName("BIRIM_FIYATI");

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.DigerAdId).HasColumnName("DIGER_AD_ID");

            Property(e => e.Iadeli).HasColumnName("IADELI");

            Property(e => e.Kapasite).HasColumnName("KAPASITE");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.RehinKabiId).HasColumnName("REHIN_KABI_ID");

            Property(e => e.SatisHesapId).HasColumnName("SATIS_HESAP_ID");

            HasOptional(d => d.AlisHesap)
                .WithMany(p => p.TohalKapAlisHesaps)
                .HasForeignKey(d => d.AlisHesapId);

            HasOptional(d => d.DigerAd)
                .WithMany(p => p.TohalKaps)
                .HasForeignKey(d => d.DigerAdId);

            HasOptional(d => d.RehinKabi)
                .WithMany(p => p.InverseRehinKabi)
                .HasForeignKey(d => d.RehinKabiId);

            HasOptional(d => d.SatisHesap)
                .WithMany(p => p.TohalKapSatisHesaps)
                .HasForeignKey(d => d.SatisHesapId);
        }
    }
}
