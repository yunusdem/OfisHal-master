using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalFirmaTanimlariConfiguration : EntityTypeConfiguration<VohalFirmaTanimlari>
    {
        public VohalFirmaTanimlariConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.DigSicilKodu);
            ToTable("VOHAL_FIRMA_TANIMLARI");

            Property(e => e.DigAdres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_ADRES");

            Property(e => e.DigBagkurKullaniciAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_BAGKUR_KULLANICI_ADI");

            Property(e => e.DigBagkurSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIG_BAGKUR_SIFRESI");

            Property(e => e.DigEposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_EPOSTA");

            Property(e => e.DigFirmaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_FIRMA_ADI");

            Property(e => e.DigGsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_GSM_NO");

            Property(e => e.DigSahisAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_SAHIS_ADI");

            Property(e => e.DigSahisSoyadi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_SAHIS_SOYADI");

            Property(e => e.DigSicilKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_SICIL_KODU")
                .IsFixedLength();

            Property(e => e.DigTelefon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_TELEFON");

            Property(e => e.DigTopHaliAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_TOP_HALI_ADI");

            Property(e => e.DigTopHaliTelNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_TOP_HALI_TEL_NO");

            Property(e => e.DigVergiDairesiId).HasColumnName("DIG_VERGI_DAIRESI_ID");

            Property(e => e.DigVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.DigYazihaneNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_YAZIHANE_NO")
                .IsFixedLength();

            Property(e => e.FirBankaAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIR_BANKA_ADI");

            Property(e => e.FirCadde)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIR_CADDE");

            Property(e => e.FirDaireNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIR_DAIRE_NO")
                .IsFixedLength();

            Property(e => e.FirIbanNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIR_IBAN_NO");

            Property(e => e.FirKapiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIR_KAPI_NO")
                .IsFixedLength();

            Property(e => e.FirMahalle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIR_MAHALLE");

            Property(e => e.FirMersisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIR_MERSIS_NO")
                .IsFixedLength();

            Property(e => e.FirPostaKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIR_POSTA_KODU")
                .IsFixedLength();

            Property(e => e.FirSokak)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIR_SOKAK");

            Property(e => e.FirWebAdresi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIR_WEB_ADRESI");

            Property(e => e.GibFirmamizPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU");

            Property(e => e.GibFirmamizPostaKutusuId).HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU_ID");

            Property(e => e.HalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HAL_ADI");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.VergiDairesiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI_ADI");
        }
    }
}
