using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalFaturaConfiguration : EntityTypeConfiguration<VohalFatura>
    {
        public VohalFaturaConfiguration()
        {
            HasKey(e => e.FaturaId);
            //HasNoKey();

            ToTable("VOHAL_FATURA");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.Aktarildi).HasColumnName("AKTARILDI");

            Property(e => e.BagkurDosyaId).HasColumnName("BAGKUR_DOSYA_ID");

            Property(e => e.BagkurDosyaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAGKUR_DOSYA_NO");

            Property(e => e.BagkurDosyasiMuhasebelesti).HasColumnName("BAGKUR_DOSYASI_MUHASEBELESTI");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeHksId).HasColumnName("BELDE_HKS_ID");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

            Property(e => e.BildirimDurumu).HasColumnName("BILDIRIM_DURUMU");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.CariHamaliyeHesaplamaSekli).HasColumnName("CARI_HAMALIYE_HESAPLAMA_SEKLI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKdvOrani).HasColumnName("CARI_KDV_ORANI");

            Property(e => e.CariKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KOD")
                .IsFixedLength();

            Property(e => e.CariNakliyeHesaplamaSekli).HasColumnName("CARI_NAKLIYE_HESAPLAMA_SEKLI");

            Property(e => e.CariSifati).HasColumnName("CARI_SIFATI");

            Property(e => e.CariUnvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");

            Property(e => e.Degistirildi).HasColumnName("DEGISTIRILDI");

            Property(e => e.EFaturaBolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_BOLGE_KODU");

            Property(e => e.EFaturaCadde).HasColumnName("E_FATURA_CADDE");

            Property(e => e.EFaturaDaireNo).HasColumnName("E_FATURA_DAIRE_NO");

            Property(e => e.EFaturaEposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_EPOSTA");

            Property(e => e.EFaturaEttn)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ETTN");

            Property(e => e.EFaturaFaksi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_FAKSI");

            Property(e => e.EFaturaFaturaKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_FATURA_KODU");

            Property(e => e.EFaturaGsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_GSM_NO");

            Property(e => e.EFaturaIl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_IL");

            Property(e => e.EFaturaIlce)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ILCE");

            Property(e => e.EFaturaKapiNo).HasColumnName("E_FATURA_KAPI_NO");

            Property(e => e.EFaturaMahalle)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_MAHALLE");

            Property(e => e.EFaturaMalverenKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_MALVEREN_KODU")
                .IsFixedLength();

            Property(e => e.EFaturaMusteriAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_MUSTERI_ADI");

            Property(e => e.EFaturaNot)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_NOT");

            Property(e => e.EFaturaPostaKodu).HasColumnName("E_FATURA_POSTA_KODU");

            Property(e => e.EFaturaSemt)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_SEMT");

            Property(e => e.EFaturaSenaryosu).HasColumnName("E_FATURA_SENARYOSU");

            Property(e => e.EFaturaSiparisNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_SIPARIS_NO");

            Property(e => e.EFaturaSiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("E_FATURA_SIPARIS_TARIHI");

            Property(e => e.EFaturaSokak).HasColumnName("E_FATURA_SOKAK");

            Property(e => e.EFaturaTelefon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_TELEFON");

            Property(e => e.EFaturaUlke)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ULKE");

            Property(e => e.EFaturaVergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_VERGI_DAIRESI");

            Property(e => e.EFaturaVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.EFaturaWebAdresi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_WEB_ADRESI");

            Property(e => e.EIrsaliyeEttn)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_ETTN");

            Property(e => e.EPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_POSTA");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.EkleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EKLEYEN_KULLANICI_ADI");

            Property(e => e.FatKesilmedenKunyeAlinamaz).HasColumnName("FAT_KESILMEDEN_KUNYE_ALINAMAZ");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FisId).HasColumnName("FIS_ID");

            Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIS_NO")
                .IsFixedLength();

            Property(e => e.FiyatListesiId).HasColumnName("FIYAT_LISTESI_ID");

            Property(e => e.FiyatReferansFaturaId).HasColumnName("FIYAT_REFERANS_FATURA_ID");

            Property(e => e.FiyatReferansFaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIYAT_REFERANS_FATURA_NO")
                .IsFixedLength();

            Property(e => e.GibFirmamizIrsaliyeKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_FIRMAMIZ_IRSALIYE_KUTUSU");

            Property(e => e.GibFirmamizIrsaliyeKutusuId).HasColumnName("GIB_FIRMAMIZ_IRSALIYE_KUTUSU_ID");

            Property(e => e.GibFirmamizPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU");

            Property(e => e.GibFirmamizPostaKutusuId).HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU_ID");

            Property(e => e.GibMuhatapIrsaliyeKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_MUHATAP_IRSALIYE_KUTUSU");

            Property(e => e.GibMuhatapIrsaliyeKutusuId).HasColumnName("GIB_MUHATAP_IRSALIYE_KUTUSU_ID");

            Property(e => e.GibMuhatapPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_MUHATAP_POSTA_KUTUSU");

            Property(e => e.GibMuhatapPostaKutusuId).HasColumnName("GIB_MUHATAP_POSTA_KUTUSU_ID");

            Property(e => e.GidecegiYerTipi).HasColumnName("GIDECEGI_YER_TIPI");

            Property(e => e.GidecegiYerWebSiraNo).HasColumnName("GIDECEGI_YER_WEB_SIRA_NO");

            Property(e => e.GsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GSM_NO");

            Property(e => e.Guid)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncellemeZamaniString)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEME_ZAMANI_STRING");

            Property(e => e.GuncelleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEYEN_KULLANICI_ADI");

            Property(e => e.HalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HAL_ADI");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.HksMalinNiteligi).HasColumnName("HKS_MALIN_NITELIGI");

            Property(e => e.IadeEdilenKapSayisi).HasColumnName("IADE_EDILEN_KAP_SAYISI");

            Property(e => e.IadeFaturasi).HasColumnName("IADE_FATURASI");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapKdvOrani).HasColumnName("IADESIZ_KAP_KDV_ORANI");

            Property(e => e.IhracatKuru).HasColumnName("IHRACAT_KURU");

            Property(e => e.IhracatParaBirimi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IHRACAT_PARA_BIRIMI");

            Property(e => e.IhracatParaBirimiId).HasColumnName("IHRACAT_PARA_BIRIMI_ID");

            Property(e => e.IhracatParaBirimiKisaltma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IHRACAT_PARA_BIRIMI_KISALTMA");

            Property(e => e.Ihracatci).HasColumnName("IHRACATCI");

            Property(e => e.IlAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL_ADI");

            Property(e => e.IlHksId).HasColumnName("IL_HKS_ID");

            Property(e => e.IlId).HasColumnName("IL_ID");

            Property(e => e.IlceAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE_ADI");

            Property(e => e.IlceHksId).HasColumnName("ILCE_HKS_ID");

            Property(e => e.IlceId).HasColumnName("ILCE_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeZamani)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_ZAMANI");

            Property(e => e.Iskonto).HasColumnName("ISKONTO");

            Property(e => e.IskontoHesaplanmasin).HasColumnName("ISKONTO_HESAPLANMASIN");

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.KdvliIadesizKap).HasColumnName("KDVLI_IADESIZ_KAP");

            Property(e => e.KdvsizIadesizKap).HasColumnName("KDVSIZ_IADESIZ_KAP");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.KrediKartiTahsilati).HasColumnName("KREDI_KARTI_TAHSILATI");

            Property(e => e.MagazaId).HasColumnName("MAGAZA_ID");

            Property(e => e.MagazaKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAGAZA_KODU")
                .IsFixedLength();

            Property(e => e.MalIskontoToplami).HasColumnName("MAL_ISKONTO_TOPLAMI");

            Property(e => e.Marka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.MasrafVar).HasColumnName("MASRAF_VAR");

            Property(e => e.NakitTahsilat).HasColumnName("NAKIT_TAHSILAT");

            Property(e => e.Nakliye).HasColumnName("NAKLIYE");

            Property(e => e.NakliyeKdv).HasColumnName("NAKLIYE_KDV");

            Property(e => e.NakliyeKdvOrani).HasColumnName("NAKLIYE_KDV_ORANI");

            Property(e => e.NavlunMaliyeti).HasColumnName("NAVLUN_MALIYETI");

            Property(e => e.OdemeSekli)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");

            Property(e => e.OdemeSekliId).HasColumnName("ODEME_SEKLI_ID");

            Property(e => e.OdemeSekliKisaltma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI_KISALTMA");

            Property(e => e.OdeyenKurumunVergiDaireId).HasColumnName("ODEYEN_KURUMUN_VERGI_DAIRE_ID");

            Property(e => e.OdeyenKurumunVergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ODEYEN_KURUMUN_VERGI_DAIRESI");

            Property(e => e.OdeyenKurumunVergiNosu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEYEN_KURUMUN_VERGI_NOSU")
                .IsFixedLength();

            Property(e => e.OnBildirimDurumu).HasColumnName("ON_BILDIRIM_DURUMU");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.PosCihaziAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POS_CIHAZI_ADI");

            Property(e => e.PosCihaziId).HasColumnName("POS_CIHAZI_ID");

            Property(e => e.RedDurumu).HasColumnName("RED_DURUMU");

            Property(e => e.ReferansNo)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("REFERANS_NO");

            Property(e => e.RehinDevri).HasColumnName("REHIN_DEVRI");

            Property(e => e.RehinIadeliKap).HasColumnName("REHIN_IADELI_KAP");

            Property(e => e.RehinVar).HasColumnName("REHIN_VAR");

            Property(e => e.RiskSiniri).HasColumnName("RISK_SINIRI");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumKdv).HasColumnName("RUSUM_KDV");

            Property(e => e.RusumKdvIliskisi).HasColumnName("RUSUM_KDV_ILISKISI");

            Property(e => e.RusumKdvOrani).HasColumnName("RUSUM_KDV_ORANI");

            Property(e => e.SehirAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SEHIR_ADI");

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.Sifati).HasColumnName("SIFATI");

            Property(e => e.SigortaMaliyeti).HasColumnName("SIGORTA_MALIYETI");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.SiparisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_NO")
                .IsFixedLength();

            Property(e => e.SoforAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOFOR_ADI");

            Property(e => e.SoforId).HasColumnName("SOFOR_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.TeslimatSekli)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TESLIMAT_SEKLI");

            Property(e => e.TeslimatSekliId).HasColumnName("TESLIMAT_SEKLI_ID");

            Property(e => e.TeslimatSekliKisaltma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TESLIMAT_SEKLI_KISALTMA");

            Property(e => e.TeslimatYeriAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TESLIMAT_YERI_ADI");

            Property(e => e.TeslimatYeriId).HasColumnName("TESLIMAT_YERI_ID");

            Property(e => e.TeslimatYeriTuru).HasColumnName("TESLIMAT_YERI_TURU");

            Property(e => e.TeslimatYeriWebSiraNo).HasColumnName("TESLIMAT_YERI_WEB_SIRA_NO");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.UlasimSekli)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ULASIM_SEKLI");

            Property(e => e.UlasimSekliId).HasColumnName("ULASIM_SEKLI_ID");

            Property(e => e.UlasimSekliKisaltma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ULASIM_SEKLI_KISALTMA");

            Property(e => e.UlkeId).HasColumnName("ULKE_ID");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.Vade).HasColumnName("VADE");

            Property(e => e.Veresiye).HasColumnName("VERESIYE");

            Property(e => e.VeresiyeDurumuDegisti).HasColumnName("VERESIYE_DURUMU_DEGISTI");

            Property(e => e.VeresiyeSiniri).HasColumnName("VERESIYE_SINIRI");

            Property(e => e.VergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI");

            Property(e => e.VergiDairesiId).HasColumnName("VERGI_DAIRESI_ID");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.Yukleme).HasColumnName("YUKLEME");

            Property(e => e.YuklemeKdv).HasColumnName("YUKLEME_KDV");

            Property(e => e.YuklemeKdvOrani).HasColumnName("YUKLEME_KDV_ORANI");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
