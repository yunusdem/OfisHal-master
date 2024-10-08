using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrAlisFaturasiDetayConfiguration : EntityTypeConfiguration<VohalrAlisFaturasiDetay>
    {
        public VohalrAlisFaturasiDetayConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ALIS_FATURASI_DETAY");

            Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.CariHareketId).HasColumnName("CARI_HAREKET_ID");

            Property(e => e.Darali).HasColumnName("DARALI");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.DigKiloOndalikSayisi).HasColumnName("DIG_KILO_ONDALIK_SAYISI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
