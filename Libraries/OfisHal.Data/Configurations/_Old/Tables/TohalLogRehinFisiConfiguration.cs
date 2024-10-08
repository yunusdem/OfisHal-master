using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogRehinFisiConfiguration : EntityTypeConfiguration<TohalLogRehinFisi>
    {
        public TohalLogRehinFisiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_REHIN_FISI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OElleDegistirildi).HasColumnName("O_ELLE_DEGISTIRILDI");

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OKapId).HasColumnName("O_KAP_ID");

            Property(e => e.OKapMiktari).HasColumnName("O_KAP_MIKTARI");

            Property(e => e.OMarkaId).HasColumnName("O_MARKA_ID");

            Property(e => e.OSatirNo).HasColumnName("O_SATIR_NO");

            Property(e => e.OTutar).HasColumnName("O_TUTAR");

            Property(e => e.SElleDegistirildi).HasColumnName("S_ELLE_DEGISTIRILDI");

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SKapId).HasColumnName("S_KAP_ID");

            Property(e => e.SKapMiktari).HasColumnName("S_KAP_MIKTARI");

            Property(e => e.SMarkaId).HasColumnName("S_MARKA_ID");

            Property(e => e.SSatirNo).HasColumnName("S_SATIR_NO");

            Property(e => e.STutar).HasColumnName("S_TUTAR");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
