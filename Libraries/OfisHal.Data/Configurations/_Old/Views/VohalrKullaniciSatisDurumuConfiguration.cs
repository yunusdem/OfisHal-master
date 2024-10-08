using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrKullaniciSatisDurumuConfiguration : EntityTypeConfiguration<VohalrKullaniciSatisDurumu>
    {
        public VohalrKullaniciSatisDurumuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_KULLANICI_SATIS_DURUMU");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaToplami).HasColumnName("FATURA_TOPLAMI");

            Property(e => e.FaturaUnvani)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FATURA_UNVANI");

            Property(e => e.KesintilerToplami).HasColumnName("KESINTILER_TOPLAMI");

            Property(e => e.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.KurusBasamakSayisi).HasColumnName("KURUS_BASAMAK_SAYISI");

            Property(e => e.PesinVeyaVeresiye)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PESIN_VEYA_VERESIYE");

            Property(e => e.RefNo).HasColumnName("REF_NO");

            Property(e => e.Rehin).HasColumnName("REHIN");

            Property(e => e.SatRusumKdvIliskisi).HasColumnName("SAT_RUSUM_KDV_ILISKISI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.Veresiye).HasColumnName("VERESIYE");
        }
    }
}
