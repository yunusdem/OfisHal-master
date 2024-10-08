using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    public class ResmiFormlarController : BaseController
    {

        // Resmi Formlar > Hal Müdürlüğü İşlemleri > Döküm Künyeleri Bildir
        public ActionResult DokumKunyelerBildir()
        {
            return View();
        }
        // Resmi Formlar > Hal Müdürlüğü İşlemleri > SAtış Künyeleri Bildir
        public ActionResult SatisKunyelerBildir()
        {
            return View();
        }
        // Resmi Formlar > Hal Müdürlüğü İşlemleri > Kapanan Dökümleri Bildir
        public ActionResult KapananDokumleriBildir()
        {
            return View();
        }
        // Resmi Formlar > Hal Müdürlüğü İşlemleri > Tanımlar
        public ActionResult Tanimlar()
        {
            return View();
        }
        // Resmi Formlar > İstanbul Hal Müdürlüğü Formu
        public ActionResult IstanbulHalMudurluguFormu()
        {
            return View();
        }
        // Resmi Formlar > Eta Fatura Transferi (Txt)
        public ActionResult EtaFaturaTransfer()
        {
            return View();
        }
        // Resmi Formlar > Zirve Fatura Transferi
        public ActionResult ZirveFaturaTransferi()
        {
            return View();
        }
        // Resmi Formlar > Toplu Bildirim Formu
        public ActionResult TopluBildirmFormu()
        {//çalışmıyor sistemd
            return View();
        }
        // Resmi Formlar > Adana Hal Müdürlüğü > Adana Hal Müdürlüğü Bildirimi
        public ActionResult AdanaHalMudurluguBildirim()
        {
            return View();
        }
        // Resmi Formlar > Adana Hal Müdürlüğü > Tanımlar
        public ActionResult AdanaTanimlar()
        {
            return View();
        }
        // Resmi Formlar > Konya Hal Müdürlüğü
        public ActionResult KonyaHalMudurlugu()
        {
            return View();
        }
    }
}
