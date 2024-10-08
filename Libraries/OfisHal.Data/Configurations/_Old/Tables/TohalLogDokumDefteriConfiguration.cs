using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogDokumDefteriConfiguration : EntityTypeConfiguration<TohalLogDokumDefteri>
    {
        public TohalLogDokumDefteriConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_DOKUM_DEFTERI");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OCiroPrimi).HasColumnName("O_CIRO_PRIMI");

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OKapSayisi).HasColumnName("O_KAP_SAYISI");

            Property(e => e.OKdvOrani).HasColumnName("O_KDV_ORANI");

            Property(e => e.OMalId).HasColumnName("O_MAL_ID");

            Property(e => e.OMiktar).HasColumnName("O_MIKTAR");

            Property(e => e.OStokHareketiId).HasColumnName("O_STOK_HAREKETI_ID");

            Property(e => e.OTutar).HasColumnName("O_TUTAR");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SCiroPrimi).HasColumnName("S_CIRO_PRIMI");

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SKapSayisi).HasColumnName("S_KAP_SAYISI");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SMalId).HasColumnName("S_MAL_ID");

            Property(e => e.SMiktar).HasColumnName("S_MIKTAR");

            Property(e => e.SStokHareketiId).HasColumnName("S_STOK_HAREKETI_ID");

            Property(e => e.STutar).HasColumnName("S_TUTAR");
        }
    }
}
