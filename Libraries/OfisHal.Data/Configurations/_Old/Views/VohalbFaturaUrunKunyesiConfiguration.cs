using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalbFaturaUrunKunyesiConfiguration : EntityTypeConfiguration<VohalbFaturaUrunKunyesi>
    {
        public VohalbFaturaUrunKunyesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALB_FATURA_URUN_KUNYESI");

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.Darali).HasColumnName("DARALI");

            Property(e => e.FaturaAdresi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FATURA_ADRESI");

            Property(e => e.FaturaBelde)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FATURA_BELDE");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaIl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FATURA_IL");

            Property(e => e.FaturaIlce)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FATURA_ILCE");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.FaturaUnvani)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FATURA_UNVANI");

            Property(e => e.FaturaVergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FATURA_VERGI_DAIRESI");

            Property(e => e.FirmamizAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FIRMAMIZ_ADI");

            Property(e => e.FirmamizEposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRMAMIZ_EPOSTA");

            Property(e => e.FirmamizGsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMAMIZ_GSM_NO");

            Property(e => e.FirmamizVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMAMIZ_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.HksMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_MAL_ADI");

            Property(e => e.HksMalCinsi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_MAL_CINSI");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MustahsilAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilAdresi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADRESI");

            Property(e => e.MustahsilBelde)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_BELDE");

            Property(e => e.MustahsilIl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_IL");

            Property(e => e.MustahsilIlce)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ILCE");

            Property(e => e.MustahsilPostaKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_POSTA_KODU");

            Property(e => e.MustahsilVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.SatirAciklamasi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SATIR_ACIKLAMASI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.ToptanciHaliAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TOPTANCI_HALI_ADI");

            Property(e => e.ToptanciHaliTelNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TOPTANCI_HALI_TEL_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.UretimSekli).HasColumnName("URETIM_SEKLI");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
