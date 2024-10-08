using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrTicariKarlilikFaturaDetayConfiguration : EntityTypeConfiguration<VohalrTicariKarlilikFaturaDetay>
    {
        public VohalrTicariKarlilikFaturaDetayConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_TICARI_KARLILIK_FATURA_DETAY");

            Property(e => e.Birim)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BIRIM");

            Property(e => e.BirimId).HasColumnName("BIRIM_ID");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MusteriAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_ADI");

            Property(e => e.MusteriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_KODU")
                .IsFixedLength();

            Property(e => e.SatirIskonto).HasColumnName("SATIR_ISKONTO");

            Property(e => e.SiparisAciklamasi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_ACIKLAMASI");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.SiparisNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_NO")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
