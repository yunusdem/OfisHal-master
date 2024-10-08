using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using OfisHal.Web.Controllers;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using OfisHal.Web.Models;

namespace OfisHal.Web.Controllers
{
    public class KasaIslemleriController : BaseController
    {
        private readonly Db _context;

        public KasaIslemleriController(Db context)
        {
            _context = context;
        }
        // Kasa İşlemleri > Kasa Hareketi Kayıt
        [HttpGet]
        public ActionResult KasaHareketKayit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> KasaHareketKayit(VohalHesapHareketi model, string Meblag, string Kdv)
        {
            if (model.HesapId == 0)
            {
                ModelState.AddModelError("HesapId", "Hesap Alanı Boş Geçilemez");
                return View(model);
            }
            Meblag = Meblag?.Replace(".", "");
            var meb = Convert.ToDecimal(Meblag);
            Kdv = Kdv?.Replace(".", "");
            var kd = Convert.ToDecimal(Kdv);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@HESAP_HAREKETI_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@HESAP_ID", SqlDbType.Int){ Value = (object)model.HesapId ?? DBNull.Value },
                    new SqlParameter("@TARIH", SqlDbType.DateTime){Value = (object)model.Tarih ?? DBNull.Value },
                    new SqlParameter("@ACIKLAMA", SqlDbType.VarChar){Value = (object)model.Aciklama ?? DBNull.Value },
                    new SqlParameter("@MEBLAG", SqlDbType.Float){Value = (object)meb ?? DBNull.Value },
                    new SqlParameter("@KDV_ORANI", SqlDbType.Float){Value = (object)model.KdvOrani?? DBNull.Value },
                    new SqlParameter("@KDV", SqlDbType.Float){Value = (object)kd ?? DBNull.Value },
                    new SqlParameter("@TIP", SqlDbType.TinyInt){Value = (object)model.Tip?? DBNull.Value },
                    new SqlParameter("@HAREKET_TIPI", SqlDbType.TinyInt){Value = (object)model.HareketTipi?? DBNull.Value },
                    new SqlParameter("@KULLANICI_ID", 1),
                    new SqlParameter("@GUID", Guid.NewGuid()),
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", 1),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_HESAP_HAREKETI_KAYDET @HESAP_HAREKETI_ID OUTPUT, @HESAP_ID, @TARIH, @ACIKLAMA, @MEBLAG, @KDV_ORANI, @KDV, @TIP, @HAREKET_TIPI, @KULLANICI_ID, @GUID, @DEGISIKLIK_TAKIP_VAR", parameters.ToArray());
                var hareketId = parameters[0].Value;
                TempData["SuccessMessage"] = "Kayıt Eklendi";
                return RedirectToAction(nameof(KasaHareketDuzenle), new { id = hareketId });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(KasaHareketKayit));
            }
        }
        [HttpGet]
        public async Task<ActionResult> KasaHareketDuzenle(int id)
        {
            var model = await _context.VohalHesapHareketis.FirstOrDefaultAsync(x => x.HesapHareketiId == id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> KasaHareketDuzenle(VohalHesapHareketi model, string Meblag, string Kdv)
        {
            if (model.HesapId == 0)
            {
                ModelState.AddModelError("HesapId", "Hesap Alanı Boş Geçilemez");
                return View(model);
            }
            Meblag = Meblag?.Replace(".", "");
            var meb = Convert.ToDecimal(Meblag);
            Kdv = Kdv?.Replace(".", "");
            var kd = Convert.ToDecimal(Kdv);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@HESAP_HAREKETI_ID", SqlDbType.Int)
                    {
                        Value = model.HesapHareketiId
                    },
                    new SqlParameter("@HESAP_ID", SqlDbType.Int){ Value = (object)model.HesapId ?? DBNull.Value },
                    new SqlParameter("@TARIH", SqlDbType.DateTime){Value = (object)model.Tarih ?? DBNull.Value },
                    new SqlParameter("@ACIKLAMA", SqlDbType.VarChar){Value = (object)model.Aciklama ?? DBNull.Value },
                    new SqlParameter("@MEBLAG", SqlDbType.Float){Value = (object)meb ?? DBNull.Value },
                    new SqlParameter("@KDV_ORANI", SqlDbType.Float){Value = (object)model.KdvOrani?? DBNull.Value },
                    new SqlParameter("@KDV", SqlDbType.Float){Value = (object)kd ?? DBNull.Value },
                    new SqlParameter("@TIP", SqlDbType.TinyInt){Value = (object)model.Tip?? DBNull.Value },
                    new SqlParameter("@HAREKET_TIPI", SqlDbType.TinyInt){Value = (object)model.HareketTipi?? DBNull.Value },
                    new SqlParameter("@KULLANICI_ID", 1),
                    new SqlParameter("@GUID", Guid.NewGuid()),
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", 1),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_HESAP_HAREKETI_KAYDET @HESAP_HAREKETI_ID OUTPUT, @HESAP_ID, @TARIH, @ACIKLAMA, @MEBLAG, @KDV_ORANI, @KDV, @TIP, @HAREKET_TIPI, @KULLANICI_ID, @GUID, @DEGISIKLIK_TAKIP_VAR", parameters.ToArray());
                TempData["SuccessMessage"] = "Kayıt Güncellendi";
                return RedirectToAction(nameof(KasaHareketDuzenle), new { id = model.HesapHareketiId });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(KasaHareketDuzenle), new { id = model.HesapHareketiId });
            }
        }

        public async Task<JsonResult> BakiyeSoyleAsync(int id)
        {
            var bakiye =await _context.VohalHesapBakiyeListesis.Where(x => x.HesapId == id).FirstOrDefaultAsync();
            return Json(bakiye, JsonRequestBehavior.AllowGet);
        }
        // Kasa İşlemleri > Kasa Notu
        public ActionResult KasaNotu()
        {
            return View();
        }
        public async Task<ActionResult> Delete(int hesaHareketId, int kullaniciId)
        {
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@HESAP_HAREKETI_ID", SqlDbType.Int){Value = hesaHareketId},
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int){Value = kullaniciId},
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Int){Value = 1},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_HESAP_HAREKETI_SIL @HESAP_HAREKETI_ID, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR", parameters.ToArray());
                TempData["SuccessMessage"] = "Kayıt Silindi";
                return RedirectToAction(nameof(KasaHareketKayit));
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(KasaHareketDuzenle), new { id = hesaHareketId });
            }
        }
        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.VohalHesapHareketis.OrderBy(x => x.HesapHareketiId).FirstOrDefault() : _context.VohalHesapHareketis.OrderByDescending(x => x.HesapHareketiId).FirstOrDefault();
            return val != null ? RedirectToAction("KasaHareketDuzenle", new { id = val.HesapHareketiId }) : RedirectToAction("KasaHareketKayit");
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.VohalHesapHareketis.Where(x => x.HesapHareketiId > currentId).OrderBy(x => x.HesapHareketiId).FirstOrDefault() : _context.VohalHesapHareketis.OrderByDescending(x => x.HesapHareketiId).Where(x => x.HesapHareketiId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("KasaHareketDuzenle", new { id = val.HesapHareketiId });
        }
    }
}
