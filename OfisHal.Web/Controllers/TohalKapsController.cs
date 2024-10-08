using OfisHal.Core.Domain;
using OfisHal.Core.ViewModels;
using OfisHal.Data.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class TohalKapsController : BaseController
    {
        private readonly Db _context;

        public TohalKapsController(Db context)
        {
            _context = context;
        }
        // GET: TohalKaps/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(VohalKap tohalKap, string Dara, string BirimFiyati, string Kapasite)
        {
            if (string.IsNullOrEmpty(tohalKap.Ad) || string.IsNullOrEmpty(tohalKap.Kod))
            {
                if (string.IsNullOrEmpty(tohalKap.Ad))
                    ModelState.AddModelError(nameof(tohalKap.Ad), "Ad Alanı Boş Olamaz");
                else
                    ModelState.AddModelError(nameof(tohalKap.Kod), "Kod Alanı Boş Olamaz");
                return View(tohalKap);
            }
            Dara = Dara?.Replace(".", "");
            var dara = Convert.ToInt32(Dara);
            Kapasite = Kapasite?.Replace(".", "");
            var kapasite = Convert.ToInt32(Kapasite);
            BirimFiyati = BirimFiyati?.Replace(".", "");
            var birimfiyat = Convert.ToDecimal(BirimFiyati);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@KAP_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    },
                    new SqlParameter("@KOD", (object)tohalKap.Kod ?? DBNull.Value),
                    new SqlParameter("@AD", (object)tohalKap.Ad ?? DBNull.Value),
                    new SqlParameter("@DARA", SqlDbType.Int){ Value = (object)dara ?? DBNull.Value},
                    new SqlParameter("@IADELI", SqlDbType.Bit){ Value =(object)tohalKap.Iadeli ?? DBNull.Value },
                    new SqlParameter("@BIRIM_FIYATI", SqlDbType.Float) { Value = (object)birimfiyat ?? DBNull.Value},
                    new SqlParameter("@REHIN_KABI_ID", (object)tohalKap.RehinKabiId ?? DBNull.Value),
                    new SqlParameter("@DIGER_AD_ID", (object)tohalKap.DigerAdId ?? DBNull.Value),
                    new SqlParameter("@ALIS_HESAP_ID", (object)tohalKap.AlisHesapId ?? DBNull.Value),
                    new SqlParameter("@SATIS_HESAP_ID", (object)tohalKap.SatisHesapId ?? DBNull.Value),
                    new SqlParameter("@KAPASITE", (object)kapasite ?? DBNull.Value),
                    new SqlParameter("@AMBALAJ_TIPI_KODU", (object)tohalKap.AmbalajTipiKodu ?? DBNull.Value),
                    new SqlParameter("@AMBALAJ_MARKASI", (object)tohalKap.AmbalajMarkasi ?? DBNull.Value),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_KAP_KAYDET @KAP_ID OUTPUT, @KOD, @AD, @DARA, @IADELI, @BIRIM_FIYATI, @REHIN_KABI_ID, @DIGER_AD_ID, @ALIS_HESAP_ID, @SATIS_HESAP_ID, @KAPASITE, @AMBALAJ_TIPI_KODU, @AMBALAJ_MARKASI", parameters.ToArray());
                int kapid = (int)parameters[0].Value;
                TempData["SuccessMessage"] = "Yeni Kap Eklendi";
                return RedirectToAction(nameof(Edit), new { id = kapid });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başaırısz" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Create));
            }
        }

        // GET: TohalKaps/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null || _context.TohalKaps == null)
            {
                return HttpNotFound();
            }

            var tohalKap = await _context.VohalKaps.FindAsync(id);
            if (tohalKap == null)
            {
                return HttpNotFound();
            }
            return View(tohalKap);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind(Include = "KapId,Kod,Ad,Dara,Iadeli,BirimFiyati,RehinKabiId,DigerAdId,AlisHesapId,SatisHesapId,AmbalajTipiKodu,AmbalajMarkasi,Kapasite")] VohalKap tohalKap, string Dara, string BirimFiyati,string Kapasite)
        {
            if (string.IsNullOrEmpty(tohalKap.Ad) || string.IsNullOrEmpty(tohalKap.Kod))
            {
                if (string.IsNullOrEmpty(tohalKap.Ad))
                    ModelState.AddModelError(nameof(tohalKap.Ad), "Ad Alanı Boş Olamaz");
                else
                    ModelState.AddModelError(nameof(tohalKap.Kod), "Kod Alanı Boş Olamaz");
                return View(tohalKap);
            }
            Dara = Dara?.Replace(".", "");
            var dara = Convert.ToInt32(Dara);
            Kapasite = Kapasite?.Replace(".", "");
            var kapasite = Convert.ToInt32(Kapasite);
            BirimFiyati = BirimFiyati?.Replace(".", "");
            var birimfiyat = Convert.ToDecimal(BirimFiyati);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@KAP_ID", SqlDbType.Int)
                    {
                        Value = tohalKap.KapId,
                    },
                    new SqlParameter("@KOD", (object)tohalKap.Kod ?? DBNull.Value),
                    new SqlParameter("@AD", (object)tohalKap.Ad ?? DBNull.Value),
                    new SqlParameter("@DARA", SqlDbType.Int){ Value = (object)dara ?? DBNull.Value},
                    new SqlParameter("@IADELI", (object)tohalKap.Iadeli ?? DBNull.Value),
                    new SqlParameter("@BIRIM_FIYATI", SqlDbType.Float) { Value = (object)birimfiyat ?? DBNull.Value},
                    new SqlParameter("@REHIN_KABI_ID", (object)tohalKap.RehinKabiId ?? DBNull.Value),
                    new SqlParameter("@DIGER_AD_ID", (object)tohalKap.DigerAdId ?? DBNull.Value),
                    new SqlParameter("@ALIS_HESAP_ID", (object)tohalKap.AlisHesapId ?? DBNull.Value),
                    new SqlParameter("@SATIS_HESAP_ID", (object)tohalKap.SatisHesapId ?? DBNull.Value),
                    new SqlParameter("@KAPASITE", (object)kapasite ?? DBNull.Value),
                    new SqlParameter("@AMBALAJ_TIPI_KODU", (object)tohalKap.AmbalajTipiKodu ?? DBNull.Value),
                    new SqlParameter("@AMBALAJ_MARKASI", (object)tohalKap.AmbalajMarkasi ?? DBNull.Value),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_KAP_KAYDET @KAP_ID OUTPUT, @KOD, @AD, @DARA, @IADELI, @BIRIM_FIYATI, @REHIN_KABI_ID, @DIGER_AD_ID, @ALIS_HESAP_ID, @SATIS_HESAP_ID, @KAPASITE, @AMBALAJ_TIPI_KODU, @AMBALAJ_MARKASI", parameters.ToArray());
                int kapid = (int)parameters[0].Value;
                TempData["SuccessMessage"] = "Kap Düzenlendi";
                return RedirectToAction(nameof(Edit), new { id = tohalKap.KapId });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başaırısz" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Edit), new { id = tohalKap.KapId });
            }
        }
        public async Task<ActionResult> DigerAdlar(int tur) => PartialView("_DigerAdlar", await DigerAdlarGetir(tur));

        private async Task<List<DigerAdlarViewModel>> DigerAdlarGetir(int tur) =>
             await _context.TohalDigerAds.Where(x => x.Tur == tur).OrderBy(x => x.Ad).ThenBy(x => x.DigerAdId).Select(x => new DigerAdlarViewModel
             {
                 DigerAdId = x.DigerAdId,
                 DigerAd = x.Ad,
                 KapAdi = x.TohalKaps.Select(k => k.Ad).FirstOrDefault(),
             }).ToListAsync();

        public async Task<ActionResult> DigerAdGetir(int tur, string content)
        {
            var result = await _context.TohalDigerAds.Where(x => x.Tur == tur && x.Ad.Contains(content)).Select(x => new DigerAdlarViewModel
            {
                DigerAdId = x.DigerAdId,
                DigerAd = x.Ad,
                KapAdi = x.TohalKaps.Select(k => k.Ad).FirstOrDefault(),
            }).ToListAsync();
            if (result.Count > 1) return PartialView("_DigerAdlar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.VohalKaps.FirstOrDefault() : _context.VohalKaps.OrderByDescending(x => x.KapId).FirstOrDefault();
            return val != null ? RedirectToAction("Edit", new { id = val.KapId }) : RedirectToAction("Create");
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.VohalKaps.Where(x => x.KapId > currentId).FirstOrDefault() : _context.VohalKaps.OrderByDescending(x => x.KapId).Where(x => x.KapId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("Edit", new { id = val.KapId });
        }
    }
}
