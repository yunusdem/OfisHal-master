using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalIskeleFaturaSatiriConfiguration : EntityTypeConfiguration<TohalIskeleFaturaSatiri>
    {
        public TohalIskeleFaturaSatiriConfiguration()
        {
            HasKey(e => e.SatirGuid);
            //HasNoKey();

            ToTable("TOHAL_ISKELE_FATURA_SATIRI");

            Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            

            Property(e => e.AlisFatSatId).HasColumnName("ALIS_FAT_SAT_ID");

            Property(e => e.AlisKunyeId).HasColumnName("ALIS_KUNYE_ID");

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.Darali).HasColumnName("DARALI");

            Property(e => e.FisSatiriId).HasColumnName("FIS_SATIRI_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.Iskonto).HasColumnName("ISKONTO");

            Property(e => e.IskontoHesaplanmasin).HasColumnName("ISKONTO_HESAPLANMASIN");

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.IskontoPayi).HasColumnName("ISKONTO_PAYI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvTevkifatPaydasi).HasColumnName("KDV_TEVKIFAT_PAYDASI");

            Property(e => e.KdvTevkifatPayi).HasColumnName("KDV_TEVKIFAT_PAYI");

            Property(e => e.KdvTevkifatTanimiId).HasColumnName("KDV_TEVKIFAT_TANIMI_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKapFiyati).HasColumnName("MAL_KAP_FIYATI");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumHesaplanmasin).HasColumnName("RUSUM_HESAPLANMASIN");

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

            Property(e => e.SatirGuid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SATIR_GUID");

            Property(e => e.SatirId).HasColumnName("SATIR_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisKunyeId).HasColumnName("SATIS_KUNYE_ID");

            Property(e => e.SatisTipi).HasColumnName("SATIS_TIPI");

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.TutarHesaplanmasin).HasColumnName("TUTAR_HESAPLANMASIN");

            Property(e => e.VtSatisKunyeId).HasColumnName("VT_SATIS_KUNYE_ID");

            Property(e => e.VtStokKunyeId).HasColumnName("VT_STOK_KUNYE_ID");

            Property(e => e.Yukleme).HasColumnName("YUKLEME");
        }
    }
}
