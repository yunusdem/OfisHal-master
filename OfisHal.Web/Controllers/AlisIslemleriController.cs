using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using OfisHal.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class AlisIslemleriController : BaseController
    {
        private readonly Db _context;
        private readonly IHksService _hksService;

        public AlisIslemleriController(Db context, IHksService hksService)
        {
            _context = context;
            _hksService = hksService;
        }
        // Alış İşlemleri > Rehin İade
        public ActionResult RehinIade()
        {
            return View();
        }
        // Alış İşlemleri > Sipariş
        public ActionResult Siparis()
        {
            return View();
        }
        // Alış İşlemleri > Künye Bildirim Listesi
        public ActionResult KunyeBildirimListesi()
        {
            return View();
        }
        // Alış İşlemleri > Kayıtlı Künyeleri Al
        public async Task<ActionResult> KayitliKunyeleriAl()
        {
            ViewData["teslimatyerler"] = await TeslimatyerlerGetir();
            return View();
        }

        // Alış İşlemleri > Alış Faturası
        public async Task<ActionResult> Index(int faturaId = 0, bool yeni = false, string pgdown = "")
        {
            if (pgdown != "")
            {
                yeni = true;
            }
            ViewData["tanimSifati"] = _context.TohalTanims.FirstOrDefault().DigSifati;
            ViewData["tanimBildirimTuru"] = _context.TohalTanims.FirstOrDefault().DokBildirimTuru;
            ViewData["tanimRusumOrani"] = _context.TohalTanims.FirstOrDefault().AlsRusumOrani ?? 0;
            ViewData["tanimKdvOrani"] = _context.TohalTanims.FirstOrDefault().AlsDigerMalKdvOrani ?? 0;
            ViewData["iskontoVisible"] = _context.TohalTanims.FirstOrDefault().SatIskontoVar ?? false;
   
            var yenimesaj = _context.TohalKullaniciYetkisis.Where(x => x.YetkiCinsi == 9).FirstOrDefault();
            if (yenimesaj != null)
            {
                ViewData["acilisyetki"] = 1;
            }
            else
            {
                ViewData["acilisyetki"] = 0;
            }
           
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
                        Tip = 0,
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
                        GibFrmIrsaliyeKutusuId = eirsaliyepk?.GibKullaniciId
                    };

                    _context.TohalFaturas.Add(newModel);
                    _context.SaveChanges();
                    try
                    {
                        var tanimstopaj = _context.TohalTanims.FirstOrDefault().HesStopajHesabiId ?? 0;
                        ViewData["stopajHesap"] = _context.TohalHesaps.Where(x => x.HesapId == tanimstopaj).FirstOrDefault();
                    }
                    catch
                    {

                    }
           
                }
                var faturaList = _context.VohalFaturas.OrderByDescending(x => x.FaturaId)
                                                      .Where(x => x.Tip == 0)
                                                      .Take(2)
                                                      .ToList();

                //faturaList null ise yeni fatura oluşturmak için index e yeni true gönder
                if (faturaList.Count == 0 && !yeni)
                {
                    return RedirectToAction("Index", new { yeni = true });
                }


                var model = faturaList[0];
                var prevModel = (faturaList.Count > 1) ? faturaList[1] : faturaList[0];
                ViewData["TeslimatYer"] = new SelectList(_context.TohalTeslimatYeris, "TeslimatYeriId", "Ad", model.TeslimatYeriId);
                ViewData["faturaToplam"] = _context.VohalFaturaSonToplams
                        .Where(y => y.FaturaId == model.FaturaId)
                        .FirstOrDefault() ?? new VohalFaturaSonToplam();
                ViewData["prevModelId"] = prevModel.FaturaId.ToString();
                ViewData["nextModelId"] = "";
                ViewData["faturaModel"] = _context.VohalFaturaSatiriUrts
                                .Where(y => y.FaturaId == model.FaturaId)
                                .ToList();
                if (model.CariKartId != null)
                {
                    ViewData["Bakiye"] = await BakiyeSoyleAsync((int)model.CariKartId);

                }
                ViewData["makbuzEvrakMasraflar"] = await _context.VohalEvrakMasrafis.Where(x => x.FaturaId == model.FaturaId).OrderBy(x => x.SatirNo).ToListAsync();


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
                        .Where(y => y.Tip == 0 && y.FaturaId < currentFatura.FaturaId)
                        .OrderByDescending(x => x.FaturaId)
                        .FirstOrDefault();

                    var nextModel = _context.VohalFaturas
                        .Where(y => y.Tip == 0 && y.FaturaId > currentFatura.FaturaId)
                        .OrderBy(x => x.FaturaId)
                        .FirstOrDefault();

                    ViewData["prevModelId"] = prevModel?.FaturaId.ToString();
                    ViewData["nextModelId"] = nextModel?.FaturaId.ToString();
                    ViewData["faturaToplam"] = _context.VohalFaturaSonToplams.Where(y => y.FaturaId == currentFatura.FaturaId).FirstOrDefault() ?? new VohalFaturaSonToplam(); ;
                    ViewData["TeslimatYer"] = new SelectList(_context.TohalTeslimatYeris, "TeslimatYeriId", "Ad", currentFatura.TeslimatYeriId);
                    if (currentFatura.CariKartId != null)
                    {
                        ViewData["Bakiye"] = await BakiyeSoyleAsync((int)currentFatura.CariKartId); 


                    }
                    ViewData["faturaModel"] = _context.VohalFaturaSatiriUrts
                        .Where(y => y.FaturaId == currentFatura.FaturaId)
                        .ToList();

                    ViewData["makbuzEvrakMasraflar"] = await _context.VohalEvrakMasrafis.Where(x => x.FaturaId == currentFatura.FaturaId).OrderBy(x => x.SatirNo).ToListAsync();

                    return View(currentFatura);
                }
            }

            // Eğer geçerli bir fatura bulunamazsa, istediğin gibi bir hata kontrolü ekleyebilirsin.
            return HttpNotFound();
        }


        [HttpPost]
        public async Task<JsonResult> CreateFaturaSatir(List<TohalIskeleFaturaSatiri> tohalIskeleFaturaSatirlari)
        {
            try
            {
                RemoveIskele();
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

                        tohalIskeleFaturaSatiri.KapId = tohalIskeleFaturaSatiri.KapId == 0 ? null : tohalIskeleFaturaSatiri.KapId;
                        tohalIskeleFaturaSatiri.StokKunyeId = tohalIskeleFaturaSatiri.StokKunyeId == 0 ? null : tohalIskeleFaturaSatiri.StokKunyeId;
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



        [HttpPost]
        public async Task<ActionResult> SaveFatura([Bind(Include = "CariKartId,Tip,FaturaNo,Tarih,IrsaliyeNo,Unvan,SehirId,Adres,KisilikTipi,VergiDairesiId,VergiKimlikNo,Rusum,IskontoOrani,RusumKdvOrani,Iskonto,RusumKdv,KdvsizIadesizKap,KdvliIadesizKap,IadesizKapKdvOrani,IadesizKapKdv,Yukleme,RehinIadeliKap,YuklemeKdvOrani,YuklemeKdv,Nakliye,NakliyeKdvOrani,NakliyeKdv,Kesildi,Veresiye,Vade,EkleyenId,EklemeZamani,GuncelleyenId,GuncellemeZamani,Degistirildi,MagazaId,IrsaliyeZamani,Guid,RehinDevri,Ihracatci,PlakaNo,RusumKdvIliskisi,YerId,GsmNo,EPosta,GidecegiYerTipi,Sifati,BildirimTuru,CariSifati,HalId,TeslimatYeriId,HksWebSiraNo,GibFirmamizPostaKutusuId,GibMuhatapPostaKutusuId,Zaman,EFaturaEttn,EFaturaDurumu,EFaturaHataAciklamasi,Onaylandi,SiparisId,IskontoHesaplanmasin,HksMalinNiteligi,Aktarildi,EFaturaNot,EFaturaSiparisNo,EFaturaSiparisTarihi,EFaturaBolgeKodu,VeresiyeDurumuDegisti,MalIskontoToplami,EFaturaGibDurumu,KunyeIstekGuid,FisId,BagkurDosyaId,EIrsaliyeEttn,EIrsaliyeDurumu,EIrsaliyeHataAciklamasi,EIrsaliyeGibDurumu,GibFrmIrsaliyeKutusuId,GibMuhatapIrsaliyeKutusuId,IhracatParaBirimiId,IhracatKuru,NavlunMaliyeti,SigortaMaliyeti,TeslimatSekliId,UlasimSekliId,OdemeSekliId,FiyatReferansFaturaId,OdeyenKurumunVergiNosu,OdeyenKurumunVergiDaireId,NakitTahsilat,KrediKartiTahsilati,PosCihaziId,SoforId,IadeFaturasi")] TohalFatura tohalFatura, string totaliskontoVal = "0", string ioran = "0", bool irsaliyeBut = false)
        {
            tohalFatura.Iskonto = double.Parse(totaliskontoVal.Replace(".", ","));
            tohalFatura.IskontoOrani = double.Parse(ioran.Replace(".", ","));
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
                    {
                        parameters.Add(new SqlParameter("@YENI_KAYIT", SqlDbType.Bit)
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
                catch
                {

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
                        kdv += item.Tutar * item.KdvOrani / 100;
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


                    if (tohalFatura.Kesildi == true)
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

                                new SqlParameter("@TUR", SqlDbType.TinyInt) { Value = 0 },
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
                    // Veritabanına değişiklikleri kaydet
                    await _context.SaveChangesAsync();


                    //_context.TohalIskeleFaturaSatiris.RemoveRange(iskeleFaturaSatirlari);

                    //await _context.SaveChangesAsync();
                    RemoveIskele();
                    // İşlem başarıyla tamamlandı
                    return Json(new { success = true, message = "Başarıyla eklendi",faturaId = faturaId }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception)
                {
                    RemoveIskele();
                    return Json(new { success = false, message = "Hata Oluştu", faturaId = faturaId }, JsonRequestBehavior.DenyGet);
                }

               
            }
            RemoveIskele();
            return View(tohalFatura);
        }

        public ActionResult AlisFaturasiKunyeAL(string belgeNo, int faturaId)
        {

            var result = _hksService.Kunyeler(belgeNo);
            var result2 = _hksService.BildirimKaydet(faturaId, true);

            if (result2.Count > 0)
            {
                return Json(new { success = true, message = result2, faturaId = faturaId }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, message = "İşlem başarısız!", faturaId = faturaId }, JsonRequestBehavior.AllowGet);
            }
        }
        public async Task<ActionResult> Delete(int faturaid, int kullaniciId)
        {
            try
            {
                var parametersVer = new List<SqlParameter>
                            {
                                new SqlParameter("@FATURA_ID", (object)faturaid ?? DBNull.Value),
                                new SqlParameter("@NAKIT_TAHSILAT", DBNull.Value),
                                new SqlParameter("@KREDI_KARTI_TAHSILATI",  DBNull.Value),
                                new SqlParameter("@POS_CIHAZI_ID", DBNull.Value),
                                new SqlParameter("@VERESIYE", SqlDbType.Bit) { Value = 0 },
                                new SqlParameter("@KULLANICI_ID", SqlDbType.Int) { Value = 1 },
                                new SqlParameter("@DEGISIKLIK_TAKIP_VAR", true),
                                new SqlParameter("@VERESIYE_DURUMU_DEGISTI", 1)
                            };

                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_VERESIYE_KAYDET @FATURA_ID, @NAKIT_TAHSILAT, @KREDI_KARTI_TAHSILATI, @POS_CIHAZI_ID, @VERESIYE, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @VERESIYE_DURUMU_DEGISTI", parametersVer.ToArray());


                //var entity = _context.TohalCariHarekets.Where(x => x.FaturaId == faturaid).FirstOrDefault();
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@FATURA_ID", SqlDbType.Int){Value = faturaid},
                    new SqlParameter("@KULLANICI_ID", SqlDbType.Int){Value = kullaniciId},
                    new SqlParameter("@DEGISIKLIK_TAKIP_VAR", SqlDbType.Int){Value = kullaniciId},
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_FATURA_SIL @FATURA_ID, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR", parameters.ToArray());
                TempData["SuccessMessage"] = "Fatura Silindi";
               
                //if (entity != null) _context.TohalCariHarekets.Remove(entity);
                //_context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch (SqlException ex)
            {
                TempData["ErrorMessage"] = "Fatura Silinemedi" + ex.Errors[0].Message;
                return RedirectToAction(nameof(Index), new { faturaId = faturaid });
            }
        }

        private async Task<List<SelectListItem>> TeslimatyerlerGetir() =>
                await _context.VohalAramaTeslimatYeris.OrderBy(x => x.Ad).ThenBy(x => x.TeslimatYeriId).Select(x => new SelectListItem { Value = x.TeslimatYeriId.ToString(), Text = x.Tip + " - " + x.Ad }).ToListAsync();
        public ActionResult ilkSonKayit(bool firstOrLast)
        {
            var val = firstOrLast ? _context.VohalAramaFaturas.Where(x => x.Tip == 0).FirstOrDefault() : _context.VohalAramaFaturas.Where(x => x.Tip == 0).OrderByDescending(x => x.FaturaId).FirstOrDefault();
            return RedirectToAction("Index", new { faturaId = val?.FaturaId });
        }
        public ActionResult sonrakiOncekiKayit(bool afterOrBefore, int currentId)
        {
            var val = afterOrBefore ? _context.VohalAramaFaturas.Where(x => x.Tip == 0 && x.FaturaId > currentId).FirstOrDefault() : _context.VohalAramaFaturas.OrderByDescending(x => x.FaturaId).Where(x => x.Tip == 0 && x.FaturaId < currentId).FirstOrDefault();
            if (val == null)
                return RedirectToAction("ilkSonKayit", new { firstOrlast = !afterOrBefore });
            return RedirectToAction("Index", new { id = val?.FaturaId });
        }

        public void RemoveIskele()
        {
            _context.TohalIskeleFaturaSatiris.RemoveRange(_context.TohalIskeleFaturaSatiris);
            _context.TohalIskeleEvrakMasrafis.RemoveRange(_context.TohalIskeleEvrakMasrafis);

            _context.SaveChanges();
        }


        [HttpPost]
        public async Task<ActionResult> RehinIadeOlustur(List<TohalKapHareket> model)
        {
            foreach (var item in model)
            {
                try
                {
                    var parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@KAP_HAREKET_ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        },
                        new SqlParameter("@CARI_KART_ID", (object)item.CariKartId ?? DBNull.Value),
                        new SqlParameter("@TARIH", (object)item.Tarih ?? DBNull.Value),
                        new SqlParameter("@ACIKLAMA", (object)item.Aciklama ?? DBNull.Value),
                        new SqlParameter("@KAP_ID", (object)item.KapId ?? DBNull.Value),
                        new SqlParameter("@MIKTAR", (object)item.Miktar ?? DBNull.Value),
                        new SqlParameter("@FIYAT", (object)item.Fiyat ?? DBNull.Value),
                        new SqlParameter("@TUTAR", (object)item.Tutar ?? DBNull.Value),
                        new SqlParameter("@TIP", (object)0 ?? DBNull.Value),
                        new SqlParameter("@REHIN_FISI_ID", (object)item.RehinFisiId ?? DBNull.Value),
                        new SqlParameter("@ISLENECEGI_HESAP", (object)item.IslenecegiHesap ?? DBNull.Value),
                        new SqlParameter("@KULLANICI_ID", 1),
                        new SqlParameter("@DEGISIKLIK_TAKIP_VAR", 1),
                        new SqlParameter("@GUNCELLEME_ZAMANI", DateTime.Now.ToString("yyyy-MM-dd"))
                    };
                    await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_KAP_HAREKET_KAYDET @KAP_HAREKET_ID OUTPUT, @CARI_KART_ID, @TARIH, @ACIKLAMA, @KAP_ID, @MIKTAR, @FIYAT, @TUTAR, @TIP, @REHIN_FISI_ID, @ISLENECEGI_HESAP, @KULLANICI_ID, @DEGISIKLIK_TAKIP_VAR, @GUNCELLEME_ZAMANI", parameters.ToArray());

                }
                catch (SqlException ex)
                {
                    TempData["ErrorMessage"] = ex.Errors[0].Message;
                    return Json(new { success = false, message = "İşlem Başarısız" + ex.Errors[0].Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { success = true, message = "İşlem Başarıyla Tamamlandı" }, JsonRequestBehavior.AllowGet);
        }
        public async Task<String> BakiyeSoyleAsync(int id)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@CARI_KART_ID", SqlDbType.Int) { Value = id },
                new SqlParameter("@BAKIYE",SqlDbType.Float) { Direction = ParameterDirection.Output },
                new SqlParameter("@REHINDEKI_KAP_TUTARI", SqlDbType.Float) { Direction = ParameterDirection.Output },
                new SqlParameter("@KESILMEMIS_FATURA_TUTARI", SqlDbType.Float) { Direction = ParameterDirection.Output },
                new SqlParameter("@KESILMEYEN_DAHIL_REHINDEKI_KAP_TUTARI", SqlDbType.Float) { Direction = ParameterDirection.Output },
                new SqlParameter("@BELGE_BASMADAN_CAGRILDI", SqlDbType.Bit) { Value = 0 },
                new SqlParameter("@BORC_TOPLAMI", SqlDbType.Float) { Direction = ParameterDirection.Output },
                new SqlParameter("@ALACAK_TOPLAMI", SqlDbType.Float) { Direction = ParameterDirection.Output }
            };
            await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_BAKIYEYI_SOYLE @CARI_KART_ID, @BAKIYE OUTPUT, @REHINDEKI_KAP_TUTARI OUTPUT, @KESILMEMIS_FATURA_TUTARI OUTPUT, @KESILMEYEN_DAHIL_REHINDEKI_KAP_TUTARI OUTPUT, @BELGE_BASMADAN_CAGRILDI, @BORC_TOPLAMI OUTPUT, @ALACAK_TOPLAMI OUTPUT", parameters.ToArray());
            var bakiye = parameters[1].Value.ToString().Replace('.', ',');
            var rehindekiKapTutar = parameters[2].Value.ToString().Replace('.', ',');
            var borcToplam = parameters[6].Value.ToString().Replace('.', ',');
            var alacakToplam = parameters[7].Value.ToString().Replace('.', ',');
            return bakiye;
        }
        public async Task<JsonResult> VohalRehinFisiBekleyenGetir(int faturaId)
        {
            var data = await _context.VohalRehinFisiBekleyens.Where(x => x.FaturaId == faturaId && x.KalanMiktar > 0).OrderBy(x => x.SatirNo).ToListAsync();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult MalKabul()
        {


            ViewData["tanimRusumOrani"] = _context.TohalTanims.FirstOrDefault().AlsRusumOrani ?? 0;
            ViewData["tanimKdvOrani"] = _context.TohalTanims.FirstOrDefault().AlsDigerMalKdvOrani ?? 0;
            ViewData["tanimSifati"] = _context.TohalTanims.FirstOrDefault().DigSifati;
            ViewData["tanimBildirimTuru"] = _context.TohalTanims.FirstOrDefault().SatBildirimTuru;
            ViewData["tanimRusumOrani"] = _context.TohalTanims.FirstOrDefault().AlsRusumOrani ?? 0;



            ViewData["faturaModel"] = new List<VohalFaturaSatiriUrt>();


            return View();
        }

    }
}
