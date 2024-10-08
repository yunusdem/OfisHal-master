using System;

namespace OfisHal.Web.Models
{
    public class VoambrAmbarPrimi
    {
        public int IrsaliyeId { get; set; }
        public DateTime Tarih { get; set; }
        public string PlakaNo { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public int? Adet { get; set; }
        public double? AmbarPrimi { get; set; }
    }
}