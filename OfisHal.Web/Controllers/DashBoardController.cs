using OfisHal.Core;
using OfisHal.Core.ViewModels;
using OfisHal.Data.Context;
using OfisHal.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class DashBoardController : BaseController
    {
        private readonly CatalogDb _catalogDb;
        private readonly IHksService _hksService;
        private readonly Db _db;

        public DashBoardController(CatalogDb catalogDb,Db db,IHksService hksService)
        {
            _catalogDb = catalogDb;
            _hksService = hksService;
            _db = db;
        }

        public ActionResult Index()
        {
            /*
            var urunSql = new List<string>();
            var cinsSql = new List<string>();

            foreach (var urun in _hksService.Urunler())
            {
                urunSql.Add($"INSERT [dbo].[HKS_URUNLER_TABLE] ([ID], [AD]) VALUES ({urun.Id}, CONVERT(TEXT, N'{urun.UrunAdi}'))");

                foreach (var cins in _hksService.UrunCinsleri(urun.Id))
                    cinsSql.Add($"INSERT [dbo].[HKS_URUN_CINSLERI_TABLE] ([ID], [AD], [URETIM_SEKLI_ID], [URUN_ID], [URUN_KODU]) VALUES ({cins.Id}, CONVERT(TEXT, N'{cins.UrunCinsiAdi}'), {cins.UretimSekliId}, {cins.UrunId}, CONVERT(TEXT, N'{cins.UrunKodu}'))");
            }

            var template = System.IO.File.ReadAllText(Server.MapPath("~/SQLSablon.txt"));
            template = template.Replace("{{URUNLER}}", string.Join(Environment.NewLine, urunSql));
            template = template.Replace("{{CINSLER}}", string.Join(Environment.NewLine, cinsSql));

            System.IO.File.WriteAllText(Server.MapPath("~/Script.sql"), template, Encoding.UTF8);
            */
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Index(string workSpace)
        {
            if(!string.IsNullOrWhiteSpace(workSpace))
                Response.AddCookie(Constants.WorkSpaceCookieName, workSpace);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult GoToSubtItems(MenuItemsViewModel items)
        {
            return View("Index",items);
        }
    }
}
