using Elmah.ContentSyndication;
using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using OfisHal.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class DokumIslemleriController : BaseController
    {
        private readonly Db _context;
        private readonly IHksService _hksService;
        private readonly IInvoiceService _invoiceService;

        public DokumIslemleriController(Db context, IHksService hksService, IInvoiceService invoiceService)
        {
            _context = context;
            _hksService = hksService;
            _invoiceService = invoiceService;
        }
        public ActionResult Stok(int faturaId = 0, bool yeni = false)
        {


            ViewData["tanimSifati"] = _context.TohalTanims.FirstOrDefault().DigSifati;
            ViewData["tanimBildirimTuru"] = _context.TohalTanims.FirstOrDefault().DokBildirimTuru;
            if (faturaId == 0)
            {

                var faturaList = _context.VohalMakbuzs.OrderByDescending(x => x.MakbuzId)
                                      .Take(2)
                                      .ToList();

                if (faturaList.Count == 0 && !yeni)
                {
                    return RedirectToAction("Stok", new { yeni = true });
                }
                VohalMakbuz model = new VohalMakbuz();
                VohalMakbuz prevModel = new VohalMakbuz();
                if (yeni)
                {
                    model.StokGirisTarihi = DateTime.Now;
                    prevModel = (faturaList.Count > 1) ? faturaList[0] : prevModel;
                }
                else
                {
                    model = faturaList[0];
                    prevModel = (faturaList.Count > 1) ? faturaList[1] : faturaList[0];
                }



                ViewData["prevModelId"] = prevModel.MakbuzId.ToString();

                var satirList = _context.VohalStokHareketis
                                .Where(y => y.MakbuzId == model.MakbuzId)
                                .ToList();

                ViewData["TeslimatYer"] = new SelectList(_context.TohalTeslimatYeris, "TeslimatYeriId", "Ad", model.TeslimatYeriId);
                ViewData["faturaModel"] = satirList;

                return View(model);
            }
            else
            {
                // Şu andaki faturaId değerine sahip olan faturayı bul
                var currentFatura = _context.VohalMakbuzs.FirstOrDefault(x => x.MakbuzId == faturaId);

                if (currentFatura != null)
                {
                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalMakbuzs
                        .Where(y => y.MakbuzId < currentFatura.MakbuzId)
                        .OrderByDescending(x => x.MakbuzId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalMakbuzs
                        .Where(y => y.MakbuzId > currentFatura.MakbuzId)
                        .OrderBy(x => x.MakbuzId)
                        .FirstOrDefault();

                    ViewData["prevModelId"] = prevModel?.MakbuzId.ToString();
                    ViewData["nextModelId"] = nextModel?.MakbuzId.ToString();
                    var satirList = _context.VohalStokHareketis.Where(y => y.MakbuzId == currentFatura.MakbuzId).ToList();
                    ViewData["TeslimatYer"] = new SelectList(_context.TohalTeslimatYeris, "TeslimatYeriId", "Ad", currentFatura.TeslimatYeriId);
                    ViewData["faturaModel"] = satirList;
                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();
        }

        [HttpPost]
        public async Task<JsonResult> CreateMakbuzSatir(List<TohalIskeleMakbuzSatiri> tohalIslkeleMakbuzSatirlari, int makbuzid)
        {
            try
            {
                RemoveIskele();
                if (ModelState.IsValid)
                {

                    if (tohalIslkeleMakbuzSatirlari == null)
                    {
                        tohalIslkeleMakbuzSatirlari = new List<TohalIskeleMakbuzSatiri>();
                    }

                    foreach (var satir in tohalIslkeleMakbuzSatirlari)
                    {
                        satir.SatisTarihi = (satir.SatisTarihi == DateTime.MinValue
                                                                || satir.SatisTarihi == null)
                                                                ? DateTime.Now
                                                                : satir.SatisTarihi;

                       
                        _context.TohalIskeleMakbuzSatiris.Add(satir);
                        //TohalEvrakKdv evrak = new TohalEvrakKdv
                        //{
                        //    MakbuzId = makbuzid,
                        //    Oran = (double)satir.KdvOrani,
                        //    Matrah = (double)satir.Tutar,
                        //    Kdv = (double)(satir.KdvOrani * satir.Tutar) / 100,
                        //    KdvTevkifatTanimiId = null,
                        //    KdvTevkifatPayi = 0,
                        //    KdvTevkifatPaydasi = 0,
                        //    KdvTahakkuku = (double)(satir.KdvOrani * satir.Tutar) / 100,
                        //    KdvTevkifati = 0
                        //};
                        //_context.TohalEvrakKdvs.Add(evrak);
                    }
                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Başarıyla eklendi" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    RemoveIskele();
                    return Json(new { success = false, message = "Geçersiz model durumu" }, JsonRequestBehavior.DenyGet);
                }
            }
            catch (Exception ex)
            {
                RemoveIskele();
                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.DenyGet);
            }
        }
        [HttpPost]
        public async Task<JsonResult> CreateEvrakMasrafSatir(List<TohalIskeleEvrakMasrafi> tohalIskeleEvrakSatirlari)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (tohalIskeleEvrakSatirlari == null)
                    {
                        tohalIskeleEvrakSatirlari = new List<TohalIskeleEvrakMasrafi>();
                    }

                    foreach (var satir in tohalIskeleEvrakSatirlari)
                    {
                        _context.TohalIskeleEvrakMasrafis.Add(satir);
                    }
                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Başarıyla eklendi" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    RemoveIskele();
                    return Json(new { success = false, message = "Geçersiz model durumu" }, JsonRequestBehavior.DenyGet);
                }
            }
            catch (Exception ex)
            {
                RemoveIskele();
                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.DenyGet);
            }
        }
        [HttpGet]
        public ActionResult MakbuzMustahsilStok(int id)
        {
            var data = _context.VohalStokHareketis.Where(x => x.MakbuzId == id).ToList();
            return PartialView("~/Views/DokumIslemleri/Partials/_MakbuzMustahsilStok.cshtml", data);
        }
     
        //[HttpPost]
        //public ActionResult EvrakKdvKaydet(int makbuzId)
        //{
        //    var makbuz = _context.VohalMakbuzs.Where(x => x.MakbuzId == makbuzId).FirstOrDefault();
        //    TohalEvrakKdv evrak = new TohalEvrakKdv
        //    {
        //        MakbuzId = makbuzId,
        //        Oran = 1,
        //        Matrah = tutar,
        //        Kdv = makbuz.kd,
        //        KdvTevkifatTanimiId = 0,
        //        KdvTevkifatPayi = 0,
        //        KdvTevkifatPaydasi = 0,
        //        KdvTahakkuku = 0,
        //        KdvTevkifati = 0
        //    };
        //    _context.TohalEvrakKdvs.Add(evrak);
        //    _context.SaveChanges();
        //    return Json(new { success = true, message = "Başarıyla eklendi" }, JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        public async Task<JsonResult> CreateFaturaSatir(List<TohalIskeleStokHareketi> tohalIskeleStokHareketleri)
        {

            try
            {
                RemoveIskele();
                if (ModelState.IsValid)
                {

                    if (tohalIskeleStokHareketleri == null)
                    {
                        tohalIskeleStokHareketleri = new List<TohalIskeleStokHareketi>();
                    }
                    foreach (var tohalIskeleStokHareketi in tohalIskeleStokHareketleri)
                    {

                        tohalIskeleStokHareketi.StokHareketiId = tohalIskeleStokHareketi.StokHareketiId == 0 ? null : tohalIskeleStokHareketi.StokHareketiId;


                        tohalIskeleStokHareketi.KapId = tohalIskeleStokHareketi.KapId == 0
                                                                                        ? null
                                                                                        : tohalIskeleStokHareketi.KapId;

                        tohalIskeleStokHareketi.StokKunyeId = tohalIskeleStokHareketi.StokKunyeId == 0
                                                                                                    ? null
                                                                                                    : tohalIskeleStokHareketi.StokKunyeId;

                        tohalIskeleStokHareketi.StokKunyeId = tohalIskeleStokHareketi.AlisKunyeId == 0
                                                                                                    ? null
                                                                                                    : tohalIskeleStokHareketi.AlisKunyeId;

                        tohalIskeleStokHareketi.GirisTarihi = (tohalIskeleStokHareketi.GirisTarihi == DateTime.MinValue
                                                                || tohalIskeleStokHareketi.GirisTarihi == null)
                                                                ? DateTime.Now
                                                                : tohalIskeleStokHareketi.GirisTarihi;

                        _context.TohalIskeleStokHareketis.Add(tohalIskeleStokHareketi);
                    }



                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Başarıyla eklendi" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    RemoveIskele();
                    return Json(new { success = false, message = "Geçersiz model durumu" }, JsonRequestBehavior.DenyGet);
                }
            }
            catch (Exception ex)
            {
                RemoveIskele();
                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.DenyGet);
            }

        }

        [HttpPost]
        public async Task<ActionResult> SaveFatura([Bind(Include = "MakbuzId,DokumNo,CariKartId,MarkaId,StokGirisTarihi,IrsaliyeNo,GeldigiYer,Plaka,FaturaTarihi,FaturaNo,RusumOrani,Rusum,StopajOrani,Stopaj,BagkurOrani,Bagkur,BorsaOrani,Borsa,Navlun,NavlunKdvOrani,NavlunKdv,KomisyonOrani,Komisyon,KomisyonKdvOrani,KomisyonKdv,IadesizKapTutari,IadesizKapKdvOrani,IadesizKapKdv,IadesizKapKomisyonaDahil,Aciklama,Kesildi,OrtakId,OrtaklikOrani,Vade,EkleyenId,EklemeZamani,GuncelleyenId,GuncellemeZamani,MakbuzGuncelleyenId,MakbuzGuncellemeZamani,IadeliKapTutari,YerId,UlkeId,Sifati,TeslimatYeriId,BildirimTuru,HalId,MalToplami,KdvToplami,MasrafToplami,MasrafKdvToplami,KapSayisi,CariyeIslemeSekli,DigHksBildirimSekli,BagkurHesaplanmasin,BagkurDosyaId,HksMalinNiteligi,EFaturaNot,EFaturaBolgeKodu,GibFirmamizPostaKutusuId,GibMuhatapPostaKutusuId,EFaturaDurumu,EFaturaEttn,EFaturaGibDurumu,EFaturaHataAciklamasi,FaturaZamani")] TohalMakbuz tohalFatura)
        {
            if (ModelState.IsValid)
            {
                var dokumTanimlar = await _context.VohalDokumTanimlaris.FirstOrDefaultAsync();
                var guid = Guid.NewGuid();
                try
                {
                    _context.TohalIskeleStokHareketis.ToList().ForEach(x =>
                    {
                        x.Guid = guid;
                        _context.Entry(x).State = EntityState.Modified;
                    });

                    _context.TohalIskeleEvrakMasrafis.ToList().ForEach(x =>
                    {
                        x.Guid = guid;
                        _context.Entry(x).State = EntityState.Modified;
                    });

                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    RemoveIskele();
                    return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);

                }

                var parametersSatir = new List<SqlParameter>();

                if (tohalFatura.MakbuzId == 0)
                {
                    parametersSatir.Add(new SqlParameter("@MAKBUZ_ID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                }
                else
                {
                    parametersSatir.Add(new SqlParameter("@MAKBUZ_ID", SqlDbType.Int) { Value = tohalFatura.MakbuzId });
                }

                var parametersSatirDevam = new List<SqlParameter>
                {
                    new SqlParameter("@MARKA_ID", (object) tohalFatura.MarkaId ?? DBNull.Value),
                    new SqlParameter("@CARI_KART_ID", (object) tohalFatura.CariKartId ?? DBNull.Value),
                    new SqlParameter("@DOKUM_NO", (object) tohalFatura.DokumNo ?? DBNull.Value),
                    new SqlParameter("@STOK_GIRIS_TARIHI", (object) tohalFatura.StokGirisTarihi ?? DBNull.Value),
                    new SqlParameter("@IRSALIYE_NO", (object)tohalFatura.IrsaliyeNo ?? DBNull.Value),
                    new SqlParameter("@YER_ID", (object)tohalFatura.YerId ?? DBNull.Value),
                    new SqlParameter("@ULKE_ID", (object)tohalFatura.UlkeId ?? DBNull.Value),
                    new SqlParameter("@PLAKA", (object)tohalFatura.Plaka ?? DBNull.Value),
                    new SqlParameter("@NAVLUN", (object) tohalFatura.Navlun ?? DBNull.Value),
                    new SqlParameter("@IADESIZ_KAP_TUTARI", (object) tohalFatura.IadesizKapTutari ?? DBNull.Value),
                    new SqlParameter("@SIFATI", (object) tohalFatura.Sifati ?? DBNull.Value),
                    new SqlParameter("@BILDIRIM_TURU", (object) tohalFatura.BildirimTuru ?? DBNull.Value),
                    new SqlParameter("@TESLIMAT_YERI_ID", (object) tohalFatura.TeslimatYeriId ?? DBNull.Value),
                    new SqlParameter("@HAL_ID", (object)tohalFatura.HalId ?? DBNull.Value),
                    new SqlParameter("@ACIKLAMA", (object)tohalFatura.Aciklama ?? DBNull.Value),
                    new SqlParameter("@CARIYE_ISLEME_SEKLI", (object) tohalFatura.CariyeIslemeSekli ?? DBNull.Value),
                    new SqlParameter("@HKS_MALIN_NITELIGI", (object)tohalFatura.HksMalinNiteligi ?? DBNull.Value),
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", false),
                    new SqlParameter("@GUID", SqlDbType.UniqueIdentifier) { Value = guid },
                    new SqlParameter("@SP_DEN_CAGRILDI", true),
                    new SqlParameter("@HATA_MESAJI", SqlDbType.VarChar,100)
                    {
                        Direction = ParameterDirection.Output
                    },
                };

                parametersSatir.AddRange(parametersSatirDevam);
                try
                {
                    await _context.Database.ExecuteSqlCommandAsync(
                          "EXEC SOHAL_STOK_HAREKETI_KAYDET " +
                          "@MAKBUZ_ID OUTPUT, @MARKA_ID, @CARI_KART_ID, @DOKUM_NO, @STOK_GIRIS_TARIHI, " +
                          "@IRSALIYE_NO, @YER_ID, @ULKE_ID, @PLAKA, " +
                          "@NAVLUN, @IADESIZ_KAP_TUTARI, @SIFATI, @BILDIRIM_TURU, @TESLIMAT_YERI_ID, @HAL_ID, " +
                          "@ACIKLAMA, @CARIYE_ISLEME_SEKLI, @HKS_MALIN_NITELIGI, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, " +
                          "@GUID, @SP_DEN_CAGRILDI, @HATA_MESAJI OUTPUT",
                          parametersSatir.ToArray());

                }
                catch
                {

                }

                int faturaId = (int)parametersSatir[0].Value;
                string uyarıMesaji = parametersSatir[parametersSatir.Count - 1].Value.ToString();

                if (uyarıMesaji.Length > 0)
                {
                    //hata mesajı
                }
                else
                {
                    try
                    {
                        if (String.IsNullOrEmpty(tohalFatura.DokumNo))
                        {

                            var parametersNum = new List<SqlParameter>
                            {

                                new SqlParameter("@TUR", SqlDbType.TinyInt) { Value = 2 },
                                new SqlParameter("@SOYLENECEK_NO", SqlDbType.Char,20)
                                {
                                    Direction = ParameterDirection.Output
                                },
                                new SqlParameter("@SAYFA_SAYISI", SqlDbType.TinyInt) { Value = 1 },
                            };

                            await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_NUMERATOR_URET @TUR, @SOYLENECEK_NO OUTPUT, @SAYFA_SAYISI", parametersNum.ToArray());

                            var numMakbuz = _context.TohalMakbuzs.Where(x => x.MakbuzId == faturaId).SingleOrDefault();
                            numMakbuz.DokumNo = parametersNum[1].Value.ToString();
                            _context.Entry(numMakbuz).State = EntityState.Modified;
                            _context.SaveChanges();
                            RemoveIskele();
                            // İşlem başarıyla tamamlandı
                            return Json(new { success = true, message = "Başarıyla eklendi", faturaId = faturaId }, JsonRequestBehavior.AllowGet);

                        }
                        else
                        {
                            try
                            {
                                // Veritabanına değişiklikleri kaydet
                                await _context.SaveChangesAsync();
           
                                RemoveIskele();
                                // İşlem başarıyla tamamlandı
                                return Json(new { success = true, message = "Başarıyla eklendi", faturaId = faturaId }, JsonRequestBehavior.AllowGet);
                            }
                            catch (Exception)
                            {
                                RemoveIskele();
                                return Json(new { success = false, message = "Hata Oluştu", faturaId = faturaId }, JsonRequestBehavior.DenyGet);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        RemoveIskele();
                        Console.WriteLine("Hata Oluştu: " + ex.Message);
                    }
                }



            }

            RemoveIskele();

            return View(tohalFatura);
        }

        public async Task<ActionResult> Delete(int makbuzId, int kullaniciId)
        {
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MAKBUZ_ID", SqlDbType.Int){Value = makbuzId},
                    new SqlParameter("@TRANSACTION_YAP", false),
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int){Value = kullaniciId},
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Int){Value = 1},
                    new SqlParameter("@HATA_NO", SqlDbType.Int){Direction = ParameterDirection.Output},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_MAKBUZ_SIL @MAKBUZ_ID, @TRANSACTION_YAP, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @HATA_NO OUTPUT", parameters.ToArray());
                var hataNo = parameters[4].Value;
                var result = (hataNo != null && hataNo.ToString() != "{}");
                var alertText = result ? $"Hata No: {hataNo}" : "Makbuz Silindi";
                return RedirectToAction(nameof(Stok), new { metin = alertText, durum = !result });
            }
            catch (SqlException ex)
            {
                return RedirectToAction(nameof(Stok), new { id = makbuzId, metin = ex.Errors[0].Message, durum = false });
            }
        }

        // Döküm İşlemleri > İşlemdeki Faturalar
        public ActionResult IslemdekiFaturalar()
        {
            return View(new VohalAramaMakbuz());
        }

        [HttpPost]
        public async Task<ActionResult> IslemdekiFaturalar(string fatKod = null, string fatAd = null)
        {
            var items = _context.VohalAramaMakbuzs.Where(x => (x.Kesildi == false || x.Kesildi == null) && x.BekleyenHareketSayisi > 0).AsQueryable();

            if (!string.IsNullOrWhiteSpace(fatKod))
                items = items.Where(x => x.CariKodu == fatKod).OrderBy(x => x.CariKodu);
            else if (!string.IsNullOrWhiteSpace(fatAd))
                items = items.Where(x => x.CariAdi == fatAd).OrderBy(x => x.CariAdi);

            var id = await items.OrderBy(x => new { x.StokGirisTarihi, x.DokumNo }).Select(x => x.MakbuzId).FirstOrDefaultAsync();

            if (id > 0)
                return RedirectToAction(nameof(Makbuz), new { faturaId = id });

            return View();
        }

        // Döküm İşlemleri > Hazır Faturalar
        public ActionResult HazirFaturalar()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> HazirFaturalar(string kod = null, string ad = null)
        {
            var items = _context.VohalAramaMakbuzs.Where(x => (x.Kesildi == false || x.Kesildi == null) && x.BekleyenHareketSayisi == 0).AsQueryable();

            if (!string.IsNullOrWhiteSpace(kod))
                items = items.Where(x => x.CariKodu == kod).OrderBy(x => x.CariKodu);
            else if (!string.IsNullOrWhiteSpace(ad))
                items = items.Where(x => x.CariAdi == ad).OrderBy(x => x.CariAdi);

            var id = await items.OrderBy(x => new { x.StokGirisTarihi, x.DokumNo }).Select(x => x.MakbuzId).FirstOrDefaultAsync();

            if (id > 0)
                return RedirectToAction(nameof(Makbuz), new { faturaId = id });

            return View();
        }

        // Döküm İşlemleri > Kesilmiş Faturalar
        public ActionResult KesilmisFaturalar()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> KesilmisFaturalar(string kod = null, string ad = null, string faturaNo = null, DateTime? tarih = null)
        {
            var items = _context.VohalAramaMakbuzs.Where(x => x.Kesildi == true).AsQueryable();
            var addedDate = tarih.Value.AddDays(1);
            if (!string.IsNullOrWhiteSpace(kod) && tarih.HasValue)
                items = items.Where(x => x.KodTarih == string.Concat(kod, tarih.Value.ToString("yyyyMMdd"))).OrderBy(x => x.CariKodu);
            else if (!string.IsNullOrWhiteSpace(ad) && tarih.HasValue)
                items = items.Where(x => x.AdTarih == string.Concat(ad, tarih.Value.ToString("yyyyMMdd"))).OrderBy(x => x.CariAdi);
            else if (tarih.HasValue && string.IsNullOrWhiteSpace(kod) && string.IsNullOrWhiteSpace(ad))
                items = items.Where(x => x.StokGirisTarihi >= tarih && x.StokGirisTarihi < addedDate);
            else if (!string.IsNullOrWhiteSpace(kod))
                items = items.Where(x => x.CariKodu == kod).OrderBy(x => x.CariKodu);
            else if (!string.IsNullOrWhiteSpace(ad))
                items = items.Where(x => x.CariAdi == ad).OrderBy(x => x.CariAdi);

            if (!string.IsNullOrWhiteSpace(faturaNo))
                items = items.Where(x => x.FaturaNo == faturaNo).OrderBy(x => x.FaturaNo);

            var id = await items.OrderBy(x => new { x.StokGirisTarihi, x.DokumNo }).Select(x => x.MakbuzId).FirstOrDefaultAsync();

            if (id > 0)
                return RedirectToAction(nameof(Makbuz), new { faturaId = id });

            return View();
        }
        public async Task<ActionResult> Makbuz(int faturaId)
        {
      
                var item = await _context.VohalMakbuzs.FirstOrDefaultAsync(x => x.MakbuzId == faturaId);

                if (item != null)
                {
                
                if(item.Kesildi == true)
                {
                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalMakbuzs
                        .Where(y => y.MakbuzId < item.MakbuzId && y.Kesildi == true)
                        .OrderByDescending(x => x.MakbuzId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalMakbuzs
                        .Where(y => y.MakbuzId > item.MakbuzId && y.Kesildi == true)
                        .OrderBy(x => x.MakbuzId)
                        .FirstOrDefault();
                    ViewData["prevModelId"] = prevModel?.MakbuzId.ToString();
                    ViewData["nextModelId"] = nextModel?.MakbuzId.ToString();
                }
                if((item.Kesildi == false || item.Kesildi == null) && item.BekleyenHareketSayisi == 0)
                {
                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalMakbuzs
                        .Where(y => y.MakbuzId < item.MakbuzId && (y.Kesildi == false || y.Kesildi == null) && y.BekleyenHareketSayisi == 0)
                        .OrderByDescending(x => x.MakbuzId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalMakbuzs
                        .Where(q => q.MakbuzId > item.MakbuzId && (q.Kesildi == false || q.Kesildi == null) && q.BekleyenHareketSayisi == 0)
                        .OrderBy(x => x.MakbuzId)
                        .FirstOrDefault();
                    ViewData["prevModelId"] = prevModel?.MakbuzId.ToString();
                    ViewData["nextModelId"] = nextModel?.MakbuzId.ToString();
                }
                if ((item.Kesildi == false || item.Kesildi == null) && item.BekleyenHareketSayisi > 0)
                {

                    // Bir önceki ve bir sonraki faturayı bul
                    var prevModel = _context.VohalMakbuzs
                        .Where(y => y.MakbuzId < item.MakbuzId && (y.Kesildi == false || y.Kesildi == null) && y.BekleyenHareketSayisi > 0)
                        .OrderByDescending(x => x.MakbuzId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalMakbuzs
                        .Where(y => y.MakbuzId > item.MakbuzId && (y.Kesildi == false || y.Kesildi == null) && y.BekleyenHareketSayisi > 0)
                        .OrderBy(x => x.MakbuzId)
                        .FirstOrDefault();
                    ViewData["prevModelId"] = prevModel?.MakbuzId.ToString();
                    ViewData["nextModelId"] = nextModel?.MakbuzId.ToString();
                }


                  

                if(item.GibFirmamizPostaKutusuId == null || item.GibFirmamizPostaKutusuId == 0)
                {
                    var efaturapk = _context.TohalGibKullanicis
                    .Where(x => x.PkTipi == 0 && x.KayitSekli == 1 && x.DokumanTipi == 0)
                    .FirstOrDefault();

                    item.GibFirmamizPostaKutusuId = efaturapk.GibKullaniciId;
                    item.GibFirmamizPostaKutusu = efaturapk.PostaKutusu;
                }
                }
                else
                {
                    return HttpNotFound();
                }

                ViewData["makbuzSatirlar"] = await _context.VohalMakbuzSatiris.Where(x => x.MakbuzId == item.MakbuzId).OrderBy(x => x.MalKodu).ThenBy(x => x.Fiyat).ToListAsync();
                ViewData["makbuzEvrakMasraflar"] = await _context.VohalEvrakMasrafis.Where(x => x.MakbuzId == item.MakbuzId).OrderBy(x => x.SatirNo).ToListAsync();
                return View(item);
         
   
        }

        [HttpPost]
        public async Task<ActionResult> Makbuz([Bind(Include = "MakbuzId, MarkaId, Marka, CariKartId, CariKodu, CariAdi, KisilikTipi, VergiKimlikNo, DokumNo, StokGirisTarihi, FaturaTarihi, FaturaZamani, FaturaNo, IrsaliyeNo, Plaka, Aciklama, Kesildi, RusumOrani, Rusum, StopajOrani, Stopaj, BagkurOrani, Bagkur, BorsaOrani, Borsa, Navlun, NavlunKdvOrani, NavlunKdv, KomisyonOrani, Komisyon, KomisyonKdvOrani, KomisyonKdv, IadeliKapTutari, IadesizKapTutari, IadesizKapKdvOrani, IadesizKapKdv, IadesizKapKomisyonaDahil, GelenMiktar, GelenKap, SatilanMiktar, SatilanKap, BekleyenHareketSayisi, MakbuzdakiMiktar, MakbuzdakiKap, Masraf, MasrafKdv, MalTutari, MalKdv, OrtakId, OrtaklikOrani, OrtakAdi, Vade, EkleyenKullaniciAdi, EklemeZamani, GuncelleyenKullaniciAdi, GuncellemeZamani, MakbuzGuncelleyenKullaniciAdi, MakbuzGuncellemeZamani, EPosta, GsmNo, KodTarih, AdTarih, BeldeId, BeldeHksId, BeldeAdi, IlceId, IlceHksId, IlceAdi, IlId, IlHksId, IlAdi, UlkeId, BagkurHesaplanmasin, UlkeAdi, Sifati, BildirimTuru, HksMalinNiteligi, TeslimatYeriId, TeslimatYeriTuru, TeslimatYeriAdi, HksWebSiraNo, HalId, HalAdi, CariyeIslemeSekli, BagkurDosyaId, BagkurDosyaNo, BagkurDosyasiMuhasebelesti, GibMuhatapPostaKutusuId, GibMuhatapPostaKutusu, GibFirmamizPostaKutusu, GibFirmamizPostaKutusuId, EFaturaNot, EFaturaBolgeKodu, EkleyenId, EFaturaMusteriAdi, EFaturaVergiDairesi, EFaturaVergiKimlikNo, EFaturaDaireNo, EFaturaKapiNo, EFaturaSokak, EFaturaCadde, EFaturaMahalle, EFaturaSemt, EFaturaIlce, EFaturaIl, EFaturaUlke, EFaturaTelefon, EFaturaFaksi, EFaturaEposta, EFaturaWebAdresi, EFaturaGsmNo, EFaturaPostaKodu, RedDurumu, EFaturaFaturaKodu, EFaturaMalverenKodu, EFaturaDurumu, Tip, BildirimDurumu, DonenAlanDegeri, Siralama, EFaturaEttn")] VohalMakbuz model, bool kesildiBut = false)
        {
            #region Hesaplamalar
            /*
            model.Rusum = 1;
            model.NavlunKdv = 1;
            model.Bagkur = 1;
            model.BagkurOrani = 1;
            model.Stopaj = 1;
            model.Borsa = 1;
            model.Komisyon = 1;
            model.KomisyonKdv = 1;
            model.IadesizKapKdv = 1;
            */
            #endregion

                var guid = Guid.NewGuid();
            try
            {
                _context.TohalIskeleMakbuzSatiris.ToList().ForEach(x =>
                {
                    x.Guid = guid;
                    _context.Entry(x).State = EntityState.Modified;
                });
                _context.TohalIskeleEvrakMasrafis.ToList().ForEach(x =>
                {
                    x.Guid = guid;
                    _context.Entry(x).State = EntityState.Modified;
                });
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                RemoveIskele();
                return Json(new { success = false, message = $"Bir hata oluştu: {ex.Message}" }, JsonRequestBehavior.AllowGet);

            }

            try
            {
                var efaturapk = _context.TohalGibKullanicis
                        .Where(x => x.PkTipi == 0 && x.KayitSekli == 1 && x.DokumanTipi == 0)
                        .FirstOrDefault();

                model.GibFirmamizPostaKutusuId = efaturapk.GibKullaniciId;

                var prms = new List<SqlParameter>
                {
                    new SqlParameter("@MAKBUZ_ID", model.MakbuzId),
                    new SqlParameter("@MARKA_ID", model.MarkaId),
                    new SqlParameter("@CARI_KART_ID", model.CariKartId),
                    new SqlParameter("@DOKUM_NO", model.DokumNo),
                    new SqlParameter("@STOK_GIRIS_TARIHI", model.StokGirisTarihi),
                    new SqlParameter("@FATURA_TARIHI", model.FaturaTarihi),
                    new SqlParameter("@FATURA_NO", model.FaturaNo),
                    new SqlParameter("@IRSALIYE_NO", model.IrsaliyeNo),
                    new SqlParameter("@PLAKA", model.Plaka),
                    new SqlParameter("@ACIKLAMA", model.Aciklama),
                    new SqlParameter("@KESILDI", model.Kesildi),
                    new SqlParameter("@RUSUM_ORANI", model.RusumOrani),
                    new SqlParameter("@RUSUM", model.Rusum),
                    new SqlParameter("@STOPAJ_ORANI", model.StopajOrani),
                    new SqlParameter("@STOPAJ", model.Stopaj),
                    new SqlParameter("@BAGKUR_ORANI", model.BagkurOrani),
                    new SqlParameter("@BAGKUR", model.Bagkur),
                    new SqlParameter("@BORSA_ORANI", model.BorsaOrani),
                    new SqlParameter("@BORSA", model.Borsa),
                    new SqlParameter("@NAVLUN", model.Navlun),
                    new SqlParameter("@NAVLUN_KDV_ORANI", model.NavlunKdvOrani),
                    new SqlParameter("@NAVLUN_KDV", model.NavlunKdv),
                    new SqlParameter("@KOMISYON_ORANI", model.KomisyonOrani),
                    new SqlParameter("@KOMISYON", model.Komisyon),
                    new SqlParameter("@KOMISYON_KDV_ORANI", model.KomisyonKdvOrani),
                    new SqlParameter("@KOMISYON_KDV", model.KomisyonKdv),
                    new SqlParameter("@IADELI_KAP_TUTARI", model.IadeliKapTutari),
                    new SqlParameter("@IADESIZ_KAP_TUTARI", model.IadesizKapTutari),
                    new SqlParameter("@IADESIZ_KAP_KDV_ORANI", model.IadesizKapKdvOrani),
                    new SqlParameter("@IADESIZ_KAP_KDV", model.IadesizKapKdv),
                    new SqlParameter("@IADESIZ_KAP_KOMISYONA_DAHIL", model.IadesizKapKomisyonaDahil),
                    new SqlParameter("@YER_ID", _context.TohalMakbuzs.FirstOrDefault(x => x.MakbuzId == model.MakbuzId)?.YerId),
                    new SqlParameter("@ULKE_ID", model.UlkeId),
                    new SqlParameter("@BAGKUR_HESAPLANMASIN", model.BagkurHesaplanmasin),
                    new SqlParameter("@BAGKUR_DOSYA_ID", model.BagkurDosyaId),
                    new SqlParameter("@KULLANICI_ID", User.GetUserId()),
                    new SqlParameter("@GUID", guid),
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", true),
                    new SqlParameter("@E_FATURA_NOT", model.EFaturaNot),
                    new SqlParameter("@E_FATURA_BOLGE_KODU", model.EFaturaBolgeKodu),
                    new SqlParameter("@GIB_FIRMAMIZ_POSTA_KUTUSU_ID", model.GibFirmamizPostaKutusuId),
                    new SqlParameter("@GIB_MUHATAP_POSTA_KUTUSU_ID", model.GibMuhatapPostaKutusuId),
                    new SqlParameter("@FATURA_ZAMANI", model.FaturaZamani),
                };

                prms.ForEach(x =>
                {
                    if (x.Value == null)
                        x.Value = DBNull.Value;
                });
                try
                {
                    var result = await _context.Database.ExecuteSqlCommandAsync("exec SOHAL_MAKBUZ_KAYDET @MAKBUZ_ID," +
                           "@MARKA_ID,@CARI_KART_ID,@DOKUM_NO,@STOK_GIRIS_TARIHI,@FATURA_TARIHI,@FATURA_NO,@IRSALIYE_NO,@PLAKA,@ACIKLAMA,@KESILDI,@RUSUM_ORANI,@RUSUM,@STOPAJ_ORANI," +
                           "@STOPAJ,@BAGKUR_ORANI,@BAGKUR,@BORSA_ORANI,@BORSA,@NAVLUN,@NAVLUN_KDV_ORANI,@NAVLUN_KDV,@KOMISYON_ORANI,@KOMISYON,@KOMISYON_KDV_ORANI,@KOMISYON_KDV,@IADELI_KAP_TUTARI," +
                           "@IADESIZ_KAP_TUTARI,@IADESIZ_KAP_KDV_ORANI,@IADESIZ_KAP_KDV,@IADESIZ_KAP_KOMISYONA_DAHIL,@YER_ID,@ULKE_ID,@BAGKUR_HESAPLANMASIN,@BAGKUR_DOSYA_ID,@KULLANICI_ID,@GUID," +
                           "@DEGISIKLIK_TAKIP_VAR,@E_FATURA_NOT,@E_FATURA_BOLGE_KODU,@GIB_FIRMAMIZ_POSTA_KUTUSU_ID,@GIB_MUHATAP_POSTA_KUTUSU_ID,@FATURA_ZAMANI", prms.ToArray());
                    TempData["Status"] = result > 0;

                    if (kesildiBut)
                    {
                        var resultEbelge = await EBelgeNoUret(model.MakbuzId, 1, 2);

                        if (resultEbelge == "Başarısız")
                        {
                            RemoveIskele();
                            var makbuz = _context.TohalMakbuzs.FirstOrDefault(x => x.MakbuzId == model.MakbuzId);
                            makbuz.Kesildi = false;
                            _context.Entry(makbuz).State = EntityState.Modified;
                            _context.SaveChanges();
                            return Json(new { success = false, message = "İşlem Başarısız" });
                        }
                        //else
                        //{
                        //    var makbuz = _context.TohalMakbuzs.FirstOrDefault(x => x.MakbuzId == model.MakbuzId);
                        //    makbuz.FaturaNo = resultEbelge;
                        //    _context.Entry(makbuz).State = EntityState.Modified;
                        //    _context.SaveChanges();
                        //}
                    }




                    return Json(new { success = true, message = "İşlem Başarılı" });
                }
                catch
                {
                    RemoveIskele();
                    return Json(new { success = false, message = "İşlem Başarısız" });
                }
            }
            catch (SqlException ex)
            {
                RemoveIskele();
                return Json(new { success = false, message = "İşlem Başarısız" + ex.Errors[0].Message });
            }
        }

        // Döküm İşlemleri > Toplu Fatura Kesme
        public ActionResult TopluFaturaKesme()
        {
            return View();
        }
        public JsonResult VohalAramaMakbuzlar(bool kesildi, bool hazir)
        {
            var query = _context.VohalAramaMakbuzs.Where(x => x.Kesildi == kesildi).ToList();
            if (hazir)
                query = query.Where(x => x.BekleyenHareketSayisi == 0).ToList();
            var items = query.Select(x => new { CariKartId = x.CariKartId, MakbuzId = x.MakbuzId, CariAdi = x.CariAdi, DokumNo = x.DokumNo, StokGirisTarihi = x.StokGirisTarihi.ToString("dd.MM.yyyy") }).ToList();

            return Json(items, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<ActionResult> TopluFaturaKes(List<int> makbuzIdler)
        {
            RemoveIskele();
            //seçtigimiz makbuz idleri için tek tek işlem yapılacak
            for (int i = 0; i < makbuzIdler.Count; i++)
            {
                var makbuzId = makbuzIdler.ElementAt(i);
                //makbuzu id ye alıyoruz ve kesildi özelligini 0 dan 1 çeviriyoruz
                var makbuz = await _context.VohalMakbuzs.Where(x => x.MakbuzId == makbuzId).FirstOrDefaultAsync();

                var resultEbelge = await EBelgeNoUret(makbuz.MakbuzId, 1, 2);

                if (resultEbelge == "Başarısız")
                {
                    makbuz.Kesildi = false;
                    _context.Entry(makbuz).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                //else
                //{
                //    makbuz.Kesildi = true;
                //    makbuz.FaturaNo = resultEbelge;
                //    _context.Entry(makbuz).State = EntityState.Modified;
                //    _context.SaveChanges();
                //}

            }
            return Json(new { success = true, message = "İşlem Başarılı" });
        }
   
        public async Task<string> EBelgeNoUret(int makbuzid, int evraktur, int belgetur)
        {
            try
            {


                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@FATURA_ID", (object)makbuzid ?? DBNull.Value),
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int){ Value = 1},
                    new SqlParameter("@EVRAK_TURU", SqlDbType.Int){ Value = evraktur},
                    new SqlParameter("@E_BELGE_TURU", SqlDbType.Int){ Value = belgetur},
                    new SqlParameter("@URET", SqlDbType.Bit){ Value = true},
                    new SqlParameter("@FATURA_NO", SqlDbType.Char,20)
                    {
                        Direction = ParameterDirection.Output
                    }
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_E_BELGE_NO_URET @FATURA_ID, @KULLANICI_ID, @EVRAK_TURU, @E_BELGE_TURU,@URET,@FATURA_NO OUTPUT", parameters.ToArray());
                string faturano = (string)parameters[5].Value;
                return faturano;
            }
            catch
            {
                RemoveIskele();
                return "Başarısız";
            }
        }
        // Döküm İşlemleri > Beyannameler > Mal Beyannamesi
        public ActionResult MalBeyannamesi()
        {
            return View();
        }
        // Döküm İşlemleri > Döküm Defteri > Döküm Defteri İşlemleri
        public async Task<ActionResult> DokumDefterIslemleri()
        {
            ViewData["dokums"] = await DokumGetir();
            return View();
        }

        #region Döküm İşlemleri > Entegrasyon

        #region Stoksuz Entegrasyon
        public ActionResult StoksuzEnteg()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> StoksuzEnteg(DateTime date, string brand = null, string malKod = null)
        {
            await StokEntegrasyon(false, date, brand, malKod);

            return View();
        }
        #endregion

        #region Stoklu Entegrasyon
        public ActionResult StokluEnteg()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> StokluEnteg(DateTime date, string brand = null, string malKod = null)
        {
            await StokluEntegrasyon(true, date, brand, malKod);
            return View();
        }
        #endregion

        private async Task StokEntegrasyon(bool stoklu, DateTime date, string brand, string malKod)
        {
            var faturaIds = new List<int>();

            var faturaSatirlari = await _context.VohalEntegreEdilmeyenFaturaSatiris
                .Where(x => x.Tarih == date || x.Marka == brand || x.MalAdi == malKod).OrderBy(x => new { x.FaturaId, x.SatirNo }).ToListAsync();


            foreach (var item in faturaSatirlari)
            {
                var parametersStoksuz = new List<SqlParameter>();

                // Prosedürün tüm parametrelerini ekle
                parametersStoksuz.Add(new SqlParameter("@TARIH", item.Tarih));
                parametersStoksuz.Add(new SqlParameter("@MARKA_ID", (object)item.MarkaId ?? DBNull.Value));
                parametersStoksuz.Add(new SqlParameter("@MAL_ID", (object)item.MalId ?? DBNull.Value));
                parametersStoksuz.Add(new SqlParameter("@KAP_ID", (object)item.KapId ?? DBNull.Value));
                parametersStoksuz.Add(new SqlParameter("@STOK_TIPI", (object)item.StokTipi ?? DBNull.Value));
                parametersStoksuz.Add(new SqlParameter("@STOK_KUNYE_ID", (object)item.StokKunyeId ?? DBNull.Value));
                parametersStoksuz.Add(new SqlParameter("@GUN_BAZINDA_DOKUM_AC", SqlDbType.Bit) { Value = 1 });
                parametersStoksuz.Add(new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 });

                // Çıktı parametrelerini ekle (varsa)
                parametersStoksuz.Add(new SqlParameter("@MAKBUZ_ID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                parametersStoksuz.Add(new SqlParameter("@STOK_HAREKETI_ID", SqlDbType.Int) { Direction = ParameterDirection.Output });

                var makbuzId = 0;
                var stokHareketiId = 0;
                try
                {

                    var result = await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_STOKSUZ_ENTEGRASYONU_YAP @TARIH, @MARKA_ID, @MAL_ID, @KAP_ID, @STOK_TIPI, @STOK_KUNYE_ID, @GUN_BAZINDA_DOKUM_AC, @KULLANICI_ID, @MAKBUZ_ID OUTPUT, @STOK_HAREKETI_ID OUTPUT", parametersStoksuz.ToArray());

                    // Çıktı parametrelerini işle (varsa)
                    makbuzId = (int)parametersStoksuz[parametersStoksuz.Count - 2].Value;
                    stokHareketiId = (int)parametersStoksuz[parametersStoksuz.Count - 1].Value;


                }
                catch(Exception ex)
                {
                    TempData["ErrorMessagge"] = "İşlem Başarısız" + ex.InnerException;
                    makbuzId = (int)parametersStoksuz[parametersStoksuz.Count - 2].Value;
                    stokHareketiId = (int)parametersStoksuz[parametersStoksuz.Count - 1].Value;
                }
                var dokumdefter = new TohalDokumDefteri();

                dokumdefter.MakbuzId = makbuzId;
                dokumdefter.StokHareketiId = stokHareketiId;
                dokumdefter.FaturaSatiriId = item.FaturaSatiriId;
                dokumdefter.MalId = item.MalId;
                dokumdefter.KapSayisi = item.KapMiktari;
                dokumdefter.Miktar = item.MalMiktari;
                dokumdefter.Fiyat = item.Fiyat;
                dokumdefter.Tutar = item.Tutar;
                dokumdefter.KdvOrani = item.KdvOrani;
                dokumdefter.CiroPrimi = (double)item.CiroPrimi;

                _context.TohalDokumDefteris.Add(dokumdefter);
                _context.SaveChanges();

            }



            foreach (var item in faturaSatirlari)
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@ENTEGRASYON_TIPI",SqlDbType.Bit){ Value = 1},
                    new SqlParameter("@FATURA_SATIRI_ID", (object)item.FaturaSatiriId ?? DBNull.Value),
                    new SqlParameter("@SATIS_TARIHI", item.Tarih)
                };
                try
                {

                    var result = await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_ENTEGRASYONU_YAP @ENTEGRASYON_TIPI, @FATURA_SATIRI_ID, @SATIS_TARIHI", parameters.ToArray());

                    if (result > 0)
                        faturaIds.Add(item.FaturaId);

            
                }
                catch (Exception ex) {

                    TempData["ErrorMessagge"] = "İşlem Başarısız" + ex.InnerException;
                }

                if (faturaSatirlari.Count > 0)
                {
                    TempData["SuccessMessage"] = "Entegrasyon Tamamlandı.";

                }
                else
                {
                    TempData["ErrorMessagge"] = "Entegrasyon yapılacak satır bulunamadı.";
                }
            }


            //if (faturaIds.Any())
            //    _invoiceService.SendSelected(faturaIds.Distinct().ToList(), Services.IceSvc.Belge_Turu.EMustahsil);
        }

        private async Task StokluEntegrasyon(bool stoklu, DateTime date, string brand, string malKod)
        {
            var faturaIds = new List<int>();

            var faturaSatirlari = await _context.VohalEntegreEdilmeyenFaturaSatiris
                .Where(x => x.Tarih == date || x.Marka == brand || x.MalAdi == malKod).OrderBy(x => new { x.FaturaId, x.SatirNo }).ToListAsync();

            foreach (var item in faturaSatirlari)
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@ENTEGRASYON_TIPI",SqlDbType.Bit){ Value = 0},
                    new SqlParameter("@FATURA_SATIRI_ID", item.FaturaSatiriId),
                    new SqlParameter("@SATIS_TARIHI", item.Tarih)
                };
                var result = await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_ENTEGRASYONU_YAP @ENTEGRASYON_TIPI, @FATURA_SATIRI_ID, @SATIS_TARIHI", parameters.ToArray());

                if (result > 0)
                    faturaIds.Add(item.FaturaId);

               
            }
            if (faturaSatirlari.Count > 0)
            {
                TempData["SuccessMessage"] = "Entegrasyon Tamamlandı.";

            }
            else
            {
                TempData["ErrorMessagge"] = "Entegrasyon yapılacak satır bulunamadı.";
            }

            //if (faturaIds.Any())
            //    _invoiceService.SendSelected(faturaIds.Distinct().ToList(), Services.IceSvc.Belge_Turu.EMustahsil);
        }


        // Stoksuz Entegrasyon İptali
        public ActionResult StoksuzEntegIptali()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> StoksuzEntegIptali(DateTime tarih, string markaId = null, string malId = null)
        {
            var result = await StokEntegrasyonIptal(false, tarih, markaId, malId);
            return View();
        }


        // Stoklu Entegrasyon İptali
        public ActionResult StokluEntegIptali()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> StokluEntegIptali(DateTime tarih, string markaId = null, string malId = null)
        {
            var result = await StokEntegrasyonIptal(true, tarih, markaId, malId);
            return View();
        }

        private async Task<int> StokEntegrasyonIptal(bool stoklu, DateTime tarih, string markaId, string malId)
        {

            var parameters = new List<SqlParameter>
                {
                 new SqlParameter("@ENTEGRASYON_TIPI",SqlDbType.Bit){ Value = stoklu ? 0 : 1},
                 new SqlParameter("@TARIH", tarih),
                 new SqlParameter("@MARKA_ID", markaId.Length > 0 ? (object)markaId : DBNull.Value),
                 new SqlParameter("@MAL_ID", malId.Length > 0 ? (object)malId : DBNull.Value),
                 new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 }
                };
            try
            {
                var result = await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_ENTEGRASYONU_IPTAL_ET @ENTEGRASYON_TIPI, @TARIH, @MARKA_ID,@MAL_ID, @KULLANICI_ID", parameters.ToArray());
                TempData["SuccessMessage"] = "Entegrasyon(lar) iptal edildi.";
                return result;
            }
            catch (Exception ex)
            {
                TempData["SuccessMessage"] = ex.Message;
                return 0;
            }
        }
        #endregion

        // Döküm İşlemleri > Künye Bildirim Listesi
        public ActionResult KunyeBildirimListesi()
        {
            return View();
        }
        // Döküm İşlemleri > Kayıtlı Künyeleri Al
        public async Task<ActionResult> KayitliKunyeler()
        {
            ViewData["yerler"] = await TeslimatYerlerGetir();
            return View();
        }
        // Döküm İşlemleri > Stok İade
        public ActionResult StokIade()
        {
            return View();
        }

        public ActionResult StokKunyeAL(string belgeNo, int faturaId)
        {
            //var result = _hksService.Urunler();
            //var test = _hksService.UrunCinsleri(335);
            //var test2 = _hksService.UrunBirimleri();
            //var test3 =_hksService.UretimSekilleri();
            //var test4 = _hksService.MalNitelikleri();
            //var result = _hksService.Kunyeler(belgeNo);
            var result2 = _hksService.StokBildirimKaydet(faturaId);

            if (result2.Count > 0)
            {
                return Json(new { success = true, message = result2 }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, message = "İşlem başarısız!" }, JsonRequestBehavior.AllowGet);
            }
        }


        private async Task<List<SelectListItem>> DokumGetir()
        {
            var dokumList = await _context.VohalAramaDokums
                .OrderBy(x => x.DokumNo)
                .ThenBy(x => x.MakbuzId)
                .ToListAsync();

            return dokumList.Select(x => new SelectListItem
            {
                Value = x.MakbuzId.ToString(),
                Text = $"{x.DokumNo} - {(x.Marka != null ? x.Marka : "NULL")} - {x.CariAdi} - {x.StokGirisTarihi:dd.MM.yyyy} - {(x.IrsaliyeNo != null ? x.IrsaliyeNo : "NULL")} - {x.Navlun}"
            }).ToList();
        }


        private async Task<List<SelectListItem>> TeslimatYerlerGetir() =>
            await _context.VohalAramaTeslimatYeris.OrderBy(x => x.Ad).ThenBy(x => x.TeslimatYeriId).Select(x => new SelectListItem { Value = x.TeslimatYeriId.ToString(), Text = $"{x.Tip} - {x.Ad}" }).ToListAsync();


        public ActionResult ilkSonKayit(bool firstOrLast, string redirectAction , int condition)
        {
            VohalMakbuz val = new VohalMakbuz();
            if(condition == 0)
            {
                val = firstOrLast ? _context.VohalMakbuzs.Where(y => y.Kesildi == true).FirstOrDefault() : _context.VohalMakbuzs.Where(y=> y.Kesildi == true).OrderByDescending(x => x.MakbuzId).FirstOrDefault();
            }
            else if(condition == 1)
            {
                val = firstOrLast ? _context.VohalMakbuzs.Where(y => (y.Kesildi == false || y.Kesildi == null) && y.BekleyenHareketSayisi == 0).FirstOrDefault() : _context.VohalMakbuzs.Where(y => (y.Kesildi == false || y.Kesildi == null) && y.BekleyenHareketSayisi == 0).OrderByDescending(x => x.MakbuzId).FirstOrDefault();
            }
            else
            {
                val = firstOrLast ? _context.VohalMakbuzs.Where(y => (y.Kesildi == false || y.Kesildi == null) && y.BekleyenHareketSayisi > 0).FirstOrDefault() : _context.VohalMakbuzs.Where(y => (y.Kesildi == false || y.Kesildi == null) && y.BekleyenHareketSayisi > 0).OrderByDescending(x => x.MakbuzId).FirstOrDefault();

            }


            return val != null ? RedirectToAction(redirectAction, new { faturaId = val.MakbuzId }) : RedirectToAction(redirectAction);
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId, string redirectAction)
        {
            var val = afterOrBefore ? _context.VohalMakbuzs.Where(x => x.MakbuzId > currentId && (x.Kesildi == false || x.Kesildi == null)).FirstOrDefault() : _context.VohalMakbuzs.OrderByDescending(x => x.MakbuzId).Where(x => x.MakbuzId < currentId && (x.Kesildi == false || x.Kesildi == null)).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction(redirectAction, new { faturaId = val.MakbuzId });
        }

        public void RemoveIskele()
        {
            _context.TohalIskeleStokHareketis.RemoveRange(_context.TohalIskeleStokHareketis);
            _context.TohalIskeleMakbuzSatiris.RemoveRange(_context.TohalIskeleMakbuzSatiris);
            _context.TohalIskeleEvrakMasrafis.RemoveRange(_context.TohalIskeleEvrakMasrafis);
            _context.SaveChanges();
        }
    }
}
