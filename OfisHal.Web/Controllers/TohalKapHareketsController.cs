using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class TohalKapHareketsController : BaseController
    {
        private readonly Db _context;

        public TohalKapHareketsController(Db context)
        {
            _context = context;
        }
        public async Task<ActionResult> Edit(int? id)
        {
            VohalKapHareket model = await _context.VohalKapHarekets.Where(x => x.KartTipi == 0 && (id != null && id > 0 ? x.KapHareketId == id : true)).FirstOrDefaultAsync();

            if(model == null)
            {
               model = new VohalKapHareket();
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(VohalKapHareket model, string Miktar, string Fiyat, string Tutar)
        {
            Miktar = Miktar?.Replace(".", "");
            var miktar = Convert.ToInt32(Miktar);
            Fiyat = Fiyat?.Replace(".", "");
            var fiyat = Convert.ToDecimal(Fiyat);
            Tutar = Tutar?.Replace(".", "");
            var tutar = Convert.ToDecimal(Tutar);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@KAP_HAREKET_ID", SqlDbType.Int)
                    {
                        Value = model.KapHareketId
                    },
                    new SqlParameter("@CARI_KART_ID", (object)model.CariKartId ?? DBNull.Value),
                    new SqlParameter("@TARIH", (object)model.Tarih ?? DBNull.Value),
                    new SqlParameter("@ACIKLAMA", (object)model.Aciklama ?? DBNull.Value),
                    new SqlParameter("@KAP_ID", SqlDbType.Int){ Value=(object)model.KapId ?? DBNull.Value },
                    new SqlParameter("@MIKTAR", SqlDbType.Int){Value = (object)miktar ?? DBNull.Value},
                    new SqlParameter("@FIYAT", SqlDbType.Decimal){ Value = (object)fiyat ?? DBNull.Value},
                    new SqlParameter("@TUTAR", SqlDbType.Decimal){Value = (object)tutar ?? DBNull.Value},
                    new SqlParameter("@TIP", (object)model.Tip ?? DBNull.Value),
                    new SqlParameter("@REHIN_FISI_ID", SqlDbType.Int){ Value = (object)model.RehinFisiId ?? DBNull.Value},
                    new SqlParameter("@ISLENECEGI_HESAP", (object)model.IslenecegiHesap ?? DBNull.Value),
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = 0 },
                    new SqlParameter("@GUNCELLEME_ZAMANI", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_KAP_HAREKET_KAYDET @KAP_HAREKET_ID OUTPUT, @CARI_KART_ID, @TARIH, @ACIKLAMA, @KAP_ID, @MIKTAR, @FIYAT, @TUTAR, @TIP, @REHIN_FISI_ID, @ISLENECEGI_HESAP, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @GUNCELLEME_ZAMANI", parameters.ToArray());
                int kapHareketId = (int)parameters[0].Value;
                TempData["SuccessMessage"] = "İşlem Başarılı";
                return RedirectToAction(nameof(Edit), new { id = kapHareketId });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Edit), new { id = model.KapHareketId });
            }
        }
        public async Task<object> BakiyeSoyleAsync(int cariId, int kapId)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@CARI_KART_ID", SqlDbType.Int) { Value = cariId },
                new SqlParameter("@KAP_ID", SqlDbType.Int) { Value = kapId },
                new SqlParameter("@BAKIYE",SqlDbType.Float) { Direction = ParameterDirection.Output },
            };
            await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_KAP_BAKIYEYI_SOYLE @CARI_KART_ID,@KAP_ID, @BAKIYE OUTPUT", parameters.ToArray());
            var bakiye = parameters[2].Value.ToString().Replace('.', ',');
            return bakiye;
        }
        public async Task<ActionResult> Delete(int kapHareketId, int kullaniciId)
        {
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@KAP_HAREKET_ID", SqlDbType.Int){Value = kapHareketId},
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int){Value = kullaniciId},
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Int){Value = 1},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_KAP_HAREKET_SIL @KAP_HAREKET_ID, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR", parameters.ToArray());
                TempData["SuccessMessage"] = "Kayıt Silindi";
                return RedirectToAction("Edit");
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başaırısz" + ex.Errors[0].Message;
                return RedirectToAction("Edit", new { id = kapHareketId });
            }
        }
        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.VohalKapHarekets.Where(x => x.KartTipi == 0).OrderBy(x => x.KapHareketId).FirstOrDefault() : _context.VohalKapHarekets.Where(x => x.KartTipi == 0).OrderByDescending(x => x.KapHareketId).FirstOrDefault();
            return val != null ? RedirectToAction("Edit", new { id = val.KapHareketId }) : RedirectToAction("Edit");
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.VohalKapHarekets.Where(x => x.KartTipi == 0 && x.KapHareketId > currentId).FirstOrDefault() : _context.VohalKapHarekets.OrderByDescending(x => x.KapHareketId).Where(x => x.KartTipi == 0 && x.KapHareketId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("Edit", new { id = val.KapHareketId });
        }
    }
}
