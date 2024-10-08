using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalKullaniciConfiguration : EntityTypeConfiguration<VohalKullanici>
    {
        public VohalKullaniciConfiguration()
        {
            HasKey(e => e.KullaniciId);
            //HasNoKey();

            ToTable("VOHAL_KULLANICI");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AlisFaturasiSiraNo).HasColumnName("ALIS_FATURASI_SIRA_NO");

            Property(e => e.AlisIslemleriYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ALIS_ISLEMLERI_YETKISI");

            Property(e => e.AmbarCariYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("AMBAR_CARI_YETKISI");

            Property(e => e.AmbarFaturaMenusuYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("AMBAR_FATURA_MENUSU_YETKISI");

            Property(e => e.AnaMenuYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ANA_MENU_YETKISI");

            Property(e => e.BankaIslemleriYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("BANKA_ISLEMLERI_YETKISI");

            Property(e => e.BarkodYaziciId).HasColumnName("BARKOD_YAZICI_ID");

            Property(e => e.BarkodYaziciNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BARKOD_YAZICI_NO");

            Property(e => e.CekSenetIslemleriYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CEK_SENET_ISLEMLERI_YETKISI");

            Property(e => e.DegisiklikTakipSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEGISIKLIK_TAKIP_SIFRESI");

            Property(e => e.DialogFontu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIALOG_FONTU");

            Property(e => e.DikeyZoom).HasColumnName("DIKEY_ZOOM");

            Property(e => e.DokumIslemleriYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("DOKUM_ISLEMLERI_YETKISI");

            Property(e => e.EArsivFaturasiOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_ARSIV_FATURASI_ON_EKI")
                .IsFixedLength();

            Property(e => e.EArsivFaturasiSiraNo).HasColumnName("E_ARSIV_FATURASI_SIRA_NO");

            Property(e => e.EBelgeKullaniliyor).HasColumnName("E_BELGE_KULLANILIYOR");

            Property(e => e.EFaturaGondericiBirimi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_GONDERICI_BIRIMI");

            Property(e => e.EFaturaGondericiBirimiId).HasColumnName("E_FATURA_GONDERICI_BIRIMI_ID");

            Property(e => e.EFaturaOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ON_EKI")
                .IsFixedLength();

            Property(e => e.EFaturaSiraNo).HasColumnName("E_FATURA_SIRA_NO");

            Property(e => e.EIrsaliyeGondericiBirimi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_GONDERICI_BIRIMI");

            Property(e => e.EIrsaliyeGondericiBirimiId).HasColumnName("E_IRSALIYE_GONDERICI_BIRIMI_ID");

            Property(e => e.EIrsaliyeOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_ON_EKI")
                .IsFixedLength();

            Property(e => e.EIrsaliyeSiraNo).HasColumnName("E_IRSALIYE_SIRA_NO");

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

            Property(e => e.EMustahsilMakbuzuOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_MUSTAHSIL_MAKBUZU_ON_EKI")
                .IsFixedLength();

            Property(e => e.EMustahsilMakbuzuSiraNo).HasColumnName("E_MUSTAHSIL_MAKBUZU_SIRA_NO");

            Property(e => e.EntegratorKullaniciAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ENTEGRATOR_KULLANICI_ADI");

            Property(e => e.EntegratorKullaniciSifresi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ENTEGRATOR_KULLANICI_SIFRESI");

            Property(e => e.FisSiraNo).HasColumnName("FIS_SIRA_NO");

            Property(e => e.GridBaslikRengi).HasColumnName("GRID_BASLIK_RENGI");

            Property(e => e.GridFontu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GRID_FONTU");

            Property(e => e.GridZeminRengi).HasColumnName("GRID_ZEMIN_RENGI");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.HalCariYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("HAL_CARI_YETKISI");

            Property(e => e.IrsaliyeYaziciId).HasColumnName("IRSALIYE_YAZICI_ID");

            Property(e => e.IrsaliyeYaziciNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_YAZICI_NO");

            Property(e => e.KaldigiAlsFaturaId).HasColumnName("KALDIGI_ALS_FATURA_ID");

            Property(e => e.KaldigiSatFaturaId).HasColumnName("KALDIGI_SAT_FATURA_ID");

            Property(e => e.KasaIslemleriYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("KASA_ISLEMLERI_YETKISI");

            Property(e => e.KayitGostermeGunSayisi).HasColumnName("KAYIT_GOSTERME_GUN_SAYISI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.MalKabulSiraNo).HasColumnName("MAL_KABUL_SIRA_NO");

            Property(e => e.MenuArkaPlanRengi).HasColumnName("MENU_ARKA_PLAN_RENGI");

            Property(e => e.MenuBaslikFontu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MENU_BASLIK_FONTU");

            Property(e => e.MenuFontu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MENU_FONTU");

            Property(e => e.MobilYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("MOBIL_YETKISI");

            Property(e => e.MuhasebeYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("MUHASEBE_YETKISI");

            Property(e => e.MustahsilCariYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_CARI_YETKISI");

            Property(e => e.MustahsilFaturasiSiraNo).HasColumnName("MUSTAHSIL_FATURASI_SIRA_NO");

            Property(e => e.MustahsilYaziciId).HasColumnName("MUSTAHSIL_YAZICI_ID");

            Property(e => e.MustahsilYaziciNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_YAZICI_NO");

            Property(e => e.MusteriCariYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_CARI_YETKISI");

            Property(e => e.NavlunEFaturaOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NAVLUN_E_FATURA_ON_EKI")
                .IsFixedLength();

            Property(e => e.NavlunFaturaSiraNo).HasColumnName("NAVLUN_FATURA_SIRA_NO");

            Property(e => e.PencereFokusRengi).HasColumnName("PENCERE_FOKUS_RENGI");

            Property(e => e.PencereYaziRengi).HasColumnName("PENCERE_YAZI_RENGI");

            Property(e => e.PencereZeminRengi).HasColumnName("PENCERE_ZEMIN_RENGI");

            Property(e => e.ProgramYaziRengi).HasColumnName("PROGRAM_YAZI_RENGI");

            Property(e => e.ProgramZeminRengi).HasColumnName("PROGRAM_ZEMIN_RENGI");

            Property(e => e.ResmiFormlarYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("RESMI_FORMLAR_YETKISI");

            Property(e => e.SatisFaturasiSiraNo).HasColumnName("SATIS_FATURASI_SIRA_NO");

            Property(e => e.SatisIslemleriYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SATIS_ISLEMLERI_YETKISI");

            Property(e => e.ServisIslemleriYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SERVIS_ISLEMLERI_YETKISI");

            Property(e => e.Sifre)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("SIFRE");

            Property(e => e.SistemYoneticisi).HasColumnName("SISTEM_YONETICISI");

            Property(e => e.TeknikIslemlerYetkisi)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("TEKNIK_ISLEMLER_YETKISI");

            Property(e => e.VadeUyariGunSayisi).HasColumnName("VADE_UYARI_GUN_SAYISI");

            Property(e => e.YatayZoom).HasColumnName("YATAY_ZOOM");

            Property(e => e.YaziciId).HasColumnName("YAZICI_ID");

            Property(e => e.YaziciNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("YAZICI_NO");
        }
    }
}
