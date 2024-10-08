using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalMakbuzConfiguration : EntityTypeConfiguration<VohalMakbuz>
    {
        public VohalMakbuzConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.MakbuzId);
            ToTable("VOHAL_MAKBUZ");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AdTarih)
                .HasMaxLength(210)
                .IsUnicode(false)
                .HasColumnName("AD_TARIH");

            Property(e => e.Bagkur).HasColumnName("BAGKUR");

            Property(e => e.BagkurDosyaId).HasColumnName("BAGKUR_DOSYA_ID");

            Property(e => e.BagkurDosyaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAGKUR_DOSYA_NO");

            Property(e => e.BagkurDosyasiMuhasebelesti).HasColumnName("BAGKUR_DOSYASI_MUHASEBELESTI");

            Property(e => e.BagkurHesaplanmasin).HasColumnName("BAGKUR_HESAPLANMASIN");

            Property(e => e.BagkurOrani).HasColumnName("BAGKUR_ORANI");

            Property(e => e.BekleyenHareketSayisi).HasColumnName("BEKLEYEN_HAREKET_SAYISI");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeHksId).HasColumnName("BELDE_HKS_ID");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

            Property(e => e.BildirimDurumu).HasColumnName("BILDIRIM_DURUMU");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.Borsa).HasColumnName("BORSA");

            Property(e => e.BorsaOrani).HasColumnName("BORSA_ORANI");

            Property(e => e.CariAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KODU")
                .IsFixedLength();

            Property(e => e.CariyeIslemeSekli).HasColumnName("CARIYE_ISLEME_SEKLI");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.DonenAlanDegeri)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DONEN_ALAN_DEGERI");

            Property(e => e.EFaturaBolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_BOLGE_KODU");

            Property(e => e.EFaturaCadde).HasColumnName("E_FATURA_CADDE");

            Property(e => e.EFaturaDaireNo).HasColumnName("E_FATURA_DAIRE_NO");

            Property(e => e.EFaturaDurumu).HasColumnName("E_FATURA_DURUMU");

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
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_MUSTERI_ADI");

            Property(e => e.EFaturaNot)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_NOT");

            Property(e => e.EFaturaPostaKodu).HasColumnName("E_FATURA_POSTA_KODU");

            Property(e => e.EFaturaSemt)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_SEMT");

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

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.FaturaZamani)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_ZAMANI");

            Property(e => e.GelenKap).HasColumnName("GELEN_KAP");

            Property(e => e.GelenMiktar).HasColumnName("GELEN_MIKTAR");

            Property(e => e.GibFirmamizPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU");

            Property(e => e.GibFirmamizPostaKutusuId).HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU_ID");

            Property(e => e.GibMuhatapPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_MUHATAP_POSTA_KUTUSU");

            Property(e => e.GibMuhatapPostaKutusuId).HasColumnName("GIB_MUHATAP_POSTA_KUTUSU_ID");

            Property(e => e.GsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GSM_NO");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

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

            Property(e => e.HksWebSiraNo).HasColumnName("HKS_WEB_SIRA_NO");

            Property(e => e.IadeliKapTutari).HasColumnName("IADELI_KAP_TUTARI");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapKdvOrani).HasColumnName("IADESIZ_KAP_KDV_ORANI");

            Property(e => e.IadesizKapKomisyonaDahil).HasColumnName("IADESIZ_KAP_KOMISYONA_DAHIL");

            Property(e => e.IadesizKapTutari).HasColumnName("IADESIZ_KAP_TUTARI");

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

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.KodTarih)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KOD_TARIH")
                .IsFixedLength();

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.KomisyonKdv).HasColumnName("KOMISYON_KDV");

            Property(e => e.KomisyonKdvOrani).HasColumnName("KOMISYON_KDV_ORANI");

            Property(e => e.KomisyonOrani).HasColumnName("KOMISYON_ORANI");

            Property(e => e.MakbuzGuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("MAKBUZ_GUNCELLEME_ZAMANI");

            Property(e => e.MakbuzGuncelleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAKBUZ_GUNCELLEYEN_KULLANICI_ADI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MakbuzdakiKap).HasColumnName("MAKBUZDAKI_KAP");

            Property(e => e.MakbuzdakiMiktar).HasColumnName("MAKBUZDAKI_MIKTAR");

            Property(e => e.MalKdv).HasColumnName("MAL_KDV");

            Property(e => e.MalTutari).HasColumnName("MAL_TUTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.MasrafKdv).HasColumnName("MASRAF_KDV");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.OrtakAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORTAK_ADI");

            Property(e => e.OrtakId).HasColumnName("ORTAK_ID");

            Property(e => e.OrtaklikOrani).HasColumnName("ORTAKLIK_ORANI");

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.RedDurumu).HasColumnName("RED_DURUMU");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

            Property(e => e.SatilanKap).HasColumnName("SATILAN_KAP");

            Property(e => e.SatilanMiktar).HasColumnName("SATILAN_MIKTAR");

            Property(e => e.Sifati).HasColumnName("SIFATI");

            Property(e => e.Siralama).HasColumnName("SIRALAMA");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.Stopaj).HasColumnName("STOPAJ");

            Property(e => e.StopajOrani).HasColumnName("STOPAJ_ORANI");

            Property(e => e.TeslimatYeriAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TESLIMAT_YERI_ADI");

            Property(e => e.TeslimatYeriId).HasColumnName("TESLIMAT_YERI_ID");

            Property(e => e.TeslimatYeriTuru).HasColumnName("TESLIMAT_YERI_TURU");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.UlkeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ULKE_ADI");

            Property(e => e.UlkeId).HasColumnName("ULKE_ID");

            Property(e => e.Vade).HasColumnName("VADE");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
