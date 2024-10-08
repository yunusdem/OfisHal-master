using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalMusteriRiskBakiyeListesiConfiguration : EntityTypeConfiguration<VohalMusteriRiskBakiyeListesi>
    {
        public VohalMusteriRiskBakiyeListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_MUSTERI_RISK_BAKIYE_LISTESI");

            Property(e => e.BekleyenCekBakiye).HasColumnName("BEKLEYEN_CEK_BAKIYE");

            Property(e => e.CariAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KODU")
                .IsFixedLength();

            Property(e => e.RiskBakiye).HasColumnName("RISK_BAKIYE");

            Property(e => e.VeresiyeBakiye).HasColumnName("VERESIYE_BAKIYE");
        }
    }
}
