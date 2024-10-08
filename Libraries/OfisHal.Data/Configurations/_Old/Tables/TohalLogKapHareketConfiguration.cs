using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogKapHareketConfiguration : EntityTypeConfiguration<TohalLogKapHareket>
    {
        public TohalLogKapHareketConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_KAP_HAREKET");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KapHareketId).HasColumnName("KAP_HAREKET_ID");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OCariKartId).HasColumnName("O_CARI_KART_ID");

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OIslenecegiHesap).HasColumnName("O_ISLENECEGI_HESAP");

            Property(e => e.OKapId).HasColumnName("O_KAP_ID");

            Property(e => e.OMiktar).HasColumnName("O_MIKTAR");

            Property(e => e.ORehinFisiId).HasColumnName("O_REHIN_FISI_ID");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OTip).HasColumnName("O_TIP");

            Property(e => e.OTutar).HasColumnName("O_TUTAR");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SCariKartId).HasColumnName("S_CARI_KART_ID");

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SIslenecegiHesap).HasColumnName("S_ISLENECEGI_HESAP");

            Property(e => e.SKapId).HasColumnName("S_KAP_ID");

            Property(e => e.SMiktar).HasColumnName("S_MIKTAR");

            Property(e => e.SRehinFisiId).HasColumnName("S_REHIN_FISI_ID");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.STip).HasColumnName("S_TIP");

            Property(e => e.STutar).HasColumnName("S_TUTAR");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
