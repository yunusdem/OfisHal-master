using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal00SatisFaturasiConfiguration : EntityTypeConfiguration<Vohal00SatisFaturasi>
    {
        public Vohal00SatisFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_00_SATIS_FATURASI");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.Aktarildi).HasColumnName("AKTARILDI");

            Property(e => e.BagkurDosyaId).HasColumnName("BAGKUR_DOSYA_ID");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariSifati).HasColumnName("CARI_SIFATI");

            Property(e => e.Degistirildi).HasColumnName("DEGISTIRILDI");

            Property(e => e.EFaturaBolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_BOLGE_KODU");

            Property(e => e.EFaturaDurumu).HasColumnName("E_FATURA_DURUMU");

            Property(e => e.EFaturaEttn)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ETTN");

            Property(e => e.EFaturaGibDurumu).HasColumnName("E_FATURA_GIB_DURUMU");

            Property(e => e.EFaturaHataAciklamasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_HATA_ACIKLAMASI");

            Property(e => e.EFaturaNot)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_NOT");

            Property(e => e.EFaturaSiparisNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_SIPARIS_NO");

            Property(e => e.EFaturaSiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("E_FATURA_SIPARIS_TARIHI");

            Property(e => e.EIrsaliyeDurumu).HasColumnName("E_IRSALIYE_DURUMU");

            Property(e => e.EIrsaliyeEttn)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_ETTN");

            Property(e => e.EIrsaliyeGibDurumu).HasColumnName("E_IRSALIYE_GIB_DURUMU");

            Property(e => e.EIrsaliyeHataAciklamasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_HATA_ACIKLAMASI");

            Property(e => e.EPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_POSTA");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.FaturaId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FisId).HasColumnName("FIS_ID");

            Property(e => e.FiyatReferansFaturaId).HasColumnName("FIYAT_REFERANS_FATURA_ID");

            Property(e => e.GibFirmamizPostaKutusuId).HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU_ID");

            Property(e => e.GibFrmIrsaliyeKutusuId).HasColumnName("GIB_FRM_IRSALIYE_KUTUSU_ID");

            Property(e => e.GibMuhatapIrsaliyeKutusuId).HasColumnName("GIB_MUHATAP_IRSALIYE_KUTUSU_ID");

            Property(e => e.GibMuhatapPostaKutusuId).HasColumnName("GIB_MUHATAP_POSTA_KUTUSU_ID");

            Property(e => e.GidecegiYerTipi).HasColumnName("GIDECEGI_YER_TIPI");

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

            Property(e => e.GuncelleyenId).HasColumnName("GUNCELLEYEN_ID");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.HksMalinNiteligi).HasColumnName("HKS_MALIN_NITELIGI");

            Property(e => e.HksWebSiraNo).HasColumnName("HKS_WEB_SIRA_NO");

            Property(e => e.IadeFaturasi).HasColumnName("IADE_FATURASI");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapKdvOrani).HasColumnName("IADESIZ_KAP_KDV_ORANI");

            Property(e => e.IhracatKuru).HasColumnName("IHRACAT_KURU");

            Property(e => e.IhracatParaBirimiId).HasColumnName("IHRACAT_PARA_BIRIMI_ID");

            Property(e => e.Ihracatci).HasColumnName("IHRACATCI");

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

            Property(e => e.KunyeIstekGuid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUNYE_ISTEK_GUID");

            Property(e => e.MagazaId).HasColumnName("MAGAZA_ID");

            Property(e => e.MalIskontoToplami).HasColumnName("MAL_ISKONTO_TOPLAMI");

            Property(e => e.NakitTahsilat).HasColumnName("NAKIT_TAHSILAT");

            Property(e => e.Nakliye).HasColumnName("NAKLIYE");

            Property(e => e.NakliyeKdv).HasColumnName("NAKLIYE_KDV");

            Property(e => e.NakliyeKdvOrani).HasColumnName("NAKLIYE_KDV_ORANI");

            Property(e => e.NavlunMaliyeti).HasColumnName("NAVLUN_MALIYETI");

            Property(e => e.OdemeSekliId).HasColumnName("ODEME_SEKLI_ID");

            Property(e => e.OdeyenKurumunVergiDaireId).HasColumnName("ODEYEN_KURUMUN_VERGI_DAIRE_ID");

            Property(e => e.OdeyenKurumunVergiNosu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEYEN_KURUMUN_VERGI_NOSU")
                .IsFixedLength();

            Property(e => e.Onaylandi).HasColumnName("ONAYLANDI");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.PosCihaziId).HasColumnName("POS_CIHAZI_ID");

            Property(e => e.RehinDevri).HasColumnName("REHIN_DEVRI");

            Property(e => e.RehinIadeliKap).HasColumnName("REHIN_IADELI_KAP");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumKdv).HasColumnName("RUSUM_KDV");

            Property(e => e.RusumKdvIliskisi).HasColumnName("RUSUM_KDV_ILISKISI");

            Property(e => e.RusumKdvOrani).HasColumnName("RUSUM_KDV_ORANI");

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.Sifati).HasColumnName("SIFATI");

            Property(e => e.SigortaMaliyeti).HasColumnName("SIGORTA_MALIYETI");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.SoforId).HasColumnName("SOFOR_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.TeslimatSekliId).HasColumnName("TESLIMAT_SEKLI_ID");

            Property(e => e.TeslimatYeriId).HasColumnName("TESLIMAT_YERI_ID");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.UlasimSekliId).HasColumnName("ULASIM_SEKLI_ID");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.Vade).HasColumnName("VADE");

            Property(e => e.Veresiye).HasColumnName("VERESIYE");

            Property(e => e.VeresiyeDurumuDegisti).HasColumnName("VERESIYE_DURUMU_DEGISTI");

            Property(e => e.VergiDairesiId).HasColumnName("VERGI_DAIRESI_ID");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.YerId).HasColumnName("YER_ID");

            Property(e => e.Yukleme).HasColumnName("YUKLEME");

            Property(e => e.YuklemeKdv).HasColumnName("YUKLEME_KDV");

            Property(e => e.YuklemeKdvOrani).HasColumnName("YUKLEME_KDV_ORANI");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
