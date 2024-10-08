using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambAmbarTanimlariConfiguration : EntityTypeConfiguration<VoambAmbarTanimlari>
    {
        public VoambAmbarTanimlariConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_AMBAR_TANIMLARI");

            Property(e => e.DigBelgeDizini)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_BELGE_DIZINI");

            Property(e => e.DigBuyukHarfeCevir).HasColumnName("DIG_BUYUK_HARFE_CEVIR");

            Property(e => e.DigCariKodBasinaSifir).HasColumnName("DIG_CARI_KOD_BASINA_SIFIR");

            Property(e => e.DigDokumNoBasinaSifir).HasColumnName("DIG_DOKUM_NO_BASINA_SIFIR");

            Property(e => e.DigFaturaNoBasinaSifir).HasColumnName("DIG_FATURA_NO_BASINA_SIFIR");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.DigKasaDefterindeDevirVar).HasColumnName("DIG_KASA_DEFTERINDE_DEVIR_VAR");

            Property(e => e.DigKasaDevirSekli).HasColumnName("DIG_KASA_DEVIR_SEKLI");

            Property(e => e.DigKasaDevri).HasColumnName("DIG_KASA_DEVRI");

            Property(e => e.DigMustahsilKodSiraNo).HasColumnName("DIG_MUSTAHSIL_KOD_SIRA_NO");

            Property(e => e.DigMusteriKodSiraNo).HasColumnName("DIG_MUSTERI_KOD_SIRA_NO");

            Property(e => e.DigTuccarKodSiraNo).HasColumnName("DIG_TUCCAR_KOD_SIRA_NO");

            Property(e => e.DigYedekKlasoru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_YEDEK_KLASORU");

            Property(e => e.SatDigerMalKdvOrani).HasColumnName("SAT_DIGER_MAL_KDV_ORANI");

            Property(e => e.SatYuklemeKdvOrani).HasColumnName("SAT_YUKLEME_KDV_ORANI");

            Property(e => e.Surum)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SURUM");
        }
    }
}
