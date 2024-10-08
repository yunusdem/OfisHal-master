using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalSatisTanimlariConfiguration : EntityTypeConfiguration<VohalSatisTanimlari>
    {
        public VohalSatisTanimlariConfiguration()
        {
            //HasNoKey();

            HasKey(e => e.SatBarkodBelgesi);

            ToTable("VOHAL_SATIS_TANIMLARI");

            Property(e => e.SatAyniMallariTopla).HasColumnName("SAT_AYNI_MALLARI_TOPLA");

            Property(e => e.SatBarkodBelgesi).HasColumnName("SAT_BARKOD_BELGESI");

            Property(e => e.SatBarkoduDirekYazdir).HasColumnName("SAT_BARKODU_DIREK_YAZDIR");

            Property(e => e.SatBildirimServisi).HasColumnName("SAT_BILDIRIM_SERVISI");

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

            Property(e => e.SatStokKunyesiDegistir).HasColumnName("SAT_STOK_KUNYESI_DEGISTIR");

            Property(e => e.SatStokMiktariGoster).HasColumnName("SAT_STOK_MIKTARI_GOSTER");

            Property(e => e.SatSubeAdresiniKullan).HasColumnName("SAT_SUBE_ADRESINI_KULLAN");

            Property(e => e.SatTeslimatYeriKopyalansin).HasColumnName("SAT_TESLIMAT_YERI_KOPYALANSIN");

            Property(e => e.SatVerMukMalKdvOrani).HasColumnName("SAT_VER_MUK_MAL_KDV_ORANI");

            Property(e => e.SatVeresiyeUyarisi).HasColumnName("SAT_VERESIYE_UYARISI");

            Property(e => e.SatYuklemeKdvOrani).HasColumnName("SAT_YUKLEME_KDV_ORANI");
        }
    }
}
