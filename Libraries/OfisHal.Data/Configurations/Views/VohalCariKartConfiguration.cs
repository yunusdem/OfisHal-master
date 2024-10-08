using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalCariKartConfiguration : EntityTypeConfiguration<VohalCariKart>
    {
        public VohalCariKartConfiguration()
        {
            HasKey(e => e.CariKartId);
            //HasNoKey();

            ToTable("VOHAL_CARI_KART");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.BabaAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BABA_ADI");

            Property(e => e.BagkurNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BAGKUR_NO")
                .IsFixedLength();

            Property(e => e.BankaHesapNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BANKA_HESAP_NO");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeHksId).HasColumnName("BELDE_HKS_ID");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

            Property(e => e.BolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BOLGE_KODU");

            Property(e => e.BolgeKoduId).HasColumnName("BOLGE_KODU_ID");

            Property(e => e.BorsaSicilNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BORSA_SICIL_NO")
                .IsFixedLength();

            Property(e => e.Cadde)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CADDE");

            Property(e => e.CariHesapId).HasColumnName("CARI_HESAP_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DaireNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DAIRE_NO")
                .IsFixedLength();

            Property(e => e.Devir).HasColumnName("DEVIR");

            Property(e => e.DigerHesapId).HasColumnName("DIGER_HESAP_ID");

            Property(e => e.DigerHesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIGER_HESAP_KODU")
                .IsFixedLength();

            Property(e => e.Dogum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOGUM");

            Property(e => e.EFaturaBakiyeVar).HasColumnName("E_FATURA_BAKIYE_VAR");

            Property(e => e.EFaturaBelgesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_BELGESI");

            Property(e => e.EFaturaBolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_BOLGE_KODU");

            Property(e => e.EFaturaFaturaKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_FATURA_KODU");

            Property(e => e.EFaturaSenaryosu).HasColumnName("E_FATURA_SENARYOSU");

            Property(e => e.EIrsaliyeBelgesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_BELGESI");

            Property(e => e.EIrsaliyePostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_POSTA_KUTUSU");

            Property(e => e.EIrsaliyePostaKutusuId).HasColumnName("E_IRSALIYE_POSTA_KUTUSU_ID");

            Property(e => e.EPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_POSTA");

            Property(e => e.Faks)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FAKS");

            Property(e => e.FatKesilmedenKunyeAlinamaz).HasColumnName("FAT_KESILMEDEN_KUNYE_ALINAMAZ");

            Property(e => e.Filtre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FILTRE");

            Property(e => e.FiyatListesiAciklamasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FIYAT_LISTESI_ACIKLAMASI");

            Property(e => e.FiyatListesiId).HasColumnName("FIYAT_LISTESI_ID");

            Property(e => e.GeldigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.GibEFaturaPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_E_FATURA_POSTA_KUTUSU");

            Property(e => e.GibEFaturaPostaKutusuId).HasColumnName("GIB_E_FATURA_POSTA_KUTUSU_ID");

            Property(e => e.GidecegiYerTipi).HasColumnName("GIDECEGI_YER_TIPI");

            Property(e => e.GidecegiYerWebSiraNo).HasColumnName("GIDECEGI_YER_WEB_SIRA_NO");

            Property(e => e.GsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GSM_NO");

            Property(e => e.GunFarki).HasColumnName("GUN_FARKI");

            Property(e => e.HalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HAL_ADI");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.HalKomisyoncusu).HasColumnName("HAL_KOMISYONCUSU");

            Property(e => e.HamaliyeHesaplamaSekli).HasColumnName("HAMALIYE_HESAPLAMA_SEKLI");

            Property(e => e.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();

            Property(e => e.HksBilgisiAlindi).HasColumnName("HKS_BILGISI_ALINDI");

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

            Property(e => e.KapiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAPI_NO")
                .IsFixedLength();

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Kefil)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KEFIL");

            Property(e => e.KendiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KENDI_KODU")
                .IsFixedLength();

            Property(e => e.KesintiAlinmasin).HasColumnName("KESINTI_ALINMASIN");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Mahalle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAHALLE");

            Property(e => e.MarkaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA_ADI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.MuafiyetBelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUAFIYET_BELGE_NO")
                .IsFixedLength();

            Property(e => e.MuafiyetBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("MUAFIYET_BITIS_TARIHI");

            Property(e => e.NakliyeHesaplamaSekli).HasColumnName("NAKLIYE_HESAPLAMA_SEKLI");

            Property(e => e.Oran).HasColumnName("ORAN");

            Property(e => e.OrtakAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORTAK_ADI");

            Property(e => e.OrtakId).HasColumnName("ORTAK_ID");

            Property(e => e.OrtaklikOrani).HasColumnName("ORTAKLIK_ORANI");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.PostaKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POSTA_KODU");

            Property(e => e.PostaKoduId).HasColumnName("POSTA_KODU_ID");

            Property(e => e.ReeskontOrani).HasColumnName("REESKONT_ORANI");

            Property(e => e.RehinCariKartAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REHIN_CARI_KART_ADI");

            Property(e => e.RehinCariKartId).HasColumnName("REHIN_CARI_KART_ID");

            Property(e => e.RiskSiniri).HasColumnName("RISK_SINIRI");

            Property(e => e.RusumAlinmasin).HasColumnName("RUSUM_ALINMASIN");

            Property(e => e.SatinAlaninSifati).HasColumnName("SATIN_ALANIN_SIFATI");

            Property(e => e.Sehir)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SEHIR");

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.SoforAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOFOR_ADI");

            Property(e => e.SoforId).HasColumnName("SOFOR_ID");

            Property(e => e.SoforTckn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOFOR_TCKN");

            Property(e => e.Sokak)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOKAK");

            Property(e => e.StopajsizKesebilir).HasColumnName("STOPAJSIZ_KESEBILIR");

            Property(e => e.Tel1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL1");

            Property(e => e.Tel2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL2");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.UlkeHksId).HasColumnName("ULKE_HKS_ID");

            Property(e => e.UlkeId).HasColumnName("ULKE_ID");

            Property(e => e.Vade).HasColumnName("VADE");

            Property(e => e.VeresiyeSiniri).HasColumnName("VERESIYE_SINIRI");

            Property(e => e.VergiDairesiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI_ADI");

            Property(e => e.VergiDairesiId).HasColumnName("VERGI_DAIRESI_ID");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.VergiNoSorgulandi).HasColumnName("VERGI_NO_SORGULANDI");

            Property(e => e.WebAdresi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WEB_ADRESI");

            Property(e => e.YazihaneNot)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_NOT");

            Property(e => e.YazihaneSiraNo).HasColumnName("YAZIHANE_SIRA_NO");

            Property(e => e.YetkiliKisi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YETKILI_KISI");
        }
    }
}
