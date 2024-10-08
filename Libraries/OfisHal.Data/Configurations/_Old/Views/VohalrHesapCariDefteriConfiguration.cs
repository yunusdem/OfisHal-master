using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrHesapCariDefteriConfiguration : EntityTypeConfiguration<VohalrHesapCariDefteri>
    {
        public VohalrHesapCariDefteriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_HESAP_CARI_DEFTERI");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.EvrakTuru).HasColumnName("EVRAK_TURU");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapHareketiId).HasColumnName("HESAP_HAREKETI_ID");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.HesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MiktarBasamakSayisi).HasColumnName("MIKTAR_BASAMAK_SAYISI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");
        }
    }
}
