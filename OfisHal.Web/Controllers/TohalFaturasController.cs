using OfisHal.Core;
using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using OfisHal.Services;
using OfisHal.Services.HksBildirimSvc;
using OfisHal.Services.HksGenelSvc;
using OfisHal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class TohalFaturasController : BaseController
    {
        private readonly CatalogDb _catalogDb;
        private readonly Db _context;
        private readonly IHksService _hksService;
        public TohalFaturasController(Db context,CatalogDb catalogDb, IHksService hksService)
        {
            _context = context;
            _catalogDb= catalogDb;
            _hksService = hksService;
        }

        public ActionResult FaturaAktarma()
        {
            VohalFatura model = new VohalFatura();
            model.Tarih = DateTime.Now;
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> FaturaAktarma(string WorkSpace, DateTime? startDate = null, DateTime? endDate = null, string firstInvoiceNo = "", string lastInvoiceNo = "", string aktarFaturaId = "0")
        {
            var dbId = Convert.ToInt32(WorkSpace);

            if (dbId > 0)
            {
                #region Mevcut db kayıtlarını bul
                // bu işlemi önceden halletmemizin nedeni yaratacağımız diğer db instance'ı ile karıştırmak istemememiz
                //var invoiceQry = _context.TohalFaturas.Include(i => i.TohalFaturaSatiris).AsQueryable().AsNoTracking();
                var invoiceQry = _context.TohalFaturas
                                    .Include(i => i.TohalFaturaSatiris)
                                        .Include(s => s.TohalFaturaSatiris.Select(i => i.Mal))
                                        .Include(s => s.TohalFaturaSatiris.Select(i => i.Marka))
                                        .Include(s => s.TohalFaturaSatiris.Select(i => i.Kap))
                                    .Include(i => i.CariKart)
                                    .Where(f => f.FaturaNo != null)
                                    .AsQueryable()
                                    .AsNoTracking();
                if (startDate.HasValue)
                    invoiceQry = invoiceQry.Where(x => x.Tarih >= startDate.Value);

                if (endDate.HasValue)
                    invoiceQry = invoiceQry.Where(x => x.Tarih <= endDate.Value);

                if (firstInvoiceNo != "")
                    invoiceQry = invoiceQry.Where(x => x.FaturaNo == firstInvoiceNo);

                if (lastInvoiceNo != "")
                    invoiceQry = invoiceQry.Where(x => x.FaturaNo == lastInvoiceNo);

                int faturaId = Convert.ToInt32(aktarFaturaId);
                if (faturaId != 0)
                {
                    invoiceQry = invoiceQry.Where(x => x.FaturaId == faturaId);
                }
                // filtrelerin devamı

                var invoiceList = await invoiceQry.ToListAsync(); // liste haline getir belleğe al
                var tempinvoiceList = invoiceList;
                tempinvoiceList.ForEach(i =>
                {
                    i.FaturaId = 0;
                    foreach (var item in i.TohalFaturaSatiris)
                    {
                        item.FaturaId = 0;
                        item.FaturaSatiriId = 0;
                    }
                }); // tümünün ID bilgilerini 0'ladım diğer tarafa eklerken ID'leriyle gitmesin diye
                #endregion

                #region Karşı db işlemleri
                // güvenlik: karşı db aktif mi ve bizim firmamıza ait mi kontrolleri
                var currentUser = await _catalogDb.Users.FindAsync(User.GetUserId());

                if (currentUser != null) // user kontrol
                {
                    try
                    {
                        var connStr = new SqlConnectionStringBuilder(_context.Database.Connection.ConnectionString);

                        var db = await _catalogDb.Databases.FirstOrDefaultAsync(d => d.IsActive && d.Id == dbId && d.CustomerId == currentUser.CustomerId);

                        // aktif istenen db kontrol
                        // gönderilen db adı çalıştığımız db adı ile aynı olmamalı
                        if (db != null && !connStr.InitialCatalog.Equals(db.DatabaseName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            connStr.InitialCatalog = db.DatabaseName; // connstring db bilgisini ayarla

                            using (var newDb = new Db(connStr.ConnectionString))
                            {
                                foreach (var invoice in tempinvoiceList)
                                {

                                    foreach (var item in invoice.TohalFaturaSatiris.ToList())
                                    {
                                        var cari = _context.TohalCariKarts.Where(x => x.MarkaId == item.MarkaId).FirstOrDefault();

                                        var mal = newDb.TohalMals.Where(x => x.Kod == item.Mal.Kod).FirstOrDefault();
                                        if (mal != null)
                                        {
                                            item.Mal = null;
                                            item.MalId = mal.MalId;
                                        }
                                        else
                                        {
                                            var insertedEntity = newDb.TohalMals.Add(item.Mal);
                                            newDb.SaveChanges();

                                            var insertedId = insertedEntity.MalId;
                                            item.Mal = null;
                                            item.MalId = insertedId;

                                        }
                                        if (cari != null)
                                        {
                                            var newdbcari = newDb.TohalCariKarts.Where(x => x.Kod == cari.Kod).FirstOrDefault();
                                            if (newdbcari != null)
                                            {
                                                if (newdbcari.MarkaId != null)
                                                    item.Marka = null;
                                                item.MarkaId = (int)newdbcari.MarkaId;
                                            }
                                            else
                                            {

                                                var insertedEntity = newDb.TohalMarkas.Add(item.Marka);
                                                newDb.SaveChanges();

                                                var insertedId = insertedEntity.MarkaId;
                                                item.Marka = null;
                                                item.MarkaId = insertedId;
                                            }
                                        }
                                        if (item.Kap != null)
                                        {
                                            var kap = newDb.TohalKaps.Where(x => x.Kod == item.Kap.Kod).FirstOrDefault();
                                            if (kap != null)
                                            {
                                                item.KapId = newDb.TohalKaps.Where(x => x.Kod == item.Kap.Kod).FirstOrDefault().KapId;
                                            }
                                            else
                                            {

                                                var insertedEntity = newDb.TohalKaps.Add(item.Kap);
                                                newDb.SaveChanges();

                                                var insertedId = insertedEntity.KapId;
                                                item.Kap = null;
                                                item.KapId = insertedId;
                                            }
                                        }
                                    }


                                    invoice.CariKart = null;
                                    invoice.CariKartId = null;


                                }
                                newDb.TohalFaturas.AddRange(tempinvoiceList);
                                await newDb.SaveChangesAsync();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);
                    }
                    try
                    {
                        foreach (var invoice in invoiceList)
                        {
                            invoice.Aktarildi = true;
                            _context.Entry(invoice).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                    }
                    catch
                    {

                    }
                }
            }
            return Json(new { success = true, message = "Başarıyla eklendi" }, JsonRequestBehavior.AllowGet);
            #endregion
        }

        // GET: TohalFaturas
        public async Task<ActionResult> Index(int faturaId = 0, bool yeni = false, string pgdown = "")
        {
            if (pgdown != "")
            {
                yeni = true;
            }
            var tanim = _context.TohalTanims.FirstOrDefault();
            var satkdv = tanim.SatDigerMalKdvOrani;
            var satverkdv = tanim.SatVerMukMalKdvOrani;
            ViewData["tanimKdvOrani0"] = satkdv;
            ViewData["tanimKdvOrani1"] = satverkdv;
            ViewData["tanimSifati"] = tanim.DigSifati;
            ViewData["tanimBildirimTuru"] = tanim.SatBildirimTuru;
            ViewData["tanimRusumOrani"] = tanim.SatRusumOrani ?? 0;
            ViewData["iskontoVisible"] = tanim.SatIskontoVar ?? false;
            var yenimesaj = _context.TohalKullaniciYetkisis.Where(x => x.YetkiCinsi == 9).FirstOrDefault();
            if (yenimesaj != null)
            {
                ViewData["acilisyetki"] = 1;
            }
            else
            {
                ViewData["acilisyetki"] = 0;
            }
            var senaryo = tanim.EFaturaSenaryosu;
            var efaturapk = _context.TohalGibKullanicis
                                    .Where(x => x.PkTipi == 0 && x.KayitSekli == 1 && x.DokumanTipi == 0)
                                    .FirstOrDefault();
            var eirsaliyepk = _context.TohalGibKullanicis
                                    .Where(x => x.PkTipi == 0 && x.KayitSekli == 1 && x.DokumanTipi == 1)
                                    .FirstOrDefault();
            if (faturaId == 0)
            {
                if (yeni)
                {
                    var newModel = new TohalFatura
                    {
                        Tarih = DateTime.Now,
                        Tip = 1,
                        FaturaNo = string.Empty,
                        IrsaliyeNo = string.Empty,
                        Unvan = string.Empty,
                        Adres = string.Empty,
                        KisilikTipi = 0,
                        VergiKimlikNo = string.Empty,
                        Rusum = 0.0,
                        IskontoOrani = 0.0,
                        RusumKdvOrani = 0.0,
                        Iskonto = 0.0,
                        RusumKdv = 0.0,
                        KdvsizIadesizKap = 0.0,
                        KdvliIadesizKap = 0.0,
                        IadesizKapKdvOrani = 0.0,
                        IadesizKapKdv = 0.0,
                        Yukleme = 0.0,
                        RehinIadeliKap = 0,
                        YuklemeKdvOrani = 0.0,
                        YuklemeKdv = 0.0,
                        Nakliye = 0.0,
                        NakliyeKdvOrani = 0.0,
                        NakliyeKdv = 0.0,
                        EkleyenId = 1,
                        EklemeZamani = DateTime.Now,
                        GuncelleyenId = 1,
                        GuncellemeZamani = DateTime.Now,
                        IrsaliyeZamani = DateTime.Now,
                        Guid = Guid.NewGuid().ToString(),
                        PlakaNo = string.Empty,
                        RusumKdvIliskisi = 0,
                        GsmNo = string.Empty,
                        EPosta = string.Empty,
                        GidecegiYerTipi = 0,
                        Sifati = 0,
                        BildirimTuru = 0,
                        CariSifati = 0,
                        Zaman = DateTime.Now,
                        EFaturaDurumu = 0,
                        EFaturaHataAciklamasi = string.Empty,
                        HksMalinNiteligi = 0,
                        EFaturaNot = string.Empty,
                        EFaturaSiparisNo = string.Empty,
                        EFaturaBolgeKodu = string.Empty,
                        MalIskontoToplami = 0.0,
                        EFaturaGibDurumu = 0,
                        KunyeIstekGuid = string.Empty,
                        EIrsaliyeDurumu = 0,
                        EIrsaliyeHataAciklamasi = string.Empty,
                        EIrsaliyeGibDurumu = 0,
                        OdeyenKurumunVergiNosu = string.Empty,
                        NakitTahsilat = 0.0,
                        KrediKartiTahsilati = 0.0,
                        GibFirmamizPostaKutusuId = efaturapk?.GibKullaniciId,
                        GibFrmIrsaliyeKutusuId = eirsaliyepk?.GibKullaniciId,
                        Veresiye = tanim.SatFaturaDefaultVeresiye ?? false,
                        EFaturaSenaryosu = senaryo
                        
                };

                    _context.TohalFaturas.Add(newModel);
                    _context.SaveChanges();
                }

                var faturaList = _context.VohalFaturas.OrderByDescending(x => x.FaturaId)
                                                      .Where(x => x.Tip == 1)
                                                      .Take(2)
                                                      .ToList();

                if (faturaList.Count == 0)
                {
                    return RedirectToAction("Index", new { yeni = true });
                }

                var model = faturaList[0];
                var prevModel = (faturaList.Count > 1) ? faturaList[1] : faturaList[0];
                var teslimatYerleri = _context.TohalTeslimatYeris;
                var siraliTeslimatYerleri = teslimatYerleri.OrderBy(t => (t.HksWebSiraNo ?? int.MaxValue))
                                                    .ThenBy(t => t.TeslimatYeriId);

                ViewData["TeslimatYer"] = new SelectList(siraliTeslimatYerleri, "TeslimatYeriId", "Ad", model.TeslimatYeriId);
                ViewData["Magazalar"] = new SelectList(_context.TohalMagazas.Where(x => x.CariKartId == model.CariKartId), "MagazaId", "Ad", model.MagazaId);
                ViewData["prevModelId"] = prevModel.FaturaId.ToString();
                ViewData["nextModelId"] = "";
                ViewData["faturaModel"] = _context.VohalFaturaSatiriUrts.Where(y => y.FaturaId == model.FaturaId).ToList();
                ViewData["faturaRehinModel"] = _context.VohalRehinFisis.Where(y => y.FaturaId == model.FaturaId).ToList();
                if (model.CariKartId != null)
                {
                    ViewData["Bakiye"] = await BakiyeSoyleAsync((int)model.CariKartId);

                }
                ViewData["faturaToplam"] = _context.VohalFaturaSonToplams
                .Where(y => y.FaturaId == model.FaturaId)
                .FirstOrDefault() ?? new VohalFaturaSonToplam();

                if(model.EFaturaSenaryosu == null)
                {
                    model.EFaturaSenaryosu = tanim.EFaturaSenaryosu;
                }

                if (model.KisilikTipi == 0)
                    ViewData["tanimKdvOrani"] = satkdv ?? 0;
                else
                    ViewData["tanimKdvOrani"] = satverkdv ?? 0;

                return View(model);
            }
            else
            {
                // Şu andaki faturaId değerine sahip olan faturayı bul
                var currentFatura = _context.VohalFaturas.FirstOrDefault(x => x.FaturaId == faturaId);

                if (currentFatura != null)
                {
                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalFaturas
                        .Where(y => y.Tip == 1 && y.FaturaId < currentFatura.FaturaId)
                        .OrderByDescending(x => x.FaturaId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalFaturas
                        .Where(y => y.Tip == 1 && y.FaturaId > currentFatura.FaturaId)
                        .OrderBy(x => x.FaturaId)
                        .FirstOrDefault();

                    ViewData["Magazalar"] = new SelectList(_context.TohalMagazas.Where(x => x.CariKartId == currentFatura.CariKartId), "MagazaId", "Ad", currentFatura.MagazaId);
                    ViewData["prevModelId"] = prevModel?.FaturaId.ToString();
                    ViewData["nextModelId"] = nextModel?.FaturaId.ToString();
                    ViewData["faturaToplam"] = _context.VohalFaturaSonToplams
                               .Where(y => y.FaturaId == currentFatura.FaturaId)
                               .FirstOrDefault() ?? new VohalFaturaSonToplam();
                    ViewData["faturaModel"] = _context.VohalFaturaSatiriUrts.Where(y => y.FaturaId == currentFatura.FaturaId).ToList();
                    ViewData["faturaRehinModel"] = _context.VohalRehinFisis.Where(y => y.FaturaId == currentFatura.FaturaId).ToList();
                    ViewData["TeslimatYer"] = new SelectList(_context.TohalTeslimatYeris, "TeslimatYeriId", "Ad", currentFatura.TeslimatYeriId);
 
                    if (currentFatura.CariKartId != null)
                    {
                        ViewData["Bakiye"] = await BakiyeSoyleAsync((int)currentFatura.CariKartId);
                    }
                    if(currentFatura.KisilikTipi == 0)
                    ViewData["tanimKdvOrani"] = satkdv ?? 0;
                    else
                    ViewData["tanimKdvOrani"] = satverkdv ?? 0;

                    if (currentFatura.EFaturaSenaryosu == null)
                    {
                        currentFatura.EFaturaSenaryosu = tanim.EFaturaSenaryosu;
                    }
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();
        }


        // GET: TohalFaturas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null || _context.TohalFaturas == null)
            {
                return HttpNotFound();
            }

            var tohalFatura = await _context.TohalFaturas
                .Include(t => t.BagkurDosya)
                .Include(t => t.CariKart)
                .Include(t => t.Ekleyen)
                .Include(t => t.Fis)
                .Include(t => t.FiyatReferansFatura)
                .Include(t => t.GibFirmamizPostaKutusu)
                .Include(t => t.GibFrmIrsaliyeKutusu)
                .Include(t => t.GibMuhatapIrsaliyeKutusu)
                .Include(t => t.GibMuhatapPostaKutusu)
                .Include(t => t.Guncelleyen)
                .Include(t => t.Hal)
                .Include(t => t.IhracatParaBirimi)
                .Include(t => t.Magaza)
                .Include(t => t.OdemeSekli)
                .Include(t => t.PosCihazi)
                .Include(t => t.Sehir)
                .Include(t => t.Siparis)
                .Include(t => t.Sofor)
                .Include(t => t.TeslimatSekli)
                .Include(t => t.TeslimatYeri)
                .Include(t => t.UlasimSekli)
                .Include(t => t.VergiDairesi)
                .Include(t => t.Yer)
                .FirstOrDefaultAsync(m => m.FaturaId == id);
            if (tohalFatura == null)
            {
                return HttpNotFound();
            }

            return View(tohalFatura);
        }

        [HttpPost]
        public async Task<JsonResult> CreateRehinFisiSatir(List<TohalIskeleRehinFisi> tohalIskeleFaturaSatirlari)
        {
            try
            {
                await RemoveIskele();
                if (ModelState.IsValid)
                {
                    if (tohalIskeleFaturaSatirlari.Any())
                    {
                        foreach (var tohalIskeleFaturaSatiri in tohalIskeleFaturaSatirlari)
                        {
                            if (tohalIskeleFaturaSatiri.SatirGuid == null || tohalIskeleFaturaSatiri.SatirGuid == "" || tohalIskeleFaturaSatiri.SatirGuid == Guid.Empty.ToString())
                                tohalIskeleFaturaSatiri.SatirGuid = Guid.NewGuid().ToString();

                            tohalIskeleFaturaSatiri.KapId = tohalIskeleFaturaSatiri.KapId == 0 ? null : tohalIskeleFaturaSatiri.KapId;
                            _context.TohalIskeleRehinFisis.Add(tohalIskeleFaturaSatiri);
                        }

                        await _context.SaveChangesAsync();
                    }

                    return Json(new { success = true, message = "Başarıyla eklendi" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    await RemoveIskele();
                    return Json(new { success = false, message = "Geçersiz model durumu" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                await RemoveIskele();
                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public async Task<JsonResult> CreateFaturaSatir(List<TohalIskeleFaturaSatiri> tohalIskeleFaturaSatirlari)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (tohalIskeleFaturaSatirlari == null)
                    {
                        tohalIskeleFaturaSatirlari = new List<TohalIskeleFaturaSatiri>();
                    }
                    foreach (var tohalIskeleFaturaSatiri in tohalIskeleFaturaSatirlari)
                    {
                        if (tohalIskeleFaturaSatiri.SatirGuid == null ||
                          tohalIskeleFaturaSatiri.SatirGuid == "" ||
                          tohalIskeleFaturaSatiri.SatirGuid == Guid.Empty.ToString())
                        {
                            tohalIskeleFaturaSatiri.SatirGuid = Guid.NewGuid().ToString();

                        }
                        if(tohalIskeleFaturaSatiri.StokKunyeId == null || tohalIskeleFaturaSatiri.SatisKunyeId == null)
                        {
                            tohalIskeleFaturaSatiri.SatirGuid = Guid.NewGuid().ToString();
                        }

                        tohalIskeleFaturaSatiri.KapId = tohalIskeleFaturaSatiri.KapId == 0 ? null : tohalIskeleFaturaSatiri.KapId;
                        tohalIskeleFaturaSatiri.MalId = tohalIskeleFaturaSatiri.MalId == 0 ? null : tohalIskeleFaturaSatiri.MalId;
                        tohalIskeleFaturaSatiri.StokKunyeId = tohalIskeleFaturaSatiri.StokKunyeId == 0 ? null : tohalIskeleFaturaSatiri.StokKunyeId;
                        tohalIskeleFaturaSatiri.SatisKunyeId = tohalIskeleFaturaSatiri.SatisKunyeId == 0 ? null : tohalIskeleFaturaSatiri.SatisKunyeId;
                        tohalIskeleFaturaSatiri.KdvTevkifatTanimiId = tohalIskeleFaturaSatiri.KdvTevkifatTanimiId == 0 ? null : tohalIskeleFaturaSatiri.KdvTevkifatTanimiId;
                        tohalIskeleFaturaSatiri.IskontoOrani = tohalIskeleFaturaSatiri.IskontoOrani == null ? 0 : tohalIskeleFaturaSatiri.IskontoOrani;
                        tohalIskeleFaturaSatiri.IskontoPayi = tohalIskeleFaturaSatiri.IskontoPayi == null ? 0 : tohalIskeleFaturaSatiri.IskontoPayi;
                        tohalIskeleFaturaSatiri.Iskonto = tohalIskeleFaturaSatiri.Iskonto == null ? 0 : tohalIskeleFaturaSatiri.Iskonto;
                        tohalIskeleFaturaSatiri.Yukleme = tohalIskeleFaturaSatiri.Yukleme == null ? 0 : tohalIskeleFaturaSatiri.Yukleme;
                        _context.TohalIskeleFaturaSatiris.Add(tohalIskeleFaturaSatiri);
                    }

                    await _context.SaveChangesAsync();
                    return Json(new { success = true, message = "Başarıyla eklendi" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    await RemoveIskele();
                    return Json(new { success = false, message = "Geçersiz model durumu" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                await RemoveIskele();
                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public async Task<ActionResult> SaveFatura([Bind(Include = "CariKartId,Tip,FaturaNo,Tarih,IrsaliyeNo,Unvan,SehirId,Adres,KisilikTipi,VergiDairesiId,VergiKimlikNo,Rusum,RusumKdvOrani,RusumKdv,KdvsizIadesizKap,KdvliIadesizKap,IadesizKapKdvOrani,IadesizKapKdv,Yukleme,RehinIadeliKap,YuklemeKdvOrani,YuklemeKdv,Nakliye,NakliyeKdvOrani,NakliyeKdv,Kesildi,Veresiye,Vade,EkleyenId,EklemeZamani,GuncelleyenId,GuncellemeZamani,Degistirildi,MagazaId,IrsaliyeZamani,Guid,RehinDevri,Ihracatci,PlakaNo,RusumKdvIliskisi,YerId,GsmNo,EPosta,GidecegiYerTipi,Sifati,BildirimTuru,CariSifati,HalId,TeslimatYeriId,HksWebSiraNo,GibFirmamizPostaKutusuId,GibMuhatapPostaKutusuId,Zaman,EFaturaEttn,EFaturaDurumu,EFaturaHataAciklamasi,Onaylandi,SiparisId,IskontoHesaplanmasin,HksMalinNiteligi,Aktarildi,EFaturaNot,EFaturaSiparisNo,EFaturaSiparisTarihi,EFaturaBolgeKodu,VeresiyeDurumuDegisti,MalIskontoToplami,EFaturaGibDurumu,KunyeIstekGuid,FisId,BagkurDosyaId,EIrsaliyeEttn,EIrsaliyeDurumu,EIrsaliyeHataAciklamasi,EIrsaliyeGibDurumu,GibFrmIrsaliyeKutusuId,GibMuhatapIrsaliyeKutusuId,IhracatParaBirimiId,IhracatKuru,NavlunMaliyeti,SigortaMaliyeti,TeslimatSekliId,UlasimSekliId,OdemeSekliId,FiyatReferansFaturaId,OdeyenKurumunVergiNosu,OdeyenKurumunVergiDaireId,NakitTahsilat,KrediKartiTahsilati,PosCihaziId,SoforId,IadeFaturasi,EFaturaSenaryosu")] TohalFatura tohalFatura, string ktahsilat = "0", string ntahsilat = "0", string iskonto = "0", string ioran = "0", string iskontotoplam = "0", bool kesildiBut = false, bool kunyeBut = false, bool irsaliyeBut = false)
        {
            if (kunyeBut) { 
                try { 

                    if(tohalFatura.CariKartId != null 
                        && tohalFatura.CariKartId != 0
                        && tohalFatura.VergiKimlikNo != null
                        && tohalFatura.VergiKimlikNo != "") { 
                        var cariUser = _context.TohalCariKarts.Where(x => x.CariKartId == tohalFatura.CariKartId).FirstOrDefault();

                        if(cariUser.HksBilgisiAlindi == false)
                        {
                            var magazaId = HksBilgiAl((int)tohalFatura.CariKartId, tohalFatura.VergiKimlikNo.Trim());
                            tohalFatura.MagazaId = magazaId;
                        }
                    }
                }
                catch (Exception)
                {
                    await RemoveIskele();
                }
            }
            tohalFatura.NakitTahsilat = Convert.ToDouble(ntahsilat);
            tohalFatura.KrediKartiTahsilati = Convert.ToDouble(ktahsilat);
            if (iskonto.Contains(".") && iskonto.Contains(","))
            {
                // Hem nokta hem virgül içeriyor
                tohalFatura.Iskonto = double.Parse(iskonto.Replace(".", ""));
            }
            else
            {
                // Sadece nokta içeriyor
                tohalFatura.Iskonto = double.Parse(iskonto.Replace(".", ","));
            }
            tohalFatura.IskontoOrani = double.Parse(ioran.Replace(".", ","));
            tohalFatura.MalIskontoToplami = double.Parse(iskontotoplam.Replace(".", ","));
            if (ModelState.IsValid)
            {
                #region Fatura Kaydetme

                var guid = Guid.NewGuid();
                try
                {
                    _context.TohalIskeleFaturaSatiris.ToList().ForEach(x =>
                    {
                        x.Guid = guid;
                        _context.Entry(x).State = EntityState.Modified;
                    });
                    _context.TohalIskeleRehinFisis.ToList().ForEach(x =>
                    {
                        x.Guid = guid;
                        _context.Entry(x).State = EntityState.Modified;
                    });
                    _context.TohalIskeleRehinFisis.RemoveRange(_context.TohalIskeleRehinFisis.Where(x => x.KapId == null));
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    await RemoveIskele();
                    return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);

                }
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@FATURA_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@CARI_KART_ID", (object)tohalFatura.CariKartId ?? DBNull.Value),
                    new SqlParameter("@TIP", tohalFatura.Tip),
                    new SqlParameter("@TARIH", tohalFatura.Tarih),
                    new SqlParameter("@FATURA_NO", (object)tohalFatura.FaturaNo ?? DBNull.Value),
                    new SqlParameter("@IRSALIYE_NO", (object)tohalFatura.IrsaliyeNo ?? DBNull.Value),
                    new SqlParameter("@UNVAN", (object)tohalFatura.Unvan ?? DBNull.Value),
                    new SqlParameter("@YER_ID", (object)tohalFatura.YerId ?? DBNull.Value),
                    new SqlParameter("@ADRES", (object)tohalFatura.Adres ?? DBNull.Value),
                    new SqlParameter("@KISILIK_TIPI", tohalFatura.KisilikTipi),
                    new SqlParameter("@VERGI_DAIRESI_ID", (object)tohalFatura.VergiDairesiId ?? DBNull.Value),
                    new SqlParameter("@VERGI_KIMLIK_NO", (object)tohalFatura.VergiKimlikNo ?? DBNull.Value),
                    new SqlParameter("@RUSUM", tohalFatura.Rusum),
                    new SqlParameter("@RUSUM_KDV_ORANI", tohalFatura.RusumKdvOrani),
                    new SqlParameter("@RUSUM_KDV", tohalFatura.RusumKdv),
                    new SqlParameter("@ISKONTO_ORANI", tohalFatura.IskontoOrani),
                    new SqlParameter("@ISKONTO", tohalFatura.Iskonto),
                    new SqlParameter("@KDVSIZE_IADESIZ_KAP", tohalFatura.KdvsizIadesizKap),
                    new SqlParameter("@KDVLI_IADESIZ_KAP", tohalFatura.KdvliIadesizKap),
                    new SqlParameter("@IADESIZ_KAP_KDV_ORANI", tohalFatura.IadesizKapKdvOrani),
                    new SqlParameter("@IADESIZ_KAP_KDV", tohalFatura.IadesizKapKdv),
                    new SqlParameter("@REHIN_IADELI_KAP", tohalFatura.RehinIadeliKap),
                    new SqlParameter("@YUKLEME", tohalFatura.Yukleme),
                    new SqlParameter("@YUKLEME_KDV_ORANI", tohalFatura.YuklemeKdvOrani),
                    new SqlParameter("@YUKLEME_KDV", tohalFatura.YuklemeKdv),
                    new SqlParameter("@NAKLIYE", tohalFatura.Nakliye),
                    new SqlParameter("@NAKLIYE_KDV_ORANI", tohalFatura.NakliyeKdvOrani),
                    new SqlParameter("@NAKLIYE_KDV", tohalFatura.NakliyeKdv),
                    new SqlParameter("@VADE", (object)tohalFatura.Vade ?? DBNull.Value),
                    new SqlParameter("@MAGAZA_ID", (object)tohalFatura.MagazaId ?? DBNull.Value),
                    new SqlParameter("@IRSALIYE_ZAMANI", tohalFatura.IrsaliyeZamani),
                    new SqlParameter("@SIPARIS_ID", (object)tohalFatura.SiparisId ?? DBNull.Value),
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                    new SqlParameter("@DEGISTIRILDI", (object)tohalFatura.Degistirildi ?? DBNull.Value),
                    new SqlParameter("@IHRACATCI", (object)tohalFatura.Ihracatci ?? DBNull.Value),
                    new SqlParameter("@PLAKA_NO", (object)tohalFatura.PlakaNo ?? DBNull.Value),
                    new SqlParameter("@RUSUM_KDV_ILISKISI", (object)tohalFatura.RusumKdvIliskisi ?? DBNull.Value),
                    new SqlParameter("@FATURA_GUID", (object)new Guid(tohalFatura.Guid) ?? DBNull.Value),
                    new SqlParameter("@GUID", SqlDbType.UniqueIdentifier) { Value = guid },
                    new SqlParameter("@GUNCELLEME_ZAMANI",(object) tohalFatura.GuncellemeZamani ?? DateTime.Now),
                    new SqlParameter("@GUNCELLEME_ZORUNLU", SqlDbType.Bit) { Value = true },
                    new SqlParameter("@GSM_NO", (object)tohalFatura.GsmNo ?? DBNull.Value),
                    new SqlParameter("@EPOSTA", (object)tohalFatura.EPosta ?? DBNull.Value),
                    new SqlParameter("@GIDECEGI_YER_TIPI", (object)tohalFatura.GidecegiYerTipi ?? DBNull.Value),
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = true },
                    new SqlParameter("@SIFATI", (object)tohalFatura.Sifati ?? DBNull.Value),
                    new SqlParameter("@BILDIRIM_TURU", (object)tohalFatura.BildirimTuru ?? DBNull.Value),
                    new SqlParameter("@CARI_SIFATI", (object)tohalFatura.CariSifati ?? DBNull.Value),
                    new SqlParameter("@HAL_ID", (object)tohalFatura.HalId ?? DBNull.Value),
                    new SqlParameter("@TESLIMAT_YERI_ID", (object)tohalFatura.TeslimatYeriId ?? DBNull.Value),
                    new SqlParameter("@HKS_WEB_SIRA_NO", (object)tohalFatura.HksWebSiraNo ?? DBNull.Value),
                    new SqlParameter("@HKS_MALIN_NITELIGI", (object)tohalFatura.HksMalinNiteligi ?? DBNull.Value),
                    new SqlParameter("@ZAMAN", tohalFatura.Zaman),
                    new SqlParameter("@GIB_FIRMAMIZ_POSTA_KUTUSU_ID", (object)tohalFatura.GibFirmamizPostaKutusuId ?? DBNull.Value),
                    new SqlParameter("@GIB_MUHATAP_POSTA_KUTUSU_ID", (object)tohalFatura.GibMuhatapPostaKutusuId ?? DBNull.Value),
                    new SqlParameter("@ISKONTO_HESAPLANMASIN", (object)tohalFatura.IskontoHesaplanmasin ?? DBNull.Value),
                    new SqlParameter("@E_FATURA_NOT", (object)tohalFatura.EFaturaNot ?? DBNull.Value),
                    new SqlParameter("@E_FATURA_BOLGE_KODU", (object)tohalFatura.EFaturaBolgeKodu ?? DBNull.Value),
                    new SqlParameter("@E_FATURA_SIPARIS_NO", (object)tohalFatura.EFaturaSiparisNo ?? DBNull.Value),
                    new SqlParameter("@E_FATURA_SIPARIS_TARIHI", (object)tohalFatura.EFaturaSiparisTarihi ?? DBNull.Value),
                    new SqlParameter("@MAL_ISKONTO_TOPLAMI", tohalFatura.MalIskontoToplami),
                    new SqlParameter("@FIS_ID", (object)tohalFatura.FisId ?? DBNull.Value),
                    new SqlParameter("@BAGKUR_DOSYA_ID", (object)tohalFatura.BagkurDosyaId ?? DBNull.Value),
                    new SqlParameter("@GIB_FIRMAMIZ_IRSALIYE_KUTUSU_ID", (object)tohalFatura.GibFrmIrsaliyeKutusuId ?? DBNull.Value),
                    new SqlParameter("@GIB_MUHATAP_IRSALIYE_KUTUSU_ID", (object)tohalFatura.GibMuhatapIrsaliyeKutusuId ?? DBNull.Value),
                    new SqlParameter("@IHRACAT_PARA_BIRIMI_ID", (object)tohalFatura.IhracatParaBirimiId ?? DBNull.Value),
                    new SqlParameter("@IHRACAT_KURU", (object)tohalFatura.IhracatKuru ?? DBNull.Value),
                    new SqlParameter("@NAVLUN_MALIYETI", (object)tohalFatura.NavlunMaliyeti ?? DBNull.Value),
                    new SqlParameter("@SIGORTA_MALIYETI", (object)tohalFatura.SigortaMaliyeti ?? DBNull.Value),
                    new SqlParameter("@TESLIMAT_SEKLI_ID", (object)tohalFatura.TeslimatSekliId ?? DBNull.Value),
                    new SqlParameter("@ULASIM_SEKLI_ID", (object)tohalFatura.UlasimSekliId ?? DBNull.Value),
                    new SqlParameter("@ODEME_SEKLI_ID", (object)tohalFatura.OdemeSekliId ?? DBNull.Value),
                    new SqlParameter("@FIYAT_REFERANS_FATURA_ID", (object)tohalFatura.FiyatReferansFaturaId ?? DBNull.Value),
                    new SqlParameter("@ODEYEN_KURUMUN_VERGI_NOSU", (object)tohalFatura.OdeyenKurumunVergiNosu ?? DBNull.Value),
                    new SqlParameter("@ODEYEN_KURUMUN_VERGI_DAIRE_ID", (object)tohalFatura.OdeyenKurumunVergiDaireId ?? DBNull.Value),
                    new SqlParameter("@SOFOR_ID", (object)tohalFatura.SoforId ?? DBNull.Value),
                    new SqlParameter("@NAKIT_TAHSILAT", tohalFatura.NakitTahsilat),
                    new SqlParameter("@KREDI_KARTI_TAHSILATI", tohalFatura.KrediKartiTahsilati),
                    new SqlParameter("@POS_CIHAZI_ID", (object)tohalFatura.PosCihaziId ?? DBNull.Value),
                    new SqlParameter("@KESILDI", (object)tohalFatura.Kesildi ?? DBNull.Value),
                    new SqlParameter("@IADE_FATURASI", (object)tohalFatura.IadeFaturasi ?? DBNull.Value),
                    new SqlParameter("@E_FATURA_SENARYOSU", (object)tohalFatura.EFaturaSenaryosu ?? DBNull.Value),
         
                };

                try
                {
                    var surum = _context.TohalTanims.SingleOrDefault().Surum;
                    var additionalParameter = "";
                    if (surum != "2024.01.09")
                    {
                        additionalParameter = "@KDV_ISTISNA_KODU_ID,";
                        parameters.Add(new SqlParameter("@KDV_ISTISNA_KODU_ID", SqlDbType.Int) { Value = DBNull.Value });
                        parameters.Add(new SqlParameter("@YENI_KAYIT", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        });
                        parameters.Add(new SqlParameter("@UYARI_MESAJI", SqlDbType.VarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        });
                    }
                    else
                    {   parameters.Add(new SqlParameter("@YENI_KAYIT", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        });
                        parameters.Add(new SqlParameter("@UYARI_MESAJI", SqlDbType.VarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        });

                    }
                    
                    await _context.Database.ExecuteSqlCommandAsync(
                        "EXEC SOHAL_FATURA_KAYDET " +
                        "@FATURA_ID OUTPUT, @CARI_KART_ID, @TIP, @TARIH, @FATURA_NO, @IRSALIYE_NO, @UNVAN, " +
                        "@YER_ID, @ADRES, @KISILIK_TIPI, @VERGI_DAIRESI_ID, @VERGI_KIMLIK_NO, @RUSUM, " +
                        "@RUSUM_KDV_ORANI, @RUSUM_KDV, @ISKONTO_ORANI, @ISKONTO, @KDVSIZE_IADESIZ_KAP, " +
                        "@KDVLI_IADESIZ_KAP, @IADESIZ_KAP_KDV_ORANI, @IADESIZ_KAP_KDV, @REHIN_IADELI_KAP, " +
                        "@YUKLEME, @YUKLEME_KDV_ORANI, @YUKLEME_KDV, @NAKLIYE, @NAKLIYE_KDV_ORANI, " +
                        "@NAKLIYE_KDV, @VADE, @MAGAZA_ID, @IRSALIYE_ZAMANI, @SIPARIS_ID, @KULLANICI_ID, " +
                        "@DEGISTIRILDI, @IHRACATCI, @PLAKA_NO, @RUSUM_KDV_ILISKISI, @FATURA_GUID, @GUID, " +
                        "@GUNCELLEME_ZAMANI, @GUNCELLEME_ZORUNLU, @GSM_NO, @EPOSTA, @GIDECEGI_YER_TIPI, " +
                        "@DEGISIKLIK_TAKIP_VAR, @SIFATI, @BILDIRIM_TURU, @CARI_SIFATI, @HAL_ID, " +
                        "@TESLIMAT_YERI_ID, @HKS_WEB_SIRA_NO, @HKS_MALIN_NITELIGI, @ZAMAN, " +
                        "@GIB_FIRMAMIZ_POSTA_KUTUSU_ID, @GIB_MUHATAP_POSTA_KUTUSU_ID, @ISKONTO_HESAPLANMASIN, " +
                        "@E_FATURA_NOT, @E_FATURA_BOLGE_KODU, @E_FATURA_SIPARIS_NO, @E_FATURA_SIPARIS_TARIHI, " +
                        "@MAL_ISKONTO_TOPLAMI, @FIS_ID, @BAGKUR_DOSYA_ID, @GIB_FIRMAMIZ_IRSALIYE_KUTUSU_ID, " +
                        "@GIB_MUHATAP_IRSALIYE_KUTUSU_ID, @IHRACAT_PARA_BIRIMI_ID, @IHRACAT_KURU, " +
                        "@NAVLUN_MALIYETI, @SIGORTA_MALIYETI, @TESLIMAT_SEKLI_ID, @ULASIM_SEKLI_ID, " +
                        "@ODEME_SEKLI_ID, @FIYAT_REFERANS_FATURA_ID, @ODEYEN_KURUMUN_VERGI_NOSU, " +
                        "@ODEYEN_KURUMUN_VERGI_DAIRE_ID, @SOFOR_ID, @NAKIT_TAHSILAT, @KREDI_KARTI_TAHSILATI, " +
                        "@POS_CIHAZI_ID, @KESILDI, @IADE_FATURASI, @E_FATURA_SENARYOSU," + additionalParameter + "@YENI_KAYIT OUTPUT, @UYARI_MESAJI OUTPUT",
                        parameters.ToArray());
                }
                catch (Exception)
                {
                    await RemoveIskele();
                    int faturaId1 = (int)parameters[0].Value;
                    string uyarıMesaji1 = parameters[parameters.Count - 1].Value.ToString();
                    return Json(new { error = false, message = "Fatura Kaydedilemedi" }, JsonRequestBehavior.DenyGet);
                }


                int faturaId = (int)parameters[0].Value;
                string uyarıMesaji = parameters[parameters.Count - 1].Value.ToString();
                var noVersiyeFat = _context.TohalFaturas.Where(x => x.FaturaId == faturaId).SingleOrDefault();
                #endregion

                if (uyarıMesaji.Length > 0)
                {
                    //hata mesajı
                }
                else
                {
                    #region FATURA KDV HESAPLAMA

                    // Tüm TohalIskeleFaturaSatiri verilerini çek
                    List<VohalFaturaSatiriUrt> faturaSatirlari = _context.VohalFaturaSatiriUrts.Where(x => x.FaturaId == faturaId).ToList();
                    //Satırlardaki tutar üzerinden kdv hesapla ve toplamı bul
                    double toplam = 0;
                    double kdv = 0;
                    foreach (var item in faturaSatirlari)
                    {
                        kdv += (item.Tutar - item.Iskonto ) * item.KdvOrani / 100;
                        toplam += item.Tutar;
                    }

                    //Eğer TohalEvrakKdvs tablosunda faturaId varsa güncelle yoksa ekle
                    if (_context.TohalEvrakKdvs.Where(x => x.FaturaId == faturaId).Count() == 0)
                    {
                        _context.TohalEvrakKdvs.Add(new TohalEvrakKdv
                        {
                            FaturaId = faturaId,
                            Matrah = (double)toplam,
                            Kdv = kdv
                        });
                    }
                    else
                    {
                        var evrak = _context.TohalEvrakKdvs.Where(x => x.FaturaId == faturaId).FirstOrDefault();
                        evrak.Matrah = (double)toplam;
                        evrak.Kdv = (double)kdv;
                        _context.Entry(evrak).State = EntityState.Modified;
                    }

                    _context.SaveChanges();
                    #endregion

                    if (kesildiBut)
                    {
                        #region FATURA KESİLDİ
                        try
                        {

                            var parametersVer = new List<SqlParameter>
                                {
                                    new SqlParameter("@FATURA_ID", (object)faturaId ?? DBNull.Value),
                                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                                    new SqlParameter("@KESILDI", true),
                                };

                            await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_FATURA_KESILDI @FATURA_ID, @KULLANICI_ID, @KESILDI", parametersVer.ToArray());

                        }

                        catch (Exception)
                        {

                            return Json(new { success = false, message = "Fatura Kesilemedi" }, JsonRequestBehavior.DenyGet);
                        }
                        #endregion

                     
                        if (tohalFatura.GibFirmamizPostaKutusuId != null
                            && tohalFatura.GibFirmamizPostaKutusuId != 0)
                        {
                            #region E-BELGE NUMERATOR
                            try
                            {
                                var ebelgetur = tohalFatura.GibMuhatapPostaKutusuId != null ? 0 : 1;
                                if (!irsaliyeBut)
                                {
                                    if (ebelgetur == 1)
                                    {
                                        var gibKul = _context.TohalGibKullanicis.FirstOrDefault(x => x.Vkn == tohalFatura.VergiKimlikNo);
                                        if (gibKul != null)
                                        {
                                            ebelgetur = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    ebelgetur = 3;
                                }
                  

                                var parameterseNum = new List<SqlParameter>
                            {
                                new SqlParameter("@FATURA_ID", (object)faturaId ?? DBNull.Value),
                                new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                                new SqlParameter("@EVRAK_TURU", SqlDbType.Int) { Value = 0 },
                                new SqlParameter("@E_BELGE_TURU", SqlDbType.Int) { Value = ebelgetur },
                                new SqlParameter("@URET", SqlDbType.Bit) { Value = true },
                                new SqlParameter("@FATURA_NO", SqlDbType.Char,20)
                                {
                                    Direction = ParameterDirection.Output
                                }
                            };

                                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_E_BELGE_NO_URET @FATURA_ID, @KULLANICI_ID, @EVRAK_TURU, @E_BELGE_TURU,@URET,@FATURA_NO OUTPUT", parameterseNum.ToArray());

                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine("Hata Oluştu: " + ex.Message);
                            }

                            #endregion

                        }
                        else
                        {
                            #region FATURA NUMERATOR
                            try
                            {
                                if (String.IsNullOrEmpty(tohalFatura.FaturaNo))
                                {

                                    var parametersNum = new List<SqlParameter>
                            {

                                new SqlParameter("@TUR", SqlDbType.TinyInt) { Value = 1 },
                                new SqlParameter("@SOYLENECEK_NO", SqlDbType.Char,20)
                                {
                                    Direction = ParameterDirection.Output
                                },
                                new SqlParameter("@SAYFA_SAYISI", SqlDbType.TinyInt) { Value = 1 },
                            };

                                    await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_NUMERATOR_URET @TUR, @SOYLENECEK_NO OUTPUT, @SAYFA_SAYISI", parametersNum.ToArray());

                                    var noNumFat = _context.TohalFaturas.Where(x => x.FaturaId == faturaId).SingleOrDefault();
                                    noNumFat.FaturaNo = parametersNum[1].Value.ToString();
                                    _context.Entry(noNumFat).State = EntityState.Modified;
                                    _context.SaveChanges();
                                }
                            }
                            catch (Exception ex)
                            {

                                // Hata iletisini konsola yazdırabilir veya başka bir şekilde kaydedebilirsiniz.
                                Console.WriteLine("Hata Oluştu: " + ex.Message);
                            }

                            #endregion

                        }

                    }

                    #region VERESİYE KAYDETME
                    try
                    {
                        



                        if (noVersiyeFat.Veresiye != tohalFatura.Veresiye && tohalFatura.Veresiye != null)
                        {
                            var parametersVer = new List<SqlParameter>
                            {
                                new SqlParameter("@FATURA_ID", (object)faturaId ?? DBNull.Value),
                                new SqlParameter("@NAKIT_TAHSILAT", (object)tohalFatura.NakitTahsilat ?? DBNull.Value),
                                new SqlParameter("@KREDI_KARTI_TAHSILATI", (object)tohalFatura.KrediKartiTahsilati ?? DBNull.Value),
                                new SqlParameter("@POS_CIHAZI_ID", DBNull.Value),
                                new SqlParameter("@VERESIYE", (object)tohalFatura.Veresiye ?? DBNull.Value),
                                new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                                new SqlParameter("@DEGISIKLIK_TAKIP_VAR", false),
                                new SqlParameter("@VERESIYE_DURUMU_DEGISTI", 1)
                            };

                            await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_VERESIYE_KAYDET @FATURA_ID, @NAKIT_TAHSILAT, @KREDI_KARTI_TAHSILATI, @POS_CIHAZI_ID, @VERESIYE, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @VERESIYE_DURUMU_DEGISTI", parametersVer.ToArray());

                        }
                        else
                        {
                            var parametersVer = new List<SqlParameter>
                            {
                                new SqlParameter("@FATURA_ID", (object)faturaId ?? DBNull.Value),
                                new SqlParameter("@NAKIT_TAHSILAT", (object)tohalFatura.NakitTahsilat ?? DBNull.Value),
                                new SqlParameter("@KREDI_KARTI_TAHSILATI", (object)tohalFatura.KrediKartiTahsilati ?? DBNull.Value),
                                new SqlParameter("@POS_CIHAZI_ID", DBNull.Value),
                                new SqlParameter("@VERESIYE", (object)tohalFatura.Veresiye ?? DBNull.Value),
                                new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                                new SqlParameter("@DEGISIKLIK_TAKIP_VAR", false),
                                new SqlParameter("@VERESIYE_DURUMU_DEGISTI", false)
                            };

                            await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_VERESIYE_KAYDET @FATURA_ID, @NAKIT_TAHSILAT, @KREDI_KARTI_TAHSILATI, @POS_CIHAZI_ID, @VERESIYE, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @VERESIYE_DURUMU_DEGISTI", parametersVer.ToArray());

                        }
                    }
                    catch (Exception ex)
                    {

                        // Hata iletisini konsola yazdırabilir veya başka bir şekilde kaydedebilirsiniz.
                        Console.WriteLine("Hata Oluştu: " + ex.Message);
                    }
                    #endregion
                }

             
                try
                {

                    // İşlem başarılı olduysa iskeledeki tüm satırları sil
                    //_context.TohalIskeleFaturaSatiris.RemoveRange(iskeleFaturaSatirlari);

                    // Veritabanına silme işlemini kaydet
                    await _context.SaveChangesAsync();
                    await RemoveIskele();
                    // İşlem başarıyla tamamlandı
                    return Json(new { success = true, message = "Başarıyla eklendi", faturaId = faturaId }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    await RemoveIskele();
                    return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}", faturaId = faturaId }, JsonRequestBehavior.AllowGet);
                }

            }
            await RemoveIskele();
            return View(tohalFatura);
        }


        private bool TohalFaturaExists(int id)
        {
            return _context.TohalFaturas.Any(e => e.FaturaId == id);
        }

        [HttpPost]
        public ActionResult HksIstekKunye(bool saklananlariSil, int kunyeTuru, DateTime ilkTarihKunye, DateTime sonTarihKunye)
        {
            if (saklananlariSil)
            {
                _context.Database.ExecuteSqlCommand("TRUNCATE TABLE TOHKS_KAYITLI_KUNYE_LISTESI");
                _context.SaveChanges();
            }
            var kayitliKunyeler1 = _hksService.BildirimcininYaptigiBildirimler(kunyeTuru, 0, ilkTarihKunye, sonTarihKunye, "", true, null);
            var kayitliKunyeler2 = _hksService.BildirimciyeYapilaniBildirimler(kunyeTuru, 0, ilkTarihKunye, sonTarihKunye, "", true, null);

            var kayitliKunyeler = kayitliKunyeler1.Concat(kayitliKunyeler2);

            //kayitliKunyeleri TOHKS_KAYITLI_KUNYE_LISTESI tablosuna kaydet
            foreach (var item in kayitliKunyeler)
            {
                // item.MalinKodNo ile malId çek
                var malId = _context.VohalHksMals.Where(x => x.MalCinsiHksId == item.MalinCinsKodNo).FirstOrDefault().MalAdiId;

                //item.KunyeNo ile kunye çek
                var kunyeId = _context.TohalKunyes
                            .Where(x => x.Kod == item.KunyeNo.ToString())
                            .SingleOrDefault()?.KunyeId;
                var kunye = new TohksKayitliKunyeListesi
                {

                    IslemeAlinmaZamani = DateTime.Today,
                    Tip =0,
                    BildirimciVergiNo = item.BildirimciTcKimlikVergiNo,
                    BildirimTuru = item.BildirimTuru,
                    BildirimTarihi = item.BildirimTarihi,
                    MalinSahibiVergiNo = item.MalinSahibiTcKimlikVergiNo,
                    UreticiVergiNo = item.UreticiTcKimlikVergiNo,
                    KalanMiktar = item.KalanMiktar,
                    KunyeNo = item.KunyeNo.ToString(),
                    MalinKodNo = item.MalinKodNo,
                    MalinAdi = item.MalinAdi,
                    MalinCinsKodNo = item.MalinCinsKodNo,
                    MalinCinsi = item.MalinCinsi,
                    MalinMiktari = item.MalinMiktari,
                    MalinSatisFiyati = item.MalinSatisFiyati,
                    MalinTuruKodNo = item.MalinTuruKodNo,
                    MalinTuru = item.MalinTuru,
                    MiktarBirimId = item.MiktarBirimId,
                    MiktarBirimiAd = item.MiktarBirimiAd,
                    RusumMiktari = item.RusumMiktari,
                    MalId = malId,
                    GidecekIsyeriId = item.GidecekIsyeriId,
                    KunyeId = kunyeId,
                    PlakaNo = item.AracPlakaNo,
                    Sifat = Convert.ToByte(item.Sifat),
                    BelgeNo = item.BelgeNo
                };
                //eğer "kunye.KunyeNo" TohksKayitliKunyeListesis tablosunda mevcut değilse kaydet
                if (_context.TohksKayitliKunyeListesis.Where(x => x.KunyeNo == kunye.KunyeNo && x.Tip == 0).SingleOrDefault() == null)
                {
                    _context.TohksKayitliKunyeListesis.Add(kunye);
                    _context.SaveChanges();
                }
            }
                sonTarihKunye = sonTarihKunye.AddDays(1);


                var kunyeler = _context.VohksHksKayitliKunyeBilgileris
                  .Where(x => x.Tip == 0
                            && x.BildirimTarihi >= ilkTarihKunye
                            && x.BildirimTarihi <= sonTarihKunye)
                  .ToList()
                  .GroupBy(x => x.KunyeNo) // Group by KunyeNo
                  .Select(g => g.First()) // Select the first item from each group (unique KunyeNo)
                  .Select(x => new
                  {
                      KunyeId = x.KunyeId,
                      Tip = x.Tip,
                      BildirimTarihi = x.BildirimTarihi.HasValue ? x.BildirimTarihi.Value.ToString("dd.MM.yyyy") : null,
                      KunyeNo = x.KunyeNo,
                      MalinCinsKodNo = x.MalinCinsKodNo,
                      HksMalinAdi = x.HksMalinAdi,
                      MalinCinsi = x.MalinCinsi,
                      KapKalanMiktar = x.KapKalanMiktar,
                      KiloKalanMiktar = x.KiloKalanMiktar,
                      MalinSatisFiyati = x.MalinSatisFiyati,
                      MalinSahibiVergiNo = x.MalinSahibiVergiNo,
                      MalinSahibiAdi = x.MalinSahibiAdi,
                      UreticiAdi = x.UreticiAdi,
                      TeslimatYeri = x.TeslimatYeri,
                      PlakaNo = x.PlakaNo,
                      BelgeNo = x.BelgeNo,
                      Sifat = x.Sifat,
                      MalinMiktari = x.MalinMiktari,
                      RusumMiktari = x.RusumMiktari,
                      MalId = x.MalId
                  })
                  .ToList();

            return Json(new { success = true, message = "İşlem Başarılı", data = kunyeler, oncekileriSil = saklananlariSil }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SatisFaturasiKunyeAl(string belgeNo, int faturaId, byte sifat)
        {

            List<BildirimKayitCevap> result2, result3;
            if (sifat == ((byte)Sifat.Komisyoncu))
            {
                result2 = _hksService.SatisStokBildirimKaydet(faturaId);
                result3 = _hksService.BildirimKaydet(faturaId, false);
                if (result3.Count > 0)
                {
                    return Json(new { success = true, message = result2, faturaId = faturaId }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "İşlem başarısız!", faturaId = faturaId }, JsonRequestBehavior.AllowGet);

                }
            }
            else
            {

                result2 = _hksService.BildirimKaydet(faturaId, true);

                result3 = _hksService.BildirimKaydet(faturaId, false);

                if (result3.Count > 0)
                {
                    return Json(new { success = true, message = result3, message0 = result2 }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "İşlem başarısız!" }, JsonRequestBehavior.AllowGet);

                }
            }
        }
        public async Task<ActionResult> Delete(int faturaid, int kullaniciId)
        {
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@FATURA_ID", SqlDbType.Int){Value = faturaid},
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int){Value = kullaniciId},
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Int){Value = kullaniciId},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_FATURA_SIL @FATURA_ID, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR", parameters.ToArray());
                TempData["SuccessMessage"] = "Fatura Silindi";
                return RedirectToAction(nameof(Index));
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "Fatura Silinemedi" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Index), new { faturaId = faturaid });
            }
        }

        [HttpGet]
        public async Task<ActionResult> FaturaDetay(int id)
        {
            var fatura = await _context.VohalFaturas.FirstOrDefaultAsync(x => x.FaturaId == id);
            return View(fatura);
        }
        [HttpPost]
        public ActionResult FaturaDetay(VohalFatura model)
        {
            return RedirectToAction("Index", new { faturaId = model.FaturaId });
        }

        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.VohalAramaFaturas.Where(x => x.Tip == 1).FirstOrDefault() : _context.VohalAramaFaturas.Where(x => x.Tip == 1).OrderByDescending(x => x.FaturaId).FirstOrDefault();
            return RedirectToAction("Index", new { faturaId = val?.FaturaId });
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.VohalAramaFaturas.Where(x => x.Tip == 1 && x.FaturaId > currentId).FirstOrDefault() : _context.VohalAramaFaturas.OrderByDescending(x => x.FaturaId).Where(x => x.Tip == 1 && x.FaturaId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("Index", new { id = val?.FaturaId });
        }

        public async Task<string> BakiyeSoyleAsync(int id)
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
            return bakiye;
        }

        public async Task RemoveIskele()
        {
            _context.TohalIskeleFaturaSatiris.RemoveRange(_context.TohalIskeleFaturaSatiris);
            _context.TohalIskeleRehinFisis.RemoveRange(_context.TohalIskeleRehinFisis);
            await _context.SaveChangesAsync();
        }
        public ActionResult KunyelerGetir(int teslimatYerId)
        {
            var data = new List<VohksHksKayitliKunyeBilgileri>();
            ViewData["TeslimatYerKunye"] = new SelectList(_context.TohalTeslimatYeris, "TeslimatYeriId", "Ad", teslimatYerId);
            return PartialView("~/Views/TohalFaturas/Partials/_kunyeModal.cshtml", data);

        }

        public ActionResult HksHatalariGetir()
        {
            var data = _context.CevapTablosus.ToList();
            return PartialView("~/Views/Shared/_HataliHksModal.cshtml", data);

        }

        public ActionResult DeleteAllItems()
        {
            try
            {
                _context.CevapTablosus.RemoveRange(_context.CevapTablosus);
                _context.SaveChanges();
                return Json(new { success = true, message = "İşlem Başarılı" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { success = false, message = "İşlem başarısız!" }, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public async Task<ActionResult> SatisKunyeSakla(List<string> kunyeNoList)
        {
            try { 
            _context.TohksIskeleKunyeListesis.RemoveRange(_context.TohksIskeleKunyeListesis);
            var guid = Guid.NewGuid();
            foreach(var item in kunyeNoList)
            {
                var kunyedb = _context.VohksHksKayitliKunyeBilgileris.Where(x => x.KunyeNo == item).FirstOrDefault();
                var kunye = new TohksIskeleKunyeListesi
                {
                    Guid = guid,
                    Tarih = DateTime.Now,
                    GirisTarihi = kunyedb.BildirimTarihi,
                    Kunye = kunyedb.KunyeNo,
                    MalId = kunyedb.MalId,
                    KapMiktar = kunyedb.KapKalanMiktar,
                    KiloMiktar = kunyedb.KiloKalanMiktar,
                    Fiyat = kunyedb.MalinSatisFiyati,
                    CariKartId = kunyedb.UreticiId,
                    PlakaNo = kunyedb.PlakaNo,
                    Sifat = kunyedb.Sifat,
                    TeslimatYeriId = kunyedb.TeslimatYeriId,
                    BelgeNo = ""

                };
                    _context.TohksIskeleKunyeListesis.Add(kunye);
            }
                _context.SaveChanges();

               

                var parametersVer = new List<SqlParameter>
                {
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                    new SqlParameter("@GUID", SqlDbType.UniqueIdentifier) { Value = guid },
                    new SqlParameter("@ONCEKI_KAYDEDILENLERI_SIL", SqlDbType.Bit) { Value = 1 },
                };

                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_HKS_KUNYELERI_SATIS_ICIN_KAYDET @KULLANICI_ID, @GUID, @ONCEKI_KAYDEDILENLERI_SIL", parametersVer.ToArray());


                return Json(new { success = true, message = "İşlem Başarılı" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                _context.TohksIskeleKunyeListesis.RemoveRange(_context.TohksIskeleKunyeListesis);
                return Json(new { success = false, message = "İşlem başarısız!" }, JsonRequestBehavior.AllowGet);
            }
        }

        public int HksBilgiAl(int cariKartId, string tckn)
        {

            //var test = _hksService.SifatListesi().ToList();
            //var testx = _hksService.IsletmeTurleri().ToList();

            TohalMagaza teslimatYeri = new TohalMagaza();
            var model = _context.TohalCariKarts.Where(x => x.CariKartId == cariKartId).FirstOrDefault();
            var kayitlikisi = _hksService.KayitliKisiler(new List<string> { tckn }).FirstOrDefault();
            if (kayitlikisi.KayitliKisiMi)
            {
                List<int> sifatlar = kayitlikisi.Sifatlari.ToList();
                TohalCariSifat yeniSifat;

                if (sifatlar != null && sifatlar.Any())
                {
                    foreach (int sifatId in sifatlar)
                    {
                        yeniSifat = new TohalCariSifat();
                        yeniSifat.CariKartId = cariKartId;
                        yeniSifat.Sifat = (byte)sifatId;
                        if (!_context.TohalCariSifats.Any(s => s.CariKartId == cariKartId && s.Sifat == sifatId))
                        {
                            _context.TohalCariSifats.Add(yeniSifat);
                        }
                    }
                    _context.SaveChanges();
                }


              

                IEnumerable<SubeDTO> subeler = _hksService.Subeler(tckn);

                if (subeler != null && subeler.Any())
                {
                    foreach (var sube in subeler)
                    {
                        teslimatYeri = new TohalMagaza();
                        teslimatYeri.CariKartId = cariKartId;
                        teslimatYeri.GidecegiYer = (byte?)sube.IsyeriTuru;
                        teslimatYeri.Ad = sube.SubeAdi;
                        teslimatYeri.HksId = sube.Id;
                        teslimatYeri.Adres = sube.Adres;
                        teslimatYeri.Kod = "K" + cariKartId + sube.IsyeriTuru.ToString();

                        if (!_context.TohalMagazas.Any(s => s.HksId == sube.Id))
                        {
                            _context.TohalMagazas.Add(teslimatYeri);
                        }
                    }
                    _context.SaveChanges();
                }

                IEnumerable<HalIciIsyeriDTO> haliciisyerleri = _hksService.HalIciIsyerleri(tckn);

                if (haliciisyerleri != null && haliciisyerleri.Any())
                {
                    foreach (var haliciisyeri in haliciisyerleri)
                    {
                        teslimatYeri = new TohalMagaza();
                        teslimatYeri.CariKartId = cariKartId;
                        teslimatYeri.GidecegiYer = 7;
                        teslimatYeri.Ad = haliciisyeri.IsyeriAdi;
                        teslimatYeri.HksId = haliciisyeri.Id;
                        teslimatYeri.Adres = haliciisyeri.HalAdi;
                        teslimatYeri.Kod = "K" + cariKartId + haliciisyeri.Id.ToString();
                        if (!_context.TohalMagazas.Any(s => s.HksId == haliciisyeri.Id))
                        {
                            _context.TohalMagazas.Add(teslimatYeri);
                        }
                    }
                    _context.SaveChanges();
                }

                IEnumerable<DepoDTO> depolar = _hksService.Depolar(tckn);

                if (depolar != null && depolar.Any())
                {
                    foreach (var depo in depolar)
                    {
                        teslimatYeri = new TohalMagaza();
                        teslimatYeri.CariKartId = cariKartId;
                        teslimatYeri.GidecegiYer = (byte)(depo.Halicimi ? 5 : 6);
                        teslimatYeri.Ad = depo.DepoAdi;
                        teslimatYeri.HksId = depo.Id;
                        teslimatYeri.Adres = depo.Adres;
                        teslimatYeri.Kod = "K" + cariKartId + depo.Id.ToString();
                        if (!_context.TohalMagazas.Any(s => s.HksId == depo.Id))
                        {
                            _context.TohalMagazas.Add(teslimatYeri);
                        }
                    }
                    _context.SaveChanges();

                }


                model.HksBilgisiAlindi = true;
                _context.Entry(model).State = EntityState.Modified;
                _context.SaveChanges();

            }
            else
            {
                model.HksBilgisiAlindi = true;
                _context.Entry(model).State = EntityState.Modified;
                _context.SaveChanges();
                TempData["ErrorMessage"] = "Kişi HKS Sistemine Kayıtlı Değil";
            }
            //TODO:Magaza yoksa hata veriyor
            var magazaId =_context.TohalMagazas.Where(x => x.CariKartId == cariKartId).FirstOrDefault().MagazaId;
            return magazaId;
        }


    }
}
