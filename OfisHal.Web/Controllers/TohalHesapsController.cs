using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using OfisHal.Web.Models;
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
    public class TohalHesapsController : BaseController
    {
        private readonly Db _context;

        public TohalHesapsController(Db context)
        {
            _context = context;
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(VohalHesap tohalHesap, string IscilikKiloKatsayisi, string IscilikAdetKatsayisi, string KesintiOrani)
        {
            if (string.IsNullOrEmpty(tohalHesap.Ad) || string.IsNullOrEmpty(tohalHesap.Kod))
            {
                if (string.IsNullOrEmpty(tohalHesap.Ad))
                    ModelState.AddModelError(nameof(tohalHesap.Ad), "Ad Alanı Boş Olamaz");
                else
                    ModelState.AddModelError(nameof(tohalHesap.Kod), "Kod Alanı Boş Olamaz");
                return View(tohalHesap);
            }
            IscilikKiloKatsayisi = IscilikKiloKatsayisi?.Replace(".", "");
            var kiloKatSayi = Convert.ToDecimal(IscilikKiloKatsayisi);
            IscilikAdetKatsayisi = IscilikAdetKatsayisi?.Replace(".", "");
            var adetKatSayi = Convert.ToDecimal(IscilikAdetKatsayisi);
            KesintiOrani = KesintiOrani?.Replace(".", "");
            var oran = Convert.ToDecimal(KesintiOrani);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@HESAP_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@KOD", SqlDbType.Char){  Value = (object)tohalHesap.Kod ?? DBNull.Value },
                    new SqlParameter("@AD", SqlDbType.VarChar){ Value = (object)tohalHesap.Ad ?? DBNull.Value },
                    new SqlParameter("@KDV_ORANI", SqlDbType.Float){ Value = (object)tohalHesap.KdvOrani ?? DBNull.Value },
                    new SqlParameter("@ISCILIK_KILO_KATSAYISI", SqlDbType.Float){ Value = (object)kiloKatSayi ?? DBNull.Value },
                    new SqlParameter("@ISCILIK_ADET_KATSAYISI", SqlDbType.Float){ Value = (object)adetKatSayi ?? DBNull.Value },
                    new SqlParameter("@KESINTI_ORANI", SqlDbType.Float){ Value = (object)oran ?? DBNull.Value },
                    new SqlParameter("@YILSONU_DEVRI", SqlDbType.Bit){ Value = (object)tohalHesap.YilsonuDevri ?? DBNull.Value },
                    new SqlParameter("@REHIN_DEVRI", SqlDbType.Bit){ Value = (object)tohalHesap.RehinDevri ?? DBNull.Value },
                    new SqlParameter("@MUH_HESAP_ID", SqlDbType.Int){ Value = (object)tohalHesap.MuhHesapId ?? DBNull.Value },
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_HESAP_KAYDET @HESAP_ID OUTPUT, @KOD, @AD, @KDV_ORANI, @ISCILIK_KILO_KATSAYISI, @ISCILIK_ADET_KATSAYISI, @KESINTI_ORANI, @YILSONU_DEVRI, @REHIN_DEVRI, @MUH_HESAP_ID", parameters.ToArray());
                var hesapId = parameters[0].Value;
                TempData["SuccessMessage"] = "Hesap Eklendi";
                return RedirectToAction(nameof(Edit), new { id = hesapId });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Create));
            }
        }

        public async Task<ActionResult> Edit(int? id)
        {
            var tohalHesap = await _context.VohalHesaps.FindAsync(id);
            if (tohalHesap == null)
            {
                return HttpNotFound();
            }
            return View(tohalHesap);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, VohalHesap tohalHesap, string IscilikKiloKatsayisi, string IscilikAdetKatsayisi, string KesintiOrani)
        {
            if (string.IsNullOrEmpty(tohalHesap.Ad) || string.IsNullOrEmpty(tohalHesap.Kod))
            {
                if (string.IsNullOrEmpty(tohalHesap.Ad))
                    ModelState.AddModelError(nameof(tohalHesap.Ad), "Ad Alanı Boş Olamaz");
                else
                    ModelState.AddModelError(nameof(tohalHesap.Kod), "Kod Alanı Boş Olamaz");
                return View(tohalHesap);
            }
            IscilikKiloKatsayisi = IscilikKiloKatsayisi?.Replace(".", "");
            var kiloKatSayi = Convert.ToDecimal(IscilikKiloKatsayisi);
            IscilikAdetKatsayisi = IscilikAdetKatsayisi?.Replace(".", "");
            var adetKatSayi = Convert.ToDecimal(IscilikAdetKatsayisi);
            KesintiOrani = KesintiOrani?.Replace(".", "");
            var oran = Convert.ToDecimal(KesintiOrani);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@HESAP_ID", SqlDbType.Int)
                    {
                        Value = tohalHesap.HesapId
                    },
                    new SqlParameter("@KOD", SqlDbType.Char){  Value = (object)tohalHesap.Kod ?? DBNull.Value },
                    new SqlParameter("@AD", SqlDbType.VarChar){ Value = (object)tohalHesap.Ad ?? DBNull.Value },
                    new SqlParameter("@KDV_ORANI", SqlDbType.Float){ Value = (object)tohalHesap.KdvOrani ?? DBNull.Value },
                    new SqlParameter("@ISCILIK_KILO_KATSAYISI", SqlDbType.Float){ Value = (object)kiloKatSayi ?? DBNull.Value },
                    new SqlParameter("@ISCILIK_ADET_KATSAYISI", SqlDbType.Float){ Value = (object)adetKatSayi ?? DBNull.Value },
                    new SqlParameter("@KESINTI_ORANI", SqlDbType.Float){ Value = (object)oran ?? DBNull.Value },
                    new SqlParameter("@YILSONU_DEVRI", SqlDbType.Bit){ Value = (object)tohalHesap.YilsonuDevri ?? DBNull.Value },
                    new SqlParameter("@REHIN_DEVRI", SqlDbType.Bit){ Value = (object)tohalHesap.RehinDevri ?? DBNull.Value },
                    new SqlParameter("@MUH_HESAP_ID", SqlDbType.Int){ Value = (object)tohalHesap.MuhHesapId ?? DBNull.Value },
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_HESAP_KAYDET @HESAP_ID OUTPUT, @KOD, @AD, @KDV_ORANI, @ISCILIK_KILO_KATSAYISI, @ISCILIK_ADET_KATSAYISI, @KESINTI_ORANI, @YILSONU_DEVRI, @REHIN_DEVRI, @MUH_HESAP_ID", parameters.ToArray());
                var hesapId = parameters[0].Value;
                TempData["SuccessMessage"] = "Hesap Güncellendi";
                return RedirectToAction(nameof(Edit), new { id = hesapId });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Edit), new { id = tohalHesap.HesapId });
            }
        }

        public async Task<ActionResult> Delete(int hesapId)
        {
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@HESAP_ID", SqlDbType.Int){Value = hesapId},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_HESAP_SIL @HESAP_ID", parameters.ToArray());
                TempData["SuccessMessage"] = "Kayıt Silindi";
                return RedirectToAction("ilkSonKayit", new { firstOrLast = true });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Edit), new { id = hesapId });
            }
        }
        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.VohalHesaps.OrderBy(x => x.HesapId).FirstOrDefault() : _context.VohalHesaps.OrderByDescending(x => x.HesapId).FirstOrDefault();
            return val != null ? RedirectToAction("Edit", new { id = val.HesapId }) : RedirectToAction("Create");
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.VohalHesaps.Where(x => x.HesapId > currentId).FirstOrDefault() : _context.VohalHesaps.OrderByDescending(x => x.HesapId).Where(x => x.HesapId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("Edit", new { id = val.HesapId });
        }
    }
}
