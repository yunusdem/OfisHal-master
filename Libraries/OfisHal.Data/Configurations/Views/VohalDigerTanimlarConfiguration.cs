using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalDigerTanimlarConfiguration : EntityTypeConfiguration<VohalDigerTanimlar>
    {
        public VohalDigerTanimlarConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.DigBordroKapDevri);
            ToTable("VOHAL_DIGER_TANIMLAR");

            Property(e => e.DegisiklikTakipSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEGISIKLIK_TAKIP_SIFRESI");

            Property(e => e.DevirAlani)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEVIR_ALANI");

            Property(e => e.DigAciklama2Goster).HasColumnName("DIG_ACIKLAMA2_GOSTER");

            Property(e => e.DigBagkurDosyaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_BAGKUR_DOSYA_NO");

            Property(e => e.DigBelgeDizini)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_BELGE_DIZINI");

            Property(e => e.DigBordroKapDevri).HasColumnName("DIG_BORDRO_KAP_DEVRI");

            Property(e => e.DigBordroKiloDevri).HasColumnName("DIG_BORDRO_KILO_DEVRI");

            Property(e => e.DigBordroSayfaNo).HasColumnName("DIG_BORDRO_SAYFA_NO");

            Property(e => e.DigBuyukHarfeCevir).HasColumnName("DIG_BUYUK_HARFE_CEVIR");

            Property(e => e.DigCariHareketRefNo).HasColumnName("DIG_CARI_HAREKET_REF_NO");

            Property(e => e.DigCariKodBasinaSifir).HasColumnName("DIG_CARI_KOD_BASINA_SIFIR");

            Property(e => e.DigDokumDefterSayfaNo).HasColumnName("DIG_DOKUM_DEFTER_SAYFA_NO");

            Property(e => e.DigDokumNoBasinaSifir).HasColumnName("DIG_DOKUM_NO_BASINA_SIFIR");

            Property(e => e.DigDonemBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DIG_DONEM_BASLANGIC_TARIHI");

            Property(e => e.DigDonemBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DIG_DONEM_BITIS_TARIHI");

            Property(e => e.DigEBagkurVar).HasColumnName("DIG_E_BAGKUR_VAR");

            Property(e => e.DigEditDenetimIsleyisi).HasColumnName("DIG_EDIT_DENETIM_ISLEYISI");

            Property(e => e.DigEtaFaturaKlasoru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_ETA_FATURA_KLASORU");

            Property(e => e.DigFaturaNoBasinaSifir).HasColumnName("DIG_FATURA_NO_BASINA_SIFIR");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.DigHalMudurlukFormuKlasoru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_HAL_MUDURLUK_FORMU_KLASORU");

            Property(e => e.DigIkinciYedekKlasoru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_IKINCI_YEDEK_KLASORU");

            Property(e => e.DigKasMustahCalismaSekli).HasColumnName("DIG_KAS_MUSTAH_CALISMA_SEKLI");

            Property(e => e.DigKasaDefterindeAlisVar).HasColumnName("DIG_KASA_DEFTERINDE_ALIS_VAR");

            Property(e => e.DigKasaDefterindeDevirVar).HasColumnName("DIG_KASA_DEFTERINDE_DEVIR_VAR");

            Property(e => e.DigKasaDevirSekli).HasColumnName("DIG_KASA_DEVIR_SEKLI");

            Property(e => e.DigKasaDevri).HasColumnName("DIG_KASA_DEVRI");

            Property(e => e.DigKasaDevrindeYukNakVar).HasColumnName("DIG_KASA_DEVRINDE_YUK_NAK_VAR");

            Property(e => e.DigKasaKrediKartiVar).HasColumnName("DIG_KASA_KREDI_KARTI_VAR");

            Property(e => e.DigKasaVeresiyeSekli).HasColumnName("DIG_KASA_VERESIYE_SEKLI");

            Property(e => e.DigKiloOndalikSayisi).HasColumnName("DIG_KILO_ONDALIK_SAYISI");

            Property(e => e.DigMalBeyanSayfaNo).HasColumnName("DIG_MAL_BEYAN_SAYFA_NO");

            Property(e => e.DigMudurlukKulAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_MUDURLUK_KUL_ADI");

            Property(e => e.DigMudurlukKulSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIG_MUDURLUK_KUL_SIFRESI");

            Property(e => e.DigMustahsilKodSiraNo).HasColumnName("DIG_MUSTAHSIL_KOD_SIRA_NO");

            Property(e => e.DigMusteriKodSiraNo).HasColumnName("DIG_MUSTERI_KOD_SIRA_NO");

            Property(e => e.DigOdemeBordroBasinaSifir).HasColumnName("DIG_ODEME_BORDRO_BASINA_SIFIR");

            Property(e => e.DigOdemeBordroSiraNo).HasColumnName("DIG_ODEME_BORDRO_SIRA_NO");

            Property(e => e.DigRehinBakiyeGosterilsin).HasColumnName("DIG_REHIN_BAKIYE_GOSTERILSIN");

            Property(e => e.DigRehinBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DIG_REHIN_BASLANGIC_TARIHI");

            Property(e => e.DigRehinBazliKapCari).HasColumnName("DIG_REHIN_BAZLI_KAP_CARI");

            Property(e => e.DigRehinIadeCalismaSekli).HasColumnName("DIG_REHIN_IADE_CALISMA_SEKLI");

            Property(e => e.DigRehinTahsilatGosterimi).HasColumnName("DIG_REHIN_TAHSILAT_GOSTERIMI");

            Property(e => e.DigSatisTipi).HasColumnName("DIG_SATIS_TIPI");

            Property(e => e.DigTutarHesaplamaSekli).HasColumnName("DIG_TUTAR_HESAPLAMA_SEKLI");

            Property(e => e.DigVadeFarkiOrani).HasColumnName("DIG_VADE_FARKI_ORANI");

            Property(e => e.DigVeresiyeAsimOlayi).HasColumnName("DIG_VERESIYE_ASIM_OLAYI");

            Property(e => e.DigVeresiyeMizaniAc).HasColumnName("DIG_VERESIYE_MIZANI_AC");

            Property(e => e.DigVergiSorgulayanTcKNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_VERGI_SORGULAYAN_TC_K_NO")
                .IsFixedLength();

            Property(e => e.DigYedekKlasoru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_YEDEK_KLASORU");

            Property(e => e.FisSiraNo).HasColumnName("FIS_SIRA_NO");

            Property(e => e.HalMudurlukXmlAdi).HasColumnName("HAL_MUDURLUK_XML_ADI");

            Property(e => e.HesapYili).HasColumnName("HESAP_YILI");

            Property(e => e.KunyeCogalmaLog).HasColumnName("KUNYE_COGALMA_LOG");

            Property(e => e.MalKabulSiraNo).HasColumnName("MAL_KABUL_SIRA_NO");

            Property(e => e.SonAlinanGibKullaniciTarih)
                .HasColumnType("datetime")
                .HasColumnName("SON_ALINAN_GIB_KULLANICI_TARIH");

            Property(e => e.Surum)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SURUM");

            Property(e => e.Tip).HasColumnName("TIP");
        }
    }
}
