using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrFaturaVeresiyeDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrFaturaVeresiyeDegisiklikTakip>
    {
        public VohalrFaturaVeresiyeDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_FATURA_VERESIYE_DEGISIKLIK_TAKIP");

            Property(e => e.CariHareketTarihi)
                .HasColumnType("datetime")
                .HasColumnName("CARI_HAREKET_TARIHI");

            Property(e => e.FaturaToplami).HasColumnName("FATURA_TOPLAMI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.PesinAlinan).HasColumnName("PESIN_ALINAN");

            Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF_NO")
                .IsFixedLength();

            Property(e => e.ReferansNo).HasColumnName("REFERANS_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.VeresiyeHareketTutari).HasColumnName("VERESIYE_HAREKET_TUTARI");
        }
    }
}
