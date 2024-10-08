using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalEvrakMasrafiConfiguration : EntityTypeConfiguration<VohalEvrakMasrafi>
    {
        public VohalEvrakMasrafiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_EVRAK_MASRAFI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.HesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IscilikAdetKatsayisi).HasColumnName("ISCILIK_ADET_KATSAYISI");

            Property(e => e.IscilikKiloKatsayisi).HasColumnName("ISCILIK_KILO_KATSAYISI");

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

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KesintiOrani).HasColumnName("KESINTI_ORANI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.Muhatap).HasColumnName("MUHATAP");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");
        }
    }
}
