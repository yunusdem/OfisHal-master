using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrKapCariDefteriConfiguration : EntityTypeConfiguration<VohalrKapCariDefteri>
    {
        public VohalrKapCariDefteriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_KAP_CARI_DEFTERI");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.CariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_AD");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKartTipi).HasColumnName("CARI_KART_TIPI");

            Property(e => e.CariKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KOD")
                .IsFixedLength();

            Property(e => e.IslenecegiHesap)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("ISLENECEGI_HESAP");

            Property(e => e.KapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MiktarBasamakSayisi).HasColumnName("MIKTAR_BASAMAK_SAYISI");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
