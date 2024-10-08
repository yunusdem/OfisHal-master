using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using OfisHal.Services;
using OfisHal.Web.Models;
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

    public class CekSenetIslemleriController : BaseController
    {
        private readonly Db _context;
        private readonly IHksService _hksService;
        public CekSenetIslemleriController(Db context, IHksService hksService)
        {
            _context = context;
            _hksService = hksService;
        }
        // Çek Senet İşlemleri > Tahsilat
        public ActionResult Tahsilat(int faturaId = 0, bool yeni = false)
        {

            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<VohalObSatiri>();
                ViewData["faturaModel2"] = new List<VohalObSatiri>();
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
        // Çek Senet İşlemleri > Ödeme

        [HttpPost]
        public async Task<JsonResult> CreateFaturaSatir(List<TohalIskeleObSatiri> tohalIskeleFaturaSatirlari)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (tohalIskeleFaturaSatirlari == null)
                    {
                        tohalIskeleFaturaSatirlari = new List<TohalIskeleObSatiri>();
                    }
                    TohalOdemeAraci odemeAraci;
                    foreach (var tohalIskeleFaturaSatiri in tohalIskeleFaturaSatirlari)
                    {
                        odemeAraci = new TohalOdemeAraci();
                        if (tohalIskeleFaturaSatiri.Guid == Guid.Empty)
                        {
                            tohalIskeleFaturaSatiri.Guid = Guid.NewGuid();

                        }
                        //var oaraciItem = _context.TohalOdemeAracis.Where(x => x.OdemeAraciNo == tohalIskeleFaturaSatiri.OdemeAraciNo).FirstOrDefault();

                        //if(oaraciItem == null) { 
                        //odemeAraci.VadeTarihi = tohalIskeleFaturaSatiri.VadeTarihi ?? DateTime.Now;
                        //odemeAraci.BankaHesabiId = tohalIskeleFaturaSatiri.BankaHesabiId == 0 ? null : tohalIskeleFaturaSatiri.BankaHesabiId;
                        //odemeAraci.BankaId = tohalIskeleFaturaSatiri.BankaId == 0 ? null : tohalIskeleFaturaSatiri.BankaId;
                        //odemeAraci.Tur = tohalIskeleFaturaSatiri.OdemeAraciTuru ?? 0;
                        //odemeAraci.Meblag = tohalIskeleFaturaSatiri.Meblag ?? 0;
                        //odemeAraci.OdemeAraciNo = tohalIskeleFaturaSatiri.OdemeAraciNo;
                        //_context.TohalOdemeAracis.Add(odemeAraci);
                        //_context.SaveChanges();
                        //}
                        tohalIskeleFaturaSatiri.OdemeAraciId = tohalIskeleFaturaSatiri.OdemeAraciId == 0 ? null : tohalIskeleFaturaSatiri.OdemeAraciId;
                        tohalIskeleFaturaSatiri.OdemeAraciSahibi = tohalIskeleFaturaSatiri.OdemeAraciSahibi ?? false;
                        tohalIskeleFaturaSatiri.OdemeAraciTuru = tohalIskeleFaturaSatiri.OdemeAraciTuru;

                        _context.TohalIskeleObSatiris.Add(tohalIskeleFaturaSatiri);

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

        public async Task RemoveIskele()
        {
            _context.TohalIskeleObSatiris.RemoveRange(_context.TohalIskeleObSatiris);
            await _context.SaveChangesAsync();
        }


        [HttpPost]
        public async Task<ActionResult> SaveFatura([Bind(Include = "OdemeBordrosuId,CariKartId,IslemTuru,BordroNo,Tarih,Aciklama,EkleyenId,Devir,EklemeZamani,GuncelleyenId,GuncellemeZamani,BankaHesabiId")] TohalOdemeBordrosu tohalFatura)
        {
   
            if (ModelState.IsValid)
            {
                #region Fatura Kaydetme

                var guid = Guid.NewGuid();
                try
                {
                    _context.TohalIskeleObSatiris.ToList().ForEach(x =>
                    {
                        x.Guid = guid;
                        _context.Entry(x).State = EntityState.Modified;
                    });
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    await RemoveIskele();
                    return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);

                }
             
                if(tohalFatura.Tarih == DateTime.MinValue)
                {
                    tohalFatura.Tarih = DateTime.Today;
                }
                var parameters = new List<SqlParameter>();

                if(tohalFatura.OdemeBordrosuId == 0)
                {
                    parameters.Add(new SqlParameter("@ODEME_BORDROSU_ID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                }
                else
                {
                    parameters.Add(new SqlParameter("@ODEME_BORDROSU_ID", SqlDbType.Int)
                    {
                        Value = tohalFatura.OdemeBordrosuId,
                        Direction = ParameterDirection.InputOutput
                    });
                }

                parameters.Add(new SqlParameter("@CARI_KART_ID", (object)tohalFatura.CariKartId ?? DBNull.Value));
                parameters.Add(new SqlParameter("@BANKA_HESABI_ID", (object)tohalFatura.BankaHesabiId ?? DBNull.Value));
                parameters.Add(new SqlParameter("@ISLEM_TURU", (object)tohalFatura.IslemTuru ?? 0));
                parameters.Add(new SqlParameter("@BORDRO_NO", (object)tohalFatura.BordroNo ?? DBNull.Value));
                parameters.Add(new SqlParameter("@TARIH", tohalFatura.Tarih));
                parameters.Add(new SqlParameter("@ACIKLAMA", (object)tohalFatura.Aciklama ?? DBNull.Value));
                parameters.Add(new SqlParameter("@DEVIR", SqlDbType.Bit) { Value = 0 });
                parameters.Add(new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Bit) { Value = 0 });
                parameters.Add(new SqlParameter("@KULLANICI_ID", SqlDbType.Int){ Value = 1 });
                parameters.Add(new SqlParameter("@GUID", SqlDbType.UniqueIdentifier) { Value = guid });

                try
                {
                    await _context.Database.ExecuteSqlCommandAsync(
                     "EXEC SOHAL_ODEME_BORDROSU_KAYDET " +
                     "@ODEME_BORDROSU_ID OUTPUT, @CARI_KART_ID, @BANKA_HESABI_ID, @ISLEM_TURU, " +
                     "@BORDRO_NO, @TARIH, @ACIKLAMA, @DEVIR, @DEGISIKLIK_TAKIP_VAR, @KULLANICI_ID, @GUID",
                     parameters.ToArray());
                }
                catch
                {
                    await RemoveIskele();
                    return Json(new { error = false, message = "Kayıt eklenemedi" }, JsonRequestBehavior.DenyGet);
                }
                int faturaId = (int)parameters[0].Value;
                #endregion


                try
                {             
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

        public ActionResult Odeme(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<VohalObSatiri>();
                ViewData["faturaModel2"] = new List<VohalObSatiri>();
                ViewData["faturaModel3"] = new List<VohalObSatiri>();
                ViewData["faturaModel4"] = new List<VohalObSatiri>();
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
                    ViewData["faturaModel3"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 2).ToList();
                    ViewData["faturaModel4"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 3).ToList();
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();

        }
        // Çek Senet İşlemleri > Karşılıksız Portföye İade
        public ActionResult KarsiliksizPortfoyeIade(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<VohalObSatiri>();
                ViewData["faturaModel2"] = new List<VohalObSatiri>();
                ViewData["faturaModel3"] = new List<VohalObSatiri>();
                ViewData["faturaModel4"] = new List<VohalObSatiri>();
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
                    ViewData["faturaModel3"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 1).ToList();
                    ViewData["faturaModel4"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 1).ToList();
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();

        }
        // Çek Senet İşlemleri > Portföye İade
        public ActionResult PortfoyeIade(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<VohalObSatiri>();
                ViewData["faturaModel2"] = new List<VohalObSatiri>();
                ViewData["faturaModel3"] = new List<VohalObSatiri>();
                ViewData["faturaModel4"] = new List<VohalObSatiri>();
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
                    ViewData["faturaModel3"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 1).ToList();
                    ViewData["faturaModel4"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 1).ToList();
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();

        }
        // Çek Senet İşlemleri > Elden Tahsil
        public ActionResult EldenTahsil(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<VohalObSatiri>();
                ViewData["faturaModel2"] = new List<VohalObSatiri>();
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
        // Çek Senet İşlemleri > İade
        public ActionResult Iade(int faturaId = 0, bool yeni = false)
        {

            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {

                ViewData["faturaModel"] = new List<VohalObSatiri>();
                ViewData["faturaModel2"] = new List<VohalObSatiri>();
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
        // Çek Senet İşlemleri > Firma çek - senet elden ödeme
        public ActionResult FirmaCekEldenOdeme(int faturaId = 0, bool yeni = false)
        {
            var tanim = _context.TohalTanims.FirstOrDefault();

            if (faturaId == 0)
            {
   
                ViewData["faturaModel3"] = new List<VohalObSatiri>();
                ViewData["faturaModel4"] = new List<VohalObSatiri>();
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
                    ViewData["faturaModel4"] = _context.VohalObSatiris.Where(y => y.OdemeBordrosuId == currentFatura.OdemeBordrosuId && y.OdemeAraciTuru == 3).ToList();
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
