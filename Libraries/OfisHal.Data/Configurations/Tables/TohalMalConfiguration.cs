using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalMalConfiguration : EntityTypeConfiguration<TohalMal>
    {
        public TohalMalConfiguration()
        {
            HasKey(e => e.MalId);

            ToTable("TOHAL_MAL");

            HasIndex(e => e.Kod)
                .IsUnique();

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AlisFiyati).HasColumnName("ALIS_FIYATI");

            Property(e => e.AlisHesapId).HasColumnName("ALIS_HESAP_ID");

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.DigerAdId).HasColumnName("DIGER_AD_ID");

            Property(e => e.FaturaBirimi).HasColumnName("FATURA_BIRIMI");

            Property(e => e.GrupNo).HasColumnName("GRUP_NO");

            Property(e => e.GtipNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GTIP_NO")
                .IsFixedLength();

            Property(e => e.KapIcindekiMiktari).HasColumnName("KAP_ICINDEKI_MIKTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.OrtalamaKilo).HasColumnName("ORTALAMA_KILO");

            Property(e => e.SatisFiyati).HasColumnName("SATIS_FIYATI");

            Property(e => e.SatisHesapId).HasColumnName("SATIS_HESAP_ID");

            Property(e => e.SonKullanmaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SON_KULLANMA_TARIHI");

            Property(e => e.Tur).HasColumnName("TUR");

            HasOptional(d => d.AlisHesap)
                .WithMany(p => p.TohalMalAlisHesaps)
                .HasForeignKey(d => d.AlisHesapId);

            HasOptional(d => d.DigerAd)
                .WithMany(p => p.TohalMals)
                .HasForeignKey(d => d.DigerAdId);

            HasOptional(d => d.KdvTevkifatTanimi)
                .WithMany(p => p.TohalMals)
                .HasForeignKey(d => d.KdvTevkifatTanimiId);

            HasOptional(d => d.SatisHesap)
                .WithMany(p => p.TohalMalSatisHesaps)
                .HasForeignKey(d => d.SatisHesapId);
        }
    }
}
