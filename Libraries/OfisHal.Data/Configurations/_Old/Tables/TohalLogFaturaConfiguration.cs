using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogFaturaConfiguration : EntityTypeConfiguration<TohalLogFatura>
    {
        public TohalLogFaturaConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_FATURA");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAdres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_ADRES");

            Property(e => e.OBagkurDosyaId).HasColumnName("O_BAGKUR_DOSYA_ID");

            Property(e => e.OBildirimTuru).HasColumnName("O_BILDIRIM_TURU");

            Property(e => e.OCariKartId).HasColumnName("O_CARI_KART_ID");

            Property(e => e.OCariSifati).HasColumnName("O_CARI_SIFATI");

            Property(e => e.ODegistirildi).HasColumnName("O_DEGISTIRILDI");

            Property(e => e.OEPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O_E_POSTA");

            Property(e => e.OFaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_FATURA_NO")
                .IsFixedLength();

            Property(e => e.OFisId).HasColumnName("O_FIS_ID");

            Property(e => e.OFiyatReferansFaturaId).HasColumnName("O_FIYAT_REFERANS_FATURA_ID");

            Property(e => e.OGidecegiYerTipi).HasColumnName("O_GIDECEGI_YER_TIPI");

            Property(e => e.OGsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_GSM_NO");

            Property(e => e.OGuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("O_GUNCELLEME_ZAMANI");

            Property(e => e.OHalId).HasColumnName("O_HAL_ID");

            Property(e => e.OHksMalinNiteligi).HasColumnName("O_HKS_MALIN_NITELIGI");

            Property(e => e.OHksWebSiraNo).HasColumnName("O_HKS_WEB_SIRA_NO");

            Property(e => e.OIadesizKapKdv).HasColumnName("O_IADESIZ_KAP_KDV");

            Property(e => e.OIadesizKapKdvOrani).HasColumnName("O_IADESIZ_KAP_KDV_ORANI");

            Property(e => e.OIhracatKuru).HasColumnName("O_IHRACAT_KURU");

            Property(e => e.OIhracatParaBirimiId).HasColumnName("O_IHRACAT_PARA_BIRIMI_ID");

            Property(e => e.OIhracatci).HasColumnName("O_IHRACATCI");

            Property(e => e.OIrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.OIrsaliyeZamani)
                .HasColumnType("datetime")
                .HasColumnName("O_IRSALIYE_ZAMANI");

            Property(e => e.OIskonto).HasColumnName("O_ISKONTO");

            Property(e => e.OIskontoOrani).HasColumnName("O_ISKONTO_ORANI");

            Property(e => e.OKdvliIadesizKap).HasColumnName("O_KDVLI_IADESIZ_KAP");

            Property(e => e.OKdvsizIadesizKap).HasColumnName("O_KDVSIZ_IADESIZ_KAP");

            Property(e => e.OKesildi).HasColumnName("O_KESILDI");

            Property(e => e.OKisilikTipi).HasColumnName("O_KISILIK_TIPI");

            Property(e => e.OKrediKartiTahsilati).HasColumnName("O_KREDI_KARTI_TAHSILATI");

            Property(e => e.OMagazaId).HasColumnName("O_MAGAZA_ID");

            Property(e => e.OMalIskontoToplami).HasColumnName("O_MAL_ISKONTO_TOPLAMI");

            Property(e => e.ONakitTahsilat).HasColumnName("O_NAKIT_TAHSILAT");

            Property(e => e.ONakliye).HasColumnName("O_NAKLIYE");

            Property(e => e.ONakliyeKdv).HasColumnName("O_NAKLIYE_KDV");

            Property(e => e.ONakliyeKdvOrani).HasColumnName("O_NAKLIYE_KDV_ORANI");

            Property(e => e.ONavlunMaliyeti).HasColumnName("O_NAVLUN_MALIYETI");

            Property(e => e.OOdemeSekliId).HasColumnName("O_ODEME_SEKLI_ID");

            Property(e => e.OOdeyenKurumunVergiDaireId).HasColumnName("O_ODEYEN_KURUMUN_VERGI_DAIRE_ID");

            Property(e => e.OOdeyenKurumunVergiNosu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_ODEYEN_KURUMUN_VERGI_NOSU")
                .IsFixedLength();

            Property(e => e.OPlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_PLAKA_NO")
                .IsFixedLength();

            Property(e => e.OPosCihaziId).HasColumnName("O_POS_CIHAZI_ID");

            Property(e => e.ORehinIadeliKap).HasColumnName("O_REHIN_IADELI_KAP");

            Property(e => e.ORusum).HasColumnName("O_RUSUM");

            Property(e => e.ORusumKdv).HasColumnName("O_RUSUM_KDV");

            Property(e => e.ORusumKdvIliskisi).HasColumnName("O_RUSUM_KDV_ILISKISI");

            Property(e => e.ORusumKdvOrani).HasColumnName("O_RUSUM_KDV_ORANI");

            Property(e => e.OSifati).HasColumnName("O_SIFATI");

            Property(e => e.OSigortaMaliyeti).HasColumnName("O_SIGORTA_MALIYETI");

            Property(e => e.OSiparisId).HasColumnName("O_SIPARIS_ID");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OTeslimatSekliId).HasColumnName("O_TESLIMAT_SEKLI_ID");

            Property(e => e.OTeslimatYeriId).HasColumnName("O_TESLIMAT_YERI_ID");

            Property(e => e.OTip).HasColumnName("O_TIP");

            Property(e => e.OUlasimSekliId).HasColumnName("O_ULASIM_SEKLI_ID");

            Property(e => e.OUnvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_UNVAN");

            Property(e => e.OVade).HasColumnName("O_VADE");

            Property(e => e.OVeresiye).HasColumnName("O_VERESIYE");

            Property(e => e.OVergiDairesiId).HasColumnName("O_VERGI_DAIRESI_ID");

            Property(e => e.OVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.OYerId).HasColumnName("O_YER_ID");

            Property(e => e.OYukleme).HasColumnName("O_YUKLEME");

            Property(e => e.OYuklemeKdv).HasColumnName("O_YUKLEME_KDV");

            Property(e => e.OYuklemeKdvOrani).HasColumnName("O_YUKLEME_KDV_ORANI");

            Property(e => e.OZaman)
                .HasColumnType("datetime")
                .HasColumnName("O_ZAMAN");

            Property(e => e.SAdres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_ADRES");

            Property(e => e.SBagkurDosyaId).HasColumnName("S_BAGKUR_DOSYA_ID");

            Property(e => e.SBildirimTuru).HasColumnName("S_BILDIRIM_TURU");

            Property(e => e.SCariKartId).HasColumnName("S_CARI_KART_ID");

            Property(e => e.SCariSifati).HasColumnName("S_CARI_SIFATI");

            Property(e => e.SDegistirildi).HasColumnName("S_DEGISTIRILDI");

            Property(e => e.SEPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_E_POSTA");

            Property(e => e.SFaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_FATURA_NO")
                .IsFixedLength();

            Property(e => e.SFisId).HasColumnName("S_FIS_ID");

            Property(e => e.SFiyatReferansFaturaId).HasColumnName("S_FIYAT_REFERANS_FATURA_ID");

            Property(e => e.SGidecegiYerTipi).HasColumnName("S_GIDECEGI_YER_TIPI");

            Property(e => e.SGsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_GSM_NO");

            Property(e => e.SGuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("S_GUNCELLEME_ZAMANI");

            Property(e => e.SHalId).HasColumnName("S_HAL_ID");

            Property(e => e.SHksMalinNiteligi).HasColumnName("S_HKS_MALIN_NITELIGI");

            Property(e => e.SHksWebSiraNo).HasColumnName("S_HKS_WEB_SIRA_NO");

            Property(e => e.SIadesizKapKdv).HasColumnName("S_IADESIZ_KAP_KDV");

            Property(e => e.SIadesizKapKdvOrani).HasColumnName("S_IADESIZ_KAP_KDV_ORANI");

            Property(e => e.SIhracatKuru).HasColumnName("S_IHRACAT_KURU");

            Property(e => e.SIhracatParaBirimiId).HasColumnName("S_IHRACAT_PARA_BIRIMI_ID");

            Property(e => e.SIhracatci).HasColumnName("S_IHRACATCI");

            Property(e => e.SIrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.SIrsaliyeZamani)
                .HasColumnType("datetime")
                .HasColumnName("S_IRSALIYE_ZAMANI");

            Property(e => e.SIskonto).HasColumnName("S_ISKONTO");

            Property(e => e.SIskontoOrani).HasColumnName("S_ISKONTO_ORANI");

            Property(e => e.SKdvliIadesizKap).HasColumnName("S_KDVLI_IADESIZ_KAP");

            Property(e => e.SKdvsizIadesizKap).HasColumnName("S_KDVSIZ_IADESIZ_KAP");

            Property(e => e.SKesildi).HasColumnName("S_KESILDI");

            Property(e => e.SKisilikTipi).HasColumnName("S_KISILIK_TIPI");

            Property(e => e.SKrediKartiTahsilati).HasColumnName("S_KREDI_KARTI_TAHSILATI");

            Property(e => e.SMagazaId).HasColumnName("S_MAGAZA_ID");

            Property(e => e.SMalIskontoToplami).HasColumnName("S_MAL_ISKONTO_TOPLAMI");

            Property(e => e.SNakitTahsilat).HasColumnName("S_NAKIT_TAHSILAT");

            Property(e => e.SNakliye).HasColumnName("S_NAKLIYE");

            Property(e => e.SNakliyeKdv).HasColumnName("S_NAKLIYE_KDV");

            Property(e => e.SNakliyeKdvOrani).HasColumnName("S_NAKLIYE_KDV_ORANI");

            Property(e => e.SNavlunMaliyeti).HasColumnName("S_NAVLUN_MALIYETI");

            Property(e => e.SOdemeSekliId).HasColumnName("S_ODEME_SEKLI_ID");

            Property(e => e.SOdeyenKurumunVergiDaireId).HasColumnName("S_ODEYEN_KURUMUN_VERGI_DAIRE_ID");

            Property(e => e.SOdeyenKurumunVergiNosu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_ODEYEN_KURUMUN_VERGI_NOSU")
                .IsFixedLength();

            Property(e => e.SPlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_PLAKA_NO")
                .IsFixedLength();

            Property(e => e.SPosCihaziId).HasColumnName("S_POS_CIHAZI_ID");

            Property(e => e.SRehinIadeliKap).HasColumnName("S_REHIN_IADELI_KAP");

            Property(e => e.SRusum).HasColumnName("S_RUSUM");

            Property(e => e.SRusumKdv).HasColumnName("S_RUSUM_KDV");

            Property(e => e.SRusumKdvIliskisi).HasColumnName("S_RUSUM_KDV_ILISKISI");

            Property(e => e.SRusumKdvOrani).HasColumnName("S_RUSUM_KDV_ORANI");

            Property(e => e.SSifati).HasColumnName("S_SIFATI");

            Property(e => e.SSigortaMaliyeti).HasColumnName("S_SIGORTA_MALIYETI");

            Property(e => e.SSiparisId).HasColumnName("S_SIPARIS_ID");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.STeslimatSekliId).HasColumnName("S_TESLIMAT_SEKLI_ID");

            Property(e => e.STeslimatYeriId).HasColumnName("S_TESLIMAT_YERI_ID");

            Property(e => e.STip).HasColumnName("S_TIP");

            Property(e => e.SUlasimSekliId).HasColumnName("S_ULASIM_SEKLI_ID");

            Property(e => e.SUnvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_UNVAN");

            Property(e => e.SVade).HasColumnName("S_VADE");

            Property(e => e.SVeresiye).HasColumnName("S_VERESIYE");

            Property(e => e.SVergiDairesiId).HasColumnName("S_VERGI_DAIRESI_ID");

            Property(e => e.SVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.SYerId).HasColumnName("S_YER_ID");

            Property(e => e.SYukleme).HasColumnName("S_YUKLEME");

            Property(e => e.SYuklemeKdv).HasColumnName("S_YUKLEME_KDV");

            Property(e => e.SYuklemeKdvOrani).HasColumnName("S_YUKLEME_KDV_ORANI");

            Property(e => e.SZaman)
                .HasColumnType("datetime")
                .HasColumnName("S_ZAMAN");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
