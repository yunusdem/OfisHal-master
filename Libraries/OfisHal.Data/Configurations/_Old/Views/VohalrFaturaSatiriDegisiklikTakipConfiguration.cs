using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrFaturaSatiriDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrFaturaSatiriDegisiklikTakip>
    {
        public VohalrFaturaSatiriDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_FATURA_SATIRI_DEGISIKLIK_TAKIP");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.ODara).HasColumnName("O_DARA");

            Property(e => e.ODarali).HasColumnName("O_DARALI");

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OIskonto).HasColumnName("O_ISKONTO");

            Property(e => e.OIskontoOrani).HasColumnName("O_ISKONTO_ORANI");

            Property(e => e.OKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_KAP_ADI");

            Property(e => e.OKapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_KAP_KODU")
                .IsFixedLength();

            Property(e => e.OKapMiktari).HasColumnName("O_KAP_MIKTARI");

            Property(e => e.OKdvOrani).HasColumnName("O_KDV_ORANI");

            Property(e => e.OMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_MAL_ADI");

            Property(e => e.OMalKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O_MAL_KODU")
                .IsFixedLength();

            Property(e => e.OMalMiktari).HasColumnName("O_MAL_MIKTARI");

            Property(e => e.OMarka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_MARKA");

            Property(e => e.ORusum).HasColumnName("O_RUSUM");

            Property(e => e.ORusumOrani).HasColumnName("O_RUSUM_ORANI");

            Property(e => e.OSatisK)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_SATIS_K")
                .IsFixedLength();

            Property(e => e.OSatisKunyeId).HasColumnName("O_SATIS_KUNYE_ID");

            Property(e => e.OStokK)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_STOK_K")
                .IsFixedLength();

            Property(e => e.OStokKunyeId).HasColumnName("O_STOK_KUNYE_ID");

            Property(e => e.OTutar).HasColumnName("O_TUTAR");

            Property(e => e.SAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SDara).HasColumnName("S_DARA");

            Property(e => e.SDarali).HasColumnName("S_DARALI");

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SIskonto).HasColumnName("S_ISKONTO");

            Property(e => e.SIskontoOrani).HasColumnName("S_ISKONTO_ORANI");

            Property(e => e.SKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_KAP_ADI");

            Property(e => e.SKapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_KAP_KODU")
                .IsFixedLength();

            Property(e => e.SKapMiktari).HasColumnName("S_KAP_MIKTARI");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_MAL_ADI");

            Property(e => e.SMalKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_MAL_KODU")
                .IsFixedLength();

            Property(e => e.SMalMiktari).HasColumnName("S_MAL_MIKTARI");

            Property(e => e.SMarka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_MARKA");

            Property(e => e.SRusum).HasColumnName("S_RUSUM");

            Property(e => e.SRusumOrani).HasColumnName("S_RUSUM_ORANI");

            Property(e => e.SSatisK)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_SATIS_K")
                .IsFixedLength();

            Property(e => e.SSatisKunyeId).HasColumnName("S_SATIS_KUNYE_ID");

            Property(e => e.SStokK)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_STOK_K")
                .IsFixedLength();

            Property(e => e.SStokKunyeId).HasColumnName("S_STOK_KUNYE_ID");

            Property(e => e.STutar).HasColumnName("S_TUTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.TlKurusSayisi).HasColumnName("TL_KURUS_SAYISI");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
