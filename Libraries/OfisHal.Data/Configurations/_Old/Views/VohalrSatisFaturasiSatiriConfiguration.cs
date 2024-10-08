using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSatisFaturasiSatiriConfiguration : EntityTypeConfiguration<VohalrSatisFaturasiSatiri>
    {
        public VohalrSatisFaturasiSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SATIS_FATURASI_SATIRI");

            Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.Darali).HasColumnName("DARALI");

            Property(e => e.DigerMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIGER_MAL_ADI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Iskonto).HasColumnName("ISKONTO");

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.IskontoPayi).HasColumnName("ISKONTO_PAYI");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapFiyati).HasColumnName("KAP_FIYATI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalBirimi)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("MAL_BIRIMI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisKunyesi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_KUNYESI")
                .IsFixedLength();

            Property(e => e.StokKunyesi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYESI")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
