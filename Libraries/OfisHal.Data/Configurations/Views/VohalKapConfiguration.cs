using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalKapConfiguration : EntityTypeConfiguration<VohalKap>
    {
        public VohalKapConfiguration()
        {
            HasKey(e => e.KapId);
            //HasNoKey();

            ToTable("VOHAL_KAP");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AlisHesapId).HasColumnName("ALIS_HESAP_ID");

            Property(e => e.AlisHesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ALIS_HESAP_KODU")
                .IsFixedLength();

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

            Property(e => e.DigerAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIGER_ADI");

            Property(e => e.Iadeli).HasColumnName("IADELI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.Kapasite).HasColumnName("KAPASITE");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.RehinKabiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REHIN_KABI_ADI");

            Property(e => e.RehinKabiId).HasColumnName("REHIN_KABI_ID");

            Property(e => e.RehinKabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REHIN_KABI_KODU")
                .IsFixedLength();

            Property(e => e.SatisHesapId).HasColumnName("SATIS_HESAP_ID");

            Property(e => e.SatisHesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_HESAP_KODU")
                .IsFixedLength();
        }
    }
}
