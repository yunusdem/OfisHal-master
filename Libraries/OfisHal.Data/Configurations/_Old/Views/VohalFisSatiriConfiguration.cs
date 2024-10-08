using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalFisSatiriConfiguration : EntityTypeConfiguration<VohalFisSatiri>
    {
        public VohalFisSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_FIS_SATIRI");

            Property(e => e.BirimDara).HasColumnName("BIRIM_DARA");

            Property(e => e.CariAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KOD")
                .IsFixedLength();

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.Darali).HasColumnName("DARALI");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.FisId).HasColumnName("FIS_ID");

            Property(e => e.FisSatiriId).HasColumnName("FIS_SATIRI_ID");

            Property(e => e.FisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FIS_TARIHI");

            Property(e => e.FisTipi).HasColumnName("FIS_TIPI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.FiyatFarki).HasColumnName("FIYAT_FARKI");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapIcindekiMalMiktari).HasColumnName("KAP_ICINDEKI_MAL_MIKTARI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

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

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.Marka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.PiyasaFiyati).HasColumnName("PIYASA_FIYATI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
