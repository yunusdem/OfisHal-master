using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalTanimConfiguration : EntityTypeConfiguration<TohalTanim>
    {
        public TohalTanimConfiguration()
        {
            HasKey(e => e.Surum);
            //HasNoKey();

            ToTable("TOHAL_TANIM");

            Property(e => e.AlsDigerMalKdvOrani).HasColumnName("ALS_DIGER_MAL_KDV_ORANI");

            Property(e => e.AlsFatFiyatGelsin).HasColumnName("ALS_FAT_FIYAT_GELSIN");

            Property(e => e.AlsFaturaSiraNo).HasColumnName("ALS_FATURA_SIRA_NO");

            Property(e => e.AlsMalBakiyeHesaplamaSekli).HasColumnName("ALS_MAL_BAKIYE_HESAPLAMA_SEKLI");

            Property(e => e.AlsRusumOrani).HasColumnName("ALS_RUSUM_ORANI");

            Property(e => e.AlsSiparisCalismaSekli).HasColumnName("ALS_SIPARIS_CALISMA_SEKLI");

            Property(e => e.DegisiklikTakipSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEGISIKLIK_TAKIP_SIFRESI");

            Property(e => e.DevirAlani)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEVIR_ALANI");

            Property(e => e.DevirTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DEVIR_TARIHI");

            Property(e => e.DigAciklama2Goster).HasColumnName("DIG_ACIKLAMA2_GOSTER");

            Property(e => e.DigAdres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_ADRES");

            Property(e => e.DigBagkurDosyaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_BAGKUR_DOSYA_NO");

            Property(e => e.DigBagkurKullaniciAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_BAGKUR_KULLANICI_ADI");

            Property(e => e.DigBagkurSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIG_BAGKUR_SIFRESI");

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

            Property(e => e.DigEposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_EPOSTA");

            Property(e => e.DigEtaFaturaKlasoru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_ETA_FATURA_KLASORU");

            Property(e => e.DigFaturaNoBasinaSifir).HasColumnName("DIG_FATURA_NO_BASINA_SIFIR");

            Property(e => e.DigFirmaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_FIRMA_ADI");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.DigGidecegiYerTipi).HasColumnName("DIG_GIDECEGI_YER_TIPI");

            Property(e => e.DigGsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_GSM_NO");

            Property(e => e.DigHalId).HasColumnName("DIG_HAL_ID");

            Property(e => e.DigHalMudurlukFormuKlasoru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_HAL_MUDURLUK_FORMU_KLASORU");

            Property(e => e.DigHksAdetSiniri).HasColumnName("DIG_HKS_ADET_SINIRI");

            Property(e => e.DigHksBildirimSekli).HasColumnName("DIG_HKS_BILDIRIM_SEKLI");

            Property(e => e.DigHksCalismaSekli).HasColumnName("DIG_HKS_CALISMA_SEKLI");

            Property(e => e.DigHksKiloSiniri).HasColumnName("DIG_HKS_KILO_SINIRI");

            Property(e => e.DigHksSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIG_HKS_SIFRESI");

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

            Property(e => e.DigKunyeBarkoduYazdir).HasColumnName("DIG_KUNYE_BARKODU_YAZDIR");

            Property(e => e.DigKunyeGecerlilikTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DIG_KUNYE_GECERLILIK_TARIHI");

            Property(e => e.DigKunyeTakibiVar).HasColumnName("DIG_KUNYE_TAKIBI_VAR");

            Property(e => e.DigKunyeyiOtomatikGonder).HasColumnName("DIG_KUNYEYI_OTOMATIK_GONDER");

            Property(e => e.DigMalBeyanSayfaNo).HasColumnName("DIG_MAL_BEYAN_SAYFA_NO");

            Property(e => e.DigMarkaninKunyeTakibiVar).HasColumnName("DIG_MARKANIN_KUNYE_TAKIBI_VAR");

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

            Property(e => e.DigSahisAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_SAHIS_ADI");

            Property(e => e.DigSahisSoyadi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_SAHIS_SOYADI");

            Property(e => e.DigSatinAlaninSifati).HasColumnName("DIG_SATIN_ALANIN_SIFATI");

            Property(e => e.DigSatisTipi).HasColumnName("DIG_SATIS_TIPI");

            Property(e => e.DigSicilKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_SICIL_KODU")
                .IsFixedLength();

            Property(e => e.DigSifati).HasColumnName("DIG_SIFATI");

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

            Property(e => e.DigTuccarKodSiraNo).HasColumnName("DIG_TUCCAR_KOD_SIRA_NO");

            Property(e => e.DigTutarHesaplamaSekli).HasColumnName("DIG_TUTAR_HESAPLAMA_SEKLI");

            Property(e => e.DigVadeFarkiOrani).HasColumnName("DIG_VADE_FARKI_ORANI");

            Property(e => e.DigVeresiyeAsimOlayi).HasColumnName("DIG_VERESIYE_ASIM_OLAYI");

            Property(e => e.DigVeresiyeMizaniAc).HasColumnName("DIG_VERESIYE_MIZANI_AC");

            Property(e => e.DigVergiDairesiId).HasColumnName("DIG_VERGI_DAIRESI_ID");

            Property(e => e.DigVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.DigVergiSorgulayanTcKNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_VERGI_SORGULAYAN_TC_K_NO")
                .IsFixedLength();

            Property(e => e.DigWebKullanicisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_WEB_KULLANICISI");

            Property(e => e.DigWebSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIG_WEB_SIFRESI");

            Property(e => e.DigYazihaneNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_YAZIHANE_NO")
                .IsFixedLength();

            Property(e => e.DigYedekKlasoru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_YEDEK_KLASORU");

            Property(e => e.DigYerId).HasColumnName("DIG_YER_ID");

            Property(e => e.DokAyniMallariToplamaSekli).HasColumnName("DOK_AYNI_MALLARI_TOPLAMA_SEKLI");

            Property(e => e.DokBagkurOrani).HasColumnName("DOK_BAGKUR_ORANI");

            Property(e => e.DokBildirimTuru).HasColumnName("DOK_BILDIRIM_TURU");

            Property(e => e.DokBirimHamaliye).HasColumnName("DOK_BIRIM_HAMALIYE");

            Property(e => e.DokBirimNakliye).HasColumnName("DOK_BIRIM_NAKLIYE");

            Property(e => e.DokBorsaOrani).HasColumnName("DOK_BORSA_ORANI");

            Property(e => e.DokBorsaStopajOrani).HasColumnName("DOK_BORSA_STOPAJ_ORANI");

            Property(e => e.DokCariIslemeDegissin).HasColumnName("DOK_CARI_ISLEME_DEGISSIN");

            Property(e => e.DokCariyeIslemeSekli).HasColumnName("DOK_CARIYE_ISLEME_SEKLI");

            Property(e => e.DokDokumAmbar).HasColumnName("DOK_DOKUM_AMBAR");

            Property(e => e.DokDokumDefterGosterimi).HasColumnName("DOK_DOKUM_DEFTER_GOSTERIMI");

            Property(e => e.DokDokumDefterTipi).HasColumnName("DOK_DOKUM_DEFTER_TIPI");

            Property(e => e.DokDokumDefteriVar).HasColumnName("DOK_DOKUM_DEFTERI_VAR");

            Property(e => e.DokFaturaSiraNo).HasColumnName("DOK_FATURA_SIRA_NO");

            Property(e => e.DokFiyatGirilsin).HasColumnName("DOK_FIYAT_GIRILSIN");

            Property(e => e.DokHamaliyeHesaplamaSekli).HasColumnName("DOK_HAMALIYE_HESAPLAMA_SEKLI");

            Property(e => e.DokHizmetBedeliHesabiId).HasColumnName("DOK_HIZMET_BEDELI_HESABI_ID");

            Property(e => e.DokKapKomisyonaDahil).HasColumnName("DOK_KAP_KOMISYONA_DAHIL");

            Property(e => e.DokKapliEntegrasyonYap).HasColumnName("DOK_KAPLI_ENTEGRASYON_YAP");

            Property(e => e.DokKomisyonKdvOrani).HasColumnName("DOK_KOMISYON_KDV_ORANI");

            Property(e => e.DokKomisyonOrani).HasColumnName("DOK_KOMISYON_ORANI");

            Property(e => e.DokMustahsilCiroSiniri).HasColumnName("DOK_MUSTAHSIL_CIRO_SINIRI");

            Property(e => e.DokNavlunKdvOrani).HasColumnName("DOK_NAVLUN_KDV_ORANI");

            Property(e => e.DokOtomatikHamaliye).HasColumnName("DOK_OTOMATIK_HAMALIYE");

            Property(e => e.DokRusumOrani).HasColumnName("DOK_RUSUM_ORANI");

            Property(e => e.DokSatirdaStokGirisTarihi).HasColumnName("DOK_SATIRDA_STOK_GIRIS_TARIHI");

            Property(e => e.DokStopajOrani).HasColumnName("DOK_STOPAJ_ORANI");

            Property(e => e.DokToplamaMalCalisir).HasColumnName("DOK_TOPLAMA_MAL_CALISIR");

            Property(e => e.DokTuccarKapKdvOrani).HasColumnName("DOK_TUCCAR_KAP_KDV_ORANI");

            Property(e => e.DonemOnayGunSayisi).HasColumnName("DONEM_ONAY_GUN_SAYISI");

            Property(e => e.DonemOnayTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DONEM_ONAY_TARIHI");

            Property(e => e.EArsivBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("E_ARSIV_BASLANGIC_TARIHI");

            Property(e => e.EArsivFaturasiBasilsin).HasColumnName("E_ARSIV_FATURASI_BASILSIN");

            Property(e => e.EArsivFaturasiOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_ARSIV_FATURASI_ON_EKI")
                .IsFixedLength();

            Property(e => e.EArsivFaturasiSiraNo).HasColumnName("E_ARSIV_FATURASI_SIRA_NO");

            Property(e => e.EBelgeServerIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_BELGE_SERVER_IP")
                .IsFixedLength();

            Property(e => e.EBelgeServerPortu).HasColumnName("E_BELGE_SERVER_PORTU");

            Property(e => e.EFaturaBasilsin).HasColumnName("E_FATURA_BASILSIN");

            Property(e => e.EFaturaBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("E_FATURA_BASLANGIC_TARIHI");

            Property(e => e.EFaturaExeYolu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_EXE_YOLU");

            Property(e => e.EFaturaMustahsilVar).HasColumnName("E_FATURA_MUSTAHSIL_VAR");

            Property(e => e.EFaturaMustahsilVknVar).HasColumnName("E_FATURA_MUSTAHSIL_VKN_VAR");

            Property(e => e.EFaturaNotAdetOlsun).HasColumnName("E_FATURA_NOT_ADET_OLSUN");

            Property(e => e.EFaturaOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ON_EKI")
                .IsFixedLength();

            Property(e => e.EFaturaPortalAdresi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_PORTAL_ADRESI");

            Property(e => e.EFaturaSenaryosu).HasColumnName("E_FATURA_SENARYOSU");

            Property(e => e.EFaturaSiraNo).HasColumnName("E_FATURA_SIRA_NO");

            Property(e => e.EFaturaYaziIleSekli).HasColumnName("E_FATURA_YAZI_ILE_SEKLI");

            Property(e => e.EIrsaliyeBasilsin).HasColumnName("E_IRSALIYE_BASILSIN");

            Property(e => e.EIrsaliyeBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("E_IRSALIYE_BASLANGIC_TARIHI");

            Property(e => e.EIrsaliyeOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_ON_EKI")
                .IsFixedLength();

            Property(e => e.EIrsaliyeSiraNo).HasColumnName("E_IRSALIYE_SIRA_NO");

            Property(e => e.EIrsaliyedeFiyatVar).HasColumnName("E_IRSALIYEDE_FIYAT_VAR");

            Property(e => e.EMusFatArsivOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_MUS_FAT_ARSIV_ON_EKI")
                .IsFixedLength();

            Property(e => e.EMusFatArsivSiraNo).HasColumnName("E_MUS_FAT_ARSIV_SIRA_NO");

            Property(e => e.EMustahsilFaturasiOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_MUSTAHSIL_FATURASI_ON_EKI")
                .IsFixedLength();

            Property(e => e.EMustahsilFaturasiSiraNo).HasColumnName("E_MUSTAHSIL_FATURASI_SIRA_NO");

            Property(e => e.EMustahsilMakbuzuBasilsin).HasColumnName("E_MUSTAHSIL_MAKBUZU_BASILSIN");

            Property(e => e.EMustahsilMakbuzuBaslangici)
                .HasColumnType("datetime")
                .HasColumnName("E_MUSTAHSIL_MAKBUZU_BASLANGICI");

            Property(e => e.EMustahsilMakbuzuOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_MUSTAHSIL_MAKBUZU_ON_EKI")
                .IsFixedLength();

            Property(e => e.EMustahsilMakbuzuSiraNo).HasColumnName("E_MUSTAHSIL_MAKBUZU_SIRA_NO");

            Property(e => e.EntegratorCsvDizini)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ENTEGRATOR_CSV_DIZINI");

            Property(e => e.EntegratorYanitVermeSuresi).HasColumnName("ENTEGRATOR_YANIT_VERME_SURESI");

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

            Ignore(e => e.FirEArsivFaturasiGonderilsin);
            /*Property(e => e.FirEArsivFaturasiGonderilsin)
                .HasColumnName("FIR_E_ARSIV_FATURASI_GONDERILSIN");*/
            
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

            Property(e => e.FirmalaraMakbuzKesilsin).HasColumnName("FIRMALARA_MAKBUZ_KESILSIN");

            Property(e => e.FisSiraNo).HasColumnName("FIS_SIRA_NO");

            Property(e => e.HalMudurlukXmlAdi).HasColumnName("HAL_MUDURLUK_XML_ADI");

            Property(e => e.HesBagkurHesabiId).HasColumnName("HES_BAGKUR_HESABI_ID");

            Property(e => e.HesBorsaHesabiId).HasColumnName("HES_BORSA_HESABI_ID");

            Property(e => e.HesCiroPrimiHesabiId).HasColumnName("HES_CIRO_PRIMI_HESABI_ID");

            Property(e => e.HesHamaliyeHesabiId).HasColumnName("HES_HAMALIYE_HESABI_ID");

            Property(e => e.HesIadesizSandikHesabiId).HasColumnName("HES_IADESIZ_SANDIK_HESABI_ID");

            Property(e => e.HesNakliyeHesabiId).HasColumnName("HES_NAKLIYE_HESABI_ID");

            Property(e => e.HesNavlunHesabiId).HasColumnName("HES_NAVLUN_HESABI_ID");

            Property(e => e.HesRehinHesabiId).HasColumnName("HES_REHIN_HESABI_ID");

            Property(e => e.HesRusumHesabiId).HasColumnName("HES_RUSUM_HESABI_ID");

            Property(e => e.HesStopajHesabiId).HasColumnName("HES_STOPAJ_HESABI_ID");

            Property(e => e.HesapYili).HasColumnName("HESAP_YILI");

            Property(e => e.HksBildirimBelediyeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_BILDIRIM_BELEDIYE_ADI");

            Property(e => e.HksDigerKunyeleriKullan).HasColumnName("HKS_DIGER_KUNYELERI_KULLAN");

            Property(e => e.HksKiloKapKarisik).HasColumnName("HKS_KILO_KAP_KARISIK");

            Property(e => e.HksKiloKunyesiOncelikli).HasColumnName("HKS_KILO_KUNYESI_ONCELIKLI");

            Property(e => e.HksKunyeBakiyesiDusmeSekli).HasColumnName("HKS_KUNYE_BAKIYESI_DUSME_SEKLI");

            Property(e => e.HksKunyeSecAcilsin).HasColumnName("HKS_KUNYE_SEC_ACILSIN");

            Property(e => e.HksOfiskunyeWebAdresi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HKS_OFISKUNYE_WEB_ADRESI");

            Property(e => e.HksSatirCogalabilir).HasColumnName("HKS_SATIR_COGALABILIR");

            Property(e => e.HksSatirDetayiVar).HasColumnName("HKS_SATIR_DETAYI_VAR");

            Property(e => e.HksServisAdresi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HKS_SERVIS_ADRESI");

            Property(e => e.HksStokCalismaSekli).HasColumnName("HKS_STOK_CALISMA_SEKLI");

            Property(e => e.HksVarsayilanDegerAtansin).HasColumnName("HKS_VARSAYILAN_DEGER_ATANSIN");

            Property(e => e.HksVarsayilanPlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HKS_VARSAYILAN_PLAKA_NO")
                .IsFixedLength();

            Property(e => e.IadeliKapTutarRehindenAl).HasColumnName("IADELI_KAP_TUTAR_REHINDEN_AL");

            Property(e => e.KdvMuafiyetNedeni)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KDV_MUAFIYET_NEDENI");

            Property(e => e.KunyeCogalmaLog).HasColumnName("KUNYE_COGALMA_LOG");

            Property(e => e.MalKabulSiraNo).HasColumnName("MAL_KABUL_SIRA_NO");

            Property(e => e.MusFatDuzenlemeSekli).HasColumnName("MUS_FAT_DUZENLEME_SEKLI");

            Property(e => e.RptDosyalariKopyalansin).HasColumnName("RPT_DOSYALARI_KOPYALANSIN");

            Property(e => e.SatAyniMallariTopla).HasColumnName("SAT_AYNI_MALLARI_TOPLA");

            Property(e => e.SatBarkodBelgesi).HasColumnName("SAT_BARKOD_BELGESI");

            Property(e => e.SatBarkoduDirekYazdir).HasColumnName("SAT_BARKODU_DIREK_YAZDIR");

            Property(e => e.SatBildirimServisi).HasColumnName("SAT_BILDIRIM_SERVISI");

            Property(e => e.SatBildirimTuru).HasColumnName("SAT_BILDIRIM_TURU");

            Property(e => e.SatBirimKapNakliye).HasColumnName("SAT_BIRIM_KAP_NAKLIYE");

            Property(e => e.SatBirimKiloNakliye).HasColumnName("SAT_BIRIM_KILO_NAKLIYE");

            Property(e => e.SatCiftciTuccarKdv).HasColumnName("SAT_CIFTCI_TUCCAR_KDV");

            Property(e => e.SatDaraDaraliAtlama).HasColumnName("SAT_DARA_DARALI_ATLAMA");

            Property(e => e.SatDaraRehinIliski).HasColumnName("SAT_DARA_REHIN_ILISKI");

            Property(e => e.SatDigerMalKdvOrani).HasColumnName("SAT_DIGER_MAL_KDV_ORANI");

            Property(e => e.SatDokumRusumuAsilabilir).HasColumnName("SAT_DOKUM_RUSUMU_ASILABILIR");

            Property(e => e.SatDokumdenKunyeVar).HasColumnName("SAT_DOKUMDEN_KUNYE_VAR");

            Property(e => e.SatFaturaBelgesi).HasColumnName("SAT_FATURA_BELGESI");

            Property(e => e.SatFaturaDefaultVeresiye).HasColumnName("SAT_FATURA_DEFAULT_VERESIYE");

            Property(e => e.SatFaturaMalGorunumSekli).HasColumnName("SAT_FATURA_MAL_GORUNUM_SEKLI");

            Property(e => e.SatFaturaSatirSayisi).HasColumnName("SAT_FATURA_SATIR_SAYISI");

            Property(e => e.SatFaturaUyarmaSekli).HasColumnName("SAT_FATURA_UYARMA_SEKLI");

            Property(e => e.SatFaturadaKapCiksin).HasColumnName("SAT_FATURADA_KAP_CIKSIN");

            Property(e => e.SatHamaliyeAdlandirma)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAT_HAMALIYE_ADLANDIRMA");

            Property(e => e.SatHamaliyeHesaplamaSekli).HasColumnName("SAT_HAMALIYE_HESAPLAMA_SEKLI");

            Property(e => e.SatIadesizKapHesaplansin).HasColumnName("SAT_IADESIZ_KAP_HESAPLANSIN");

            Property(e => e.SatIadesizKapKdvOrani).HasColumnName("SAT_IADESIZ_KAP_KDV_ORANI");

            Property(e => e.SatIrsaliyeNoBasinaSifir).HasColumnName("SAT_IRSALIYE_NO_BASINA_SIFIR");

            Property(e => e.SatIrsaliyeSiraNo).HasColumnName("SAT_IRSALIYE_SIRA_NO");

            Property(e => e.SatIskontoVar).HasColumnName("SAT_ISKONTO_VAR");

            Property(e => e.SatKdvAtlama).HasColumnName("SAT_KDV_ATLAMA");

            Property(e => e.SatKesilendeOranDegissin).HasColumnName("SAT_KESILENDE_ORAN_DEGISSIN");

            Property(e => e.SatKesilirkenKunyeAl).HasColumnName("SAT_KESILIRKEN_KUNYE_AL");

            Property(e => e.SatKiloOkumaSekli).HasColumnName("SAT_KILO_OKUMA_SEKLI");

            Property(e => e.SatKunyeFiyatiSinirDenetim).HasColumnName("SAT_KUNYE_FIYATI_SINIR_DENETIM");

            Property(e => e.SatKunyeFiyatiSinirOrani).HasColumnName("SAT_KUNYE_FIYATI_SINIR_ORANI");

            Property(e => e.SatKunyePlakaNoKontrolu).HasColumnName("SAT_KUNYE_PLAKA_NO_KONTROLU");

            Property(e => e.SatKunyedeListeFiyatiVar).HasColumnName("SAT_KUNYEDE_LISTE_FIYATI_VAR");

            Property(e => e.SatKunyesizSatirlardaUyar).HasColumnName("SAT_KUNYESIZ_SATIRLARDA_UYAR");

            Property(e => e.SatMalariSirala).HasColumnName("SAT_MALARI_SIRALA");

            Property(e => e.SatNakliyeAdlandirma)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAT_NAKLIYE_ADLANDIRMA");

            Property(e => e.SatNakliyeHesaplamaSekli).HasColumnName("SAT_NAKLIYE_HESAPLAMA_SEKLI");

            Property(e => e.SatNakliyeKdvOrani).HasColumnName("SAT_NAKLIYE_KDV_ORANI");

            Property(e => e.SatOtomatikHamaliye).HasColumnName("SAT_OTOMATIK_HAMALIYE");

            Property(e => e.SatOtomatikNakliye).HasColumnName("SAT_OTOMATIK_NAKLIYE");

            Property(e => e.SatPesinKayitYapilmasin).HasColumnName("SAT_PESIN_KAYIT_YAPILMASIN");

            Property(e => e.SatRehinIadeIslenecegiHsp).HasColumnName("SAT_REHIN_IADE_ISLENECEGI_HSP");

            Property(e => e.SatRehinOtomatikHesaplansin).HasColumnName("SAT_REHIN_OTOMATIK_HESAPLANSIN");

            Property(e => e.SatRehindeMarkaVar).HasColumnName("SAT_REHINDE_MARKA_VAR");

            Property(e => e.SatRusumAtlama).HasColumnName("SAT_RUSUM_ATLAMA");

            Property(e => e.SatRusumKdvGosterimi).HasColumnName("SAT_RUSUM_KDV_GOSTERIMI");

            Property(e => e.SatRusumKdvIliskisi).HasColumnName("SAT_RUSUM_KDV_ILISKISI");

            Property(e => e.SatRusumKdvOrani).HasColumnName("SAT_RUSUM_KDV_ORANI");

            Property(e => e.SatRusumOrani).HasColumnName("SAT_RUSUM_ORANI");

            Property(e => e.SatRusumuHksdenAl).HasColumnName("SAT_RUSUMU_HKSDEN_AL");

            Property(e => e.SatSatFaturaSiraNo).HasColumnName("SAT_SAT_FATURA_SIRA_NO");

            Property(e => e.SatSatirdaFiatKontrol).HasColumnName("SAT_SATIRDA_FIAT_KONTROL");

            Property(e => e.SatSatirdaNotVar).HasColumnName("SAT_SATIRDA_NOT_VAR");

            Property(e => e.SatSatisFatFiyatGelsin).HasColumnName("SAT_SATIS_FAT_FIYAT_GELSIN");

            Property(e => e.SatStokKunyesiDegistir).HasColumnName("SAT_STOK_KUNYESI_DEGISTIR");

            Property(e => e.SatStokMiktariGoster).HasColumnName("SAT_STOK_MIKTARI_GOSTER");

            Property(e => e.SatSubeAdresiniKullan).HasColumnName("SAT_SUBE_ADRESINI_KULLAN");

            Property(e => e.SatTeslimatYeriKopyalansin).HasColumnName("SAT_TESLIMAT_YERI_KOPYALANSIN");

            Property(e => e.SatVerMukMalKdvOrani).HasColumnName("SAT_VER_MUK_MAL_KDV_ORANI");

            Property(e => e.SatVeresiyeUyarisi).HasColumnName("SAT_VERESIYE_UYARISI");

            Property(e => e.SatYuklemeKdvOrani).HasColumnName("SAT_YUKLEME_KDV_ORANI");

            Property(e => e.SonAlinanGibKullaniciTarih)
                .HasColumnType("datetime")
                .HasColumnName("SON_ALINAN_GIB_KULLANICI_TARIH");

            Property(e => e.Surum)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SURUM");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.XsltDosyalariKopyalansin).HasColumnName("XSLT_DOSYALARI_KOPYALANSIN");

            HasOptional(d => d.DigHal)
                .WithMany()
                .HasForeignKey(d => d.DigHalId);

            HasOptional(d => d.DigYer)
                .WithMany()
                .HasForeignKey(d => d.DigYerId);

            HasOptional(d => d.DokHizmetBedeliHesabi)
                .WithMany()
                .HasForeignKey(d => d.DokHizmetBedeliHesabiId);

            HasOptional(d => d.HesBagkurHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesBagkurHesabiId);

            HasOptional(d => d.HesBorsaHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesBorsaHesabiId);

            HasOptional(d => d.HesCiroPrimiHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesCiroPrimiHesabiId);

            HasOptional(d => d.HesHamaliyeHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesHamaliyeHesabiId);

            HasOptional(d => d.HesIadesizSandikHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesIadesizSandikHesabiId);

            HasOptional(d => d.HesNakliyeHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesNakliyeHesabiId);

            HasOptional(d => d.HesNavlunHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesNavlunHesabiId);

            HasOptional(d => d.HesRehinHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesRehinHesabiId);

            HasOptional(d => d.HesRusumHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesRusumHesabiId);

            HasOptional(d => d.HesStopajHesabi)
                .WithMany()
                .HasForeignKey(d => d.HesStopajHesabiId);
        }
    }
}
