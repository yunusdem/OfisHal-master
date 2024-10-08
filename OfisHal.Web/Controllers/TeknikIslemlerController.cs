using Elmah.ContentSyndication;
using OfisHal.Core.Domain;
using OfisHal.Core.ViewModels;
using OfisHal.Data.Context;
using OfisHal.Services;
using OfisHal.Services.HksBildirimSvc;
using OfisHal.Services.HksGenelSvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class TeknikIslemlerController : BaseController
    {
        private readonly Db _context;
        private readonly IHksService _hksService;
        public TeknikIslemlerController(Db context, IHksService hksService)
        {
            _context = context;
            _hksService = hksService;
        }
        // Teknik İşlemler > Kullanıcı Tanımları
        public async Task<ActionResult> KullaniciTanimlari(bool yeni = false, int id = 0)
        {
            ViewData["yazicilar"] = await YazicilarGetir();
            var integratorProviders = Enum.GetValues(typeof(IntegratorProvider))
                                   .Cast<IntegratorProvider>()
                                   .Select(ip => new SelectListItem
                                   {
                                       Value = ((int)ip).ToString(),
                                       Text = ip.ToString()
                                   })
                                   .ToList();

            ViewBag.IntegratorProviders = integratorProviders;
            if (yeni)
            {
                Tuple<VohalKullanici, List<TohalKullaniciYetkisi>> model = new Tuple<VohalKullanici, List<TohalKullaniciYetkisi>>(
                    new VohalKullanici(),
                    new List<TohalKullaniciYetkisi>
                    {

                    });
                return View(model);
            }
            var kullanici = _context.VohalKullanicis.AsQueryable();
            if (id > 0)
            {
                kullanici = kullanici.Where(x => x.KullaniciId == id);
            }
            //else
            //{
            //    var kullaniciAd = User.Identity.Name;
            //    kullanici = kullanici.Where(x => x.Ad == kullaniciAd);
            //}
            var kullaniciYetkiler = _context.TohalKullaniciYetkisis.Where(x => x.KullaniciId == kullanici.FirstOrDefault().KullaniciId).ToList();
            Tuple<VohalKullanici, List<TohalKullaniciYetkisi>> kullaniciVeYetkiler = new Tuple<VohalKullanici, List<TohalKullaniciYetkisi>>(kullanici.FirstOrDefault(), kullaniciYetkiler);
            ViewData["Numerator"] = _context.TohalNumerators.OrderBy(x=> x.Tur).ToList();
            
            return View(kullaniciVeYetkiler);
        }
        [HttpPost]
        public async Task<ActionResult> KullaniciTanimlari(FormCollection frm)
        {
            SqlParameter kullaniciprm;
            try
            {
                if (int.TryParse(frm["KullaniciId"], out int id) && id > 0)
                    kullaniciprm = new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = id };
                else
                    kullaniciprm = new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Direction = ParameterDirection.Output };

                var parameters = new List<SqlParameter>
                {
                    //new SqlParameter("@KULLANICI_ID", SqlDbType.Int)
                    //{
                    //    Direction = ParameterDirection.Output
                    //},
                    kullaniciprm,
                    new SqlParameter("@AD", SqlDbType.VarChar){ Value = (object)frm["Ad"] ?? DBNull.Value },
                    new SqlParameter("@SISTEM_YONETICISI", SqlDbType.Bit){ Value = (object)frm["SistemYoneticisi"] ?? DBNull.Value },
                    new SqlParameter("@SIFRE", SqlDbType.VarChar){ Value = (object)frm["Sifre"] ?? DBNull.Value },
                    new SqlParameter("@YAZICI_ID", SqlDbType.Int){ Value = (object)frm["YaziciId"] ?? DBNull.Value },
                    new SqlParameter("@SATIS_FATURASI_SIRA_NO", SqlDbType.Int){ Value = (object)frm["SatisFaturasiSiraNo"] ?? DBNull.Value },
                    new SqlParameter("@ALIS_FATURASI_SIRA_NO", SqlDbType.Int){ Value = (object)frm["AlisFaturasiSiraNo"] ?? DBNull.Value },
                    new SqlParameter("@MUSTAHSIL_FATURASI_SIRA_NO", SqlDbType.Int){ Value = (object)frm["MustahsilFaturasiSiraNo"] ?? DBNull.Value },
                    new SqlParameter("@PROGRAM_ZEMIN_RENGI", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@PROGRAM_YAZI_RENGI", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@GRID_BASLIK_RENGI", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@GRID_ZEMIN_RENGI", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@PENCERE_ZEMIN_RENGI", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@PENCERE_YAZI_RENGI", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@PENCERE_FOKUS_RENGI", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@MENU_FONTU", SqlDbType.VarChar){ Value = DBNull.Value },
                    new SqlParameter("@MENU_BASLIK_FONTU", SqlDbType.VarChar){ Value = DBNull.Value },
                    new SqlParameter("@MENU_ARKA_PLAN_RENGI", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@DIALOG_FONTU", SqlDbType.VarChar){ Value = DBNull.Value },
                    new SqlParameter("@GRID_FONTU", SqlDbType.VarChar){ Value = DBNull.Value },
                    new SqlParameter("@KAYIT_GOSTERME_GUN_SAYISI", SqlDbType.Int){ Value = (object)frm["KayitGostermeGunSayisi"] ?? DBNull.Value },
                    new SqlParameter("@ANA_MENU_YETKISI", SqlDbType.VarChar){ Value = (object)frm["AnaMenuYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@MUSTAHSIL_CARI_YETKISI", SqlDbType.VarChar){ Value = (object)frm["MustahsilCariYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@DOKUM_ISLEMLERI_YETKISI", SqlDbType.VarChar){ Value = (object)frm["DokumIslemleriYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@MUSTERI_CARI_YETKISI", SqlDbType.VarChar){ Value = (object)frm["MusteriCariYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@SATIS_ISLEMLERI_YETKISI", SqlDbType.VarChar){ Value = (object)frm["SatisIslemleriYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@KASA_ISLEMLERI_YETKISI", SqlDbType.VarChar){ Value = (object)frm["KasaIslemleriYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@CEK_SENET_ISLEMLERI_YETKISI", SqlDbType.VarChar){ Value = (object)frm["CekSenetIslemleriYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@RESMI_FORMLAR_YETKISI", SqlDbType.VarChar){ Value = (object)frm["ResmiFormlarYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@TEKNIK_ISLEMLER_YETKISI", SqlDbType.VarChar){ Value = (object)frm["TeknikIslemlerYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@YATAY_ZOOM", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@DIKEY_ZOOM", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@BANKA_ISLEMLERI_YETKISI", SqlDbType.VarChar){ Value = (object)frm["BankaIslemleriYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@SERVIS_ISLEMLERI_YETKISI", SqlDbType.VarChar){ Value = (object)frm["ServisIslemleriYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@ALIS_ISLEMLERI_YETKISI", SqlDbType.VarChar){ Value = (object)frm["AlisIslemleriYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@MUHASEBE_YETKISI", SqlDbType.VarChar){ Value = (object)frm["MuhasebeYetkisi"] ?? DBNull.Value },
                    new SqlParameter("@AMBAR_NAVLUN_FATURA_SIRA_NO", SqlDbType.Int){ Value = DBNull.Value },
                    new SqlParameter("@AMBAR_E_FATURA_ON_EKI", SqlDbType.Char){ Value = DBNull.Value },
                    new SqlParameter("@AMBAR_CARI_YETKISI", SqlDbType.VarChar){ Value = DBNull.Value },
                    new SqlParameter("@HAL_CARI_YETKISI", SqlDbType.VarChar){ Value = DBNull.Value },
                    new SqlParameter("@AMBAR_FATURA_MENUSU_YETKISI", SqlDbType.VarChar){ Value = DBNull.Value },
                    new SqlParameter("@MUSTAHSIL_YAZICI_ID", SqlDbType.Int){ Value = (object)frm["MustahsilYaziciId"] ?? DBNull.Value },
                    new SqlParameter("@IRSALIYE_YAZICI_ID", SqlDbType.Int){ Value = (object)frm["IrsaliyeYaziciId"] ?? DBNull.Value },
                    new SqlParameter("@BARKOD_YAZICI_ID", SqlDbType.Int){ Value = (object)frm["BarkodYaziciId"] ?? DBNull.Value },
                    new SqlParameter("@VADE_UYARI_GUN_SAYISI", SqlDbType.Int){ Value = (object)frm["VadeUyariGunSayisi"] ?? DBNull.Value },
                    new SqlParameter("@FIS_SIRA_NO", SqlDbType.Int){ Value = (object)frm["FisSiraNo"] ?? DBNull.Value },
                    new SqlParameter("@MAL_KABUL_SIRA_NO", SqlDbType.Int){ Value = (object)frm["MalKabulSiraNo"] ?? DBNull.Value },
                    new SqlParameter("@MOBIL_YETKISI", SqlDbType.VarChar){ Value = (object)frm["MobilYetkisi"] ?? DBNull.Value },
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_KULLANICI_KAYDET @KULLANICI_ID OUTPUT, @AD, @SISTEM_YONETICISI, @SIFRE, @YAZICI_ID, @SATIS_FATURASI_SIRA_NO, @ALIS_FATURASI_SIRA_NO, @MUSTAHSIL_FATURASI_SIRA_NO, @PROGRAM_ZEMIN_RENGI, @PROGRAM_YAZI_RENGI, @GRID_BASLIK_RENGI, @GRID_ZEMIN_RENGI, @PENCERE_ZEMIN_RENGI, @PENCERE_YAZI_RENGI, @PENCERE_FOKUS_RENGI, @MENU_FONTU, @MENU_BASLIK_FONTU, @MENU_ARKA_PLAN_RENGI, @DIALOG_FONTU, @GRID_FONTU, @KAYIT_GOSTERME_GUN_SAYISI, @ANA_MENU_YETKISI, @MUSTAHSIL_CARI_YETKISI, @DOKUM_ISLEMLERI_YETKISI, @MUSTERI_CARI_YETKISI, @SATIS_ISLEMLERI_YETKISI, @KASA_ISLEMLERI_YETKISI, @CEK_SENET_ISLEMLERI_YETKISI, @RESMI_FORMLAR_YETKISI, @TEKNIK_ISLEMLER_YETKISI, @YATAY_ZOOM, @DIKEY_ZOOM, @BANKA_ISLEMLERI_YETKISI, @SERVIS_ISLEMLERI_YETKISI, @ALIS_ISLEMLERI_YETKISI, @MUHASEBE_YETKISI, @AMBAR_NAVLUN_FATURA_SIRA_NO, @AMBAR_E_FATURA_ON_EKI, @AMBAR_CARI_YETKISI, @HAL_CARI_YETKISI, @AMBAR_FATURA_MENUSU_YETKISI, @MUSTAHSIL_YAZICI_ID, @IRSALIYE_YAZICI_ID, @BARKOD_YAZICI_ID, @VADE_UYARI_GUN_SAYISI, @FIS_SIRA_NO, @MAL_KABUL_SIRA_NO, @MOBIL_YETKISI", parameters.ToArray());
                int kullanıcıId = (int)parameters[0].Value;
                List<byte> yetkiler = new List<byte>();
                if (frm["GunBazindaDokumAcYetkisi"] == "true")
                    yetkiler.Add(0);
                if (frm["TumFaturalariGormeYetkisi"] == "true")
                    yetkiler.Add(1);
                if (frm["CariNakitDisiKayitYetkisi"] == "true")
                    yetkiler.Add(2);
                if (frm["CalismaAlaniIslemleriYetkisi"] == "true")
                    yetkiler.Add(3);
                if (frm["TarihDegistirmeYetkisi"] == "true")
                    yetkiler.Add(4);
                if (frm["SatisFaturasiTarihDegistirmeYetkisi"] == "true")
                    yetkiler.Add(5);
                if (frm["FaturaTutariDegistirilsin"] == "true")
                    yetkiler.Add(6);
                if (frm["FaturadaRiskBakiyeGosterilsin"] == "true")
                    yetkiler.Add(7);
                if (frm["MusteriRiskSiniriniAsabilir"] == "true")
                    yetkiler.Add(8);
                if (frm["AcilisMesajlariGosterilsin"] == "true")
                    yetkiler.Add(9);
                KullaniciYetkisiKaydet(kullanıcıId, yetkiler);
                TempData["SuccessMessage"] = "Kayıt Eklendi";

                try
                {
                    var kullanici = _context.TohalKullanicis.SingleOrDefault();
                    kullanici.EntegratorKullaniciAdi = frm["EntegratorKullaniciAdi"];
                    kullanici.EntegratorKullaniciSifresi = frm["EntegratorKullaniciSifresi"];
                    _context.Entry(kullanici).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                catch
                {
                    TempData["ErrorMessage"] = "İşlem Başarısız. Entegratör bilgileri güncellenemedi";
                    return RedirectToAction(nameof(KullaniciTanimlari));
                }

                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        var tur = i; 
                        var onEk = frm[$"OnEk{i}"]; 
                        var baslangic = int.Parse(frm[$"Baslangic{i}"]);
                        var bitis = int.Parse(frm[$"Bitis{i}"]);
                        var uzunluk = int.Parse(frm[$"Uzunluk{i}"]);

                        // Check if the numerator already exists
                        var existingNumerator = _context.TohalNumerators.Where(x => x.Tur == tur).FirstOrDefault();

                        if (existingNumerator != null) // Update existing record
                        {
                            existingNumerator.Onek = onEk;
                            existingNumerator.Baslangic = baslangic;
                            existingNumerator.Bitis = bitis;
                            existingNumerator.Uzunluk = uzunluk;
                            _context.Entry(existingNumerator).State = EntityState.Modified;
                        }
                        else // Create a new record
                        {
                            var newNumerator = new TohalNumerator
                            {
                                Tur = (Byte)tur,
                                Onek = onEk,
                                Baslangic = baslangic,
                                Bitis = bitis,
                                Uzunluk = uzunluk
                            };
                            _context.TohalNumerators.Add(newNumerator);
                        }
                    }

                    await _context.SaveChangesAsync();
                }
                catch
                {
                    TempData["ErrorMessage"] = "İşlem Başarısız. Numerator bilgileri güncellenemedi";
                    return RedirectToAction(nameof(KullaniciTanimlari));
                }


                return RedirectToAction(nameof(KullaniciTanimlari), new { id = kullanıcıId });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(KullaniciTanimlari));
            }
        }
        [HttpPost]
        public ActionResult NumeratorlerGuncelle(int satisFatSiraNo, int alisFatSiraNo, int MustFatSiraNo, int fisSiraNo, int malKabulSiraNo, int kullaniciId)
        {
            try
            {
                _context.Database.ExecuteSqlCommand($"UPDATE TOHAL_KULLANICI SET SATIS_FATURASI_SIRA_NO = {satisFatSiraNo}, ALIS_FATURASI_SIRA_NO = {alisFatSiraNo}, MUSTAHSIL_FATURASI_SIRA_NO = {MustFatSiraNo}, FIS_SIRA_NO = {fisSiraNo}, MAL_KABUL_SIRA_NO = {malKabulSiraNo} WHERE KULLANICI_ID = {kullaniciId}");
                _context.SaveChanges();
                return Json(new { success = true, message = "İşlem Başarılı" });
            }
            catch (SqlException ex)
            {
                return Json(new { success = false, message = "Hata : " + ex.Errors[0].Message });
            }
        }
        private void KullaniciYetkisiKaydet(int kullaniciid, List<byte> yetkiler)
        {
            _context.Database.ExecuteSqlCommand($"DELETE FROM TOHAL_KULLANICI_YETKISI WHERE KULLANICI_ID = {kullaniciid}");
            for (int i = 0; i < yetkiler.Count; i++)
            {
                var item = yetkiler.ElementAtOrDefault(i);
                _context.TohalKullaniciYetkisis.Add(new TohalKullaniciYetkisi { KullaniciId = kullaniciid, YetkiCinsi = item });
            }
            _context.SaveChanges();
        }
        public async Task<ActionResult> KullaniciSil(int kullaniciId)
        {
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int){Value = kullaniciId},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_KULLANICI_SIL @KULLANICI_ID", parameters.ToArray());
                TempData["SuccessMessage"] = "Kayıt Silindi";
                return RedirectToAction(nameof(KullaniciTanimlari), new { yeni = true });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(KullaniciTanimlari), new { id = kullaniciId });
            }
        }
        // Teknik İşlemler > Yazıcı Tanımları
        public ActionResult YaziciTanimlari()
        {
            return View();
        }
        // Teknik İşlemler > Hal Entegre Tanımları
        [HttpGet]
        public async Task<ActionResult> HalEntegreTanimlari()
        {
            HalEntegreViewModel model = new HalEntegreViewModel()
            {
                dokum = await _context.VohalDokumTanimlaris.FirstOrDefaultAsync(),
                satis = await _context.VohalSatisTanimlaris.FirstOrDefaultAsync(),
                alis = await _context.VohalAlisTanimlaris.FirstOrDefaultAsync(),
                hesap = await _context.VohalHesapTanimlaris.FirstOrDefaultAsync() ?? new VohalHesapTanimlari(),
                hks = await _context.VohalHksTanimlars.FirstOrDefaultAsync(),
                firma = await _context.VohalFirmaTanimlaris.FirstOrDefaultAsync(),
                ebelge = await _context.VohalEBelgeTanimis.FirstOrDefaultAsync(),
                diger = await _context.VohalDigerTanimlars.FirstOrDefaultAsync()
            };
            ViewData["efaturapk"] = await _context.TohalGibKullanicis.Where(x => x.PkTipi == 0 && x.KayitSekli == 1 && x.DokumanTipi == 0).FirstOrDefaultAsync();
            ViewData["eirsaliyepk"] = await _context.TohalGibKullanicis.Where(x => x.PkTipi == 0 && x.KayitSekli == 1 && x.DokumanTipi == 1).FirstOrDefaultAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> HalEntegreTanimlari(FormCollection frm)
        {
            try
            {
                //DOKUM TANIMLARI STORE PROCEDURE
                var dokParameters = new List<SqlParameter>()
            {
                new SqlParameter("@DOK_RUSUM_ORANI", SqlDbType.Float){ Value = (object)frm["DokRusumOrani"] ?? DBNull.Value },
                new SqlParameter("@DOK_BAGKUR_ORANI", SqlDbType.Float){ Value = (object)frm["DokBagkurOrani"] ?? DBNull.Value },
                new SqlParameter("@DOK_BORSA_ORANI", SqlDbType.Float){ Value = (object)frm["DokBorsaOrani"] ?? DBNull.Value },
                new SqlParameter("@DOK_STOPAJ_ORANI", SqlDbType.Float){ Value = (object)frm["DokStopajOrani"] ?? DBNull.Value },
                new SqlParameter("@DOK_BORSA_STOPAJ_ORANI", SqlDbType.Float){ Value = (object)frm["DokBorsaStopajOrani"] ?? DBNull.Value },
                new SqlParameter("@DOK_KOMISYON_ORANI", SqlDbType.Float){ Value = (object)frm["DokKomisyonOrani"] ?? DBNull.Value },
                new SqlParameter("@DOK_KOMISYON_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["DokKomisyonKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@DOK_TUCCAR_KAP_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["DokTuccarKapKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@DOK_NAVLUN_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["DokNavlunKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@DOK_DOKUM_DEFTERI_VAR", SqlDbType.Bit){ Value = (object)frm["DokDokumDefteriVar"] ?? DBNull.Value },
                new SqlParameter("@DOK_DOKUM_AMBAR", SqlDbType.Int){ Value = (object)frm["DokDokumAmbar"] ?? DBNull.Value },
                new SqlParameter("@DOK_DOKUM_DEFTER_TIPI", SqlDbType.Int){ Value = (object)frm["DokDokumDefterTipi"] ?? DBNull.Value },
                new SqlParameter("@DOK_DOKUM_DEFTER_GOSTERIMI", SqlDbType.Int){ Value = (object)frm["DokDokumDefterGosterimi"] ?? DBNull.Value },
                new SqlParameter("@DOK_FATURA_SIRA_NO", SqlDbType.Int){ Value = (object)frm["DokFaturaSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@DOK_MUSTAHSIL_CIRO_SINIRI", SqlDbType.Float){ Value = (object)frm["DokMustahsilCiroSiniri"] ?? DBNull.Value },
                new SqlParameter("@DOK_OTOMATIK_HAMALIYE", SqlDbType.Bit){ Value = (object)frm["DokOtomatikHamaliye"] ?? DBNull.Value },
                new SqlParameter("@DOK_HAMALIYE_HESAPLAMA_SEKLI", SqlDbType.Int){ Value = (object)frm["DokHamaliyeHesaplamaSekli"] ?? DBNull.Value },
                new SqlParameter("@DOK_BIRIM_HAMALIYE", SqlDbType.Float){ Value = (object)frm["DokBirimHamaliye"] ?? DBNull.Value },
                new SqlParameter("@DOK_BIRIM_NAKLIYE", SqlDbType.Float){ Value = (object)frm["DokBirimNakliye"] ?? DBNull.Value },
                new SqlParameter("@DOK_KAP_KOMISYONA_DAHIL", SqlDbType.Bit){ Value = (object)frm["DokKapKomisyonaDahil"] ?? DBNull.Value },
                new SqlParameter("@DOK_AYNI_MALLARI_TOPLAMA_SEKLI", SqlDbType.Int){ Value = (object)frm["DokAyniMallariToplamaSekli"] ?? DBNull.Value },
                new SqlParameter("@IADELI_KAP_TUTAR_REHINDEN_AL", SqlDbType.Bit){ Value = (object)frm["IadeliKapTutarRehindenAl"] ?? DBNull.Value },
                new SqlParameter("@DOK_FIYAT_GIRILSIN", SqlDbType.Bit){ Value = (object)frm["DokFiyatGirilsin"] ?? DBNull.Value },
                new SqlParameter("@DOK_CARIYE_ISLEME_SEKLI", SqlDbType.Int){ Value = (object)frm["DokCariyeIslemeSekli"] ?? DBNull.Value },
                new SqlParameter("@DOK_CARI_ISLEME_DEGISSIN", SqlDbType.Bit){ Value = (object)frm["DokCariIslemeDegissin"] ?? DBNull.Value },
                new SqlParameter("@DOK_TOPLAMA_MAL_CALISIR", SqlDbType.Bit){ Value = (object)frm["DokToplamaMalCalisir"] ?? DBNull.Value },
                new SqlParameter("@DOK_HIZMET_BEDELI_HESABI_ID", SqlDbType.Int){ Value = frm["DokHizmetBedeliHesabiId"]?.Length > 0 && frm["DokHizmetBedeliHesabiId"] != null ? (object)frm["DokHizmetBedeliHesabiId"] : DBNull.Value},
                new SqlParameter("@DOK_KAPLI_ENTEGRASYON_YAP", SqlDbType.Bit){ Value = (object)frm["DokKapliEntegrasyonYap"] ?? DBNull.Value },
                new SqlParameter("@DOK_SATIRDA_STOK_GIRIS_TARIHI", SqlDbType.Bit){ Value = (object)frm["DokSatirdaStokGirisTarihi"] ?? DBNull.Value },
            };
                List<string> dokExecPrms = new List<string>()
            {
                "DOK_RUSUM_ORANI","DOK_BAGKUR_ORANI","DOK_BORSA_ORANI","DOK_STOPAJ_ORANI","DOK_BORSA_STOPAJ_ORANI","DOK_KOMISYON_ORANI","DOK_KOMISYON_KDV_ORANI","DOK_TUCCAR_KAP_KDV_ORANI",
                "DOK_NAVLUN_KDV_ORANI","DOK_DOKUM_DEFTERI_VAR","DOK_DOKUM_AMBAR","DOK_DOKUM_DEFTER_TIPI","DOK_DOKUM_DEFTER_GOSTERIMI","DOK_FATURA_SIRA_NO","DOK_MUSTAHSIL_CIRO_SINIRI",
                "DOK_OTOMATIK_HAMALIYE","DOK_HAMALIYE_HESAPLAMA_SEKLI","DOK_BIRIM_HAMALIYE","DOK_BIRIM_NAKLIYE","DOK_KAP_KOMISYONA_DAHIL","DOK_AYNI_MALLARI_TOPLAMA_SEKLI","IADELI_KAP_TUTAR_REHINDEN_AL",
                "DOK_FIYAT_GIRILSIN","DOK_CARIYE_ISLEME_SEKLI","DOK_CARI_ISLEME_DEGISSIN","DOK_TOPLAMA_MAL_CALISIR","DOK_HIZMET_BEDELI_HESABI_ID","DOK_KAPLI_ENTEGRASYON_YAP","DOK_SATIRDA_STOK_GIRIS_TARIHI"
            };
                var dokDbQuery = CreateSqlQuery("SOHAL_DOKUM_TANIMLARI_KAYDET", dokExecPrms);
                await _context.Database.ExecuteSqlCommandAsync(dokDbQuery, dokParameters.ToArray());

                //SATIŞ TANIMLARI STORE PROCEDURE
                var satParameters = new List<SqlParameter>()
            {
                new SqlParameter("@SAT_VER_MUK_MAL_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["SatVerMukMalKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@SAT_IADESIZ_KAP_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["SatIadesizKapKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@SAT_DIGER_MAL_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["SatDigerMalKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@SAT_YUKLEME_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["SatYuklemeKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@SAT_NAKLIYE_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["SatNakliyeKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@SAT_RUSUM_ORANI", SqlDbType.Float){ Value = (object)frm["SatRusumOrani"] ?? DBNull.Value },
                new SqlParameter("@SAT_KILO_OKUMA_SEKLI", SqlDbType.Int){ Value = (object)frm["SatKiloOkumaSekli"] ?? DBNull.Value },
                new SqlParameter("@SAT_CIFTCI_TUCCAR_KDV", SqlDbType.Bit){ Value = (object)frm["SatCiftciTuccarKdv"] ?? DBNull.Value },
                new SqlParameter("@SAT_KDV_ATLAMA", SqlDbType.Bit){ Value = (object)frm["SatKdvAtlama"] ?? DBNull.Value },
                new SqlParameter("@SAT_RUSUM_ATLAMA", SqlDbType.Bit){ Value = (object)frm["SatRusumAtlama"] ?? DBNull.Value },
                new SqlParameter("@SAT_DARA_DARALI_ATLAMA", SqlDbType.Bit){ Value = (object)frm["SatDaraDaraliAtlama"] ?? DBNull.Value },
                new SqlParameter("@SAT_DARA_REHIN_ILISKI", SqlDbType.Bit){ Value = (object)frm["SatDaraRehinIliski"] ?? DBNull.Value },
                new SqlParameter("@SAT_AYNI_MALLARI_TOPLA", SqlDbType.Bit){ Value = (object)frm["SatAyniMallariTopla"] ?? DBNull.Value },
                new SqlParameter("@SAT_MALARI_SIRALA", SqlDbType.Bit){ Value = (object)frm["SatMalariSirala"] ?? DBNull.Value },
                new SqlParameter("@SAT_SATIRDA_FIAT_KONTROL", SqlDbType.Bit){ Value = (object)frm["SatSatirdaFiatKontrol"] ?? DBNull.Value },
                new SqlParameter("@SAT_VERESIYE_UYARISI", SqlDbType.Bit){ Value = (object)frm["SatVeresiyeUyarisi"] ?? DBNull.Value },
                new SqlParameter("@SAT_REHIN_OTOMATIK_HESAPLANSIN", SqlDbType.Bit){ Value = (object)frm["SatRehinOtomatikHesaplansin"] ?? DBNull.Value },
                new SqlParameter("@SAT_SAT_FATURA_SIRA_NO", SqlDbType.Int){ Value = (object)frm["SatSatFaturaSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@SAT_REHINDE_MARKA_VAR", SqlDbType.Bit){ Value = (object)frm["SatRehindeMarkaVar"] ?? DBNull.Value },
                new SqlParameter("@SAT_REHIN_IADE_ISLENECEGI_HSP", SqlDbType.Int){ Value = (object)frm["SatRehinIadeIslenecegiHsp"] ?? DBNull.Value },
                new SqlParameter("@SAT_ISKONTO_VAR", SqlDbType.Bit){ Value = (object)frm["SatIskontoVar"] ?? DBNull.Value },
                new SqlParameter("@SAT_FATURA_MAL_GORUNUM_SEKLI", SqlDbType.Int){ Value = (object)frm["SatFaturaMalGorunumSekli"] ?? DBNull.Value },
                new SqlParameter("@SAT_RUSUM_KDV_ILISKISI", SqlDbType.Int){ Value = (object)frm["SatRusumKdvIliskisi"] ?? DBNull.Value },
                new SqlParameter("@SAT_RUSUM_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["SatRusumKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@SAT_STOK_KUNYESI_DEGISTIR", SqlDbType.Bit){ Value = (object)frm["SatStokKunyesiDegistir"] ?? DBNull.Value },
                new SqlParameter("@SAT_DOKUMDEN_KUNYE_VAR", SqlDbType.Bit){ Value = (object)frm["SatDokumdenKunyeVar"] ?? DBNull.Value },
                new SqlParameter("@SAT_FATURA_SATIR_SAYISI", SqlDbType.Int){ Value = (object)frm["SatFaturaSatirSayisi"] ?? DBNull.Value },
                new SqlParameter("@SAT_STOK_MIKTARI_GOSTER", SqlDbType.Bit){ Value = (object)frm["SatStokMiktariGoster"] ?? DBNull.Value },
                new SqlParameter("@SAT_SUBE_ADRESINI_KULLAN", SqlDbType.Bit){ Value = (object)frm["SatSubeAdresiniKullan"] ?? DBNull.Value },
                new SqlParameter("@SAT_KUNYESIZ_SATIRLARDA_UYAR", SqlDbType.Bit){ Value = (object)frm["SatKunyesizSatirlardaUyar"] ?? DBNull.Value },
                new SqlParameter("@SAT_RUSUMU_HKSDEN_AL", SqlDbType.Bit){ Value = (object)frm["SatRusumuHksdenAl"] ?? DBNull.Value },
                new SqlParameter("@SAT_DOKUM_RUSUMU_ASILABILIR", SqlDbType.Bit){ Value = (object)frm["SatDokumRusumuAsilabilir"] ?? DBNull.Value },
                new SqlParameter("@SAT_KESILIRKEN_KUNYE_AL", SqlDbType.Bit){ Value = (object)frm["SatKesilirkenKunyeAl"] ?? DBNull.Value },
                new SqlParameter("@SAT_FATURA_DEFAULT_VERESIYE", SqlDbType.Bit){ Value = (object)frm["SatFaturaDefaultVeresiye"] ?? DBNull.Value },
                new SqlParameter("@SAT_BARKODU_DIREK_YAZDIR", SqlDbType.Bit){ Value = (object)frm["SatBarkoduDirekYazdir"] ?? DBNull.Value },
                new SqlParameter("@SAT_BARKOD_BELGESI", SqlDbType.Int){ Value = (object)frm["SatBarkodBelgesi"] ?? DBNull.Value },
                new SqlParameter("@SAT_IRSALIYE_SIRA_NO", SqlDbType.Int){ Value = (object)frm["SatIrsaliyeSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@SAT_IRSALIYE_NO_BASINA_SIFIR", SqlDbType.Bit){ Value = (object)frm["SatIrsaliyeNoBasinaSifir"] ?? DBNull.Value },
                new SqlParameter("@SAT_OTOMATIK_HAMALIYE", SqlDbType.Bit){ Value = (object)frm["SatOtomatikHamaliye"] ?? DBNull.Value },
                new SqlParameter("@SAT_HAMALIYE_HESAPLAMA_SEKLI", SqlDbType.Int){ Value = (object)frm["SatHamaliyeHesaplamaSekli"] ?? DBNull.Value },
                new SqlParameter("@SAT_OTOMATIK_NAKLIYE", SqlDbType.Bit){ Value = (object)frm["SatOtomatikNakliye"] ?? DBNull.Value },
                new SqlParameter("@SAT_NAKLIYE_HESAPLAMA_SEKLI", SqlDbType.Int){ Value = (object)frm["SatNakliyeHesaplamaSekli"] ?? DBNull.Value },
                new SqlParameter("@SAT_BIRIM_KILO_NAKLIYE", SqlDbType.Float){ Value = (object)frm["SatBirimKiloNakliye"] ?? DBNull.Value },
                new SqlParameter("@SAT_BIRIM_KAP_NAKLIYE", SqlDbType.Float){ Value = (object)frm["SatBirimKapNakliye"] ?? DBNull.Value },
                new SqlParameter("@SAT_BILDIRIM_SERVISI", SqlDbType.Int){ Value = (object)frm["SatBildirimServisi"] ?? DBNull.Value },
                new SqlParameter("@SAT_PESIN_KAYIT_YAPILMASIN", SqlDbType.Bit){ Value = (object)frm["SatPesinKayitYapilmasin"] ?? DBNull.Value },
                new SqlParameter("@SAT_TESLIMAT_YERI_KOPYALANSIN", SqlDbType.Bit){ Value = (object)frm["SatTeslimatYeriKopyalansin"] ?? DBNull.Value },
                new SqlParameter("@SAT_FATURA_BELGESI", SqlDbType.Int){ Value = (object)frm["SatFaturaBelgesi"] ?? DBNull.Value },
                new SqlParameter("@SAT_FATURA_UYARMA_SEKLI", SqlDbType.Int){ Value = (object)frm["SatFaturaUyarmaSekli"] ?? DBNull.Value },
                new SqlParameter("@SAT_RUSUM_KDV_GOSTERIMI", SqlDbType.Int){ Value = (object)frm["SatRusumKdvGosterimi"] ?? DBNull.Value },
                new SqlParameter("@SAT_KUNYE_FIYATI_SINIR_ORANI", SqlDbType.Float){ Value = (object)frm["SatKunyeFiyatiSinirOrani"] ?? DBNull.Value },
                new SqlParameter("@SAT_KUNYE_FIYATI_SINIR_DENETIM", SqlDbType.Int){ Value = (object)frm["SatKunyeFiyatiSinirDenetim"] ?? DBNull.Value },
                new SqlParameter("@SAT_KUNYEDE_LISTE_FIYATI_VAR", SqlDbType.Bit){ Value = (object)frm["SatKunyedeListeFiyatiVar"] ?? DBNull.Value },
                new SqlParameter("@SAT_KUNYE_PLAKA_NO_KONTROLU", SqlDbType.Int){ Value = (object)frm["SatKunyePlakaNoKontrolu"] ?? DBNull.Value },
                new SqlParameter("@SAT_IADESIZ_KAP_OTOMATIK_HESAPLANSIN", SqlDbType.Bit){ Value = (object)frm["SatIadesizKapHesaplansin"] ?? DBNull.Value },
                new SqlParameter("@SAT_HAMALIYE_ADLANDIRMA", SqlDbType.VarChar){ Value = (object)frm["SatHamaliyeAdlandirma"] ?? DBNull.Value },
                new SqlParameter("@SAT_NAKLIYE_ADLANDIRMA", SqlDbType.VarChar){ Value = (object)frm["SatNakliyeAdlandirma"] ?? DBNull.Value },
            };
                List<string> satExecPrms = new List<string>()
            {
                "SAT_VER_MUK_MAL_KDV_ORANI","SAT_IADESIZ_KAP_KDV_ORANI","SAT_DIGER_MAL_KDV_ORANI","SAT_YUKLEME_KDV_ORANI","SAT_NAKLIYE_KDV_ORANI","SAT_RUSUM_ORANI","SAT_KILO_OKUMA_SEKLI",
                "SAT_CIFTCI_TUCCAR_KDV","SAT_KDV_ATLAMA","SAT_RUSUM_ATLAMA","SAT_DARA_DARALI_ATLAMA","SAT_DARA_REHIN_ILISKI","SAT_AYNI_MALLARI_TOPLA","SAT_MALARI_SIRALA","SAT_SATIRDA_FIAT_KONTROL",
                "SAT_VERESIYE_UYARISI","SAT_REHIN_OTOMATIK_HESAPLANSIN","SAT_SAT_FATURA_SIRA_NO","SAT_REHINDE_MARKA_VAR","SAT_REHIN_IADE_ISLENECEGI_HSP","SAT_ISKONTO_VAR","SAT_FATURA_MAL_GORUNUM_SEKLI",
                "SAT_RUSUM_KDV_ILISKISI","SAT_RUSUM_KDV_ORANI","SAT_STOK_KUNYESI_DEGISTIR","SAT_DOKUMDEN_KUNYE_VAR","SAT_FATURA_SATIR_SAYISI","SAT_STOK_MIKTARI_GOSTER","SAT_SUBE_ADRESINI_KULLAN",
                "SAT_KUNYESIZ_SATIRLARDA_UYAR","SAT_RUSUMU_HKSDEN_AL","SAT_DOKUM_RUSUMU_ASILABILIR","SAT_KESILIRKEN_KUNYE_AL","SAT_FATURA_DEFAULT_VERESIYE","SAT_BARKODU_DIREK_YAZDIR","SAT_BARKOD_BELGESI",
                "SAT_IRSALIYE_SIRA_NO","SAT_IRSALIYE_NO_BASINA_SIFIR","SAT_OTOMATIK_HAMALIYE","SAT_HAMALIYE_HESAPLAMA_SEKLI","SAT_OTOMATIK_NAKLIYE","SAT_NAKLIYE_HESAPLAMA_SEKLI","SAT_BIRIM_KILO_NAKLIYE",
                "SAT_BIRIM_KAP_NAKLIYE","SAT_BILDIRIM_SERVISI","SAT_PESIN_KAYIT_YAPILMASIN","SAT_TESLIMAT_YERI_KOPYALANSIN","SAT_FATURA_BELGESI","SAT_FATURA_UYARMA_SEKLI","SAT_RUSUM_KDV_GOSTERIMI",
                "SAT_KUNYE_FIYATI_SINIR_ORANI","SAT_KUNYE_FIYATI_SINIR_DENETIM","SAT_KUNYEDE_LISTE_FIYATI_VAR","SAT_KUNYE_PLAKA_NO_KONTROLU","SAT_IADESIZ_KAP_OTOMATIK_HESAPLANSIN","SAT_HAMALIYE_ADLANDIRMA","SAT_NAKLIYE_ADLANDIRMA"
            };
                var satDbQuery = CreateSqlQuery("SOHAL_SATIS_TANIMLARI_KAYDET", satExecPrms);
                await _context.Database.ExecuteSqlCommandAsync(satDbQuery, satParameters.ToArray());

                //ALIŞ TANIMLARI STORE PROCEDURE
                var alisParameters = new List<SqlParameter>()
            {
                new SqlParameter("@ALS_DIGER_MAL_KDV_ORANI", SqlDbType.Float){ Value = (object)frm["AlsDigerMalKdvOrani"] ?? DBNull.Value },
                new SqlParameter("@ALS_FATURA_SIRA_NO", SqlDbType.Int){ Value = (object)frm["AlsFaturaSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@ALS_RUSUM_ORANI", SqlDbType.Float){ Value = (object)frm["AlsRusumOrani"] ?? DBNull.Value },
                new SqlParameter("@ALS_SIPARIS_CALISMA_SEKLI", SqlDbType.Int){ Value = (object)frm["AlsSiparisCalismaSekli"] ?? DBNull.Value },
                new SqlParameter("@ALS_MAL_BAKIYE_HESAPLAMA_SEKLI", SqlDbType.Int){ Value = (object)frm["AlsMalBakiyeHesaplamaSekli"] ?? DBNull.Value },
            };
                List<string> alisExecPrms = new List<string>()
            {
                "ALS_DIGER_MAL_KDV_ORANI", "ALS_FATURA_SIRA_NO", "ALS_RUSUM_ORANI", "ALS_SIPARIS_CALISMA_SEKLI", "ALS_MAL_BAKIYE_HESAPLAMA_SEKLI",
            };
                var alisDbQuery = CreateSqlQuery("SOHAL_ALIS_TANIMLARI_KAYDET", alisExecPrms);
                await _context.Database.ExecuteSqlCommandAsync(alisDbQuery, alisParameters.ToArray());

                //HESAP TANIMLARI STORE PROCEDURE hesap error
                var hesapParameters = new List<SqlParameter>()
            {
                new SqlParameter("@HES_NAVLUN_HESABI_ID", SqlDbType.Int){ Value = frm["HesNavlunHesabiId"]?.Length > 0 && frm["HesNavlunHesabiId"] != null ? (object)frm["HesNavlunHesabiId"] : DBNull.Value},
                new SqlParameter("@HES_REHIN_HESABI_ID", SqlDbType.Int){ Value = frm["HesRehinHesabiId"]?.Length > 0 && frm["HesRehinHesabiId"] != null ? (object)frm["HesRehinHesabiId"] : DBNull.Value},
                new SqlParameter("@HES_IADESIZ_SANDIK_HESABI_ID", SqlDbType.Int){ Value = frm["HesIadesizSandikHesabiId"]?.Length > 0 && frm["HesIadesizSandikHesabiId"] != null ? (object)frm["HesIadesizSandikHesabiId"] : DBNull.Value},
                new SqlParameter("@HES_RUSUM_HESABI_ID", SqlDbType.Int){ Value = frm["HesRusumHesabiId"]?.Length > 0 && frm["HesRusumHesabiId"] != null ? (object)frm["HesRusumHesabiId"] : DBNull.Value},
                new SqlParameter("@HES_HAMALIYE_HESABI_ID", SqlDbType.Int){ Value = frm["HesHamaliyeHesabiId"]?.Length > 0 && frm["HesHamaliyeHesabiId"] != null ? (object)frm["HesHamaliyeHesabiId"] : DBNull.Value},
                new SqlParameter("@HES_NAKLIYE_HESABI_ID", SqlDbType.Int){ Value = frm["HesNakliyeHesabiId"]?.Length > 0 && frm["HesNakliyeHesabiId"] != null ? (object)frm["HesNakliyeHesabiId"] : DBNull.Value},
                new SqlParameter("@HES_CIRO_PRIMI_HESABI_ID", SqlDbType.Int){ Value = frm["HesCiroPrimiHesabiId"]?.Length > 0 && frm["HesCiroPrimiHesabiId"] != null ? (object)frm["HesCiroPrimiHesabiId"] : DBNull.Value},
                new SqlParameter("@HES_STOPAJ_HESABI_ID", SqlDbType.Int){ Value = frm["HesStopajHesabiId"]?.Length > 0 && frm["HesStopajHesabiId"] != null ? (object)frm["HesStopajHesabiId"] : DBNull.Value},
                new SqlParameter("@HES_BORSA_HESABI_ID", SqlDbType.Int){ Value = frm["HesBorsaHesabiId"]?.Length > 0 && frm["HesBorsaHesabiId"] != null ? (object)frm["HesBorsaHesabiId"] : DBNull.Value},
                new SqlParameter("@HES_BAGKUR_HESABI_ID", SqlDbType.Int){ Value = frm["HesBagkurHesabiId"]?.Length > 0 && frm["HesBagkurHesabiId"] != null ? (object)frm["HesBagkurHesabiId"] : DBNull.Value},
            };
                List<string> hesapExecPrms = new List<string>()
            {
                "HES_NAVLUN_HESABI_ID", "HES_REHIN_HESABI_ID", "HES_IADESIZ_SANDIK_HESABI_ID", "HES_RUSUM_HESABI_ID", "HES_HAMALIYE_HESABI_ID",
                "HES_NAKLIYE_HESABI_ID", "HES_CIRO_PRIMI_HESABI_ID", "HES_STOPAJ_HESABI_ID", "HES_BORSA_HESABI_ID", "HES_BAGKUR_HESABI_ID",
            };
                var hesapDbQuery = CreateSqlQuery("SOHAL_HESAP_TANIMLARI_KAYDET", hesapExecPrms);
                await _context.Database.ExecuteSqlCommandAsync(hesapDbQuery, hesapParameters.ToArray());

                //HKS TANIMLARI STORE PROCEDURE
                string yerId = null;
                if (frm["IlId"].Length > 0 && int.Parse(frm["IlId"]) > 0)
                    yerId = frm["IlId"];
                if (frm["IlceId"].Length > 0 && int.Parse(frm["IlceId"]) > 0)
                    yerId = frm["IlceId"];
                if (frm["BeldeId"].Length > 0 && int.Parse(frm["BeldeId"]) > 0)
                    yerId = frm["BeldeId"];

                var hksParameters = new List<SqlParameter>()
            {
                new SqlParameter("@DIG_WEB_KULLANICISI", SqlDbType.VarChar){ Value = (object)frm["DigWebKullanicisi"] ?? DBNull.Value },
                new SqlParameter("@DIG_WEB_SIFRESI", SqlDbType.VarChar){ Value = (object)frm["DigWebSifresi"] ?? DBNull.Value },
                new SqlParameter("@DIG_HKS_BILDIRIM_SEKLI", SqlDbType.Int){ Value = (object)frm["DigHksBildirimSekli"] ?? DBNull.Value },
                new SqlParameter("@DIG_HKS_SIFRESI", SqlDbType.VarChar){ Value = (object)frm["DigHksSifresi"] ?? DBNull.Value },
                new SqlParameter("@DIG_HKS_CALISMA_SEKLI", SqlDbType.Int){ Value = (object)frm["DigHksCalismaSekli"] ?? DBNull.Value },
                new SqlParameter("@DIG_KUNYEYI_OTOMATIK_GONDER", SqlDbType.Bit){ Value = (object)frm["DigKunyeyiOtomatikGonder"] ?? DBNull.Value },
                new SqlParameter("@DIG_KUNYE_TAKIBI_VAR", SqlDbType.Bit){ Value = (object)frm["DigKunyeTakibiVar"] ?? DBNull.Value },
                new SqlParameter("@DIG_KUNYE_BARKODU_YAZDIR", SqlDbType.Bit){ Value = (object)frm["DigKunyeBarkoduYazdir"] ?? DBNull.Value },
                new SqlParameter("@DIG_KUNYE_GECERLILIK_TARIHI", SqlDbType.Date){ Value = (object)frm["DigKunyeGecerlilikTarihi"] ?? DBNull.Value },
                new SqlParameter("@DIG_SIFATI", SqlDbType.Int){ Value = (object)frm["DigSifati"] ?? DBNull.Value },
                new SqlParameter("@DIG_SATIN_ALANIN_SIFATI", SqlDbType.Int){ Value = (object)frm["DigSatinAlaninSifati"] ?? DBNull.Value },
                new SqlParameter("@SAT_BILDIRIM_TURU", SqlDbType.Int){ Value = (object)frm["SatBildirimTuru"] ?? DBNull.Value },
                new SqlParameter("@DOK_BILDIRIM_TURU", SqlDbType.Int){ Value = (object)frm["DokBildirimTuru"] ?? DBNull.Value },
                new SqlParameter("@DIG_GIDECEGI_YER_TIPI", SqlDbType.Int){ Value = (object)frm["DigGidecegiYerTipi"] ?? DBNull.Value },
                new SqlParameter("@DIG_YER_ID", SqlDbType.Int){ Value = (object)yerId ?? DBNull.Value },
                new SqlParameter("@DIG_MARKANIN_KUNYE_TAKIBI_VAR", SqlDbType.Bit){ Value = (object)frm["DigMarkaninKunyeTakibiVar"] ?? DBNull.Value },
                new SqlParameter("@HKS_KUNYE_BAKIYESI_DUSME_SEKLI", SqlDbType.Int){ Value = (object)frm["HksKunyeBakiyesiDusmeSekli"] ?? DBNull.Value },
                new SqlParameter("@HKS_VARSAYILAN_DEGER_ATANSIN", SqlDbType.Bit){ Value = (object)frm["HksVarsayilanDegerAtansin"] ?? DBNull.Value },
                new SqlParameter("@HKS_SATIR_COGALABILIR", SqlDbType.Bit){ Value = (object)frm["HksSatirCogalabilir"] ?? DBNull.Value },
                new SqlParameter("@HKS_SATIR_DETAYI_VAR", SqlDbType.Bit){ Value = (object)frm["HksSatirDetayiVar"] ?? DBNull.Value },
                new SqlParameter("@HKS_VARSAYILAN_PLAKA_NO", SqlDbType.Char){ Value = (object)frm["HksVarsayilanPlakaNo"] ?? DBNull.Value },
                new SqlParameter("@HKS_STOK_CALISMA_SEKLI", SqlDbType.Int){ Value = (object)frm["HksStokCalismaSekli"] ?? DBNull.Value },
                new SqlParameter("@HKS_KUNYE_SEC_ACILSIN", SqlDbType.Bit){ Value = (object)frm["HksKunyeSecAcilsin"] ?? DBNull.Value },
                new SqlParameter("@HKS_KILO_KUNYESI_ONCELIKLI", SqlDbType.Bit){ Value = (object)frm["HksKiloKunyesiOncelikli"] ?? DBNull.Value },
                new SqlParameter("@HKS_KILO_KAP_KARISIK", SqlDbType.Bit){ Value = (object)frm["HksKiloKapKarisik"] ?? DBNull.Value },
                new SqlParameter("@HKS_DIGER_KUNYELERI_KULLAN", SqlDbType.Bit){ Value = (object)frm["HksDigerKunyeleriKullan"] ?? DBNull.Value },
                new SqlParameter("@HKS_BILDIRIM_BELEDIYE_ADI", SqlDbType.VarChar){ Value = (object)frm["HksBildirimBelediyeAdi"] ?? DBNull.Value },
                new SqlParameter("@HKS_SERVIS_ADRESI", SqlDbType.VarChar){ Value = (object)frm["HksServisAdresi"] ?? DBNull.Value },
            };
                List<string> hksExecPrms = new List<string>()
            {
               "DIG_WEB_KULLANICISI", "DIG_WEB_SIFRESI", "DIG_HKS_BILDIRIM_SEKLI", "DIG_HKS_SIFRESI", "DIG_HKS_CALISMA_SEKLI", "DIG_KUNYEYI_OTOMATIK_GONDER",
                "DIG_KUNYE_TAKIBI_VAR", "DIG_KUNYE_BARKODU_YAZDIR",  "DIG_KUNYE_GECERLILIK_TARIHI", "DIG_SIFATI", "DIG_SATIN_ALANIN_SIFATI", "SAT_BILDIRIM_TURU",
                "DOK_BILDIRIM_TURU", "DIG_GIDECEGI_YER_TIPI", "DIG_YER_ID", "DIG_MARKANIN_KUNYE_TAKIBI_VAR", "HKS_KUNYE_BAKIYESI_DUSME_SEKLI", "HKS_VARSAYILAN_DEGER_ATANSIN",
                "HKS_SATIR_COGALABILIR", "HKS_SATIR_DETAYI_VAR", "HKS_VARSAYILAN_PLAKA_NO", "HKS_STOK_CALISMA_SEKLI", "HKS_KUNYE_SEC_ACILSIN", "HKS_KILO_KUNYESI_ONCELIKLI",
                "HKS_KILO_KAP_KARISIK", "HKS_DIGER_KUNYELERI_KULLAN", "HKS_BILDIRIM_BELEDIYE_ADI", "HKS_SERVIS_ADRESI"
            };
                var hksDbQuery = CreateSqlQuery("SOHAL_HKS_TANIMLARI_KAYDET", hksExecPrms);
                await _context.Database.ExecuteSqlCommandAsync(hksDbQuery, hksParameters.ToArray());

                //FİRMA TANIMLARI STORE PROCEDURE
                if (frm["HalId"] == "") frm["HalId"] = null;
                var firmaParameters = new List<SqlParameter>()
            {
                new SqlParameter("@DIG_SICIL_KODU", SqlDbType.Char){ Value = (object)frm["DigSicilKodu"] ?? DBNull.Value },
                new SqlParameter("@DIG_YAZIHANE_NO", SqlDbType.Char){ Value = (object)frm["DigYazihaneNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_FIRMA_ADI", SqlDbType.NVarChar){ Value = (object)frm["DigFirmaAdi"] ?? DBNull.Value },
                new SqlParameter("@DIG_VERGI_DAIRESI_ID", SqlDbType.Int){ Value = (object)frm["DigVergiDairesiId"] ?? DBNull.Value },
                new SqlParameter("@DIG_VERGI_KIMLIK_NO", SqlDbType.Char){ Value = (object)frm["DigVergiKimlikNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_SAHIS_ADI", SqlDbType.VarChar){ Value = (object)frm["DigSahisAdi"] ?? DBNull.Value },
                new SqlParameter("@DIG_SAHIS_SOYADI", SqlDbType.VarChar){ Value = (object)frm["DigSahisSoyadi"] ?? DBNull.Value },
                new SqlParameter("@DIG_ADRES", SqlDbType.VarChar){ Value = (object)frm["DigAdres"] ?? DBNull.Value },
                new SqlParameter("@DIG_TELEFON", SqlDbType.VarChar){ Value = (object)frm["DigTelefon"] ?? DBNull.Value },
                new SqlParameter("@DIG_GSM_NO", SqlDbType.VarChar){ Value = (object)frm["DigGsmNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_EPOSTA", SqlDbType.VarChar){ Value = (object)frm["DigEposta"] ?? DBNull.Value },
                new SqlParameter("@DIG_TOP_HALI_ADI", SqlDbType.VarChar){ Value = (object)frm["DigTopHaliAdi"] ?? DBNull.Value },
                new SqlParameter("@DIG_TOP_HALI_TEL_NO", SqlDbType.VarChar){ Value = (object)frm["DigTopHaliTelNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_HAL_ID", SqlDbType.Int){ Value = (object)frm["HalId"] ?? DBNull.Value},
                new SqlParameter("@FIR_MAHALLE", SqlDbType.VarChar){ Value = (object)frm["FirMahalle"] ?? DBNull.Value },
                new SqlParameter("@FIR_CADDE", SqlDbType.VarChar){ Value = (object)frm["FirCadde"] ?? DBNull.Value },
                new SqlParameter("@FIR_SOKAK", SqlDbType.VarChar){ Value = (object)frm["FirSokak"] ?? DBNull.Value },
                new SqlParameter("@FIR_KAPI_NO", SqlDbType.Char){ Value = (object)frm["FirKapiNo"] ?? DBNull.Value },
                new SqlParameter("@FIR_DAIRE_NO", SqlDbType.Char){ Value = (object)frm["FirDaireNo"] ?? DBNull.Value },
                new SqlParameter("@FIR_POSTA_KODU", SqlDbType.Char){ Value = (object)frm["FirPostaKodu"] ?? DBNull.Value },
                new SqlParameter("@FIR_WEB_ADRESI", SqlDbType.VarChar){ Value = (object)frm["FirWebAdresi"] ?? DBNull.Value },
                new SqlParameter("@FIR_MERSIS_NO", SqlDbType.Char){ Value = (object)frm["FirMersisNo"] ?? DBNull.Value },
                new SqlParameter("@FIR_IBAN_NO", SqlDbType.VarChar){ Value = (object)frm["FirIbanNo"] ?? DBNull.Value },
                new SqlParameter("@FIR_BANKA_ADI", SqlDbType.VarChar){ Value = (object)frm["FirBankaAdi"] ?? DBNull.Value },
                new SqlParameter("@DIG_BAGKUR_KULLANICI_ADI", SqlDbType.VarChar){ Value = (object)frm["DigBagkurKullaniciAdi"] ?? DBNull.Value },
                new SqlParameter("@DIG_BAGKUR_SIFRESI", SqlDbType.VarChar){ Value = (object)frm["DigBagkurSifresi"] ?? DBNull.Value },
            };
                List<string> firmaExecPrms = new List<string>()
            {
               "DIG_SICIL_KODU", "DIG_YAZIHANE_NO", "DIG_FIRMA_ADI", "DIG_VERGI_DAIRESI_ID", "DIG_VERGI_KIMLIK_NO", "DIG_SAHIS_ADI", "DIG_SAHIS_SOYADI", "DIG_ADRES", "DIG_TELEFON", "DIG_GSM_NO", "DIG_EPOSTA", "DIG_TOP_HALI_ADI", "DIG_TOP_HALI_TEL_NO",
               "DIG_HAL_ID", "FIR_MAHALLE", "FIR_CADDE", "FIR_SOKAK", "FIR_KAPI_NO", "FIR_DAIRE_NO", "FIR_POSTA_KODU", "FIR_WEB_ADRESI", "FIR_MERSIS_NO", "FIR_IBAN_NO", "FIR_BANKA_ADI", "DIG_BAGKUR_KULLANICI_ADI", "DIG_BAGKUR_SIFRESI",
            };
                var firmaDbQuery = CreateSqlQuery("SOHAL_FIRMA_TANIMLARI_KAYDET", firmaExecPrms);
                await _context.Database.ExecuteSqlCommandAsync(firmaDbQuery, firmaParameters.ToArray());


                //E BELGE TANIMLARI STORE PROCEDURE
                var eBelgeParameters = new List<SqlParameter>()
            {
                new SqlParameter("@ENTEGRATOR_YANIT_VERME_SURESI", SqlDbType.Int){ Value = (object)frm["EntegratorYanitVermeSuresi"] ?? DBNull.Value },
                new SqlParameter("@E_BELGE_SERVER_IP", SqlDbType.Char){ Value = (object)frm["EBelgeServerIp"] ?? DBNull.Value },
                new SqlParameter("@E_BELGE_SERVER_PORTU", SqlDbType.Int){ Value = (object)frm["EBelgeServerPortu"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@E_FATURA_SENARYOSU", SqlDbType.Int){ Value = (object)frm["EFaturaSenaryosu"] ?? DBNull.Value },
                new SqlParameter("@KDV_MUAFIYET_NEDENI", SqlDbType.VarChar){ Value = (object)frm["KdvMuafiyetNedeni"] ?? DBNull.Value },
                new SqlParameter("@ENTEGRATOR_CSV_DIZINI", SqlDbType.VarChar){ Value = (object)frm["EntegratorCsvDizini"] ?? DBNull.Value },
                new SqlParameter("@XSLT_DOSYALARI_KOPYALANSIN", SqlDbType.Bit){ Value = (object)frm["XsltDosyalariKopyalansin"] ?? DBNull.Value },
                new SqlParameter("@RPT_DOSYALARI_KOPYALANSIN", SqlDbType.Bit){ Value = (object)frm["RptDosyalariKopyalansin"] ?? DBNull.Value },
                new SqlParameter("@E_FATURA_BASLANGIC_TARIHI", SqlDbType.DateTime){ Value = (object)frm["EFaturaBaslangicTarihi"] ?? DBNull.Value },
                new SqlParameter("@E_FATURA_ON_EKI", SqlDbType.Char){ Value = (object)frm["EFaturaOnEki"] ?? DBNull.Value },
                new SqlParameter("@E_FATURA_SIRA_NO", SqlDbType.Int){ Value = (object)frm["EFaturaSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@E_FATURA_BASILSIN", SqlDbType.Bit){ Value = (object)frm["EFaturaBasilsin"] ?? DBNull.Value },
                new SqlParameter("@E_FATURA_NOT_ADET_OLSUN", SqlDbType.Bit){ Value = (object)frm["EFaturaNotAdetOlsun"] ?? DBNull.Value },
                new SqlParameter("@E_FATURA_MUSTAHSIL_VAR", SqlDbType.Bit){ Value = (object)frm["EFaturaMustahsilVar"] ?? DBNull.Value },
                new SqlParameter("@E_FATURA_MUSTAHSIL_VKN_VAR", SqlDbType.Bit){ Value = (object)frm["EFaturaMustahsilVknVar"] ?? DBNull.Value },
                new SqlParameter("@E_ARSIV_BASLANGIC_TARIHI", SqlDbType.DateTime){ Value = (object)frm["EArsivBaslangicTarihi"] ?? DBNull.Value },
                new SqlParameter("@E_ARSIV_FATURASI_ON_EKI", SqlDbType.Char){ Value = (object)frm["EArsivFaturasiOnEki"] ?? DBNull.Value },
                new SqlParameter("@E_ARSIV_FATURASI_SIRA_NO", SqlDbType.Int){ Value = (object)frm["EArsivFaturasiSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@E_ARSIV_FATURASI_BASILSIN", SqlDbType.Bit){ Value = (object)frm["EArsivFaturasiBasilsin"] ?? DBNull.Value },
                new SqlParameter("@E_MUSTAHSIL_MAKBUZU_BASLANGIC_TARIHI", SqlDbType.DateTime){ Value = (object)frm["EMustahsilMakbuzuBaslangicTarihi"] ?? DBNull.Value },
                new SqlParameter("@E_MUSTAHSIL_MAKBUZU_ON_EKI", SqlDbType.Char){ Value = (object)frm["EMustahsilMakbuzuOnEki"] ?? DBNull.Value },
                new SqlParameter("@E_MUSTAHSIL_MAKBUZU_SIRA_NO", SqlDbType.Int){ Value = (object)frm["EMustahsilMakbuzuSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@E_MUSTAHSIL_MAKBUZU_BASILSIN", SqlDbType.Bit){ Value = (object)frm["EMustahsilMakbuzuBasilsin"] ?? DBNull.Value },
                new SqlParameter("@FIRMALARA_MAKBUZ_KESILSIN", SqlDbType.Bit){ Value = (object)frm["FirmalaraMakbuzKesilsin"] ?? DBNull.Value },
                new SqlParameter("@MUS_FAT_DUZENLEME_SEKLI", SqlDbType.Int){ Value = (object)frm["MusFatDuzenlemeSekli"] ?? DBNull.Value },
                new SqlParameter("@E_MUSTAHSIL_FATURASI_ON_EKI", SqlDbType.Char){ Value = (object)frm["EMustahsilFaturasiOnEki"] ?? DBNull.Value },
                new SqlParameter("@E_MUSTAHSIL_FATURASI_SIRA_NO", SqlDbType.Int){ Value = (object)frm["EMustahsilFaturasiSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@E_MUS_FAT_ARSIV_ON_EKI", SqlDbType.Char){ Value = (object)frm["EMusFatArsivOnEki"] ?? DBNull.Value },
                new SqlParameter("@E_MUS_FAT_ARSIV_SIRA_NO", SqlDbType.Int){ Value = (object)frm["EMusFatArsivSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@E_IRSALIYE_BASLANGIC_TARIHI", SqlDbType.DateTime){ Value = (object)frm["EIrsaliyeBaslangicTarihi"] ?? DBNull.Value },
                new SqlParameter("@E_IRSALIYE_ON_EKI", SqlDbType.Char){ Value = (object)frm["EIrsaliyeOnEki"] ?? DBNull.Value },
                new SqlParameter("@E_IRSALIYE_SIRA_NO", SqlDbType.Int){ Value = (object)frm["EIrsaliyeSiraNo"]?.Replace(".","") ?? DBNull.Value },
                new SqlParameter("@E_IRSALIYE_BASILSIN", SqlDbType.Bit){ Value = (object)frm["EIrsaliyeBasilsin"] ?? DBNull.Value },
                new SqlParameter("@E_IRSALIYEDE_FIYAT_VAR", SqlDbType.Bit){ Value = (object)frm["EIrsaliyedeFiyatVar"] ?? DBNull.Value },
                new SqlParameter("@E_FATURA_YAZI_ILE_SEKLI", SqlDbType.Int){ Value = (object)frm["EFaturaYaziIleSekli"] ?? DBNull.Value },
                new SqlParameter("@E_FATURA_EXE_YOLU", SqlDbType.VarChar){ Value = (object)frm["EFaturaExeYolu"] ?? DBNull.Value },
                new SqlParameter("@E_FATURA_PORTAL_ADRESI", SqlDbType.VarChar){ Value = (object)frm["EFaturaPortalAdresi"] ?? DBNull.Value },
            };
                List<string> eBelgeExecPrms = new List<string>()
            {
                "ENTEGRATOR_YANIT_VERME_SURESI", "E_BELGE_SERVER_IP", "E_BELGE_SERVER_PORTU", "E_FATURA_SENARYOSU", "KDV_MUAFIYET_NEDENI", "ENTEGRATOR_CSV_DIZINI", "XSLT_DOSYALARI_KOPYALANSIN",
                "RPT_DOSYALARI_KOPYALANSIN", "E_FATURA_BASLANGIC_TARIHI", "E_FATURA_ON_EKI", "E_FATURA_SIRA_NO", "E_FATURA_BASILSIN", "E_FATURA_NOT_ADET_OLSUN", "E_FATURA_MUSTAHSIL_VAR",
                "E_FATURA_MUSTAHSIL_VKN_VAR", "E_ARSIV_BASLANGIC_TARIHI", "E_ARSIV_FATURASI_ON_EKI", "E_ARSIV_FATURASI_SIRA_NO", "E_ARSIV_FATURASI_BASILSIN", "E_MUSTAHSIL_MAKBUZU_BASLANGIC_TARIHI",
                "E_MUSTAHSIL_MAKBUZU_ON_EKI", "E_MUSTAHSIL_MAKBUZU_SIRA_NO","E_MUSTAHSIL_MAKBUZU_BASILSIN", "FIRMALARA_MAKBUZ_KESILSIN", "MUS_FAT_DUZENLEME_SEKLI", "E_MUSTAHSIL_FATURASI_ON_EKI",
                "E_MUSTAHSIL_FATURASI_SIRA_NO", "E_MUS_FAT_ARSIV_ON_EKI", "E_MUS_FAT_ARSIV_SIRA_NO", "E_IRSALIYE_BASLANGIC_TARIHI", "E_IRSALIYE_ON_EKI", "E_IRSALIYE_SIRA_NO", "E_IRSALIYE_BASILSIN",
                "E_IRSALIYEDE_FIYAT_VAR", "E_FATURA_YAZI_ILE_SEKLI", "E_FATURA_EXE_YOLU", "E_FATURA_PORTAL_ADRESI",
            };
                var eBelgeDbQuery = CreateSqlQuery("SOHAL_E_BELGE_TANIMI_KAYDET", eBelgeExecPrms);
                await _context.Database.ExecuteSqlCommandAsync(eBelgeDbQuery, eBelgeParameters.ToArray()); //Error Converting data type nvarchar to bit hata veriyor!!??


                //DİGER TANIMLARI STORE PROCEDURE
                var digerParameters = new List<SqlParameter>()
            {
                new SqlParameter("@DIG_FIYAT_KURUS_SAYISI", SqlDbType.Int){ Value = (object)frm["DigFiyatKurusSayisi"] ?? DBNull.Value },
                new SqlParameter("@DIG_KILO_ONDALIK_SAYISI", SqlDbType.Int){ Value = (object)frm["DigKiloOndalikSayisi"] ?? DBNull.Value },
                new SqlParameter("@DIG_BORDRO_SAYFA_NO", SqlDbType.Int){ Value = (object)frm["DigBordroSayfaNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_BORDRO_KAP_DEVRI", SqlDbType.Int){ Value = (object)frm["DigBordroKapDevri"] ?? DBNull.Value },
                new SqlParameter("@DIG_BORDRO_KILO_DEVRI", SqlDbType.Float){ Value = (object)frm["DigBordroKiloDevri"] ?? DBNull.Value },
                new SqlParameter("@DIG_MAL_BEYAN_SAYFA_NO", SqlDbType.Int){ Value = (object)frm["DigMalBeyanSayfaNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_DOKUM_DEFTER_SAYFA_NO", SqlDbType.Int){ Value = (object)frm["DigDokumDefterSayfaNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_DOKUM_NO_BASINA_SIFIR", SqlDbType.Bit){ Value = (object)frm["DigDokumNoBasinaSifir"] ?? DBNull.Value },
                new SqlParameter("@DIG_MUSTAHSIL_KOD_SIRA_NO", SqlDbType.Int){ Value = (object)frm["DigMustahsilKodSiraNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_MUSTERI_KOD_SIRA_NO", SqlDbType.Int){ Value = (object)frm["DigMusteriKodSiraNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_CARI_KOD_BASINA_SIFIR", SqlDbType.Bit){ Value = (object)frm["DigCariKodBasinaSifir"] ?? DBNull.Value },
                new SqlParameter("@DIG_FATURA_NO_BASINA_SIFIR", SqlDbType.Bit){ Value = (object)frm["DigFaturaNoBasinaSifir"] ?? DBNull.Value },
                new SqlParameter("@DIG_REHIN_IADE_CALISMA_SEKLI", SqlDbType.Int){ Value = (object)frm["DigRehinIadeCalismaSekli"] ?? DBNull.Value },
                new SqlParameter("@DIG_REHIN_TAHSILAT_GOSTERIMI", SqlDbType.Int){ Value = (object)frm["DigRehinTahsilatGosterimi"] ?? DBNull.Value },
                new SqlParameter("@DIG_KASA_VERESIYE_SEKLI", SqlDbType.Int){ Value = (object)frm["DigKasaVeresiyeSekli"] ?? DBNull.Value },
                new SqlParameter("@DIG_KASA_DEVRI", SqlDbType.Float){ Value = (object)frm["DigKasaDevri"] ?? DBNull.Value },
                new SqlParameter("@DIG_BELGE_DIZINI", SqlDbType.VarChar){ Value = (object)frm["DigBelgeDizini"] ?? DBNull.Value },
                new SqlParameter("@DIG_EDIT_DENETIM_ISLEYISI", SqlDbType.Int){ Value = (object)frm["DigEditDenetimIsleyisi"] ?? DBNull.Value },
                new SqlParameter("@DIG_REHIN_BAZLI_KAP_CARI", SqlDbType.Bit){ Value = (object)frm["DigRehinBazliKapCari"] ?? DBNull.Value },
                new SqlParameter("@DIG_KASA_DEFTERINDE_DEVIR_VAR", SqlDbType.Bit){ Value = (object)frm["DigKasaDefterindeDevirVar"] ?? DBNull.Value },
                new SqlParameter("@DIG_KASA_DEVIR_SEKLI", SqlDbType.Int){ Value = (object)frm["DigKasaDevirSekli"] ?? DBNull.Value },
                new SqlParameter("@DIG_REHIN_BAKIYE_GOSTERILSIN", SqlDbType.Bit){ Value = (object)frm["DigRehinBakiyeGosterilsin"] ?? DBNull.Value },
                new SqlParameter("@DIG_CARI_HAREKET_REF_NO", SqlDbType.Int){ Value = (object)frm["DigCariHareketRefNo"].Replace(".","") ?? DBNull.Value },
                new SqlParameter("@DIG_BUYUK_HARFE_CEVIR", SqlDbType.Bit){ Value = (object)frm["DigBuyukHarfeCevir"] ?? DBNull.Value },
                new SqlParameter("@DIG_ODEME_BORDRO_SIRA_NO", SqlDbType.Int){ Value = (object)frm["DigOdemeBordroSiraNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_ODEME_BORDRO_BASINA_SIFIR", SqlDbType.Bit){ Value = (object)frm["DigOdemeBordroBasinaSifir"] ?? DBNull.Value },
                new SqlParameter("@DIG_VADE_FARKI_ORANI", SqlDbType.Float){ Value = (object)frm["DigVadeFarkiOrani"] ?? DBNull.Value },
                new SqlParameter("@DIG_REHIN_BASLANGIC_TARIHI", SqlDbType.DateTime){ Value = (object)frm["DigRehinBaslangicTarihi"] ?? DBNull.Value },
                new SqlParameter("@DIG_DONEM_BASLANGIC_TARIHI", SqlDbType.DateTime){ Value = (object)frm["DigDonemBaslangicTarihi"] ?? DBNull.Value },
                new SqlParameter("@DIG_TUTAR_HESAPLAMA_SEKLI", SqlDbType.Int){ Value = (object)frm["DigTutarHesaplamaSekli"] ?? DBNull.Value },
                new SqlParameter("@DIG_KAS_MUSTAH_CALISMA_SEKLI", SqlDbType.Int){ Value = (object)frm["DigKasMustahCalismaSekli"] ?? DBNull.Value },
                new SqlParameter("@DIG_SATIS_TIPI", SqlDbType.Int){ Value = (object)frm["DigSatisTipi"] ?? DBNull.Value },
                new SqlParameter("@DIG_HAL_MUDURLUK_FORMU_KLASORU", SqlDbType.VarChar){ Value = (object)frm["DigHalMudurlukFormuKlasoru"] ?? DBNull.Value },
                new SqlParameter("@DIG_YEDEK_KLASORU", SqlDbType.VarChar){ Value = (object)frm["DigYedekKlasoru"] ?? DBNull.Value },
                new SqlParameter("@DIG_VERESIYE_ASIM_OLAYI", SqlDbType.Int){ Value = (object)frm["DigVeresiyeAsimOlayi"] ?? DBNull.Value },
                new SqlParameter("@DIG_ACIKLAMA2_GOSTER", SqlDbType.Bit){ Value = (object)frm["DigAciklama2Goster"] ?? DBNull.Value },
                new SqlParameter("@HAL_MUDURLUK_XML_ADI", SqlDbType.Bit){ Value = (object)frm["HalMudurlukXmlAdi"] ?? DBNull.Value },
                new SqlParameter("@DIG_IKINCI_YEDEK_KLASORU", SqlDbType.VarChar){ Value = (object)frm["DigIkinciYedekKlasoru"] ?? DBNull.Value },
                new SqlParameter("@FIS_SIRA_NO", SqlDbType.Int){ Value = (object)frm["FisSiraNo"] ?? DBNull.Value },
                new SqlParameter("@MAL_KABUL_SIRA_NO", SqlDbType.Int){ Value = (object)frm["MalKabulSiraNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_VERESIYE_MIZANI_AC", SqlDbType.Bit){ Value = (object)frm["DigVeresiyeMizaniAc"] ?? DBNull.Value },
                new SqlParameter("@DIG_KASA_DEVRINDE_YUK_NAK_VAR", SqlDbType.Bit){ Value = (object)frm["DigKasaDevrindeYukNakVar"] ?? DBNull.Value },
                new SqlParameter("@DIG_KASA_DEFTERINDE_ALIS_VAR", SqlDbType.Bit){ Value = (object)frm["DigKasaDefterindeAlisVar"] ?? DBNull.Value },
                new SqlParameter("@KUNYE_COGALMA_LOG", SqlDbType.Bit){ Value = (object)frm["KunyeCogalmaLog"] ?? DBNull.Value },
                new SqlParameter("@DIG_BAGKUR_DOSYA_NO", SqlDbType.VarChar){ Value = (object)frm["DigBagkurDosyaNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_VERGI_NO_SORGULAMA_YONTEMI", SqlDbType.Int){ Value = DBNull.Value },
                new SqlParameter("@DIG_VERGI_SORGULAYAN_TC_K_NO", SqlDbType.Char){ Value = (object)frm["DigVergiSorgulayanTcKNo"] ?? DBNull.Value },
                new SqlParameter("@DIG_MUSAVIR_TURMOB_SIFRESI", SqlDbType.VarChar){ Value = DBNull.Value },
                new SqlParameter("@DIG_KASA_KREDI_KARTI_VAR", SqlDbType.Bit){ Value = (object)frm["DigKasaKrediKartiVar"] ?? DBNull.Value },
                new SqlParameter("@DIG_ETA_FATURA_KLASORU", SqlDbType.VarChar){ Value = (object)frm["DigEtaFaturaKlasoru"] ?? DBNull.Value },
            };
                List<string> digerExecPrms = new List<string>()
            {
                "DIG_FIYAT_KURUS_SAYISI", "DIG_KILO_ONDALIK_SAYISI", "DIG_BORDRO_SAYFA_NO", "DIG_BORDRO_KAP_DEVRI", "DIG_BORDRO_KILO_DEVRI", "DIG_MAL_BEYAN_SAYFA_NO", "DIG_DOKUM_DEFTER_SAYFA_NO", "DIG_DOKUM_NO_BASINA_SIFIR",
                "DIG_MUSTAHSIL_KOD_SIRA_NO", "DIG_MUSTERI_KOD_SIRA_NO", "DIG_CARI_KOD_BASINA_SIFIR", "DIG_FATURA_NO_BASINA_SIFIR", "DIG_REHIN_IADE_CALISMA_SEKLI", "DIG_REHIN_TAHSILAT_GOSTERIMI", "DIG_KASA_VERESIYE_SEKLI",
                "DIG_KASA_DEVRI", "DIG_BELGE_DIZINI", "DIG_EDIT_DENETIM_ISLEYISI", "DIG_REHIN_BAZLI_KAP_CARI", "DIG_KASA_DEFTERINDE_DEVIR_VAR", "DIG_KASA_DEVIR_SEKLI", "DIG_REHIN_BAKIYE_GOSTERILSIN", "DIG_CARI_HAREKET_REF_NO",
                "DIG_BUYUK_HARFE_CEVIR", "DIG_ODEME_BORDRO_SIRA_NO", "DIG_ODEME_BORDRO_BASINA_SIFIR", "DIG_VADE_FARKI_ORANI", "DIG_REHIN_BASLANGIC_TARIHI", "DIG_DONEM_BASLANGIC_TARIHI", "DIG_TUTAR_HESAPLAMA_SEKLI", "DIG_KAS_MUSTAH_CALISMA_SEKLI",
                "DIG_SATIS_TIPI", "DIG_HAL_MUDURLUK_FORMU_KLASORU", "DIG_YEDEK_KLASORU", "DIG_VERESIYE_ASIM_OLAYI", "DIG_ACIKLAMA2_GOSTER", "HAL_MUDURLUK_XML_ADI", "DIG_IKINCI_YEDEK_KLASORU",
                "FIS_SIRA_NO", "MAL_KABUL_SIRA_NO", "DIG_VERESIYE_MIZANI_AC", "DIG_KASA_DEVRINDE_YUK_NAK_VAR", "DIG_KASA_DEFTERINDE_ALIS_VAR", "KUNYE_COGALMA_LOG", "DIG_BAGKUR_DOSYA_NO", "DIG_VERGI_NO_SORGULAMA_YONTEMI", "DIG_VERGI_SORGULAYAN_TC_K_NO","DIG_MUSAVIR_TURMOB_SIFRESI", "DIG_KASA_KREDI_KARTI_VAR", "DIG_ETA_FATURA_KLASORU",
            };
                var digerDbQuery = CreateSqlQuery("SOHAL_DIGER_TANIMLARI_KAYDET", digerExecPrms);
                await _context.Database.ExecuteSqlCommandAsync(digerDbQuery, digerParameters.ToArray());
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "İşlem Sırasında Hata Oluştu: " + ex.Message;
                return RedirectToAction(nameof(HalEntegreTanimlari));

            }
            TempData["SuccessMessage"] = "İşlem Başarılı";
            return RedirectToAction(nameof(HalEntegreTanimlari));
        }
        // Teknik İşlemler > Hks Tanımları > Yer Kayıt
        public ActionResult HksYerKayit()
        {
            return View();
        }
        // Teknik İşlemler > Hks Tanımları > Hal Kayıt
        public ActionResult HksHalKayit()
        {
            return View();
        }
        // Teknik İşlemler > Hks Tanımları > Hal Kayıt Sistemi Mal Kayıt
        public ActionResult HksHalKayitSistemi()
        {
            return View();
        }
        // Teknik İşlemler > Hks Tanımları > Teslimat yeri Ve Sıfat
        public ActionResult HksTeslimatYerVeSifat()
        {
            var cariSifatlar = _context.TohalCariSifats
                          .Where(s => s.CariKartId == null)
                          .ToList();

            ViewData["TeslimatYeri"] = _context.TohalTeslimatYeris.ToList();
            return View(cariSifatlar);
        }
        // Teknik İşlemler > Hks Tanımları > Hatalı Hks İstekleri
        public ActionResult HksHataliIstekler()
        {
            return View();
        }
        // Teknik İşlemler > Cari Fiyat Listeleri
        public ActionResult CariFiyatListeleri()
        {
            return View();
        }
        // Teknik İşlemler > Piyasa Fiyat Listeleri
        public ActionResult PiyasaFiyatListeleri()
        {
            ViewData["MalModel"] = new List<VohalMal>();
            return View();
        }
        // Teknik İşlemler > KDV Tevkifat Tanımları
        public ActionResult KdvTevkifatTanimlari()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Devir Ayarları
        public ActionResult DevirAyarlari()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Devir İşlemleri
        public ActionResult DevirIslemleri()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Dönemi Onayla
        public ActionResult DonemiOnayla()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Müstahsil İl/İlçe/Beldeyi Döküme Aktar
        public ActionResult MustahsilIlIlceBeldeAktar()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Müstahsil Hal Bilgisini Döküme Aktar
        public ActionResult MustahsilHalBilgisiAktar()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Müşteri İl/İlçe/Beldeyi Satışa Aktar
        public ActionResult MusteriIlIlceBeldeAktar()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Müşteri Hal Bilgisini Satışa Aktar
        public ActionResult MusterilHalBilgisiAktar()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Kayıtısız Müşteri İl/İlçe/belde Satışa Aktar
        public ActionResult KayitsizMusteriIlIlceBeldeAktar()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Kayıtsız müşteri Hal Bilgisini Satışa Aktar
        public ActionResult KayitsizMusteriHalBilgisiAktar()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Künye Alınmayanların Listei
        public ActionResult KunyeAlinmayanlarinListesi()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Müşteri İşyerlerini Doldur
        public ActionResult MusteriIsYerleriniDoldur()
        {
            return View();
        }
        // Teknik İşlemler > Servis İşlemleri > Yeni Tablo Açma
        public ActionResult YeniTabloAcma()
        {
            return View();
        }
        private async Task<List<SelectListItem>> YazicilarGetir() =>
            await _context.TohalYazicis.OrderBy(x => x.SiraNo).ThenBy(x => x.YaziciId).Select(x => new SelectListItem { Value = x.YaziciId.ToString(), Text = x.SiraNo + " - " + x.Ad }).ToListAsync();
        
        [HttpPost]
        public ActionResult ImageSave(int sahipTuru, string baseString)
        {
            string base64Data = baseString.Substring(baseString.IndexOf(",") + 1);
            byte[] imageBytes = Convert.FromBase64String(base64Data);
            // sahip turu logo = 1 , imza = 2
            var Imges = _context.TohalImges.ToList();
            if(Imges != null)
            {
                var imge = Imges.Where(x => x.SahipTuru == sahipTuru).FirstOrDefault();
                if (imge!= null)
                {
                    imge.Imge = imageBytes;
                    _context.Entry(imge).State = EntityState.Modified;
                }
                else
                {
                    imge = new TohalImge();
                    imge.SahipTuru = Convert.ToByte(sahipTuru);
                    imge.Imge = imageBytes;
                    _context.TohalImges.Add(imge);
                }
                _context.SaveChanges();
            }
            else
            {
                var imge = new TohalImge();
                imge.SahipTuru = Convert.ToByte(sahipTuru);
                imge.Imge = imageBytes;
                _context.TohalImges.Add(imge);
                _context.SaveChanges();
            }
            return Content("");
        }
        [HttpGet]
        public ActionResult GetImage(int sahipTur)
        {
            var imge = _context.TohalImges.FirstOrDefault(x=> x.SahipTuru==sahipTur);
            var base64Strimg = Convert.ToBase64String(imge.Imge);
            return Json(new { Image = base64Strimg }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<ActionResult> PostTeslimatYeri(List<TohalTeslimatYeri> tohalTeslimatYeri)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var mevcutTeslimatYerleri = _context.TohalTeslimatYeris.ToList();
                    var mevcutTeslimatYeriIdler = mevcutTeslimatYerleri.Select(x => x.TeslimatYeriId).ToList();

                    foreach (var item in tohalTeslimatYeri)
                    {
                        if (!mevcutTeslimatYeriIdler.Contains(item.TeslimatYeriId))
                        {
                            _context.TohalTeslimatYeris.Add(item);
                        }
                        else
                        {
                            var upItem = _context.TohalTeslimatYeris.FirstOrDefault(x=> x.TeslimatYeriId == item.TeslimatYeriId);
                            upItem.Ad = item.Ad;
                            upItem.Adres = item.Adres;
                            upItem.HksId = item.HksId;
                            upItem.HksWebSiraNo = item.HksWebSiraNo;
                            upItem.Tip = item.Tip;
                            _context.Entry(upItem).State = EntityState.Modified;
                            _context.SaveChanges();
                        }
                    }

                    await _context.SaveChangesAsync();
                    return Json(new { success = true, message = "Başarıyla eklendi" });
                }
                else
                {
                    return Json(new { success = false, message = "Geçersiz model durumu" });
                }
            }
            catch (Exception)
            {
                return new HttpStatusCodeResult(500);
            }
        }


        public ActionResult HksBilgiAl()
        {

            //var test = _hksService.SifatListesi().ToList();
            //var testx = _hksService.IsletmeTurleri().ToList();
            try
            {
                _context.TohalCariSifats.RemoveRange(_context.TohalCariSifats.Where(x => x.CariKartId == null));


                var silinecekKayitlar = _context.TohalTeslimatYeris.Where(y => !_context.TohalFaturas.Any(z => z.TeslimatYeriId == y.TeslimatYeriId));

                // Silme işlemini gerçekleştir
                foreach (var kayit in silinecekKayitlar)
                {
                    _context.TohalTeslimatYeris.Remove(kayit);
                }

                var silinecekKayitlar2 =
                _context.SaveChanges();
            }
            catch
            {

            }


            var tckn = _context.TohalTanims.FirstOrDefault().DigVergiKimlikNo;
            tckn = tckn.Trim();
            var kayitlikisi = _hksService.KayitliKisiler(new List<string> { tckn }).FirstOrDefault();
            List<int> sifatlar = kayitlikisi.Sifatlari.ToList();
            TohalCariSifat yeniSifat = new TohalCariSifat();

            if (sifatlar != null && sifatlar.Any())
            {
                foreach (int sifatId in sifatlar)
                {
                    yeniSifat.CariKartId = null;
                    yeniSifat.Sifat = (byte)sifatId;
                    if (!_context.TohalCariSifats.Any(s => s.CariKartId == null && s.Sifat == sifatId))
                    {
                        _context.TohalCariSifats.Add(yeniSifat);
                    }
                }
                _context.SaveChanges();
            }

            TohalTeslimatYeri teslimatYeri = new TohalTeslimatYeri();

            IEnumerable<SubeDTO> subeler = _hksService.Subeler(tckn);

            if (subeler != null && subeler.Any())
            {
                foreach (var sube in subeler)
                {
                    teslimatYeri.Tip = 1;
                    teslimatYeri.Ad = sube.SubeAdi;
                    teslimatYeri.HksId = sube.Id;
                    teslimatYeri.Adres = sube.Adres;

                    if (!_context.TohalTeslimatYeris.Any(s => s.HksId == sube.Id))
                    {
                        _context.TohalTeslimatYeris.Add(teslimatYeri);
                    }
                    else
                    {
                        var item = _context.TohalTeslimatYeris.FirstOrDefault(x => x.HksId == sube.Id);
                        item.Tip = 1;
                        item.Ad = sube.SubeAdi;
                        item.Adres = sube.Adres;
                        _context.Entry(item).State = EntityState.Modified;
                    }
                }
                _context.SaveChanges();
            }

            IEnumerable<HalIciIsyeriDTO> haliciisyerleri = _hksService.HalIciIsyerleri(tckn);

            if (haliciisyerleri != null && haliciisyerleri.Any())
            {
                foreach (var haliciisyeri in haliciisyerleri)
                {
                    teslimatYeri.Tip = 7;
                    teslimatYeri.Ad = haliciisyeri.IsyeriAdi;
                    teslimatYeri.HksId = haliciisyeri.Id;
                    teslimatYeri.Adres = haliciisyeri.HalAdi;

                    if (!_context.TohalTeslimatYeris.Any(s => s.HksId == haliciisyeri.Id))
                    {
                        _context.TohalTeslimatYeris.Add(teslimatYeri);
                    }
                    else
                    {
                        var item = _context.TohalTeslimatYeris.FirstOrDefault(x => x.HksId == haliciisyeri.Id);
                        item.Tip = 7;
                        item.Ad = haliciisyeri.IsyeriAdi;
                        item.Adres = haliciisyeri.HalAdi;
                        _context.Entry(item).State = EntityState.Modified;
                    }
                }
                _context.SaveChanges();
            }

            IEnumerable<DepoDTO> depolar = _hksService.Depolar(tckn);

            if (depolar != null && depolar.Any())
            {
                foreach (var depo in depolar)
                {
                    teslimatYeri.Tip = (byte)(depo.Halicimi ? 5 : 6);
                    teslimatYeri.Ad = depo.DepoAdi;
                    teslimatYeri.HksId = depo.Id;
                    teslimatYeri.Adres = depo.Adres;

                    if (!_context.TohalTeslimatYeris.Any(s => s.HksId == depo.Id))
                    {
                        _context.TohalTeslimatYeris.Add(teslimatYeri);
                    }
                    else
                    {
                        var item = _context.TohalTeslimatYeris.FirstOrDefault(x => x.HksId == depo.Id);
                        item.Tip = (byte)(depo.Halicimi ? 5 : 6);
                        item.Ad = depo.DepoAdi;
                        item.Adres = depo.Adres;
                        _context.Entry(item).State = EntityState.Modified;
                    }
                }
                _context.SaveChanges();
            }

            //var test12 = _hksService.Subeler(tckn);
            //var test13 = _hksService.HalIciIsyerleri(tckn);
            //var test14 = _hksService.Depolar(tckn);


            //var test2 = _hksService.Subeler("22807667996");
            //var test3 = _hksService.HalIciIsyerleri("22807667996");
            //var test4 = _hksService.Depolar("22807667996");

            return RedirectToAction("HksTeslimatYerVeSifat");
        }
        public string CreateSqlQuery(string storePrc, List<string> prms)
        {
            //string query = $"EXEC {storePrc} ";
            StringBuilder query = new StringBuilder($"EXEC {storePrc} "); //string builder daha verimli çalışıyor !!
            for (int i = 0; i < prms.Count - 1; i++)
            {
                var prm = prms.ElementAt(i);
                query.Append($"@{prm}, ");
                //query += $"@{prm}, ";
            }
            query.Append($"@{prms.Last()}");
            return query.ToString();
        }

        public ActionResult GibKaydet(string efVal, string eiVal, string tcknVal)
        {
            if(tcknVal == null || tcknVal == "")
            {
                tcknVal = _context.TohalTanims.FirstOrDefault().DigVergiKimlikNo;
            }
          
            var efaturapk = _context.TohalGibKullanicis
     .Where(x => x.PkTipi == 0 && x.KayitSekli == 1 && x.DokumanTipi == 0)
     .FirstOrDefault();

            if (efaturapk == null)
            {

                efaturapk = new TohalGibKullanici
                {
                    Vkn = tcknVal,
                    PostaKutusu = efVal,
                    Unvan = "",
                    Tip = 1,
                    Silindi = false,
                    PkTipi = 0,
                    KayitSekli = 1,
                    DokumanTipi = 0,
                    KayitZamani = DateTime.Now
                };

                // Oluşturulan nesneyi veritabanına ekleyebilirsin
                _context.TohalGibKullanicis.Add(efaturapk);
            }
            else
            {
                efaturapk.PostaKutusu = efVal;
                efaturapk.KayitZamani = DateTime.Now;
                _context.Entry(efaturapk).State = EntityState.Modified;
            }

            var eirsaliyepk = _context.TohalGibKullanicis
                .Where(x => x.PkTipi == 0 && x.KayitSekli == 1 && x.DokumanTipi == 1)
                .FirstOrDefault();

            if (eirsaliyepk == null)
            {
                // eirsaliyepk null ise yeni bir nesne oluştur
                eirsaliyepk = new TohalGibKullanici
                {
                    Vkn = tcknVal,
                    PostaKutusu = eiVal,
                    Unvan = "",
                    Tip = 1,
                    Silindi = false,
                    PkTipi = 0,
                    KayitSekli = 1,
                    DokumanTipi = 1,
                    KayitZamani = DateTime.Now
                };

                // Oluşturulan nesneyi veritabanına ekleyebilirsin
                _context.TohalGibKullanicis.Add(eirsaliyepk);

            }
            else
            {
                eirsaliyepk.PostaKutusu = eiVal;
                _context.Entry(eirsaliyepk).State = EntityState.Modified;
            }


            _context.SaveChanges();

            return Json(new { success = true, message = "İşlem Başarılı" }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.TohalKullanicis.FirstOrDefault() : _context.TohalKullanicis.OrderByDescending(x => x.KullaniciId).FirstOrDefault();
            return val != null ? RedirectToAction("KullaniciTanimlari", new { id = val.KullaniciId }) : RedirectToAction("KullaniciTanimlari");
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.TohalKullanicis.Where(x => x.KullaniciId > currentId).FirstOrDefault() : _context.TohalKullanicis.OrderByDescending(x => x.KullaniciId).Where(x => x.KullaniciId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("KullaniciTanimlari", new { id = val.KullaniciId });
        }


        [HttpPost]
        public JsonResult FiyatListesiKaydet(List<TohalMal> tohalMal)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var MalList = _context.TohalMals.ToList();
                    if (tohalMal != null)
                    {
                        foreach (var item in tohalMal)
                        {
                            var result = _context.TohalMals.SingleOrDefault(x => x.MalId == item.MalId);
                            result.SatisFiyati = item.SatisFiyati;
                            _context.Entry(result).State = EntityState.Modified;
                        }
                        _context.SaveChanges();
                        //var parametersVer = new List<SqlParameter>
                        //{
                        //            new SqlParameter("@FIYAT_LISTESI_ID", SqlDbType.Int)
                        //            {
                        //                Direction = ParameterDirection.Output
                        //            },
                        //            new SqlParameter("@TIP", SqlDbType.TinyInt) { Value =  ""},
                        //            new SqlParameter("@TARIH", SqlDbType.Date) { Value =  ""},
                        //            new SqlParameter("@ACIKLAMA", SqlDbType.Char) { Value =  ""}
                        //};

                        //await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_FIYAT_LISTESI_KAYDET @TIP, @TARIH, @ACIKLAMA", parametersVer.ToArray());

                    }
                    return Json(new { success = true, message = "Başarıyla eklendi" }, JsonRequestBehavior.AllowGet);
                }
                else
                {

                    return Json(new { success = false, message = "Geçersiz model durumu" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
