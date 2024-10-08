using OfisHal.Core;
using OfisHal.Data.Context;
using OfisHal.Services.Reports;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class ReportsController : BaseController
    {
        private readonly Db _db;
        private readonly ReportsClient _reportsClient;

        public ReportsController(Db db)
        {
            _db = db;
            _reportsClient = new ReportsClient();
        }

        public async Task<ActionResult> Index(bool ownFile = false)
        {
            _reportsClient.SetDatabaseId(Request.GetCookie<string>(Constants.WorkSpaceCookieName));
            var model = await _reportsClient.GetAllAsync(ownFile);

            ViewData["Title"] = "Rapor Listesi";
            return View(model);
        }

        public async Task<ActionResult> Details(string id)
        {
            _reportsClient.SetDatabaseId(Request.GetCookie<string>(Constants.WorkSpaceCookieName));
            var model = await _reportsClient.GetAsync(id, false);

            if (model != null)
            {
                ViewData["Title"] = "Rapor Parametreleri";
                return View(model);
            }

            return HttpNotFound();
        }

        [HttpPost]
        public async Task<ActionResult> ExportReport(string id, bool pdf, [Bind(Prefix = "p")] FormCollection form, bool ownFile = false)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                // db'den alınması gereken default değerler burada belirtilmeli, api dbcontext ile bağlantısız

                var tanim = await _db.TohalTanims.FirstOrDefaultAsync();

                foreach (var name in form.AllKeys)
                {
                    if (name.Equals("pFirmamizAdi", StringComparison.OrdinalIgnoreCase))
                        form[name] = tanim?.DigFirmaAdi;
                    else if (name.Equals("pFirmaAdresi", StringComparison.OrdinalIgnoreCase))
                        form[name] = tanim?.DigAdres;
                    else if (name.Equals("pYazihaneNo", StringComparison.OrdinalIgnoreCase))
                        form[name] = tanim?.DigYazihaneNo;
                }

                _reportsClient.SetDatabaseId(Request.GetCookie<string>(Constants.WorkSpaceCookieName));
                var model = await _reportsClient.PostAsync(id, form, ownFile,pdf);

                if (model != null)
                {
                    var ext = pdf ? "pdf" : "xls";
                    var mime = pdf ? MediaTypeNames.Application.Pdf : "application/vnd.ms-excel";

                    var fileName = $"{id}_{DateTime.Now:dd-MM-yy-HH-mm}.{ext}";
                    Response.AddHeader("Content-Disposition", "inline; filename=" + fileName);

                    return File(model.Stream, mime);
                }
            }

            return Problem(string.Empty);
        }

        [HttpGet]
        public async Task<ActionResult> ExportReport(string id)
        {
            _reportsClient.SetDatabaseId(Request.GetCookie<string>(Constants.WorkSpaceCookieName));
            var model = await _reportsClient.GetAsync(id, true);

            if (model != null)
            {
                var allKeys = Request.QueryString.AllKeys.AsEnumerable();
                var form = new FormCollection();

                foreach (var p in model.Tabs.SelectMany(x => x.Parameters))
                {
                    if (p.Name.EndsWith("IslemId", StringComparison.OrdinalIgnoreCase))
                    {
                        if (int.TryParse(Request.QueryString[allKeys.FirstOrDefault(x => x.EndsWith("IslemId"))], out var i))
                            form[p.Name] = i.ToString();
                        else
                            form[p.Name] = "0";
                    }
                    else if (p.Name.EndsWith("KopyaSayisi", StringComparison.OrdinalIgnoreCase))
                    {
                        if (int.TryParse(Request.QueryString[allKeys.FirstOrDefault(x => x.EndsWith("KopyaSayisi"))], out var i))
                            form[p.Name] = i.ToString();
                        else
                            form[p.Name] = "1";
                    }
                    else if (p.Name.EndsWith("AdiSoyadi", StringComparison.OrdinalIgnoreCase)) //pOdemeyiAlaninAdiSoyadi
                        form[p.Name] = Request.QueryString[allKeys.FirstOrDefault(x => x.EndsWith("AdiSoyadi"))];
                    else
                        form[p.Name] = Request.QueryString[p.Name];
                }

                return await ExportReport(id, true, form, true);
            }

            return HttpNotFound();
        }
    }
}
