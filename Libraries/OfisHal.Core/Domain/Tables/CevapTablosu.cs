using System;

namespace OfisHal.Web.Models
{
    public class CevapTablosu
    {
        public Guid Guid { get; set; }
        public int SatirId { get; set; }
        public int? HataKodu { get; set; }
        public string HataMesaji { get; set; }
        public string DonenAlanAdi { get; set; }
        public string DonenAlanDegeri { get; set; }
        public int SatirNo { get; set; }
    }
}