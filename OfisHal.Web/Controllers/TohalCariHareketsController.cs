using Autofac.Features.Metadata;
using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace OfisHal.Web.Controllers
{
    public class TohalCariHareketsController : BaseController
    {
        private readonly Db _context;

        public TohalCariHareketsController(Db context)
        {
            _context = context;
        }

        // GET: TohalCariHarekets/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(VohalCariHareket tohalCariHareket, string Meblag)
        {
            if (tohalCariHareket.CariKartId == 0)
            {
                ModelState.AddModelError("CariKartId", "Cari Kart Alanı Boş Geçilemez");
                return View(tohalCariHareket);
            }
            Meblag = Meblag?.Replace(".", "");
            var meb = Convert.ToDecimal(Meblag);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CARI_HAREKET_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@CARI_KART_ID", (object)tohalCariHareket.CariKartId ?? DBNull.Value),
                    new SqlParameter("@REF_NO", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@TARIH", (object)tohalCariHareket.Tarih ?? DBNull.Value),
                    new SqlParameter("@ISLEM_TIPI", (object)tohalCariHareket.IslemTipi ?? DBNull.Value),
                    new SqlParameter("@ACIKLAMA", (object)tohalCariHareket.Aciklama ?? DBNull.Value),
                    new SqlParameter("@MEBLAG", (object)meb ?? DBNull.Value),
                    new SqlParameter("@TIP", (object)tohalCariHareket.Tip ?? DBNull.Value),
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = false },
                    new SqlParameter("@ACIKLAMA2", (object)tohalCariHareket.Aciklama2 ?? DBNull.Value),
                    new SqlParameter("@POS_CIHAZI_ID", (object)tohalCariHareket.PosCihaziId ?? DBNull.Value),
                    new SqlParameter("@KARSI_CARI_KART_ID", (object)tohalCariHareket.KarsiCariKartId ?? DBNull.Value),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_HAREKET_KAYDET @CARI_HAREKET_ID OUTPUT, @CARI_KART_ID, @REF_NO OUTPUT, @TARIH, @ISLEM_TIPI, @ACIKLAMA, @MEBLAG, @TIP, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @ACIKLAMA2, @POS_CIHAZI_ID, @KARSI_CARI_KART_ID", parameters.ToArray());
                int cariHareketId = (int)parameters[0].Value;
                string refNo = (string)parameters[2].Value;
                TempData["SuccessMessage"] = "Kayıt Eklendi";
                return RedirectToAction(nameof(Edit), new { id = cariHareketId});
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Create));
            }
        }

        // GET: TohalCariHarekets/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null || _context.TohalCariHarekets == null)
            {
                return HttpNotFound();
            }

            var tohalCariHareket = await _context.VohalCariHarekets.FirstOrDefaultAsync(x => x.CariHareketId == id);
            ViewBag.belgeUrl = $"/reports/exportreport/müstahsil cari hareket/?IslemId={tohalCariHareket.CariHareketId}";
            ViewBag.raporUrl = $"/reports/details/mustahsilcaridefteri";
            if (tohalCariHareket == null)
            {
                return HttpNotFound();
            }
            return View(tohalCariHareket);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, VohalCariHareket tohalCariHareket, string Meblag)
        {
            if (tohalCariHareket.CariKartId == 0)
            {
                ModelState.AddModelError("CariKartId", "Cari Kart Alanı Boş Geçilemez");
                ViewBag.belgeUrl = $"/reports/exportreport/müstahsil cari hareket/?IslemId={tohalCariHareket.CariHareketId}";
                ViewBag.raporUrl = $"/reports/details/mustahsilcaridefteri";
                return View(tohalCariHareket);
            }
            Meblag = Meblag?.Replace(".", "");
            var meb = Convert.ToDecimal(Meblag);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CARI_HAREKET_ID", SqlDbType.Int){Value = id},
                    new SqlParameter("@CARI_KART_ID", (object)tohalCariHareket.CariKartId ?? DBNull.Value),
                    new SqlParameter("@REF_NO", SqlDbType.NVarChar, 50){Value = (object)tohalCariHareket.RefNo},
                    new SqlParameter("@TARIH", (object)tohalCariHareket.Tarih ?? DBNull.Value),
                    new SqlParameter("@ISLEM_TIPI", (object)tohalCariHareket.IslemTipi ?? DBNull.Value),
                    new SqlParameter("@ACIKLAMA", (object)tohalCariHareket.Aciklama ?? DBNull.Value),
                    new SqlParameter("@MEBLAG", (object)meb ?? DBNull.Value),
                    new SqlParameter("@TIP", (object)tohalCariHareket.Tip ?? DBNull.Value),
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = false },
                    new SqlParameter("@ACIKLAMA2", (object)tohalCariHareket.Aciklama2 ?? DBNull.Value),
                    new SqlParameter("@POS_CIHAZI_ID", (object)tohalCariHareket.PosCihaziId ?? DBNull.Value),
                    new SqlParameter("@KARSI_CARI_KART_ID", (object)tohalCariHareket.KarsiCariKartId ?? DBNull.Value),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_HAREKET_KAYDET @CARI_HAREKET_ID OUTPUT, @CARI_KART_ID, @REF_NO OUTPUT, @TARIH, @ISLEM_TIPI, @ACIKLAMA, @MEBLAG, @TIP, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @ACIKLAMA2, @POS_CIHAZI_ID, @KARSI_CARI_KART_ID", parameters.ToArray());
                TempData["SuccessMessage"] = "Kayıt Güncellendi";
                return RedirectToAction(nameof(Edit), new { id = tohalCariHareket.CariHareketId });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Edit), new { id = tohalCariHareket.CariHareketId});
            }
        }

        #region MUSTERI VERESIYE

        public ActionResult MCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> MCreate(VohalCariHareket tohalCariHareket, string Meblag)
        {
            if (tohalCariHareket.CariKartId == 0)
            {
                ModelState.AddModelError("CariKartId", "Cari Kart Alanı Boş Geçilemez");
                return View(tohalCariHareket);
            }
            Meblag = Meblag?.Replace(".", "");
            var meb = Convert.ToDecimal(Meblag);
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CARI_HAREKET_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@CARI_KART_ID", (object)tohalCariHareket.CariKartId ?? DBNull.Value),
                    new SqlParameter("@REF_NO", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@TARIH", (object)tohalCariHareket.Tarih ?? DBNull.Value),
                    new SqlParameter("@ISLEM_TIPI", (object)tohalCariHareket.IslemTipi ?? DBNull.Value),
                    new SqlParameter("@ACIKLAMA", (object)tohalCariHareket.Aciklama ?? DBNull.Value),
                    new SqlParameter("@MEBLAG", (object)meb ?? DBNull.Value),
                    new SqlParameter("@TIP", (object)tohalCariHareket.Tip ?? DBNull.Value),
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = false },
                    new SqlParameter("@ACIKLAMA2", (object)tohalCariHareket.Aciklama2 ?? DBNull.Value),
                    new SqlParameter("@POS_CIHAZI_ID", (object)tohalCariHareket.PosCihaziId ?? DBNull.Value),
                    new SqlParameter("@KARSI_CARI_KART_ID", (object)tohalCariHareket.KarsiCariKartId ?? DBNull.Value),
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_HAREKET_KAYDET @CARI_HAREKET_ID OUTPUT, @CARI_KART_ID, @REF_NO OUTPUT, @TARIH, @ISLEM_TIPI, @ACIKLAMA, @MEBLAG, @TIP, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @ACIKLAMA2, @POS_CIHAZI_ID, @KARSI_CARI_KART_ID", parameters.ToArray());
                int cariHareketId = (int)parameters[0].Value;
                string refNo = (string)parameters[2].Value;
                TempData["SuccessMessage"] = "Kayıt Eklendi";
                return RedirectToAction(nameof(MEdit), new { id = cariHareketId });
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Create));
            }
        }

        // GET: TohalCariHarekets/MEdit/5
        public async Task<ActionResult> MEdit(int? id)
        {
            if (id == null || _context.TohalCariHarekets == null)
            {
                return HttpNotFound();
            }

            var tohalCariHareket = await _context.VohalCariHarekets.FirstOrDefaultAsync(x => x.CariHareketId == id);
            ViewBag.belgeUrl = $"/reports/exportreport/müsteri cari hareket/?IslemId={tohalCariHareket.CariHareketId}";
            ViewBag.raporUrl = $"/reports/details/musteriveresiyedefteri";
            if (tohalCariHareket == null)
            {
                return HttpNotFound();
            }
            return View(tohalCariHareket);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> MEdit(int id, VohalCariHareket tohalCariHareket, string Meblag)
        {
            if (tohalCariHareket.CariKartId == 0)
            {
                ModelState.AddModelError("CariKartId", "Cari Kart Alanı Boş Geçilemez");
                ViewBag.belgeUrl = $"/reports/exportreport/müsteri cari hareket/?IslemId={tohalCariHareket.CariHareketId}";
                ViewBag.raporUrl = $"/reports/details/musteriveresiyedefteri";
                return View(tohalCariHareket);
            }
            Meblag = Meblag?.Replace(".", "");
            var meb = Convert.ToDecimal(Meblag);
            try
            {
                var parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@CARI_HAREKET_ID", SqlDbType.Int){Value = id},
                        new SqlParameter("@CARI_KART_ID", (object)tohalCariHareket.CariKartId ?? DBNull.Value),
                        new SqlParameter("@REF_NO", SqlDbType.NVarChar, 50){Value = (object)tohalCariHareket.RefNo},
                        new SqlParameter("@TARIH", (object)tohalCariHareket.Tarih ?? DBNull.Value),
                        new SqlParameter("@ISLEM_TIPI", (object)tohalCariHareket.IslemTipi ?? DBNull.Value),
                        new SqlParameter("@ACIKLAMA", (object)tohalCariHareket.Aciklama ?? DBNull.Value),
                        new SqlParameter("@MEBLAG", (object)meb ?? DBNull.Value),
                        new SqlParameter("@TIP", (object)tohalCariHareket.Tip ?? DBNull.Value),
                        new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                        new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = false },
                        new SqlParameter("@ACIKLAMA2", (object)tohalCariHareket.Aciklama2 ?? DBNull.Value),
                        new SqlParameter("@POS_CIHAZI_ID", (object)tohalCariHareket.PosCihaziId ?? DBNull.Value),
                        new SqlParameter("@KARSI_CARI_KART_ID", (object)tohalCariHareket.KarsiCariKartId ?? DBNull.Value),
                    };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_HAREKET_KAYDET @CARI_HAREKET_ID OUTPUT, @CARI_KART_ID, @REF_NO OUTPUT, @TARIH, @ISLEM_TIPI, @ACIKLAMA, @MEBLAG, @TIP, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @ACIKLAMA2, @POS_CIHAZI_ID, @KARSI_CARI_KART_ID", parameters.ToArray());
                TempData["SuccessMessage"] = "Kayıt Güncellendi";
                return RedirectToAction(nameof(MEdit), new { id = tohalCariHareket.CariHareketId});
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                return RedirectToAction(nameof(MEdit), new { id = tohalCariHareket.CariHareketId});
            }
        }
        #endregion

        public async Task<ActionResult> Delete(int cariHareketId, int kullaniciId, int kartTipi)
        {
            // cari  => 0 - veresiye  => 1
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CARI_HAREKET_ID", SqlDbType.Int){Value = cariHareketId},
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int){Value = kullaniciId},
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Int){Value = 1},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_HAREKET_SIL @CARI_HAREKET_ID, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR", parameters.ToArray());
                TempData["SuccessMessage"] = "Kayıt Silindi";
                return kartTipi == 0 ? RedirectToAction(nameof(Create)) : RedirectToAction(nameof(MCreate));
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "İşlem Başarısız" + ex.Errors[0].Message;
                if (kartTipi == 0)
                    return RedirectToAction(nameof(Edit), new { id = cariHareketId });
                else
                    return RedirectToAction(nameof(MEdit), new { id = cariHareketId });
            }
        }
        public async Task<JsonResult> BakiyeSoyleAsync(int id)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@CARI_KART_ID", SqlDbType.Int) { Value = id },
                new SqlParameter("@BAKIYE",SqlDbType.Float) { Direction = ParameterDirection.Output },
                new SqlParameter("@REHINDEKI_KAP_TUTARI", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                new SqlParameter("@KESILMEMIS_FATURA_TUTARI", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                new SqlParameter("@KESILMEYEN_DAHIL_REHINDEKI_KAP_TUTARI", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                new SqlParameter("@BELGE_BASMADAN_CAGRILDI", SqlDbType.Bit) { Value = 0 },
                new SqlParameter("@BORC_TOPLAMI", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                new SqlParameter("@ALACAK_TOPLAMI", SqlDbType.Decimal) { Direction = ParameterDirection.Output }
            };
            await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_BAKIYEYI_SOYLE @CARI_KART_ID, @BAKIYE OUTPUT, @REHINDEKI_KAP_TUTARI OUTPUT, @KESILMEMIS_FATURA_TUTARI OUTPUT, @KESILMEYEN_DAHIL_REHINDEKI_KAP_TUTARI OUTPUT, @BELGE_BASMADAN_CAGRILDI, @BORC_TOPLAMI OUTPUT, @ALACAK_TOPLAMI OUTPUT", parameters.ToArray());
            var bakiye = parameters[1].Value.ToString().Replace('.', ',');
            var rehBakiye = parameters[2].Value?.ToString().Replace('.', ',');
            return Json(new { bakiye = bakiye, rehinBakiye = rehBakiye }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ilkSonKayit(byte tip, bool firstOrLast)
        {
            // cari  => 0 - veresiye  => 1
            var query = _context.VohalCariHarekets.Where(x => x.KartTipi == tip);
            var val = firstOrLast ? query.FirstOrDefault() : query.OrderByDescending(x => x.CariHareketId).FirstOrDefault();
            if (tip == 0)
                return val != null ? RedirectToAction("Edit", new { id = val.CariHareketId }) : RedirectToAction("Create");
            return val != null ? RedirectToAction("MEdit", new { id = val.CariHareketId }) : RedirectToAction("MCreate");
        }
        public ActionResult sonrakiOncekiKayit(byte tip, bool afterOrBefore, int currentId)
        {   // cari  => 0 - veresiye  => 1
            var query = _context.VohalCariHarekets.Where(x => x.KartTipi == tip);
            var val = afterOrBefore ? query.OrderBy(x => x.CariHareketId).Where(x => x.CariHareketId > currentId).FirstOrDefault() : query.OrderByDescending(x => x.CariHareketId).Where(x => x.CariHareketId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { tip = tip, firstOrlast = !afterOrBefore });
            if (tip == 0)
                return RedirectToAction("Edit", new { id = val.CariHareketId });
            return RedirectToAction("MEdit", new { id = val.CariHareketId });
        }

        private List<Tuple<string, string>> raporlar1(string reportUrl,int? islemid)
        {
            List<Tuple<string, string>> items = new List<Tuple<string, string>>()
            {
               new Tuple<string, string> ($"/reports/exportreport/{reportUrl}/?IslemId={islemid}","Fatura"),
            };
            return items;
        }
        private List<Tuple<string, string>> raporlar2()
        {
            List<Tuple<string, string>> items = new List<Tuple<string, string>>()
            {
               new Tuple<string, string> ("/reports/details/musteriveresiyedefteri","Veresiye Defteri"),
            };
            return items;
        }

    }
}