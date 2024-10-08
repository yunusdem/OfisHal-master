using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using OfisHal.Services;
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

    public class TohalMalsController : BaseController
    {
        private readonly Db _context;
        private readonly IHksService _hksService;

        public TohalMalsController(Db context, IHksService hksService)
        {
            _context = context;
            _hksService = hksService;
        }

        // GET: TohalMals
        public async Task<ActionResult> Index()
        {
            var Db = _context.TohalMals.Include(t => t.AlisHesap).Include(t => t.DigerAd).Include(t => t.KdvTevkifatTanimi).Include(t => t.SatisHesap);
            return View(await Db.ToListAsync());
        }


        public ActionResult GetTohalMalsIndex()
        {

            var Db = _context.TohalMals.Include(t => t.AlisHesap).Include(t => t.DigerAd).Include(t => t.KdvTevkifatTanimi).Include(t => t.SatisHesap);

            return Json(Db);
        }

        public ActionResult GetTohalKapsIndex()
        {

            var Db = _context.VohalKaps.ToList();

            return Json(Db);
        }


        // GET: TohalMals/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null || _context.TohalMals == null)
            {
                return HttpNotFound();
            }

            var tohalMal = await _context.TohalMals
                .Include(t => t.AlisHesap)
                .Include(t => t.DigerAd)
                .Include(t => t.KdvTevkifatTanimi)
                .Include(t => t.SatisHesap)
                .FirstOrDefaultAsync(m => m.MalId == id);
            if (tohalMal == null)
            {
                return HttpNotFound();
            }

            return View(tohalMal);
        }

        // GET: TohalMals/Create
        public ActionResult Create()
        {
            var malModel = new VohalMal();

            ViewData["HksMalModel"] = new List<VohalHksMal>();
            ViewData["AlisHesapId"] = new SelectList(_context.TohalMuhHesaps, "MuhHesapId", "Ad");
            ViewData["DigerAdId"] = new SelectList(_context.TohalDigerAds, "DigerAdId", "Ad");
            ViewData["KdvTevkifatTanimiId"] = _context.TohalKdvTevkifatTanimis
                                                       .OrderBy(x => x.Aciklama)
                                                       .ThenBy(x => x.KdvTevkifatTanimiId)
                                                       .Select(x => new SelectListItem
                                                       {
                                                           Value = x.KdvTevkifatTanimiId.ToString(),
                                                           Text = x.Aciklama + " - " + x.Pay + " - " + x.Payda
                                                       })
                                                       .ToList();
            ViewData["SatisHesapId"] = new SelectList(_context.TohalMuhHesaps, "MuhHesapId", "Ad");
            return View(malModel);
        }
        [HttpPost]

        public async Task<ActionResult> Create(VohalMal tohalMal)
        {

            if (string.IsNullOrEmpty(tohalMal.Ad) || string.IsNullOrEmpty(tohalMal.Kod))
            {
                if (string.IsNullOrEmpty(tohalMal.Ad))
                    ModelState.AddModelError(nameof(tohalMal.Ad), "Ad Alanı Boş Olamaz");
                else
                    ModelState.AddModelError(nameof(tohalMal.Kod), "Kod Alanı Boş Olamaz");
                return View(tohalMal);
            }
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MAL_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@TIP", SqlDbType.BigInt) { Value = 1 },
                    new SqlParameter("@KOD", (object)tohalMal.Kod ?? DBNull.Value),
                    new SqlParameter("@AD", (object)tohalMal.Ad ?? DBNull.Value),
                    new SqlParameter("@TUR", SqlDbType.BigInt) { Value = 1 },
                    new SqlParameter("@GRUP_NO", (object)tohalMal.GrupNo ?? DBNull.Value),
                    new SqlParameter("@DIGER_AD_ID", (object)tohalMal.DigerAdId ?? DBNull.Value),
                    new SqlParameter("@BIRIM", (object)tohalMal.Birim ?? DBNull.Value),
                    new SqlParameter("@ALIS_HESAP_ID", (object)tohalMal.AlisHesapId ?? DBNull.Value),
                    new SqlParameter("@SATIS_HESAP_ID", (object)tohalMal.SatisHesapId ?? DBNull.Value),
                    new SqlParameter("@KDV_ORANI", (object)tohalMal.KdvOrani ?? DBNull.Value),
                    new SqlParameter("@SON_KULLANMA_TARIHI", (object)tohalMal.SonKullanmaTarihi ?? DBNull.Value),
                    new SqlParameter("@FATURA_BIRIMI", (object)tohalMal.FaturaBirimi ?? DBNull.Value),
                    new SqlParameter("@GTIP_NO", (object)tohalMal.GtipNo ?? DBNull.Value),
                    new SqlParameter("@KDV_TEVKIFAT_TANIMI_ID", (object)tohalMal.KdvTevkifatTanimiId ?? DBNull.Value),
                    new SqlParameter("@KAP_ICINDEKI_MIKTARI", (object)tohalMal.KapIcindekiMiktari ?? DBNull.Value),
                    new SqlParameter("@ORTALAMA_KILO", (object)tohalMal.OrtalamaKilo ?? DBNull.Value),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_MAL_KAYDET @MAL_ID OUTPUT, @KOD, @AD, @TUR, @GRUP_NO, @DIGER_AD_ID, @BIRIM, @ALIS_HESAP_ID, @SATIS_HESAP_ID, @KDV_ORANI, @SON_KULLANMA_TARIHI, @FATURA_BIRIMI, @GTIP_NO, @KDV_TEVKIFAT_TANIMI_ID, @KAP_ICINDEKI_MIKTARI, @ORTALAMA_KILO", parameters.ToArray());

                int malId = (int)parameters[0].Value;
                return Json(new { success = true, message = "Başarıyla eklendi",id= malId }, JsonRequestBehavior.AllowGet);
            }
            catch (SqlException ex)
            {
                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: TohalMals/Edit/5
        public async Task<ActionResult> Edit(int? id, int? CinsKod)
        {
            if (id == null || _context.TohalMals == null)
            {
                return HttpNotFound();
            }

            var tohalMal = await _context.VohalMals.FirstOrDefaultAsync(x => x.MalId == id);
            if (tohalMal == null)
            {
                return HttpNotFound();
            }

            //_context.VohalMalHksBagis.Where(x => x.MalId == id).ToList() tohalHksMals tablosundan bu tablodaki hksMalIdler ile kayıtlar çekilip ViewData["HksMalModel"] e vohalHksMals listesi olarak atanacak
            var hksMalIdList = _context.VohalMalHksBagis.Where(x => x.MalId == id).Select(x => x.HksMalCinsiId).ToList();
            var hksMalList = _context.VohalHksMals.Where(x => hksMalIdList.Contains((int)x.MalCinsiId)).ToList();
            if (CinsKod > 0)
            {
                var newHksMal = _context.VohalHksMals.Where(x => x.MalCinsiHksId == CinsKod).FirstOrDefault();

                hksMalList.Add(newHksMal);
            }
            ViewData["HksMalModel"] = hksMalList;

            //ViewData["HksMalModel"] = _context.VohalHksMals.Where()
            ViewData["AlisHesapId"] = new SelectList(_context.TohalMuhHesaps, "MuhHesapId", "Ad", tohalMal.AlisHesapId);
            ViewData["DigerAdId"] = new SelectList(_context.TohalDigerAds, "DigerAdId", "Ad", tohalMal.DigerAdId);
            ViewData["KdvTevkifatTanimiId"] = new SelectList(_context.TohalKdvTevkifatTanimis, "KdvTevkifatTanimiId", "Aciklama", tohalMal.KdvTevkifatTanimiId);
            ViewData["SatisHesapId"] = new SelectList(_context.TohalMuhHesaps, "MuhHesapId", "Ad", tohalMal.SatisHesapId);
            return View(tohalMal);
        }

        public async Task<JsonResult> EditFromKunye(int? id, int? CinsKod)
        {
            try
            {
                if (CinsKod > 0)
                {
                    var newHksMal = _context.VohalHksMals.Where(x => x.MalCinsiHksId == CinsKod).FirstOrDefault();
                    var hksMalBagi = new List<TohalMalHksBagi>();
                    var hksMalBagiObj = new TohalMalHksBagi();
                    hksMalBagiObj.HksMalId = (int)newHksMal.MalCinsiId;
                    hksMalBagiObj.MalId = (int)id;
                    hksMalBagi.Add(hksMalBagiObj);
                    await CreateHksMalBagi(hksMalBagi);
                    return Json(new { success = true, message = "Başarıyla eklendi" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);

            }

            return Json(new { success = false, message = $"Bir hata oluştu" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]

        public async Task<ActionResult> Edit(VohalMal tohalMal)
        {
            if (string.IsNullOrEmpty(tohalMal.Ad) || string.IsNullOrEmpty(tohalMal.Kod))
            {
                if (string.IsNullOrEmpty(tohalMal.Ad))
                    ModelState.AddModelError(nameof(tohalMal.Ad), "Ad Alanı Boş Olamaz");
                else
                    ModelState.AddModelError(nameof(tohalMal.Kod), "Kod Alanı Boş Olamaz");
                return View(tohalMal);
            }
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MAL_ID", SqlDbType.Int)
                    {
                        Value = tohalMal.MalId
                    },
                    new SqlParameter("@TIP", SqlDbType.BigInt) { Value = 1 },
                    new SqlParameter("@KOD", (object)tohalMal.Kod ?? DBNull.Value),
                    new SqlParameter("@AD", (object)tohalMal.Ad ?? DBNull.Value),
                    new SqlParameter("@TUR", SqlDbType.BigInt) { Value = 1 },
                    new SqlParameter("@GRUP_NO", (object)tohalMal.GrupNo ?? DBNull.Value),
                    new SqlParameter("@DIGER_AD_ID", (object)tohalMal.DigerAdId ?? DBNull.Value),
                    new SqlParameter("@BIRIM", (object)tohalMal.Birim ?? DBNull.Value),
                    new SqlParameter("@ALIS_HESAP_ID", (object)tohalMal.AlisHesapId ?? DBNull.Value),
                    new SqlParameter("@SATIS_HESAP_ID", (object)tohalMal.SatisHesapId ?? DBNull.Value),
                    new SqlParameter("@KDV_ORANI", (object)tohalMal.KdvOrani ?? DBNull.Value),
                    new SqlParameter("@SON_KULLANMA_TARIHI", (object)tohalMal.SonKullanmaTarihi ?? DBNull.Value),
                    new SqlParameter("@FATURA_BIRIMI", (object)tohalMal.FaturaBirimi ?? DBNull.Value),
                    new SqlParameter("@GTIP_NO", (object)tohalMal.GtipNo ?? DBNull.Value),
                    new SqlParameter("@KDV_TEVKIFAT_TANIMI_ID", (object)tohalMal.KdvTevkifatTanimiId ?? DBNull.Value),
                    new SqlParameter("@KAP_ICINDEKI_MIKTARI", (object)tohalMal.KapIcindekiMiktari ?? DBNull.Value),
                    new SqlParameter("@ORTALAMA_KILO", (object)tohalMal.OrtalamaKilo ?? DBNull.Value),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_MAL_KAYDET @MAL_ID OUTPUT, @KOD, @AD, @TUR, @GRUP_NO, @DIGER_AD_ID, @BIRIM, @ALIS_HESAP_ID, @SATIS_HESAP_ID, @KDV_ORANI, @SON_KULLANMA_TARIHI, @FATURA_BIRIMI, @GTIP_NO, @KDV_TEVKIFAT_TANIMI_ID, @KAP_ICINDEKI_MIKTARI, @ORTALAMA_KILO", parameters.ToArray());

                TempData["SuccessMessage"] = "Mal Güncellendi";
                return Json(new { success = true, message = "Başarıyla güncellendi", id = tohalMal.MalId }, JsonRequestBehavior.AllowGet);
            }
            catch (SqlException ex)
            {
                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);
            }
        }

        public async Task<ActionResult> Delete(int malId)
        {
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MAL_ID", SqlDbType.Int){Value = malId},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_MAL_SIL @MAL_ID", parameters.ToArray());
                TempData["SuccessMessage"] = "Kayıt Silindi";
                return RedirectToAction("Create");
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başaırısz" + ex.Errors[0].Message;
                return RedirectToAction("Edit", new { id = malId });
            }
        }
        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.VohalMals.FirstOrDefault() : _context.VohalMals.OrderByDescending(x => x.MalId).FirstOrDefault();
            var malHksBagi = val.MalId > 0 ? _context.VohalMalHksBagis.Where(x => x.MalId == val.MalId).OrderBy(x => x.SiraNo) : null;
            return val != null ? RedirectToAction("Edit", new { id = val.MalId }) : RedirectToAction("Create");
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.VohalMals.Where(x => x.MalId > currentId).FirstOrDefault() : _context.VohalMals.OrderByDescending(x => x.MalId).Where(x => x.MalId < currentId).FirstOrDefault();
            var malHksBagi = val.MalId > 0 ? _context.VohalMalHksBagis.Where(x => x.MalId == val.MalId).OrderBy(x => x.SiraNo) : null;
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("Edit", new { id = val.MalId });
        }

        public ActionResult hksServiceUrunGetir()
        {
            var hksUrunleri = _hksService.Urunler();
            var tohalHksMals = _context.TohalHksMals.ToList();
            var tohalHksMalIds = tohalHksMals.Where(y => y.UstId == null).Select(x => x.HksId).ToList();
            var hksUrunIds = hksUrunleri.Select(x => x.Id).ToList();
            var yeniUrunler = hksUrunleri.Where(x => !tohalHksMalIds.Contains(x.Id)).ToList();

            foreach (var item in yeniUrunler)
            {
                var tohalHksMal = new TohalHksMal
                {
                    HksId = item.Id,
                    Ad = item.UrunAdi,
                    Tur = 0,
                    HksUrunKodu = null,
                    UretimSekli = null,
                    Birim = null,
                    UstId = null
                };
                _context.TohalHksMals.Add(tohalHksMal);
            }

            var guncellenecekUrunler = hksUrunleri.Where(x => tohalHksMalIds.Contains(x.Id)).ToList();

            foreach (var item in guncellenecekUrunler)
            {
                var mevcutKayit = tohalHksMals.FirstOrDefault(x => x.HksId == item.Id);
                if (mevcutKayit != null)
                {

                    mevcutKayit.Ad = item.UrunAdi;
                    mevcutKayit.Tur = 0;
                    _context.Entry(mevcutKayit).State = EntityState.Modified;
                }
            }

            _context.SaveChanges();

            var tohalHksMalCinsleri = tohalHksMals.Where(y => y.Tur == 1).ToList();
            var tohalHksSubMalIds = tohalHksMalCinsleri.Select(x => x.HksId).ToList();

            foreach (var el in hksUrunleri)
            {
                var hksUrunCinsleri = _hksService.UrunCinsleri(el.Id);
                var yeniUrunCinsleri = hksUrunCinsleri.Where(x => !tohalHksSubMalIds.Contains(x.Id)).ToList();

                foreach (var item in yeniUrunCinsleri)
                {
                    var tohalHksMal = new TohalHksMal
                    {
                        HksId = item.Id,
                        Ad = item.UrunCinsiAdi,
                        Tur = 1,
                        HksUrunKodu = item.UrunKodu,
                        UretimSekli = (byte)item.UretimSekliId,
                        Birim = null,
                        UstId = tohalHksMals.FirstOrDefault(x => x.HksId == item.UrunId)?.HksMalId
                    };
                    _context.TohalHksMals.Add(tohalHksMal);
                }

                var guncellenecekUrunCinsleri = hksUrunCinsleri.Where(x => tohalHksSubMalIds.Contains(x.Id)).ToList();

                foreach (var item in guncellenecekUrunCinsleri)
                {
                    var mevcutKayit = tohalHksMalCinsleri.FirstOrDefault(x => x.HksId == item.Id);
                    if (mevcutKayit != null)
                    {
                        mevcutKayit.Ad = item.UrunCinsiAdi;
                        mevcutKayit.Tur = 1;
                        mevcutKayit.HksUrunKodu = item.UrunKodu;
                        mevcutKayit.UretimSekli = (byte)item.UretimSekliId;
                        mevcutKayit.UstId = tohalHksMals.FirstOrDefault(x => x.HksId == item.UrunId)?.HksMalId;
                        _context.Entry(mevcutKayit).State = EntityState.Modified;
                    }
                }
            }

            _context.SaveChanges();

            return RedirectToAction("Create");
        }


        [HttpPost]
        public async Task<JsonResult> CreateHksMalBagi(List<TohalMalHksBagi> tohalMalHksBagi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var hksMalList = _context.TohalMalHksBagis.ToList();
                    if (tohalMalHksBagi != null)
                    {
                        foreach (var item in tohalMalHksBagi)
                        {
                   
                            var parametersVer = new List<SqlParameter>
                                {
                                    new SqlParameter("@MAL_ID", SqlDbType.Int) { Value =  item.MalId},
                                    new SqlParameter("@HKS_MAL_ID", SqlDbType.Int) { Value =  item.HksMalId},
                                    new SqlParameter("@SIRA_NO", SqlDbType.Int) { Value =  item.SiraNo}
                                };

                            await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_MAL_HKS_BAGI_KAYDET @MAL_ID, @HKS_MAL_ID, @SIRA_NO", parametersVer.ToArray());
                        }
                       

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
