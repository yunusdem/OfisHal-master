using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMustahsilSatisIstatistigiConfiguration : EntityTypeConfiguration<VohalrMustahsilSatisIstatistigi>
    {
        public VohalrMustahsilSatisIstatistigiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MUSTAHSIL_SATIS_ISTATISTIGI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.DigKiloOndalikSayisi).HasColumnName("DIG_KILO_ONDALIK_SAYISI");

            Property(e => e.DokRusumOrani).HasColumnName("DOK_RUSUM_ORANI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Fiyat2).HasColumnName("FIYAT2");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
