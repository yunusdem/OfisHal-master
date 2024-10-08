using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalCariKartConfiguration : EntityTypeConfiguration<TohalCariKart>
    {
        public TohalCariKartConfiguration()
        {
            HasKey(e => e.CariKartId);

            ToTable("TOHAL_CARI_KART");

            HasIndex(e => new { e.Tip, e.Ad })
                .IsUnique();

            HasIndex(e => new { e.Tip, e.Kod })
                .IsUnique();

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

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

            Property(e => e.Bakiye).HasColumnName("BAKIYE");

            Property(e => e.BakiyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BAKIYE_TARIHI");

            Property(e => e.BankaHesapNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BANKA_HESAP_NO");

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

            Property(e => e.DaireNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DAIRE_NO")
                .IsFixedLength();

            Property(e => e.Devir).HasColumnName("DEVIR");

            Property(e => e.DigerHesapId).HasColumnName("DIGER_HESAP_ID");

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

            Property(e => e.FiyatListesiId).HasColumnName("FIYAT_LISTESI_ID");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.GibEFaturaPostaKutusuId).HasColumnName("GIB_E_FATURA_POSTA_KUTUSU_ID");

            Property(e => e.GidecegiYerTipi).HasColumnName("GIDECEGI_YER_TIPI");

            Property(e => e.GidecegiYerWebSiraNo).HasColumnName("GIDECEGI_YER_WEB_SIRA_NO");

            Property(e => e.GsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GSM_NO");

            Property(e => e.GunFarki).HasColumnName("GUN_FARKI");

            Property(e => e.Hakkinda)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HAKKINDA");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.HalKomisyoncusu).HasColumnName("HAL_KOMISYONCUSU");

            Property(e => e.HamaliyeHesaplamaSekli).HasColumnName("HAMALIYE_HESAPLAMA_SEKLI");

            Property(e => e.HksBilgisiAlindi).HasColumnName("HKS_BILGISI_ALINDI");

            Property(e => e.Ihracatci).HasColumnName("IHRACATCI");

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

            Property(e => e.KesilmemisFaturaTutari).HasColumnName("KESILMEMIS_FATURA_TUTARI");

            Property(e => e.KesilmeyenDhlRehKapTutari).HasColumnName("KESILMEYEN_DHL_REH_KAP_TUTARI");

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

            Property(e => e.OrtakId).HasColumnName("ORTAK_ID");

            Property(e => e.OrtaklikOrani).HasColumnName("ORTAKLIK_ORANI");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.PostaKoduId).HasColumnName("POSTA_KODU_ID");

            Property(e => e.ReeskontOrani).HasColumnName("REESKONT_ORANI");

            Property(e => e.RehinCariKartId).HasColumnName("REHIN_CARI_KART_ID");

            Property(e => e.RehindekiKapTutari).HasColumnName("REHINDEKI_KAP_TUTARI");

            Property(e => e.RiskSiniri).HasColumnName("RISK_SINIRI");

            Property(e => e.RusumAlinmasin).HasColumnName("RUSUM_ALINMASIN");

            Property(e => e.SatinAlaninSifati).HasColumnName("SATIN_ALANIN_SIFATI");

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.SoforId).HasColumnName("SOFOR_ID");

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

            Property(e => e.UlkeId).HasColumnName("ULKE_ID");

            Property(e => e.Vade).HasColumnName("VADE");

            Property(e => e.VeresiyeSiniri).HasColumnName("VERESIYE_SINIRI");

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

            Property(e => e.YerId).HasColumnName("YER_ID");

            Property(e => e.YetkiliKisi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YETKILI_KISI");

            HasOptional(d => d.BolgeKodu)
                .WithMany(p => p.TohalCariKartBolgeKodus)
                .HasForeignKey(d => d.BolgeKoduId);

            HasOptional(d => d.CariHesap)
                .WithMany(p => p.TohalCariKartCariHesaps)
                .HasForeignKey(d => d.CariHesapId);

            HasOptional(d => d.DigerHesap)
                .WithMany(p => p.TohalCariKartDigerHesaps)
                .HasForeignKey(d => d.DigerHesapId);

            HasOptional(d => d.EIrsaliyePostaKutusu)
                .WithMany(p => p.TohalCariKartEIrsaliyePostaKutusus)
                .HasForeignKey(d => d.EIrsaliyePostaKutusuId);

            HasOptional(d => d.FiyatListesi)
                .WithMany(p => p.TohalCariKarts)
                .HasForeignKey(d => d.FiyatListesiId);

            HasOptional(d => d.GeldigiYer)
                .WithMany(p => p.TohalCariKartGeldigiYers)
                .HasForeignKey(d => d.GeldigiYerId);

            HasOptional(d => d.GibEFaturaPostaKutusu)
                .WithMany(p => p.TohalCariKartGibEFaturaPostaKutusus)
                .HasForeignKey(d => d.GibEFaturaPostaKutusuId);

            HasOptional(d => d.Hal)
                .WithMany(p => p.TohalCariKarts)
                .HasForeignKey(d => d.HalId);

            HasOptional(d => d.Marka)
                .WithMany(p => p.TohalCariKarts)
                .HasForeignKey(d => d.MarkaId);

            HasOptional(d => d.Ortak)
                .WithMany(p => p.InverseOrtak)
                .HasForeignKey(d => d.OrtakId);

            HasOptional(d => d.PostaKodu)
                .WithMany(p => p.TohalCariKartPostaKodus)
                .HasForeignKey(d => d.PostaKoduId);

            HasOptional(d => d.RehinCariKart)
                .WithMany(p => p.InverseRehinCariKart)
                .HasForeignKey(d => d.RehinCariKartId);

            HasOptional(d => d.Sofor)
                .WithMany(p => p.TohalCariKartSofors)
                .HasForeignKey(d => d.SoforId);

            HasOptional(d => d.Ulke)
                .WithMany(p => p.TohalCariKartUlkes)
                .HasForeignKey(d => d.UlkeId);

            HasOptional(d => d.VergiDairesi)
                .WithMany(p => p.TohalCariKartVergiDairesis)
                .HasForeignKey(d => d.VergiDairesiId);

            HasOptional(d => d.Yer)
                .WithMany(p => p.TohalCariKarts)
                .HasForeignKey(d => d.YerId);


        }
    }
}
