using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogFaturaSatiriConfiguration : EntityTypeConfiguration<TohalLogFaturaSatiri>
    {
        public TohalLogFaturaSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_FATURA_SATIRI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OAlisFatSatId).HasColumnName("O_ALIS_FAT_SAT_ID");

            Property(e => e.OAlisKunyeId).HasColumnName("O_ALIS_KUNYE_ID");

            Property(e => e.ODara).HasColumnName("O_DARA");

            Property(e => e.ODarali).HasColumnName("O_DARALI");

            Property(e => e.OFisSatiriId).HasColumnName("O_FIS_SATIRI_ID");

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OIskonto).HasColumnName("O_ISKONTO");

            Property(e => e.OIskontoOrani).HasColumnName("O_ISKONTO_ORANI");

            Property(e => e.OKapId).HasColumnName("O_KAP_ID");

            Property(e => e.OKapMiktari).HasColumnName("O_KAP_MIKTARI");

            Property(e => e.OKdvOrani).HasColumnName("O_KDV_ORANI");

            Property(e => e.OKdvTevkifatTanimiId).HasColumnName("O_KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.OMalId).HasColumnName("O_MAL_ID");

            Property(e => e.OMalKapFiyati).HasColumnName("O_MAL_KAP_FIYATI");

            Property(e => e.OMalMiktari).HasColumnName("O_MAL_MIKTARI");

            Property(e => e.OMarkaId).HasColumnName("O_MARKA_ID");

            Property(e => e.ORusum).HasColumnName("O_RUSUM");

            Property(e => e.ORusumHesaplanmasin).HasColumnName("O_RUSUM_HESAPLANMASIN");

            Property(e => e.ORusumOrani).HasColumnName("O_RUSUM_ORANI");

            Property(e => e.OSatisKunyeId).HasColumnName("O_SATIS_KUNYE_ID");

            Property(e => e.OSatisTipi).HasColumnName("O_SATIS_TIPI");

            Property(e => e.OStokKunyeId).HasColumnName("O_STOK_KUNYE_ID");

            Property(e => e.OTutar).HasColumnName("O_TUTAR");

            Property(e => e.SAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SAlisFatSatId).HasColumnName("S_ALIS_FAT_SAT_ID");

            Property(e => e.SAlisKunyeId).HasColumnName("S_ALIS_KUNYE_ID");

            Property(e => e.SDara).HasColumnName("S_DARA");

            Property(e => e.SDarali).HasColumnName("S_DARALI");

            Property(e => e.SFisSatiriId).HasColumnName("S_FIS_SATIRI_ID");

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SIskonto).HasColumnName("S_ISKONTO");

            Property(e => e.SIskontoOrani).HasColumnName("S_ISKONTO_ORANI");

            Property(e => e.SKapId).HasColumnName("S_KAP_ID");

            Property(e => e.SKapMiktari).HasColumnName("S_KAP_MIKTARI");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SKdvTevkifatTanimiId).HasColumnName("S_KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.SMalId).HasColumnName("S_MAL_ID");

            Property(e => e.SMalKapFiyati).HasColumnName("S_MAL_KAP_FIYATI");

            Property(e => e.SMalMiktari).HasColumnName("S_MAL_MIKTARI");

            Property(e => e.SMarkaId).HasColumnName("S_MARKA_ID");

            Property(e => e.SRusum).HasColumnName("S_RUSUM");

            Property(e => e.SRusumHesaplanmasin).HasColumnName("S_RUSUM_HESAPLANMASIN");

            Property(e => e.SRusumOrani).HasColumnName("S_RUSUM_ORANI");

            Property(e => e.SSatisKunyeId).HasColumnName("S_SATIS_KUNYE_ID");

            Property(e => e.SSatisTipi).HasColumnName("S_SATIS_TIPI");

            Property(e => e.SStokKunyeId).HasColumnName("S_STOK_KUNYE_ID");

            Property(e => e.STutar).HasColumnName("S_TUTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
