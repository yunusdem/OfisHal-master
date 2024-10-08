using System;

namespace OfisHal.Web.Models
{
    public class CevapTablosuBagkur
    {
        public Guid Guid { get; set; }
        public int SatirNo { get; set; }
        public string Cevap { get; set; }
        public int? HataKodu { get; set; }
        public string HataMesaji { get; set; }
        public int KullaniciId { get; set; }
    }
}