using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrEvrakMasrafiDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrEvrakMasrafiDegisiklikTakip>
    {
        public VohalrEvrakMasrafiDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_EVRAK_MASRAFI_DEGISIKLIK_TAKIP");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.HesapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.OKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_KAP_ADI");

            Property(e => e.OKapFiyati).HasColumnName("O_KAP_FIYATI");

            Property(e => e.OKapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_KAP_KODU")
                .IsFixedLength();

            Property(e => e.OKapSayisi).HasColumnName("O_KAP_SAYISI");

            Property(e => e.OKdv).HasColumnName("O_KDV");

            Property(e => e.OKdvOrani).HasColumnName("O_KDV_ORANI");

            Property(e => e.OMasraf).HasColumnName("O_MASRAF");

            Property(e => e.OMuhatap).HasColumnName("O_MUHATAP");

            Property(e => e.SKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_KAP_ADI");

            Property(e => e.SKapFiyati).HasColumnName("S_KAP_FIYATI");

            Property(e => e.SKapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_KAP_KODU")
                .IsFixedLength();

            Property(e => e.SKapSayisi).HasColumnName("S_KAP_SAYISI");

            Property(e => e.SKdv).HasColumnName("S_KDV");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SMasraf).HasColumnName("S_MASRAF");

            Property(e => e.SMuhatap).HasColumnName("S_MUHATAP");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.TlKurusSayisi).HasColumnName("TL_KURUS_SAYISI");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
