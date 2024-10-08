using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalHesapBakiyeListesiConfiguration : EntityTypeConfiguration<VohalHesapBakiyeListesi>
    {
        public VohalHesapBakiyeListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_HESAP_BAKIYE_LISTESI");

            Property(e => e.AlacakToplami).HasColumnName("ALACAK_TOPLAMI");

            Property(e => e.Bakiye).HasColumnName("BAKIYE");

            Property(e => e.BorcToplami).HasColumnName("BORC_TOPLAMI");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.HesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();
        }
    }
}
