using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogEvrakMasrafiConfiguration : EntityTypeConfiguration<TohalLogEvrakMasrafi>
    {
        public TohalLogEvrakMasrafiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_EVRAK_MASRAFI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.OKapFiyati).HasColumnName("O_KAP_FIYATI");

            Property(e => e.OKapId).HasColumnName("O_KAP_ID");

            Property(e => e.OKapSayisi).HasColumnName("O_KAP_SAYISI");

            Property(e => e.OKdv).HasColumnName("O_KDV");

            Property(e => e.OKdvOrani).HasColumnName("O_KDV_ORANI");

            Property(e => e.OMasraf).HasColumnName("O_MASRAF");

            Property(e => e.OMuhatap).HasColumnName("O_MUHATAP");

            Property(e => e.SKapFiyati).HasColumnName("S_KAP_FIYATI");

            Property(e => e.SKapId).HasColumnName("S_KAP_ID");

            Property(e => e.SKapSayisi).HasColumnName("S_KAP_SAYISI");

            Property(e => e.SKdv).HasColumnName("S_KDV");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SMasraf).HasColumnName("S_MASRAF");

            Property(e => e.SMuhatap).HasColumnName("S_MUHATAP");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
