using System;

namespace OfisHal.Web.Models
{
    public class VoambrAmbarListeDokumu
    {
        public int IrsaliyeId { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public string IstasyonKod { get; set; }
        public string IstasyonAd { get; set; }
        public string PlakaNo { get; set; }
        public string YazihaneKod { get; set; }
        public string YazihaneAd { get; set; }
        public string Mal { get; set; }
        public int Kap { get; set; }
        public string GonderenKod { get; set; }
        public string GonderenAd { get; set; }
    }
}