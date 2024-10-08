using Autofac.Features.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfisHal.Core.Domain;
using OfisHal.Core.ViewModels;
using OfisHal.Data.Context;
using OfisHal.Services;
using OfisHal.Services.HksGenelSvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class TohalCariKartsController : BaseController
    {
        private readonly Db _context;
        private readonly IHksService _hksService;
        private readonly IInvoiceService _invoiceService;
        public TohalCariKartsController(Db context, IHksService hksService, IInvoiceService invoiceService)
        {
            _context = context;
            _hksService = hksService;
            _invoiceService = invoiceService;
        }

        #region Mustahsil Cari
        public ActionResult Create(string metin, bool? durum)
        {
            ViewBag.resultText = new { message = metin, state = durum };
            ViewData["fiyatlar"] = new SelectList(_context.TohalFiyatListesis.Where(x => x.Tip == 0).OrderBy(x => x.Aciklama).ThenBy(x => x.FiyatListesiId), "FiyatListesiId", "Aciklama");
            ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.DokumanTipi == 0 && x.PkTipi == 1 && x.Silindi == false).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TohalCariKart tohalCariKart, string Devir, string Oran)
        {
            if (string.IsNullOrEmpty(tohalCariKart.Ad))
            {
                ModelState.AddModelError("Ad", "Ad Alanı Boş Olamaz");
                ViewData["fiyatlar"] = new SelectList(_context.TohalFiyatListesis.Where(x => x.Tip == 0).OrderBy(x => x.Aciklama).ThenBy(x => x.FiyatListesiId), "FiyatListesiId", "Aciklama");
                ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.DokumanTipi == 0 && x.PkTipi == 1 && x.Silindi == false).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
                return View(tohalCariKart);
            }
            Devir = Devir?.Replace(".", "");
            var devir = Convert.ToDecimal(Devir);

            Oran = Oran?.Replace(".", "");
            var oran = Convert.ToDecimal(Oran);
            try
            {
                var parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@CARI_KART_ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        },
                        new SqlParameter("@TIP", SqlDbType.BigInt) { Value = 0 },
                        new SqlParameter("@KOD", (object)tohalCariKart.Kod ?? DBNull.Value),
                        new SqlParameter("@AD", (object)tohalCariKart.Ad ?? DBNull.Value),
                        new SqlParameter("@MARKA_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@ADRES", (object)tohalCariKart.Adres ?? DBNull.Value),
                        new SqlParameter("@POSTA_KODU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.PostaKoduId?? DBNull.Value },
                        new SqlParameter("@TEL1", (object)tohalCariKart.Tel1 ?? DBNull.Value),
                        new SqlParameter("@TEL2", (object)tohalCariKart.Tel2 ?? DBNull.Value),
                        new SqlParameter("@FAKS", (object)tohalCariKart.Faks ?? DBNull.Value),
                        new SqlParameter("@BANKA_HESAP_NO", SqlDbType.NVarChar) { Value = (object)tohalCariKart.BankaHesapNo ?? DBNull.Value },
                        new SqlParameter("@KISILIK_TIPI", SqlDbType.BigInt) { Value = (object)tohalCariKart.KisilikTipi ?? DBNull.Value },
                        new SqlParameter("@VERGI_KIMLIK_NO", (object)tohalCariKart.VergiKimlikNo ?? DBNull.Value),
                        new SqlParameter("@VERGI_DAIRESI_ID", SqlDbType.Int) { Value = (object)tohalCariKart.VergiDairesiId ?? DBNull.Value },
                        new SqlParameter("@MUAFIYET_BELGE_NO", (object)tohalCariKart.MuafiyetBelgeNo ?? DBNull.Value),
                        new SqlParameter("@MUAFIYET_BITIS_TARIHI", SqlDbType.DateTime) { Value = (object)tohalCariKart.MuafiyetBitisTarihi ?? DBNull.Value },
                        new SqlParameter("@BAGKUR_NO", (object)tohalCariKart.BagkurNo ?? DBNull.Value),
                        new SqlParameter("@BABA_ADI", (object)tohalCariKart.BabaAdi ?? DBNull.Value),
                        new SqlParameter("@DOGUM", (object)tohalCariKart.Dogum ?? DBNull.Value),
                        new SqlParameter("@BORSA_SICIL_NO", (object)tohalCariKart.BorsaSicilNo ?? DBNull.Value),
                        new SqlParameter("@KEFIL", (object)tohalCariKart.Kefil ?? DBNull.Value),
                        new SqlParameter("@ORTAK_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@ORTAKLIK_ORANI", SqlDbType.Float) { Value = 0.0 },
                        new SqlParameter("@ORAN", SqlDbType.Float) { Value = (object)oran ?? DBNull.Value },
                        new SqlParameter("@DEVIR", SqlDbType.Decimal) { Value = (object)devir ?? 0 },
                        new SqlParameter("@FILTRE", (object)tohalCariKart.Filtre ?? DBNull.Value),
                        new SqlParameter("@KENDI_KODU", (object)tohalCariKart.KendiKodu ?? DBNull.Value),
                        new SqlParameter("@REESKONT_ORANI", SqlDbType.Float) { Value = (object)tohalCariKart.ReeskontOrani ?? 0.0 },
                        new SqlParameter("@DEVIR_ISLEMI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@RUSUM_ALINMASIN", SqlDbType.Bit) { Value = (object)tohalCariKart.RusumAlinmasin ?? DBNull.Value },
                        new SqlParameter("@PLAKA_NO", (object)tohalCariKart.PlakaNo ?? DBNull.Value),
                        new SqlParameter("@YER_ID", SqlDbType.Int) { Value = (object)tohalCariKart.YerId?? DBNull.Value },
                        new SqlParameter("@GSM_NO", (object)tohalCariKart.GsmNo ?? DBNull.Value),
                        new SqlParameter("@E_POSTA", (object)tohalCariKart.EPosta ?? DBNull.Value),
                        new SqlParameter("@GIDECEGI_YER_TIPI", SqlDbType.BigInt) { Value = (object)tohalCariKart.GidecegiYerTipi ?? DBNull.Value },
                        new SqlParameter("@SEHIR_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@SATIN_ALANIN_SIFATI", SqlDbType.BigInt) { Value = (object)tohalCariKart.SatinAlaninSifati ?? DBNull.Value },
                        new SqlParameter("@HAL_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@HAL_KOMISYONCUSU", SqlDbType.Bit) { Value = (object)tohalCariKart.HalKomisyoncusu ?? DBNull.Value },
                        new SqlParameter("@IHRACATCI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@GIDECEGI_YER_WEB_SIRA_NO", SqlDbType.Int) { Value = 0 },
                        new SqlParameter("@HKS_BILGISI_ALINDI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@E_FATURA_SENARYOSU", SqlDbType.BigInt) { Value = (object)tohalCariKart.EFaturaSenaryosu ?? DBNull.Value },
                        new SqlParameter("@VERESIYE_SINIRI", SqlDbType.Decimal) { Value = (object)tohalCariKart.VeresiyeSiniri ?? 0.0 },
                        new SqlParameter("@RISK_SINIRI", SqlDbType.Decimal) { Value =(object)tohalCariKart.RiskSiniri ?? 0.0 },
                        new SqlParameter("@ULKE_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@MAHALLE", (object)tohalCariKart.Mahalle ?? DBNull.Value),
                        new SqlParameter("@CADDE", (object)tohalCariKart.Cadde ?? DBNull.Value),
                        new SqlParameter("@SOKAK", (object)tohalCariKart.Sokak ?? DBNull.Value),
                        new SqlParameter("@KAPI_NO", (object)tohalCariKart.KapiNo ?? DBNull.Value),
                        new SqlParameter("@DAIRE_NO", (object)tohalCariKart.DaireNo ?? DBNull.Value),
                        new SqlParameter("@WEB_ADRESI", (object)tohalCariKart.WebAdresi ?? DBNull.Value),
                        new SqlParameter("@KESINTI_ALINMASIN", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                        new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@MUH_HESAP_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@DIGER_MUH_HESAP_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@GIB_E_FATURA_POSTA_KUTUSU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.GibEFaturaPostaKutusuId ?? DBNull.Value },
                        new SqlParameter("@E_FATURA_BOLGE_KODU", (object)tohalCariKart.EFaturaBolgeKodu ?? DBNull.Value),
                        new SqlParameter("@E_FATURA_FATURA_KODU", (object)tohalCariKart.EFaturaFaturaKodu ?? DBNull.Value),
                        new SqlParameter("@BOLGE_KODU_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@YETKILI_KISI", (object)tohalCariKart.YetkiliKisi ?? DBNull.Value),
                        new SqlParameter("@GELDIGI_YER_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@FIYAT_LISTESI_ID", SqlDbType.Int) { Value = (object)tohalCariKart.FiyatListesiId ?? DBNull.Value },
                        new SqlParameter("@YAZIHANE_SIRA_NO", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@YAZIHANE_NOT", (object)tohalCariKart.YazihaneNot ?? DBNull.Value),
                        new SqlParameter("@VADE", SqlDbType.Int) { Value = (object)tohalCariKart.Vade ?? 0 },
                        new SqlParameter("@E_IRSALIYE_POSTA_KUTUSU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.EIrsaliyePostaKutusuId ?? DBNull.Value },
                        new SqlParameter("@E_FATURA_BELGESI", (object)tohalCariKart.EFaturaBelgesi ?? DBNull.Value),
                        new SqlParameter("@E_IRSALIYE_BELGESI", (object)tohalCariKart.EIrsaliyeBelgesi ?? DBNull.Value),
                        new SqlParameter("@KDV_ORANI", SqlDbType.Float) { Value = (object)tohalCariKart.KdvOrani ?? DBNull.Value },
                        new SqlParameter("@E_FATURA_BAKIYE_VAR", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@VERGI_NO_SORGULANDI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@FAT_KESILMEDEN_KUNYE_ALINAMAZ", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@SOFOR_ID", SqlDbType.Int) { Value = (object)tohalCariKart.SoforId ?? DBNull.Value },
                        new SqlParameter("@HAMALIYE_HESAPLAMA_SEKLI", SqlDbType.BigInt) { Value = DBNull.Value },
                        new SqlParameter("@NAKLIYE_HESAPLAMA_SEKLI", SqlDbType.BigInt) { Value = DBNull.Value },
                        new SqlParameter("@REHIN_CARI_KART_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@STOPAJSIZ_KESEBILIR", SqlDbType.Bit) { Value = false },

                    };

                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_KART_KAYDET @CARI_KART_ID OUTPUT, @TIP, @KOD, @AD, @MARKA_ID, @ADRES, @POSTA_KODU_ID, @TEL1, @TEL2, @FAKS, @BANKA_HESAP_NO, @KISILIK_TIPI, @VERGI_KIMLIK_NO, @VERGI_DAIRESI_ID, @MUAFIYET_BELGE_NO, @MUAFIYET_BITIS_TARIHI, @BAGKUR_NO, @BABA_ADI, @DOGUM, @BORSA_SICIL_NO, @KEFIL, @ORTAK_ID, @ORTAKLIK_ORANI, @ORAN, @DEVIR, @FILTRE, @KENDI_KODU, @REESKONT_ORANI, @DEVIR_ISLEMI, @RUSUM_ALINMASIN, @PLAKA_NO, @YER_ID, @GSM_NO, @E_POSTA, @GIDECEGI_YER_TIPI, @SEHIR_ID, @SATIN_ALANIN_SIFATI, @HAL_ID, @HAL_KOMISYONCUSU, @IHRACATCI, @GIDECEGI_YER_WEB_SIRA_NO, @HKS_BILGISI_ALINDI, @E_FATURA_SENARYOSU, @VERESIYE_SINIRI, @RISK_SINIRI, @ULKE_ID, @MAHALLE, @CADDE, @SOKAK, @KAPI_NO, @DAIRE_NO, @WEB_ADRESI, @KESINTI_ALINMASIN, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @MUH_HESAP_ID, @DIGER_MUH_HESAP_ID, @GIB_E_FATURA_POSTA_KUTUSU_ID, @E_FATURA_BOLGE_KODU, @E_FATURA_FATURA_KODU, @BOLGE_KODU_ID, @YETKILI_KISI, @GELDIGI_YER_ID, @FIYAT_LISTESI_ID, @YAZIHANE_SIRA_NO, @YAZIHANE_NOT, @VADE, @E_IRSALIYE_POSTA_KUTUSU_ID, @E_FATURA_BELGESI, @E_IRSALIYE_BELGESI, @KDV_ORANI, @E_FATURA_BAKIYE_VAR, @VERGI_NO_SORGULANDI, @FAT_KESILMEDEN_KUNYE_ALINAMAZ, @SOFOR_ID, @HAMALIYE_HESAPLAMA_SEKLI, @NAKLIYE_HESAPLAMA_SEKLI, @REHIN_CARI_KART_ID, @STOPAJSIZ_KESEBILIR", parameters.ToArray());
                int cariKartId = (int)parameters[0].Value;
                return RedirectToAction(nameof(Edit), new { id = cariKartId, metin = "Yeni Müstahsil Eklendi", durum = true });
            }
            catch (SqlException ex)
            {
                return RedirectToAction(nameof(Create), new { metin = ex.Errors[0].Message, durum = false });
            }
        }

        public async Task<ActionResult> Edit(int? id, string metin, bool? durum)
        {
            if (id == null || _context.TohalCariKarts == null)
            {
                return HttpNotFound();
            }
            var tohalCariKart = await _context.VohalCariKarts.FindAsync(id);
            ViewBag.resultText = new { message = metin, state = durum };
            ViewData["fiyatlar"] = new SelectList(_context.TohalFiyatListesis.Where(x => x.Tip == 0).OrderBy(x => x.Aciklama).ThenBy(x => x.FiyatListesiId), "FiyatListesiId", "Aciklama");
      
            //ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.DokumanTipi == 0 && x.PkTipi == 1 && x.Silindi == false).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
          
            ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == tohalCariKart.VergiKimlikNo && x.DokumanTipi == 0).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
     

            return View(tohalCariKart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, VohalCariKart tohalCariKart, string Devir, string Oran)
        {
            if (tohalCariKart.BeldeId == null)
            {
                ModelState.AddModelError("bekde", "Belde Alanı Boş Olamaz");
                return RedirectToAction(nameof(Edit), new { id = id, metin = "Belde Alanı Boş Olamaz", durum = false });
            }

            Devir = Devir?.Replace(".", "");
            var devir = Convert.ToDecimal(Devir);

            Oran = Oran?.Replace(".", "");
            var oran = Convert.ToDecimal(Oran);
            int yerid = 0;
            if (tohalCariKart?.BeldeId > 0)
                yerid = (int)tohalCariKart.BeldeId;
            else if (tohalCariKart?.IlceId > 0)
                yerid = (int)tohalCariKart.IlceId;
            else if (tohalCariKart?.IlId > 0)
                yerid = (int)tohalCariKart.IlId;
            try
            {
                var parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@CARI_KART_ID", SqlDbType.Int) { Value = id },
                        new SqlParameter("@TIP", SqlDbType.BigInt) { Value = 0 },
                        new SqlParameter("@KOD", (object)tohalCariKart.Kod ?? DBNull.Value),
                        new SqlParameter("@AD", (object)tohalCariKart.Ad ?? DBNull.Value),
                        new SqlParameter("@MARKA_ID", SqlDbType.Int) { Value = (object)tohalCariKart.MarkaId ?? DBNull.Value },
                        new SqlParameter("@ADRES", (object)tohalCariKart.Adres ?? DBNull.Value),
                        new SqlParameter("@POSTA_KODU_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@TEL1", (object)tohalCariKart.Tel1 ?? DBNull.Value),
                        new SqlParameter("@TEL2", (object)tohalCariKart.Tel2 ?? DBNull.Value),
                        new SqlParameter("@FAKS", (object)tohalCariKart.Faks ?? DBNull.Value),
                        new SqlParameter("@BANKA_HESAP_NO", SqlDbType.NVarChar) { Value = DBNull.Value },
                        new SqlParameter("@KISILIK_TIPI", SqlDbType.BigInt) { Value =(object)tohalCariKart.KisilikTipi ?? 0 },
                        new SqlParameter("@VERGI_KIMLIK_NO", (object)tohalCariKart.VergiKimlikNo ?? DBNull.Value),
                        new SqlParameter("@VERGI_DAIRESI_ID", SqlDbType.Int) { Value = (object)tohalCariKart.VergiDairesiId ?? DBNull.Value },
                        new SqlParameter("@MUAFIYET_BELGE_NO", (object)tohalCariKart.MuafiyetBelgeNo ?? DBNull.Value),
                        new SqlParameter("@MUAFIYET_BITIS_TARIHI", SqlDbType.DateTime) { Value = DBNull.Value },
                        new SqlParameter("@BAGKUR_NO", (object)tohalCariKart.BagkurNo ?? DBNull.Value),
                        new SqlParameter("@BABA_ADI", (object)tohalCariKart.BabaAdi ?? DBNull.Value),
                        new SqlParameter("@DOGUM", (object)tohalCariKart.Dogum ?? DBNull.Value),
                        new SqlParameter("@BORSA_SICIL_NO", (object)tohalCariKart.BorsaSicilNo ?? DBNull.Value),
                        new SqlParameter("@KEFIL", (object)tohalCariKart.Kefil ?? DBNull.Value),
                        new SqlParameter("@ORTAK_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@ORTAKLIK_ORANI", SqlDbType.Float) { Value = 0.0 },
                        new SqlParameter("@ORAN", SqlDbType.Float) { Value = (object)oran ?? DBNull.Value },
                        new SqlParameter("@DEVIR", SqlDbType.Decimal) { Value = (object)devir ?? 0 },
                        new SqlParameter("@FILTRE", (object)tohalCariKart.Filtre ?? DBNull.Value),
                        new SqlParameter("@KENDI_KODU", (object)tohalCariKart.KendiKodu ?? DBNull.Value),
                        new SqlParameter("@REESKONT_ORANI", SqlDbType.Float) { Value = (object)tohalCariKart.ReeskontOrani ?? 0.0 },
                        new SqlParameter("@DEVIR_ISLEMI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@RUSUM_ALINMASIN", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@PLAKA_NO", (object)tohalCariKart.PlakaNo ?? DBNull.Value),
                        new SqlParameter("@YER_ID", SqlDbType.Int) { Value = (object)yerid ?? DBNull.Value },
                        new SqlParameter("@GSM_NO", (object)tohalCariKart.GsmNo ?? DBNull.Value),
                        new SqlParameter("@E_POSTA", (object)tohalCariKart.EPosta ?? DBNull.Value),
                        new SqlParameter("@GIDECEGI_YER_TIPI", SqlDbType.BigInt) { Value = (object)tohalCariKart.GidecegiYerTipi ?? DBNull.Value },
                        new SqlParameter("@SEHIR_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@SATIN_ALANIN_SIFATI", SqlDbType.BigInt) { Value = (object)tohalCariKart.SatinAlaninSifati ?? DBNull.Value },
                        new SqlParameter("@HAL_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@HAL_KOMISYONCUSU", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@IHRACATCI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@GIDECEGI_YER_WEB_SIRA_NO", SqlDbType.Int) { Value = 0 },
                        new SqlParameter("@HKS_BILGISI_ALINDI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@E_FATURA_SENARYOSU", SqlDbType.BigInt) { Value = (object)tohalCariKart.EFaturaSenaryosu ?? DBNull.Value },
                        new SqlParameter("@VERESIYE_SINIRI", SqlDbType.Decimal) { Value = 0.0 },
                        new SqlParameter("@RISK_SINIRI", SqlDbType.Decimal) { Value = 0.0 },
                        new SqlParameter("@ULKE_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@MAHALLE", (object)tohalCariKart.Mahalle ?? DBNull.Value),
                        new SqlParameter("@CADDE", (object)tohalCariKart.Cadde ?? DBNull.Value),
                        new SqlParameter("@SOKAK", (object)tohalCariKart.Sokak ?? DBNull.Value),
                        new SqlParameter("@KAPI_NO", (object)tohalCariKart.KapiNo ?? DBNull.Value),
                        new SqlParameter("@DAIRE_NO", (object)tohalCariKart.DaireNo ?? DBNull.Value),
                        new SqlParameter("@WEB_ADRESI", (object)tohalCariKart.WebAdresi ?? DBNull.Value),
                        new SqlParameter("@KESINTI_ALINMASIN", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                        new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@MUH_HESAP_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@DIGER_MUH_HESAP_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@GIB_E_FATURA_POSTA_KUTUSU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.GibEFaturaPostaKutusuId ?? DBNull.Value },
                        new SqlParameter("@E_FATURA_BOLGE_KODU", (object)tohalCariKart.EFaturaBolgeKodu ?? DBNull.Value),
                        new SqlParameter("@E_FATURA_FATURA_KODU", (object)tohalCariKart.EFaturaFaturaKodu ?? DBNull.Value),
                        new SqlParameter("@BOLGE_KODU_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@YETKILI_KISI", (object)tohalCariKart.YetkiliKisi ?? DBNull.Value),
                        new SqlParameter("@GELDIGI_YER_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@FIYAT_LISTESI_ID", SqlDbType.Int) { Value = (object)tohalCariKart.FiyatListesiId ?? DBNull.Value },
                        new SqlParameter("@YAZIHANE_SIRA_NO", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@YAZIHANE_NOT", (object)tohalCariKart.YazihaneNot ?? DBNull.Value),
                        new SqlParameter("@VADE", SqlDbType.Int) { Value = (object)tohalCariKart.Vade ?? 0 },
                        new SqlParameter("@E_IRSALIYE_POSTA_KUTUSU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.EIrsaliyePostaKutusuId ?? DBNull.Value },
                        new SqlParameter("@E_FATURA_BELGESI", (object)tohalCariKart.EFaturaBelgesi ?? DBNull.Value),
                        new SqlParameter("@E_IRSALIYE_BELGESI", (object)tohalCariKart.EIrsaliyeBelgesi ?? DBNull.Value),
                        new SqlParameter("@KDV_ORANI", SqlDbType.Float) { Value = (object)tohalCariKart.KdvOrani ?? DBNull.Value },
                        new SqlParameter("@E_FATURA_BAKIYE_VAR", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@VERGI_NO_SORGULANDI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@FAT_KESILMEDEN_KUNYE_ALINAMAZ", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@SOFOR_ID", SqlDbType.Int) { Value = (object)tohalCariKart.SoforId ?? DBNull.Value },
                        new SqlParameter("@HAMALIYE_HESAPLAMA_SEKLI", SqlDbType.BigInt) { Value = DBNull.Value },
                        new SqlParameter("@NAKLIYE_HESAPLAMA_SEKLI", SqlDbType.BigInt) { Value = DBNull.Value },
                        new SqlParameter("@REHIN_CARI_KART_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@STOPAJSIZ_KESEBILIR", SqlDbType.Bit) { Value = false },

                    };

                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_KART_KAYDET @CARI_KART_ID OUTPUT, @TIP, @KOD, @AD, @MARKA_ID, @ADRES, @POSTA_KODU_ID, @TEL1, @TEL2, @FAKS, @BANKA_HESAP_NO, @KISILIK_TIPI, @VERGI_KIMLIK_NO, @VERGI_DAIRESI_ID, @MUAFIYET_BELGE_NO, @MUAFIYET_BITIS_TARIHI, @BAGKUR_NO, @BABA_ADI, @DOGUM, @BORSA_SICIL_NO, @KEFIL, @ORTAK_ID, @ORTAKLIK_ORANI, @ORAN, @DEVIR, @FILTRE, @KENDI_KODU, @REESKONT_ORANI, @DEVIR_ISLEMI, @RUSUM_ALINMASIN, @PLAKA_NO, @YER_ID, @GSM_NO, @E_POSTA, @GIDECEGI_YER_TIPI, @SEHIR_ID, @SATIN_ALANIN_SIFATI, @HAL_ID, @HAL_KOMISYONCUSU, @IHRACATCI, @GIDECEGI_YER_WEB_SIRA_NO, @HKS_BILGISI_ALINDI, @E_FATURA_SENARYOSU, @VERESIYE_SINIRI, @RISK_SINIRI, @ULKE_ID, @MAHALLE, @CADDE, @SOKAK, @KAPI_NO, @DAIRE_NO, @WEB_ADRESI, @KESINTI_ALINMASIN, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @MUH_HESAP_ID, @DIGER_MUH_HESAP_ID, @GIB_E_FATURA_POSTA_KUTUSU_ID, @E_FATURA_BOLGE_KODU, @E_FATURA_FATURA_KODU, @BOLGE_KODU_ID, @YETKILI_KISI, @GELDIGI_YER_ID, @FIYAT_LISTESI_ID, @YAZIHANE_SIRA_NO, @YAZIHANE_NOT, @VADE, @E_IRSALIYE_POSTA_KUTUSU_ID, @E_FATURA_BELGESI, @E_IRSALIYE_BELGESI, @KDV_ORANI, @E_FATURA_BAKIYE_VAR, @VERGI_NO_SORGULANDI, @FAT_KESILMEDEN_KUNYE_ALINAMAZ, @SOFOR_ID, @HAMALIYE_HESAPLAMA_SEKLI, @NAKLIYE_HESAPLAMA_SEKLI, @REHIN_CARI_KART_ID, @STOPAJSIZ_KESEBILIR", parameters.ToArray());
                int cariKartId = (int)parameters[0].Value;
                return RedirectToAction(nameof(Edit), new { id = id, metin = "Müstahsil Güncellendi", durum = true });
            }
            catch (SqlException ex)
            {
                return RedirectToAction(nameof(Edit), new { id = id, metin = ex.Errors[0].Message, durum = false });
            }
        }
        #endregion


        #region Müşteri Cari

        public ActionResult MCreate(string metin, bool? durum)
        {
            ViewBag.resultText = new { message = metin, state = durum };
            ViewBag.sifatlar = sifatListe;
            ViewBag.gidecekyerler = gidecekyerListe;
            ViewData["fiyatlar"] = new SelectList(_context.TohalFiyatListesis.Where(x => x.Tip == 0).OrderBy(x => x.Aciklama).ThenBy(x => x.FiyatListesiId), "FiyatListesiId", "Aciklama");
            //ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.DokumanTipi == 0 && x.PkTipi == 1 && x.Silindi == false).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
            //ViewData["eIrsaliyePostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.DokumanTipi == 1 && x.PkTipi == 1 && x.Silindi == false).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");

            ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.PkTipi == 0).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
            ViewData["eIrsaliyePostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.PkTipi == 1).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
            
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> MCreate(TohalCariKart tohalCariKart, string Devir, string Oran, string KdvOrani)
        {
            if (string.IsNullOrEmpty(tohalCariKart.Ad))
            {
                ModelState.AddModelError("Ad", "Ad Alanı Boş Olamaz");
                ViewBag.sifatlar = sifatListe;
                ViewBag.gidecekyerler = gidecekyerListe;
                ViewData["fiyatlar"] = new SelectList(_context.TohalFiyatListesis.Where(x => x.Tip == 0).OrderBy(x => x.Aciklama).ThenBy(x => x.FiyatListesiId), "FiyatListesiId", "Aciklama");
                ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.DokumanTipi == 0 && x.PkTipi == 1 && x.Silindi == false).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
                ViewData["eIrsaliyePostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.DokumanTipi == 1 && x.PkTipi == 1 && x.Silindi == false).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
                return View(tohalCariKart);
            }
            Devir = Devir?.Replace(".", "");
            var devir = Convert.ToDecimal(Devir);

            Oran = Oran?.Replace(".", "");
            var oran = Convert.ToDecimal(Oran);

            KdvOrani = KdvOrani?.Replace(".", "");
            var kdvOran = Convert.ToDecimal(KdvOrani);
            try
            {
                var parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@CARI_KART_ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        },
                        new SqlParameter("@TIP", SqlDbType.BigInt) { Value = 1 },
                        new SqlParameter("@KOD", (object)tohalCariKart.Kod ?? DBNull.Value),
                        new SqlParameter("@AD", (object)tohalCariKart.Ad ?? DBNull.Value),
                        new SqlParameter("@MARKA_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@ADRES", (object)tohalCariKart.Adres ?? DBNull.Value),
                        new SqlParameter("@POSTA_KODU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.PostaKoduId?? DBNull.Value },
                        new SqlParameter("@TEL1", (object)tohalCariKart.Tel1 ?? DBNull.Value),
                        new SqlParameter("@TEL2", (object)tohalCariKart.Tel2 ?? DBNull.Value),
                        new SqlParameter("@FAKS", (object)tohalCariKart.Faks ?? DBNull.Value),
                        new SqlParameter("@BANKA_HESAP_NO", SqlDbType.NVarChar) { Value = (object)tohalCariKart.BankaHesapNo ?? DBNull.Value },
                        new SqlParameter("@KISILIK_TIPI", SqlDbType.BigInt) { Value = (object)tohalCariKart.KisilikTipi ?? DBNull.Value },
                        new SqlParameter("@VERGI_KIMLIK_NO", (object)tohalCariKart.VergiKimlikNo ?? DBNull.Value),
                        new SqlParameter("@VERGI_DAIRESI_ID", SqlDbType.Int) { Value = (object)tohalCariKart.VergiDairesiId ?? DBNull.Value },
                        new SqlParameter("@MUAFIYET_BELGE_NO", (object)tohalCariKart.MuafiyetBelgeNo ?? DBNull.Value),
                        new SqlParameter("@MUAFIYET_BITIS_TARIHI", SqlDbType.DateTime) { Value = (object)tohalCariKart.MuafiyetBitisTarihi ?? DBNull.Value },
                        new SqlParameter("@BAGKUR_NO", (object)tohalCariKart.BagkurNo ?? DBNull.Value),
                        new SqlParameter("@BABA_ADI", (object)tohalCariKart.BabaAdi ?? DBNull.Value),
                        new SqlParameter("@DOGUM", (object)tohalCariKart.Dogum ?? DBNull.Value),
                        new SqlParameter("@BORSA_SICIL_NO", (object)tohalCariKart.BorsaSicilNo ?? DBNull.Value),
                        new SqlParameter("@KEFIL", (object)tohalCariKart.Kefil ?? DBNull.Value),
                        new SqlParameter("@ORTAK_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@ORTAKLIK_ORANI", SqlDbType.Float) { Value = 0.0 },
                        new SqlParameter("@ORAN", SqlDbType.Float) { Value = (object)oran ?? DBNull.Value },
                        new SqlParameter("@DEVIR", SqlDbType.Decimal) { Value = (object)devir ?? 0 },
                        new SqlParameter("@FILTRE", (object)tohalCariKart.Filtre ?? DBNull.Value),
                        new SqlParameter("@KENDI_KODU", (object)tohalCariKart.KendiKodu ?? DBNull.Value),
                        new SqlParameter("@REESKONT_ORANI", SqlDbType.Float) { Value = (object)tohalCariKart.ReeskontOrani ?? 0.0 },
                        new SqlParameter("@DEVIR_ISLEMI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@RUSUM_ALINMASIN", SqlDbType.Bit) { Value = (object)tohalCariKart.RusumAlinmasin ?? DBNull.Value },
                        new SqlParameter("@PLAKA_NO", (object)tohalCariKart.PlakaNo ?? DBNull.Value),
                        new SqlParameter("@YER_ID", SqlDbType.Int) { Value =(object)tohalCariKart.YerId ?? DBNull.Value },
                        new SqlParameter("@GSM_NO", (object)tohalCariKart.GsmNo ?? DBNull.Value),
                        new SqlParameter("@E_POSTA", (object)tohalCariKart.EPosta ?? DBNull.Value),
                        new SqlParameter("@GIDECEGI_YER_TIPI", SqlDbType.BigInt) { Value = (object)tohalCariKart.GidecegiYerTipi ?? DBNull.Value },
                        new SqlParameter("@SEHIR_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@SATIN_ALANIN_SIFATI", SqlDbType.BigInt) { Value = (object)tohalCariKart.SatinAlaninSifati ?? DBNull.Value },
                        new SqlParameter("@HAL_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@HAL_KOMISYONCUSU", SqlDbType.Bit) { Value = (object)tohalCariKart.HalKomisyoncusu ?? DBNull.Value },
                        new SqlParameter("@IHRACATCI", SqlDbType.Bit) { Value = (object)tohalCariKart.Ihracatci ?? DBNull.Value },
                        new SqlParameter("@GIDECEGI_YER_WEB_SIRA_NO", SqlDbType.Int) { Value = 0 },
                        new SqlParameter("@HKS_BILGISI_ALINDI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@E_FATURA_SENARYOSU", SqlDbType.BigInt) { Value = (object)tohalCariKart.EFaturaSenaryosu ?? DBNull.Value },
                        new SqlParameter("@VERESIYE_SINIRI", SqlDbType.Decimal) { Value = (object)tohalCariKart.VeresiyeSiniri ?? 0.0 },
                        new SqlParameter("@RISK_SINIRI", SqlDbType.Decimal) { Value =(object)tohalCariKart.RiskSiniri ?? 0.0 },
                        new SqlParameter("@ULKE_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@MAHALLE", (object)tohalCariKart.Mahalle ?? DBNull.Value),
                        new SqlParameter("@CADDE", (object)tohalCariKart.Cadde ?? DBNull.Value),
                        new SqlParameter("@SOKAK", (object)tohalCariKart.Sokak ?? DBNull.Value),
                        new SqlParameter("@KAPI_NO", (object)tohalCariKart.KapiNo ?? DBNull.Value),
                        new SqlParameter("@DAIRE_NO", (object)tohalCariKart.DaireNo ?? DBNull.Value),
                        new SqlParameter("@WEB_ADRESI", (object)tohalCariKart.WebAdresi ?? DBNull.Value),
                        new SqlParameter("@KESINTI_ALINMASIN", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                        new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@MUH_HESAP_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@DIGER_MUH_HESAP_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@GIB_E_FATURA_POSTA_KUTUSU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.GibEFaturaPostaKutusuId ?? DBNull.Value },
                        new SqlParameter("@E_FATURA_BOLGE_KODU", (object)tohalCariKart.EFaturaBolgeKodu ?? DBNull.Value),
                        new SqlParameter("@E_FATURA_FATURA_KODU", (object)tohalCariKart.EFaturaFaturaKodu ?? DBNull.Value),
                        new SqlParameter("@BOLGE_KODU_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@YETKILI_KISI", (object)tohalCariKart.YetkiliKisi ?? DBNull.Value),
                        new SqlParameter("@GELDIGI_YER_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@FIYAT_LISTESI_ID", SqlDbType.Int) { Value = (object)tohalCariKart.FiyatListesiId ?? DBNull.Value },
                        new SqlParameter("@YAZIHANE_SIRA_NO", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@YAZIHANE_NOT", (object)tohalCariKart.YazihaneNot ?? DBNull.Value),
                        new SqlParameter("@VADE", SqlDbType.Int) { Value = (object)tohalCariKart.Vade ?? 0 },
                        new SqlParameter("@E_IRSALIYE_POSTA_KUTUSU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.EIrsaliyePostaKutusuId ?? DBNull.Value },
                        new SqlParameter("@E_FATURA_BELGESI", (object)tohalCariKart.EFaturaBelgesi ?? DBNull.Value),
                        new SqlParameter("@E_IRSALIYE_BELGESI", (object)tohalCariKart.EIrsaliyeBelgesi ?? DBNull.Value),
                        new SqlParameter("@KDV_ORANI", SqlDbType.Float) { Value = (object)kdvOran ?? DBNull.Value },
                        new SqlParameter("@E_FATURA_BAKIYE_VAR", SqlDbType.Bit) { Value = (object)tohalCariKart.EFaturaBakiyeVar ?? DBNull.Value },
                        new SqlParameter("@VERGI_NO_SORGULANDI", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@FAT_KESILMEDEN_KUNYE_ALINAMAZ", SqlDbType.Bit) { Value = (object)tohalCariKart.FatKesilmedenKunyeAlinamaz ?? DBNull.Value },
                        new SqlParameter("@SOFOR_ID", SqlDbType.Int) { Value = (object)tohalCariKart.SoforId ?? DBNull.Value },
                        new SqlParameter("@HAMALIYE_HESAPLAMA_SEKLI", SqlDbType.BigInt) { Value = DBNull.Value },
                        new SqlParameter("@NAKLIYE_HESAPLAMA_SEKLI", SqlDbType.BigInt) { Value = DBNull.Value },
                        new SqlParameter("@REHIN_CARI_KART_ID", SqlDbType.Int) { Value = DBNull.Value },
                        new SqlParameter("@STOPAJSIZ_KESEBILIR", SqlDbType.Bit) { Value = false },
                    };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_KART_KAYDET @CARI_KART_ID OUTPUT, @TIP, @KOD, @AD, @MARKA_ID, @ADRES, @POSTA_KODU_ID, @TEL1, @TEL2, @FAKS, @BANKA_HESAP_NO, @KISILIK_TIPI, @VERGI_KIMLIK_NO, @VERGI_DAIRESI_ID, @MUAFIYET_BELGE_NO, @MUAFIYET_BITIS_TARIHI, @BAGKUR_NO, @BABA_ADI, @DOGUM, @BORSA_SICIL_NO, @KEFIL, @ORTAK_ID, @ORTAKLIK_ORANI, @ORAN, @DEVIR, @FILTRE, @KENDI_KODU, @REESKONT_ORANI, @DEVIR_ISLEMI, @RUSUM_ALINMASIN, @PLAKA_NO, @YER_ID, @GSM_NO, @E_POSTA, @GIDECEGI_YER_TIPI, @SEHIR_ID, @SATIN_ALANIN_SIFATI, @HAL_ID, @HAL_KOMISYONCUSU, @IHRACATCI, @GIDECEGI_YER_WEB_SIRA_NO, @HKS_BILGISI_ALINDI, @E_FATURA_SENARYOSU, @VERESIYE_SINIRI, @RISK_SINIRI, @ULKE_ID, @MAHALLE, @CADDE, @SOKAK, @KAPI_NO, @DAIRE_NO, @WEB_ADRESI, @KESINTI_ALINMASIN, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @MUH_HESAP_ID, @DIGER_MUH_HESAP_ID, @GIB_E_FATURA_POSTA_KUTUSU_ID, @E_FATURA_BOLGE_KODU, @E_FATURA_FATURA_KODU, @BOLGE_KODU_ID, @YETKILI_KISI, @GELDIGI_YER_ID, @FIYAT_LISTESI_ID, @YAZIHANE_SIRA_NO, @YAZIHANE_NOT, @VADE, @E_IRSALIYE_POSTA_KUTUSU_ID, @E_FATURA_BELGESI, @E_IRSALIYE_BELGESI, @KDV_ORANI, @E_FATURA_BAKIYE_VAR, @VERGI_NO_SORGULANDI, @FAT_KESILMEDEN_KUNYE_ALINAMAZ, @SOFOR_ID, @HAMALIYE_HESAPLAMA_SEKLI, @NAKLIYE_HESAPLAMA_SEKLI, @REHIN_CARI_KART_ID, @STOPAJSIZ_KESEBILIR", parameters.ToArray());
                int cariKartId = (int)parameters[0].Value;
                return RedirectToAction(nameof(MEdit), new { id = cariKartId, metin = "Yeni Müşteri Eklendi", durum = true });
            }
            catch (SqlException ex)
            {
                return RedirectToAction(nameof(MCreate), new { metin = ex.Errors[0].Message, durum = false });
            }
        }


        public async Task<ActionResult> MEdit(int? id, string metin, bool? durum)
        {
            ViewBag.resultText = new { message = metin, state = durum };
            var tohalCariKart = await _context.VohalCariKarts.FindAsync(id);
            if (tohalCariKart == null)
            {
                return HttpNotFound();
            }
            ViewBag.sifatlar = sifatListe;
            ViewBag.gidecekyerler = gidecekyerListe;
            ViewData["fiyatlar"] = new SelectList(_context.TohalFiyatListesis.Where(x => x.Tip == 0).OrderBy(x => x.Aciklama).ThenBy(x => x.FiyatListesiId), "FiyatListesiId", "Aciklama");
            //ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.DokumanTipi == 0 && x.PkTipi == 1 && x.Silindi == false).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
            //ViewData["eIrsaliyePostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == "" && x.DokumanTipi == 1 && x.PkTipi == 1 && x.Silindi == false).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");

            ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == tohalCariKart.VergiKimlikNo && x.DokumanTipi == 0 ).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");
            ViewData["eIrsaliyePostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == tohalCariKart.VergiKimlikNo && x.DokumanTipi == 1 ).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu");


            return View(tohalCariKart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> MEdit(int id, VohalCariKart tohalCariKart, string Devir, string Oran, string KdvOrani)
        {
            if (tohalCariKart.BeldeId == null)
            {
                ModelState.AddModelError("bekde", "Belde Alanı Boş Olamaz");
                return RedirectToAction(nameof(MEdit), new { id = id, metin = "Belde Alanı Boş Olamaz", durum = false });
            }
            Devir = Devir?.Replace(".", "");
            var devir = Convert.ToDecimal(Devir);

            Oran = Oran?.Replace(".", "");
            var oran = Convert.ToDecimal(Oran);

            KdvOrani = KdvOrani?.Replace(".", "");
            var kdvOran = Convert.ToDecimal(KdvOrani);
            int yerid = 0;
            if (tohalCariKart?.BeldeId > 0)
                yerid = (int)tohalCariKart.BeldeId;
            else if (tohalCariKart?.IlceId > 0)
                yerid = (int)tohalCariKart.IlceId;
            else if (tohalCariKart?.IlId > 0)
                yerid = (int)tohalCariKart.IlId;
            try
            {
                var parameters = new List<SqlParameter>
                    {
                      new SqlParameter("@CARI_KART_ID", SqlDbType.Int){ Value = id },
                      new SqlParameter("@TIP", SqlDbType.BigInt) { Value = 1 },
                      new SqlParameter("@KOD", (object)tohalCariKart.Kod ?? DBNull.Value),
                      new SqlParameter("@AD", (object)tohalCariKart.Ad ?? DBNull.Value),
                      new SqlParameter("@MARKA_ID", SqlDbType.Int) { Value = (object)tohalCariKart.MarkaId ?? DBNull.Value },
                      new SqlParameter("@ADRES", (object)tohalCariKart.Adres ?? DBNull.Value),
                      new SqlParameter("@POSTA_KODU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.PostaKoduId ?? DBNull.Value },
                      new SqlParameter("@TEL1", (object)tohalCariKart.Tel1 ?? DBNull.Value),
                      new SqlParameter("@TEL2", (object)tohalCariKart.Tel2 ?? DBNull.Value),
                      new SqlParameter("@FAKS", (object)tohalCariKart.Faks ?? DBNull.Value),
                      new SqlParameter("@BANKA_HESAP_NO", SqlDbType.NVarChar) { Value = (object)tohalCariKart.BankaHesapNo ?? DBNull.Value },
                      new SqlParameter("@KISILIK_TIPI", SqlDbType.BigInt) { Value = (object)tohalCariKart.KisilikTipi ?? DBNull.Value },
                      new SqlParameter("@VERGI_KIMLIK_NO", (object)tohalCariKart.VergiKimlikNo ?? DBNull.Value),
                      new SqlParameter("@VERGI_DAIRESI_ID", SqlDbType.Int) { Value = (object)tohalCariKart.VergiDairesiId ?? DBNull.Value },
                      new SqlParameter("@MUAFIYET_BELGE_NO", (object)tohalCariKart.MuafiyetBelgeNo ?? DBNull.Value),
                      new SqlParameter("@MUAFIYET_BITIS_TARIHI", SqlDbType.DateTime) { Value = (object)tohalCariKart.MuafiyetBitisTarihi ?? DBNull.Value },
                      new SqlParameter("@BAGKUR_NO", (object)tohalCariKart.BagkurNo ?? DBNull.Value),
                      new SqlParameter("@BABA_ADI", (object)tohalCariKart.BabaAdi ?? DBNull.Value),
                      new SqlParameter("@DOGUM", (object)tohalCariKart.Dogum ?? DBNull.Value),
                      new SqlParameter("@BORSA_SICIL_NO", (object)tohalCariKart.BorsaSicilNo ?? DBNull.Value),
                      new SqlParameter("@KEFIL", (object)tohalCariKart.Kefil ?? DBNull.Value),
                      new SqlParameter("@ORTAK_ID", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@ORTAKLIK_ORANI", SqlDbType.Float) { Value = 0.0 },
                      new SqlParameter("@ORAN", SqlDbType.Float) { Value = (object)oran ?? DBNull.Value },
                      new SqlParameter("@DEVIR", SqlDbType.Decimal) { Value = (object)devir ?? 0 },
                      new SqlParameter("@FILTRE", (object)tohalCariKart.Filtre ?? DBNull.Value),
                      new SqlParameter("@KENDI_KODU", (object)tohalCariKart.KendiKodu ?? DBNull.Value),
                      new SqlParameter("@REESKONT_ORANI", SqlDbType.Float) { Value = (object)tohalCariKart.ReeskontOrani ?? 0.0 },
                      new SqlParameter("@DEVIR_ISLEMI", SqlDbType.Bit) { Value = false },
                      new SqlParameter("@RUSUM_ALINMASIN", SqlDbType.Bit) { Value = (object)tohalCariKart.RusumAlinmasin ?? DBNull.Value },
                      new SqlParameter("@PLAKA_NO", (object)tohalCariKart.PlakaNo ?? DBNull.Value),
                      new SqlParameter("@YER_ID", SqlDbType.Int) { Value = (object)yerid ?? DBNull.Value },
                      new SqlParameter("@GSM_NO", (object)tohalCariKart.GsmNo ?? DBNull.Value),
                      new SqlParameter("@E_POSTA", (object)tohalCariKart.EPosta ?? DBNull.Value),
                      new SqlParameter("@GIDECEGI_YER_TIPI", SqlDbType.BigInt) { Value = (object)tohalCariKart.GidecegiYerTipi ?? DBNull.Value },
                      new SqlParameter("@SEHIR_ID", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@SATIN_ALANIN_SIFATI", SqlDbType.BigInt) { Value = (object)tohalCariKart.SatinAlaninSifati ?? DBNull.Value },
                      new SqlParameter("@HAL_ID", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@HAL_KOMISYONCUSU", SqlDbType.Bit) { Value = (object)tohalCariKart.HalKomisyoncusu ?? DBNull.Value },
                      new SqlParameter("@IHRACATCI", SqlDbType.Bit) { Value = (object)tohalCariKart.Ihracatci ?? DBNull.Value },
                      new SqlParameter("@GIDECEGI_YER_WEB_SIRA_NO", SqlDbType.Int) { Value = 0 },
                      new SqlParameter("@HKS_BILGISI_ALINDI", SqlDbType.Bit) { Value = false },
                      new SqlParameter("@E_FATURA_SENARYOSU", SqlDbType.BigInt) { Value = (object)tohalCariKart.EFaturaSenaryosu ?? DBNull.Value },
                      new SqlParameter("@VERESIYE_SINIRI", SqlDbType.Decimal) { Value = (object)tohalCariKart.VeresiyeSiniri ?? 0.0 },
                      new SqlParameter("@RISK_SINIRI", SqlDbType.Decimal) { Value = (object)tohalCariKart.RiskSiniri ?? 0.0 },
                      new SqlParameter("@ULKE_ID", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@MAHALLE", (object)tohalCariKart.Mahalle ?? DBNull.Value),
                      new SqlParameter("@CADDE", (object)tohalCariKart.Cadde ?? DBNull.Value),
                      new SqlParameter("@SOKAK", (object)tohalCariKart.Sokak ?? DBNull.Value),
                      new SqlParameter("@KAPI_NO", (object)tohalCariKart.KapiNo ?? DBNull.Value),
                      new SqlParameter("@DAIRE_NO", (object)tohalCariKart.DaireNo ?? DBNull.Value),
                      new SqlParameter("@WEB_ADRESI", (object)tohalCariKart.WebAdresi ?? DBNull.Value),
                      new SqlParameter("@KESINTI_ALINMASIN", SqlDbType.Bit) { Value = false },
                      new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                      new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = false },
                      new SqlParameter("@MUH_HESAP_ID", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@DIGER_MUH_HESAP_ID", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@GIB_E_FATURA_POSTA_KUTUSU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.GibEFaturaPostaKutusuId ?? DBNull.Value },
                      new SqlParameter("@E_FATURA_BOLGE_KODU", (object)tohalCariKart.EFaturaBolgeKodu ?? DBNull.Value),
                      new SqlParameter("@E_FATURA_FATURA_KODU", (object)tohalCariKart.EFaturaFaturaKodu ?? DBNull.Value),
                      new SqlParameter("@BOLGE_KODU_ID", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@YETKILI_KISI", (object)tohalCariKart.YetkiliKisi ?? DBNull.Value),
                      new SqlParameter("@GELDIGI_YER_ID", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@FIYAT_LISTESI_ID", SqlDbType.Int) { Value = (object)tohalCariKart.FiyatListesiId ?? DBNull.Value },
                      new SqlParameter("@YAZIHANE_SIRA_NO", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@YAZIHANE_NOT", (object)tohalCariKart.YazihaneNot ?? DBNull.Value),
                        new SqlParameter("@VADE", SqlDbType.Int) { Value = (object)tohalCariKart.Vade ?? 0 },
                      new SqlParameter("@E_IRSALIYE_POSTA_KUTUSU_ID", SqlDbType.Int) { Value = (object)tohalCariKart.EIrsaliyePostaKutusuId ?? DBNull.Value },
                      new SqlParameter("@E_FATURA_BELGESI", (object)tohalCariKart.EFaturaBelgesi ?? DBNull.Value),
                      new SqlParameter("@E_IRSALIYE_BELGESI", (object)tohalCariKart.EIrsaliyeBelgesi ?? DBNull.Value),
                      new SqlParameter("@KDV_ORANI", SqlDbType.Float) { Value = (object)kdvOran ?? DBNull.Value },
                      new SqlParameter("@E_FATURA_BAKIYE_VAR", SqlDbType.Bit) { Value = (object)tohalCariKart.EFaturaBakiyeVar ?? DBNull.Value },
                      new SqlParameter("@VERGI_NO_SORGULANDI", SqlDbType.Bit) { Value = false },
                      new SqlParameter("@FAT_KESILMEDEN_KUNYE_ALINAMAZ", SqlDbType.Bit) { Value = (object)tohalCariKart.FatKesilmedenKunyeAlinamaz ?? DBNull.Value },
                      new SqlParameter("@SOFOR_ID", SqlDbType.Int) { Value = (object)tohalCariKart.SoforId ?? DBNull.Value },
                      new SqlParameter("@HAMALIYE_HESAPLAMA_SEKLI", SqlDbType.BigInt) { Value = DBNull.Value },
                      new SqlParameter("@NAKLIYE_HESAPLAMA_SEKLI", SqlDbType.BigInt) { Value = DBNull.Value },
                      new SqlParameter("@REHIN_CARI_KART_ID", SqlDbType.Int) { Value = DBNull.Value },
                      new SqlParameter("@STOPAJSIZ_KESEBILIR", SqlDbType.Bit) { Value = false },
                    };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_KART_KAYDET @CARI_KART_ID OUTPUT, @TIP, @KOD, @AD, @MARKA_ID, @ADRES, @POSTA_KODU_ID, @TEL1, @TEL2, @FAKS, @BANKA_HESAP_NO, @KISILIK_TIPI, @VERGI_KIMLIK_NO, @VERGI_DAIRESI_ID, @MUAFIYET_BELGE_NO, @MUAFIYET_BITIS_TARIHI, @BAGKUR_NO, @BABA_ADI, @DOGUM, @BORSA_SICIL_NO, @KEFIL, @ORTAK_ID, @ORTAKLIK_ORANI, @ORAN, @DEVIR, @FILTRE, @KENDI_KODU, @REESKONT_ORANI, @DEVIR_ISLEMI, @RUSUM_ALINMASIN, @PLAKA_NO, @YER_ID, @GSM_NO, @E_POSTA, @GIDECEGI_YER_TIPI, @SEHIR_ID, @SATIN_ALANIN_SIFATI, @HAL_ID, @HAL_KOMISYONCUSU, @IHRACATCI, @GIDECEGI_YER_WEB_SIRA_NO, @HKS_BILGISI_ALINDI, @E_FATURA_SENARYOSU, @VERESIYE_SINIRI, @RISK_SINIRI, @ULKE_ID, @MAHALLE, @CADDE, @SOKAK, @KAPI_NO, @DAIRE_NO, @WEB_ADRESI, @KESINTI_ALINMASIN, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @MUH_HESAP_ID, @DIGER_MUH_HESAP_ID, @GIB_E_FATURA_POSTA_KUTUSU_ID, @E_FATURA_BOLGE_KODU, @E_FATURA_FATURA_KODU, @BOLGE_KODU_ID, @YETKILI_KISI, @GELDIGI_YER_ID, @FIYAT_LISTESI_ID, @YAZIHANE_SIRA_NO, @YAZIHANE_NOT, @VADE, @E_IRSALIYE_POSTA_KUTUSU_ID, @E_FATURA_BELGESI, @E_IRSALIYE_BELGESI, @KDV_ORANI, @E_FATURA_BAKIYE_VAR, @VERGI_NO_SORGULANDI, @FAT_KESILMEDEN_KUNYE_ALINAMAZ, @SOFOR_ID, @HAMALIYE_HESAPLAMA_SEKLI, @NAKLIYE_HESAPLAMA_SEKLI, @REHIN_CARI_KART_ID, @STOPAJSIZ_KESEBILIR", parameters.ToArray());
                return RedirectToAction(nameof(MEdit), new { id = id, metin = "Müşteri Düzenlendi", durum = true });
            }
            catch (SqlException ex)
            {
                return RedirectToAction(nameof(MEdit), new { id = id, metin = ex.Errors[0].Message, durum = false });
            }
        }
        #endregion
        public async Task<ActionResult> Delete(int cariKartId, int kullaniciId, int tip)
        {
            // müstahsil  => 0 - müşteri => 1
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CARI_KART_ID", SqlDbType.Int){Value = cariKartId},
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int){Value = kullaniciId},
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Int){Value = kullaniciId},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_KART_SIL @CARI_KART_ID, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR", parameters.ToArray());
                return tip == 0 ? RedirectToAction(nameof(Create), new { metin = "Müstahsil Silindi", durum = true }) : RedirectToAction(nameof(MCreate), new { metin = "Müşteri Silindi", durum = true });
            }
            catch (SqlException ex)
            {
                if (tip == 0)
                    return RedirectToAction(nameof(Edit), new { id = cariKartId, metin = ex.Errors[0].Message, durum = false });
                else
                    return RedirectToAction(nameof(MEdit), new { id = cariKartId, metin = ex.Errors[0].Message, durum = false });
            }
        }
        private bool TohalCariKartExists(int id)
        {
            return _context.TohalCariKarts.Any(e => e.CariKartId == id);
        }

        public ActionResult ilkSonKayit(byte tip, bool firstOrLast)
        {
            // mustahsil  => 0 - musteri  => 1
            var query = _context.TohalCariKarts.Where(x => x.Tip == tip);
            var val = firstOrLast ? query.FirstOrDefault() : query.OrderByDescending(x => x.CariKartId).FirstOrDefault();
            if (tip == 0)
                return val != null ? RedirectToAction("Edit", new { id = val.CariKartId }) : RedirectToAction("Create");
            return val != null ? RedirectToAction("MEdit", new { id = val.CariKartId }) : RedirectToAction("MCreate");

        }
        public ActionResult sonrakiOncekiKayit(byte tip, bool afterOrBefore, int currentId)
        {   // mustahsil  => 0 - musteri  => 1
            var query = _context.TohalCariKarts.Where(x => x.Tip == tip);
            var val = afterOrBefore ? query.Where(x => x.CariKartId > currentId).FirstOrDefault() : query.OrderByDescending(x => x.CariKartId).Where(x => x.CariKartId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { tip = tip, firstOrlast = !afterOrBefore });
            if (tip == 0)
                return RedirectToAction("Edit", new { id = val.CariKartId });
            return RedirectToAction("MEdit", new { id = val.CariKartId });
        }
        public ActionResult HksBilgiAl(int cariKartId)
        {

            //var test = _hksService.SifatListesi().ToList();
            //var testx = _hksService.IsletmeTurleri().ToList();

            var model = _context.TohalCariKarts.Where(x => x.CariKartId == cariKartId).FirstOrDefault();
            var tckn = model.VergiKimlikNo.Trim();
            var kayitlikisi = _hksService.KayitliKisiler(new List<string> { tckn }).FirstOrDefault();
            if (kayitlikisi.KayitliKisiMi)
            {
                List<int> sifatlar = kayitlikisi.Sifatlari?.ToList();
                TohalCariSifat yeniSifat = new TohalCariSifat();

                if (sifatlar != null && sifatlar.Any())
                {
                    foreach (int sifatId in sifatlar)
                    {
                        yeniSifat = new TohalCariSifat();
                        yeniSifat.CariKartId = cariKartId;
                        yeniSifat.Sifat = (byte)sifatId;
                        if (!_context.TohalCariSifats.Any(s => s.CariKartId == cariKartId && s.Sifat == sifatId))
                        {
                            _context.TohalCariSifats.Add(yeniSifat);
                        }
                    }
                    _context.SaveChanges();
                }


                TohalMagaza teslimatYeri;

                IEnumerable<SubeDTO> subeler = _hksService.Subeler(tckn);

                if (subeler != null && subeler.Any())
                {
                    foreach (var sube in subeler)
                    {
                        teslimatYeri = new TohalMagaza();
                        teslimatYeri.CariKartId = cariKartId;
                        teslimatYeri.GidecegiYer = (byte?)sube.IsyeriTuru;
                        teslimatYeri.Ad = sube.SubeAdi;
                        teslimatYeri.HksId = sube.Id;
                        teslimatYeri.Adres = sube.Adres;
                        teslimatYeri.YerId = sube.BeldeId;
                        teslimatYeri.CariSifati = yeniSifat?.Sifat;
                        teslimatYeri.Kod = "K" + cariKartId + sube.IsyeriTuru.ToString();

                        if (!_context.TohalMagazas.Any(s => s.HksId == sube.Id))
                        {
                            _context.TohalMagazas.Add(teslimatYeri);
                        }
                        else
                        {
                            var item = _context.TohalMagazas.FirstOrDefault(x => x.HksId == sube.Id);
                            item.CariKartId = cariKartId;
                            item.GidecegiYer = (byte?)sube.IsyeriTuru;
                            item.Ad = sube.SubeAdi;
                            item.HksId = sube.Id;
                            item.Adres = sube.Adres;
                            item.YerId = sube.BeldeId;
                            item.CariSifati = yeniSifat?.Sifat;
                            item.Kod = "K" + cariKartId + sube.IsyeriTuru.ToString();
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
                        teslimatYeri = new TohalMagaza();
                        teslimatYeri.CariKartId = cariKartId;
                        teslimatYeri.GidecegiYer = 7;
                        teslimatYeri.Ad = haliciisyeri.IsyeriAdi;
                        teslimatYeri.HksId = haliciisyeri.Id;
                        teslimatYeri.Adres = haliciisyeri.HalAdi;
                        teslimatYeri.Kod = "K" + cariKartId + haliciisyeri.Id.ToString();
                        teslimatYeri.CariSifati = yeniSifat?.Sifat;
                        if (!_context.TohalMagazas.Any(s => s.HksId == haliciisyeri.Id))
                        {
                            _context.TohalMagazas.Add(teslimatYeri);
                        }
                        else
                        {
                            var item = _context.TohalMagazas.FirstOrDefault(x => x.HksId == haliciisyeri.Id);
                            item.CariKartId = cariKartId;
                            item.GidecegiYer = 7;
                            item.Ad = haliciisyeri.IsyeriAdi;
                            item.HksId = haliciisyeri.Id;
                            item.Adres = haliciisyeri.HalAdi;
                            item.CariSifati = yeniSifat?.Sifat;
                            item.Kod = "K" + cariKartId + haliciisyeri.Id.ToString();
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
                        teslimatYeri = new TohalMagaza();
                        teslimatYeri.CariKartId = cariKartId;
                        teslimatYeri.GidecegiYer = (byte)(depo.Halicimi ? 5 : 6);
                        teslimatYeri.Ad = depo.DepoAdi;
                        teslimatYeri.HksId = depo.Id;
                        teslimatYeri.Adres = depo.Adres;
                        teslimatYeri.CariSifati = yeniSifat?.Sifat;
                        teslimatYeri.Kod = "K" + cariKartId + depo.Id.ToString();
                        if (!_context.TohalMagazas.Any(s => s.HksId == depo.Id))
                        {
                            _context.TohalMagazas.Add(teslimatYeri);
                        }
                        else
                        {
                            var item = _context.TohalMagazas.FirstOrDefault(x => x.HksId == depo.Id);
                            item.CariKartId = cariKartId;
                            item.GidecegiYer = (byte)(depo.Halicimi ? 5 : 6);
                            item.Ad = depo.DepoAdi;
                            item.HksId = depo.Id;
                            item.Adres = depo.Adres;
                            item.CariSifati = yeniSifat?.Sifat;
                            item.Kod = "K" + cariKartId + depo.Id.ToString();
                        }
                    }
                    _context.SaveChanges();

                }


                model.HksBilgisiAlindi = true;
                _context.Entry(model).State = EntityState.Modified;
                _context.SaveChanges();

                TempData["SuccessMessage"] = "HKS Bilgileri Alındı";
            }
            else
            {
                TempData["ErrorMessage"] = "Kişi HKS Sistemine Kayıtlı Değil";
            }

            //var test12 = _hksService.Subeler(tckn);
            //var test13 = _hksService.HalIciIsyerleri(tckn);
            //var test14 = _hksService.Depolar(tckn);


            //var test2 = _hksService.Subeler("22807667996");
            //var test3 = _hksService.HalIciIsyerleri("22807667996");
            //var test4 = _hksService.Depolar("22807667996");

            return RedirectToAction("medit", new { id = cariKartId });
        }
        //public async Task<ActionResult> isyeriGetir(int id) =>
        //    Json(await _context.TohalMagazas.Where(x => x.CariKartId == id).ToListAsync(), JsonRequestBehavior.AllowGet);
        public async Task<ActionResult> sifatGetir(int id) =>
            Json(await _context.TohalCariSifats.Where(x => x.CariKartId == id).ToListAsync(), JsonRequestBehavior.AllowGet);
        [HttpPost]
        public async Task<ActionResult> sifatKaydet(List<SifatlarViewModel> model, int cariKartId)
        {
            var eskiSifatlar = await _context.TohalCariSifats.Where(x => x.CariKartId == cariKartId).ToListAsync();
            for (int i = 0; i < model.Count; i++)
            {
                var yeniSifat = model.ElementAt(i);
                var sifat = eskiSifatlar.Where(x => yeniSifat.sifatKey == x.Sifat).FirstOrDefault();
                if (yeniSifat.isExist && sifat == null)
                {
                    _context.TohalCariSifats.Add(new TohalCariSifat { CariKartId = cariKartId, Sifat = yeniSifat.sifatKey });
                }
                else if (!yeniSifat.isExist && sifat != null)
                {
                    _context.TohalCariSifats.Remove(sifat);
                }
                _context.SaveChanges();
            }
            return Json("Sıfatlar Güncellendi", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<ActionResult> IsyerleriGetirByCari(int id)
        {
            var IsYeri = await _context.VohalMagazas.Where(x => x.CariKartId == id).FirstOrDefaultAsync();
            //return IsYeri != null ? Json(IsYeri, JsonRequestBehavior.AllowGet) : Json("Kayıt Yok", JsonRequestBehavior.AllowGet);
            return Json(IsYeri, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public async Task<ActionResult> IsyeriGetir(int id)
        {
            var IsYeri = await _context.VohalMagazas.Where(x => x.MagazaId == id).FirstOrDefaultAsync();
            return Json(IsYeri, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<ActionResult> IsYerlerKaydet(IsYerleriViewModel frm)
        {
            int? yerid = 0;
            if (frm.isyeriBeldeId > 0)
                yerid = frm.isyeriBeldeId;
            else if (frm.isyeriIlceId > 0)
                yerid = frm.isyeriIlceId;
            else if (frm.isyeriIlId > 0)
                yerid = frm.isyeriIlId;
            if (frm?.MagazaId > 0)
            {
                var value = await _context.TohalMagazas.FindAsync(frm.MagazaId);
                if (value != null)
                {
                    value.Ad = frm.isyeriAd;
                    value.Kod = frm.isyeriKod;
                    value.Adres = frm.isyeriAdres;
                    value.PostaKoduId = null;
                    value.Tel1 = frm.tel1;
                    value.Tel2 = frm.tel2;
                    value.Faks = frm.faks;
                    value.YerId = yerid;
                    value.GidecegiYer = frm.gidecegiYer;
                    value.GidecegiYerWebSiraNo = frm.webSiraNo;
                    value.CariSifati = frm.cariSifati;
                    value.EnCokKullanilan = frm.enCokKullanilan;
                    value.PlakaNo = frm.plakaNo;
                    value.EIrsaliyePostaKutusuId = frm.eIrsaliyePosta;
                    value.EFaturaBolgeKodu = frm.bolgeKodu;
                    if (await _context.TohalMagazas.Where(x => x.CariKartId == value.CariKartId && x.Ad == value.Ad && x.MagazaId != value.MagazaId).FirstOrDefaultAsync() != null)
                        return Json(new { metin = value.Ad + "Daha Önce Kaydedilmiş", durum = false }, JsonRequestBehavior.AllowGet);
                    _context.Entry(value).State = EntityState.Modified;
                }
                else
                {
                    return Json(new { metin = "Mağaza Bulunamadı", durum = false }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                TohalMagaza yeniMagaza = new TohalMagaza()
                {
                    CariKartId = frm.cariKartId,
                    Ad = frm.isyeriAd,
                    Kod = frm.isyeriKod,
                    Adres = frm.isyeriAdres,
                    PostaKoduId = frm.PostaKoduId,
                    Tel1 = frm.tel1,
                    Tel2 = frm.tel2,
                    Faks = frm.faks,
                    YerId = yerid,
                    GidecegiYer = frm.gidecegiYer,
                    GidecegiYerWebSiraNo = frm.webSiraNo,
                    CariSifati = frm.cariSifati,
                    EnCokKullanilan = frm.enCokKullanilan,
                    PlakaNo = frm.plakaNo,
                    EIrsaliyePostaKutusuId = frm.eIrsaliyePosta,
                    EFaturaBolgeKodu = frm.bolgeKodu
                };
                if (await _context.TohalMagazas.Where(x => x.CariKartId == yeniMagaza.CariKartId && x.Ad == yeniMagaza.Ad).FirstOrDefaultAsync() != null)
                    return Json(new { metin = yeniMagaza.Ad + "Daha Önce Kaydedilmiş", durum = false }, JsonRequestBehavior.AllowGet);
                if (await _context.TohalMagazas.Where(x => x.CariKartId == yeniMagaza.CariKartId && x.Kod == yeniMagaza.Kod).FirstOrDefaultAsync() != null)
                    return Json(new { metin = yeniMagaza.Kod + "Daha Önce Kaydedilmiş", durum = false }, JsonRequestBehavior.AllowGet);
                _context.TohalMagazas.Add(yeniMagaza);
            }
            try { 
            await _context.SaveChangesAsync();
            }
            catch
            {

            }
            return Json(new { metin = "İşlem Başarılı", durum = true }, JsonRequestBehavior.AllowGet);

            //await _context.TohalMagazas.Add(new TohalMagaza
            //{
            //    CariKartId = Convert.ToInt32(frm["carikartId"]),
            //});

            //eğer mağaza ıd geliyorsa output olmaycak id yi alacak
            //var magazaId = new SqlParameter("@MAGAZA_ID", SqlDbType.Int);
            //if (frm["MagazaId"] != "" && int.Parse(frm["MagazaId"]) > 0)
            //    magazaId.Value = frm["MagazaId"];
            //else
            //    magazaId.Direction = ParameterDirection.Output;
            //try
            //{
            //    var parameters = new List<SqlParameter>
            //    {
            //       magazaId,
            //       new SqlParameter("@CARI_KART_ID", SqlDbType.Int){ Value = (object)frm["carikartId"] },
            //       new SqlParameter("@KOD", (object)frm["isyeriKod"] ?? DBNull.Value),
            //       new SqlParameter("@AD", (object)frm["isyeriAd"] ?? DBNull.Value),
            //       new SqlParameter("@ADRES", (object)frm["isyeriAdres"] ?? DBNull.Value),
            //       new SqlParameter("@POSTA_KODU_ID", (object)frm["aa"] ?? DBNull.Value),
            //       new SqlParameter("@TEL1", (object)frm["tel1"] ?? DBNull.Value),
            //       new SqlParameter("@TEL2", (object)frm["tel2"] ?? DBNull.Value),
            //       new SqlParameter("@FAKS", (object)frm["faks"] ?? DBNull.Value),
            //       new SqlParameter("@YER_ID", SqlDbType.Int){ Value = (object)yerid ?? DBNull.Value},
            //       new SqlParameter("@GIDECEGI_YER", (object)frm["gidecegiYer"] ?? DBNull.Value),
            //       new SqlParameter("@GIDECEGI_YER_WEB_SIRA_NO", (object)frm["webSiraNo"] ?? DBNull.Value),
            //       new SqlParameter("@HKS_ID", (object)frm["HKS_ID"] ?? DBNull.Value),
            //       new SqlParameter("@CARI_SIFATI", (object)frm["cariSifati"] ?? DBNull.Value),
            //       new SqlParameter("@EN_COK_KULLANILAN", (object)frm["enCokKullanilan"] ?? DBNull.Value),
            //       new SqlParameter("@PLAKA_NO", (object)frm["plakaNo"] ?? DBNull.Value),
            //       new SqlParameter("@E_IRSALIYE_POSTA_KUTUSU_ID", (object)frm["eIrsaliyePosta"] ?? DBNull.Value),
            //       new SqlParameter("@E_FATURA_BOLGE_KODU", (object)frm["bolgeKodu"] ?? DBNull.Value),
            //    };
            //    await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_MAGAZA_KAYDET @MAGAZA_ID OUTPUT, @CARI_KART_ID, @KOD, @AD, @POSTA_KODU_ID, @TEL1, @TEL2, @FAKS, @YER_ID, @GIDECEGI_YER, @GIDECEGI_YER_WEB_SIRA_NO, @HKS_ID, @CARI_SIFATI, @EN_COK_KULLANILAN, @PLAKA_NO, @E_IRSALIYE_POSTA_KUTUSU_ID, @E_FATURA_BOLGE_KODU", parameters.ToArray());
            //    return Json(new { metin = "İşyerleri Güncellendi", durum = true }, JsonRequestBehavior.AllowGet);
            //}
            //catch (SqlException ex)
            //{
            //    return Json(new { metin = ex.Message, durum = false }, JsonRequestBehavior.AllowGet);
            //}
        }
        public ActionResult ilkSonKayitMagaza(bool firstOrLast, int cariKartId)
        {
            var val = firstOrLast ? _context.VohalMagazas.Where(x => x.CariKartId == cariKartId).FirstOrDefault() : _context.VohalMagazas.Where(x => x.CariKartId == cariKartId).OrderByDescending(x => x.MagazaId).FirstOrDefault();
            return Json(val, JsonRequestBehavior.AllowGet);

        }
        public ActionResult silMagaza(int currentId)
        {
            try
            {
                var magaza = _context.TohalMagazas.Where(x => x.MagazaId == currentId).FirstOrDefault();
                _context.TohalMagazas.Remove(magaza);
                _context.SaveChanges();
                return Json(new { success = true, message = "Magaza Silindi"}, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(new { success = false, message = "Hata Oluştu"}, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult sonrakiOncekiKayitMagaza(bool afterOrBefore, int currentId, int cariKartId)
        {
            var val = afterOrBefore ? _context.VohalMagazas.Where(x => x.CariKartId == cariKartId && x.MagazaId > currentId).FirstOrDefault() : _context.VohalMagazas.OrderByDescending(x => x.MagazaId).Where(x => x.CariKartId == cariKartId && x.MagazaId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayitMagaza", new { firstOrlast = !afterOrBefore, cariKartId = cariKartId });
            return Json(val, JsonRequestBehavior.AllowGet);
        }
        private Dictionary<int, string> sifatListe = new Dictionary<int, string>()
    {
            { 9, "Depo/Tasnif Ve Ambalaj" },
            { 24, "E-Market" },
            { 19, "Hastane" },
            { 2, "İhracat" },
            { 23, "İmalatçı" },
            { 3, "İthalat" },
            { 5, "Komisyoncu" },
            { 13, "Lokanta" },
            { 8, "Manav" },
            { 7, "Market" },
            { 12, "Otel" },
            { 11, "Pazarcı" },
            { 1, "Sanayici" },
            { 20, "Tüccar (Hal Dışı)" },
            { 6, "Tüccar (Hal İçi)" },
            { 4, "Üretici" },
            { 10, "Üretici Örgütü" },
            { 15, "Yemek Fabrikası" },
            { 14, "Yurt" }
    };
        private Dictionary<int, string> gidecekyerListe = new Dictionary<int, string>()
    {
            { 8, "Hal Dışı İşyeri" },
            { 9, "Sınai İşletme" },
            { 12, "Dağıtım Merkezi" },
            { 18, "Bireysel Tüketim" },
            { 19, "Perakende Satış Yeri" },
            { 1, "Şube" },
            { 4, "Tasnifleme Ve Amabalajlama" },
            { 5, "Hal İçi Deposu" },
            { 6, "Hal Dışı Deposu" },
            { 7, "Hal İçi İşyeri" },
    };
        public class SifatlarViewModel
        {
            public byte sifatKey { get; set; }
            public string sifatValue { get; set; }
            public bool isExist { get; set; }
        }
    
        public async Task<ActionResult> GibKullaniciAl(string tcVkn)
        {
            var kullanici =await _invoiceService.FindUserAsync(tcVkn.Trim(),true,true);
            var kullanici2 =await _invoiceService.FindUserAsync(tcVkn.Trim(), false, true);
            if ((kullanici != null || kullanici2 != null) && (kullanici.Count() > 0 || kullanici2.Count() > 0))
            {
                ViewData["efaturaPostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == tcVkn && x.DokumanTipi == 0).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu").ToList();
                ViewData["eIrsaliyePostalar"] = new SelectList(_context.TohalGibKullanicis.Where(x => x.Vkn == tcVkn && x.DokumanTipi == 1).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId), "GibKullaniciId", "PostaKutusu").ToList();

                return Json(new { success = true, message = "İşlem Başarılı",efaturaPostalar = ViewData["efaturaPostalar"], eIrsaliyePostalar = ViewData["eIrsaliyePostalar"] }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, message = "Kayıt Bulunamadı" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
