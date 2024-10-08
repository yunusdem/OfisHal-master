using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMustahsilCariDefteriConfiguration : EntityTypeConfiguration<VohalrMustahsilCariDefteri>
    {
        public VohalrMustahsilCariDefteriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MUSTAHSIL_CARI_DEFTERI");

            Property(e => e.Aciklama)
                .HasMaxLength(247)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Alacak).HasColumnName("ALACAK");

            Property(e => e.Borc).HasColumnName("BORC");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.SehirAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SEHIR_ADI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
