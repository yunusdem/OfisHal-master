using OfisHal.Web.Controllers;
using OfisHal.Web.Models;
using System.Collections.Generic;
using System;
using System.Web.Mvc;
using OfisHal.Data.Context;
using OfisHal.Services;
using System.Linq;

namespace OfisHal.Web.Controllers
{
    public class BankaIslemleriController : BaseController
    {

        private readonly CatalogDb _catalogDb;
        private readonly Db _context;
        private readonly IHksService _hksService;
        public BankaIslemleriController(Db context, CatalogDb catalogDb, IHksService hksService)
        {
            _context = context;
            _catalogDb = catalogDb;
            _hksService = hksService;
        }
        // Banka İşlemleri > Tahsile Verme
        public ActionResult TahsileVerme(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                ViewData["faturaModel2"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                var newModel = new VohalOdemeBordrosu();
                newModel.Tarih = DateTime.Today;
                newModel.GuncellemeZamani = DateTime.Today;
                newModel.EklemeZamani = DateTime.Today;

                return View(newModel);
            }
            else
            {
                // Şu andaki faturaId değerine sahip olan faturayı bul
                var currentFatura = _context.VohalOdemeBordrosus.FirstOrDefault(x => x.OdemeBordrosuId == faturaId);

                if (currentFatura != null)
                {
                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId < currentFatura.OdemeBordrosuId)
                        .OrderByDescending(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId > currentFatura.OdemeBordrosuId)
                        .OrderBy(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    ViewData["prevModelId"] = prevModel?.OdemeBordrosuId.ToString();
                    ViewData["nextModelId"] = nextModel?.OdemeBordrosuId.ToString();
                    ViewData["faturaModel"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 0).ToList();
                    ViewData["faturaModel2"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 1).ToList();
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();
        }
        // Banka İşlemleri > Tahsil
        public ActionResult Tahsil(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                ViewData["faturaModel2"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                var newModel = new VohalOdemeBordrosu();
                newModel.Tarih = DateTime.Today;
                newModel.GuncellemeZamani = DateTime.Today;
                newModel.EklemeZamani = DateTime.Today;

                return View(newModel);
            }
            else
            {
                // Şu andaki faturaId değerine sahip olan faturayı bul
                var currentFatura = _context.VohalOdemeBordrosus.FirstOrDefault(x => x.OdemeBordrosuId == faturaId);

                if (currentFatura != null)
                {
                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId < currentFatura.OdemeBordrosuId)
                        .OrderByDescending(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId > currentFatura.OdemeBordrosuId)
                        .OrderBy(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    ViewData["prevModelId"] = prevModel?.OdemeBordrosuId.ToString();
                    ViewData["nextModelId"] = nextModel?.OdemeBordrosuId.ToString();
                    ViewData["faturaModel"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 0).ToList();
                    ViewData["faturaModel2"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 1).ToList();
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();
        }
        // Banka İşlemleri > Karşılıksız Portföye İade
        public ActionResult KarsiliksizPortfoyeIade(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                ViewData["faturaModel2"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                var newModel = new VohalOdemeBordrosu();
                newModel.Tarih = DateTime.Today;
                newModel.GuncellemeZamani = DateTime.Today;
                newModel.EklemeZamani = DateTime.Today;

                return View(newModel);
            }
            else
            {
                // Şu andaki faturaId değerine sahip olan faturayı bul
                var currentFatura = _context.VohalOdemeBordrosus.FirstOrDefault(x => x.OdemeBordrosuId == faturaId);

                if (currentFatura != null)
                {
                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId < currentFatura.OdemeBordrosuId)
                        .OrderByDescending(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId > currentFatura.OdemeBordrosuId)
                        .OrderBy(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    ViewData["prevModelId"] = prevModel?.OdemeBordrosuId.ToString();
                    ViewData["nextModelId"] = nextModel?.OdemeBordrosuId.ToString();
                    ViewData["faturaModel"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 0).ToList();
                    ViewData["faturaModel2"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 1).ToList();
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();
        }
        // Banka İşlemleri > Portföye İade
        public ActionResult PortfoyeIade(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                ViewData["faturaModel2"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                var newModel = new VohalOdemeBordrosu();
                newModel.Tarih = DateTime.Today;
                newModel.GuncellemeZamani = DateTime.Today;
                newModel.EklemeZamani = DateTime.Today;

                return View(newModel);
            }
            else
            {
                // Şu andaki faturaId değerine sahip olan faturayı bul
                var currentFatura = _context.VohalOdemeBordrosus.FirstOrDefault(x => x.OdemeBordrosuId == faturaId);

                if (currentFatura != null)
                {
                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId < currentFatura.OdemeBordrosuId)
                        .OrderByDescending(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId > currentFatura.OdemeBordrosuId)
                        .OrderBy(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    ViewData["prevModelId"] = prevModel?.OdemeBordrosuId.ToString();
                    ViewData["nextModelId"] = nextModel?.OdemeBordrosuId.ToString();
                    ViewData["faturaModel"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 0).ToList();
                    ViewData["faturaModel2"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 1).ToList();
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();
        }
        // Banka İşlemleri > Firma Çek Ödeme
        public ActionResult FirmaCekOdeme(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                ViewData["faturaModel2"] = new List<OfisHal.Web.Models.VohalObSatiri>();
                var newModel = new VohalOdemeBordrosu();
                newModel.Tarih = DateTime.Today;
                newModel.GuncellemeZamani = DateTime.Today;
                newModel.EklemeZamani = DateTime.Today;

                return View(newModel);
            }
            else
            {
                // Şu andaki faturaId değerine sahip olan faturayı bul
                var currentFatura = _context.VohalOdemeBordrosus.FirstOrDefault(x => x.OdemeBordrosuId == faturaId);

                if (currentFatura != null)
                {
                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId < currentFatura.OdemeBordrosuId)
                        .OrderByDescending(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalOdemeBordrosus
                        .Where(y => y.IslemTuru == 0 && y.OdemeBordrosuId > currentFatura.OdemeBordrosuId)
                        .OrderBy(x => x.OdemeBordrosuId)
                        .FirstOrDefault();

                    ViewData["prevModelId"] = prevModel?.OdemeBordrosuId.ToString();
                    ViewData["nextModelId"] = nextModel?.OdemeBordrosuId.ToString();
                    ViewData["faturaModel3"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 2).ToList();
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();
        }

        public ActionResult ilkSonKayit(bool firstOrLast, byte islemturu, string actionName)
        {
            var val = firstOrLast ? _context.VohalOdemeBordrosus.Where(x => x.IslemTuru == islemturu).FirstOrDefault() : _context.VohalOdemeBordrosus.Where(x => x.IslemTuru == islemturu).OrderByDescending(x => x.OdemeBordrosuId).FirstOrDefault();
            return RedirectToAction(actionName, new { faturaId = val?.OdemeBordrosuId });
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId, byte islemturu, string actionName)
        {
            var val = afterOrBefore ? _context.VohalOdemeBordrosus.Where(x => x.IslemTuru == islemturu && x.OdemeBordrosuId > currentId).FirstOrDefault() : _context.VohalOdemeBordrosus.OrderByDescending(x => x.OdemeBordrosuId).Where(x => x.IslemTuru == islemturu && x.OdemeBordrosuId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction(actionName, new { id = val?.OdemeBordrosuId });
        }
    }
}
