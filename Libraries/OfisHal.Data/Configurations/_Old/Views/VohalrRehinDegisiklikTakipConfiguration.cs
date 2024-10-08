using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrRehinDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrRehinDegisiklikTakip>
    {
        public VohalrRehinDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_REHIN_DEGISIKLIK_TAKIP");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OElleDegistirildi).HasColumnName("O_ELLE_DEGISTIRILDI");

            Property(e => e.OFiyat).HasColumnName("O_FIYAT");

            Property(e => e.OKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_KAP_ADI");

            Property(e => e.OKapMiktari).HasColumnName("O_KAP_MIKTARI");

            Property(e => e.OMarka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_MARKA");

            Property(e => e.OSatirNo).HasColumnName("O_SATIR_NO");

            Property(e => e.OTutar).HasColumnName("O_TUTAR");

            Property(e => e.SElleDegistirildi).HasColumnName("S_ELLE_DEGISTIRILDI");

            Property(e => e.SFiyat).HasColumnName("S_FIYAT");

            Property(e => e.SKapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_KAP_ADI");

            Property(e => e.SKapMiktari).HasColumnName("S_KAP_MIKTARI");

            Property(e => e.SMarka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_MARKA");

            Property(e => e.SSatirNo).HasColumnName("S_SATIR_NO");

            Property(e => e.STutar).HasColumnName("S_TUTAR");

            Property(e => e.TlKurusSayisi).HasColumnName("TL_KURUS_SAYISI");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
