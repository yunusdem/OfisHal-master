using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalbMakbuzSatiriConfiguration : EntityTypeConfiguration<VohalbMakbuzSatiri>
    {
        public VohalbMakbuzSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALB_MAKBUZ_SATIRI");

            Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.DigKiloOndalikSayisi).HasColumnName("DIG_KILO_ONDALIK_SAYISI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU");

            Property(e => e.Marka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_TARIHI");

            Property(e => e.StokKunyesi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYESI")
                .IsFixedLength();

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
