using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal01CariHareketConfiguration : EntityTypeConfiguration<Vohal01CariHareket>
    {
        public Vohal01CariHareketConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_01_CARI_HAREKET");

            Property(e => e.Aciklama)
                .HasMaxLength(319)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.BelgeTuru).HasColumnName("BELGE_TURU");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.FaturaTuru).HasColumnName("FATURA_TURU");

            Property(e => e.HareketId).HasColumnName("HAREKET_ID");

            Property(e => e.HareketTipi).HasColumnName("HAREKET_TIPI");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.OdemeAraciTuru).HasColumnName("ODEME_ARACI_TURU");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");
        }
    }
}
