using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrBorsaBeyannamesiConfiguration : EntityTypeConfiguration<VohalrBorsaBeyannamesi>
    {
        public VohalrBorsaBeyannamesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_BORSA_BEYANNAMESI");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.Borsa).HasColumnName("BORSA");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MaxFiyat).HasColumnName("MAX_FIYAT");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MinFiyat).HasColumnName("MIN_FIYAT");

            Property(e => e.MustahsilAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KODU")
                .IsFixedLength();

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
