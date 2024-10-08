using OfisHal.Core.Domain;
using OfisHal.Data.Context;
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
    public class SatisIslemleriController : BaseController
    {
        private readonly Db _context;

        public SatisIslemleriController(Db context)
        {
            _context = context;
        }
        //Satış İşlemleri > Rehin İade
        public ActionResult RehinIade()
        {
            return View();
        }
        //Satış İşlemleri > Detaylı Satış Bordrosu
        public ActionResult DetayliSatisBordro()
        {
            return View();
        }
        //Satış İşlemleri > Satış Bordrosu
        public ActionResult SatisBordro()
        {
            return View();
        }
        //Satış İşlemleri > Fatura Aktarma
        public ActionResult FaturaAktarma()
        {
            return View();
        }
        //Satış İşlemleri > Künye Bildirim Listesi
        public ActionResult KunyeBildirimListesi()
        {
            return View();
        }
        //Satış İşlemleri > Karşılaştırmalı Satış özeti Detayı
        public ActionResult KarsilastirmaliSatisOzet()
        {
            return View();
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
        public async Task<object> BakiyeSoyleAsync(int id)
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
            return Json(new { Bakiye = bakiye, RehindekiKapTutar = rehindekiKapTutar, BorcToplam = borcToplam, AlacakToplam = alacakToplam }, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> VohalRehinFisiBekleyenGetir(int faturaId)
        {
            var data = await _context.VohalRehinFisiBekleyens.Where(x => x.FaturaId == faturaId && x.KalanMiktar > 0).OrderBy(x => x.SatirNo).ToListAsync();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
