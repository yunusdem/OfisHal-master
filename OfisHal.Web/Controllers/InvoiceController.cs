using Hangfire;
using OfisHal.Core.ViewModels;
using OfisHal.Data.Context;
using OfisHal.Services;
using OfisHal.Services.IceSvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class InvoiceController : BaseController
    {
        private readonly Db _context;
        private readonly IInvoiceService _invoiceService;
        private readonly ISmtpService _smtpService;

        public InvoiceController(Db context, IInvoiceService invoiceService, ISmtpService smtpService)
        {
            _context = context;
            _invoiceService = invoiceService;
            _smtpService = smtpService; 
        }

        private async Task<byte[]> BuildPdfContentsAsync(int id)
        {
            using (var ms = new MemoryStream())
            {
                var converter = new SelectPdf.HtmlToPdf();

                var doc = converter.ConvertHtmlString(Server.HtmlDecode(await _invoiceService.PreviewXmlAsync(id, false)));

                doc.Save(ms);

                return ms.ToArray();
            }
        }

        public async Task<FileResult> GetPdf(int id) => 
            File(await BuildPdfContentsAsync(id), MediaTypeNames.Application.Pdf, id + ".pdf");

        [HttpPost]
        public async Task<EmptyResult> SendMails(List<int> ids)
        {
            var invoices = await _context.VohalFaturas
                .Where(x => ids.Contains(x.FaturaId) && !string.IsNullOrWhiteSpace(x.EFaturaEposta))
                .ToListAsync();

            foreach (var invoice in invoices)
            {
                var id = invoice.FaturaNo?.Trim();
                var email = invoice.EFaturaEposta?.Trim();
                var content = await BuildPdfContentsAsync(invoice.FaturaId);
                BackgroundJob.Enqueue(() => _smtpService.SendMail($"{id} NO'LU FATURA", "Fatura Ektedir", email, invoice.Unvan, $"{id}.pdf", content, default));
            }

            return new EmptyResult();
        }

        public ActionResult Index()
        {
            ViewData["StartDate"] = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
            ViewData["EndDate"] = DateTime.Now.ToString("yyyy-MM-dd");
            ViewData["status"] = (byte)0;
            ViewData["type"] = (byte)0;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(byte status = 0, byte? type = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            IQueryable<InvoiceSearchResultViewModel> items;
            ViewData["StartDate"] = startDate?.ToString("yyyy-MM-dd");
            ViewData["EndDate"] = endDate?.ToString("yyyy-MM-dd");
            ViewData["status"] = status;
            ViewData["type"] = type;
            if (type == 3)
                items = _context.VohalGonderimeHazirEIrsaliyes.Where(x => x.EIrsaliyeDurumu == status).Select(x => new InvoiceSearchResultViewModel
                {
                    BelgeTuru = x.EBelgeTuru,
                    Durum = x.EIrsaliyeDurumu,
                    HataAciklamasi = x.EIrsaliyeHataAciklamasi,
                    Id = x.FaturaId,
                    Tarih = x.Tarih,
                    ToplamTutar = x.ToplamTutar,
                    Unvan = x.Unvan,
                    No = x.IrsaliyeNo,
                    CariKartId = x.CariKartId
                });
            else
                items = _context.VohalGonderimeHazirEFaturas.Where(x => x.EFaturaDurumu == status && x.EBelgeTuru == type).Select(x => new InvoiceSearchResultViewModel
                {
                    BelgeTuru = x.EBelgeTuru,
                    Durum = x.EFaturaDurumu,
                    HataAciklamasi = x.EFaturaHataAciklamasi,
                    Id = x.FaturaId,
                    Tarih = x.Tarih,
                    ToplamTutar = x.ToplamTutar,
                    Unvan = x.Unvan,
                    No = x.FaturaNo,
                    CariKartId = x.CariKartId
                });

            if (startDate.HasValue)
                items = items.Where(x => x.Tarih >= startDate.Value);

            if (endDate.HasValue)
                items = items.Where(x => x.Tarih <= endDate.Value);

            items = items.OrderBy(x => x.Tarih).ThenBy(x => x.No);

            return View(await items.ToListAsync());
        }

        // Alış İşlemleri > E-Müstahsil Makbuzu Bildirimi
        public ActionResult EMustahsilMakbuzu()
        {
            ViewData["StartDate"] = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
            ViewData["EndDate"] = DateTime.Now.ToString("yyyy-MM-dd");
            ViewData["status"] = (byte)0;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> EMustahsilMakbuzu(byte status = 0, DateTime? startDate = null, DateTime? endDate = null)
        {
            ViewData["StartDate"] = startDate?.ToString("yyyy-MM-dd");
            ViewData["EndDate"] = endDate?.ToString("yyyy-MM-dd");
            ViewData["status"] = status;

            IQueryable<InvoiceSearchResultViewModel> items;

            items = _context.VohalGonderimeHazirEMustahsilMakbuzus.Select(x => new InvoiceSearchResultViewModel
            {
                BelgeTuru = x.EBelgeTuru,
                Durum = x.EFaturaDurumu,
                HataAciklamasi = x.EFaturaHataAciklamasi,
                Id = x.FaturaId,
                Tarih = x.Tarih,
                ToplamTutar = x.ToplamTutar,
                Unvan = x.Unvan,
                No = x.FaturaNo,
                CariKartId = x.CariKartId
            });

            items = items.Where(x => x.Durum == status /*&& x.BelgeTuru == type*/);

            if (startDate.HasValue)
                items = items.Where(x => x.Tarih >= startDate.Value);

            if (endDate.HasValue)
                items = items.Where(x => x.Tarih <= endDate.Value);

            items = items.OrderBy(x => x.Tarih).ThenBy(x => x.No);

            return View(await items.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> SendSelected(List<int> Id, byte type)
        {
            var selectedType = Belge_Turu.EFatura;

            switch (type)
            {
                default:
                case 0:
                    selectedType = Belge_Turu.EFatura;
                    break;
                case 1:
                    selectedType = Belge_Turu.EArsiv;
                    break;
                case 3:
                    selectedType = Belge_Turu.EIrsaliye;
                    break;
                case 4:
                    selectedType = Belge_Turu.EMustahsil;
                    break;
            }

            var result = await _invoiceService.SendSelectedAsync(Id, selectedType == Belge_Turu.EIrsaliye);

            if (result.Count > 0)
                return Json(new { success = true, message = result }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { success = false, message = result }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FaturaGonderildi(int faturaId)
        {
            var fatura = _context.TohalFaturas.Where(x => x.FaturaId == faturaId).FirstOrDefault();
            fatura.EFaturaDurumu = 1;
            _context.Entry(fatura).State = EntityState.Modified;
            _context.SaveChanges();
            return Json(new { success = true, message = "Başarıyla eklendi", faturaId = faturaId }, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> Preview(int id, bool ex = false, bool despatch = false) =>
            Content(Server.HtmlDecode(await _invoiceService.PreviewXmlAsync(id, ex, despatch)), MediaTypeNames.Text.Html, Encoding.UTF8);
    }
}
