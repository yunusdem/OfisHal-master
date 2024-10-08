using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMustahsilCariHareketiniSoyleConfiguration : EntityTypeConfiguration<VohalrMustahsilCariHareketiniSoyle>
    {
        public VohalrMustahsilCariHareketiniSoyleConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MUSTAHSIL_CARI_HAREKETINI_SOYLE");

            Property(e => e.Aciklama)
                .HasMaxLength(319)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.CariHareketinIslemTipi).HasColumnName("CARI_HAREKETIN_ISLEM_TIPI");

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
