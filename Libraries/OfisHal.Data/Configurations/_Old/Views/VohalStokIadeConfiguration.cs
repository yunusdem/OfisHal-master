using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalStokIadeConfiguration : EntityTypeConfiguration<VohalStokIade>
    {
        public VohalStokIadeConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_STOK_IADE");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AdTarih)
                .HasMaxLength(210)
                .IsUnicode(false)
                .HasColumnName("AD_TARIH");

            Property(e => e.CariAd)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_AD");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KOD")
                .IsFixedLength();

            Property(e => e.DokumBilgisi)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("DOKUM_BILGISI");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KartTipi).HasColumnName("KART_TIPI");

            Property(e => e.KodTarih)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KOD_TARIH")
                .IsFixedLength();

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");

            Property(e => e.StokIadeId).HasColumnName("STOK_IADE_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
