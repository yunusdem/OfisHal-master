using System;

namespace OfisHal.Web.Models
{
    public class VoambrAmbarHareketRaporu
    {
        public string Ambar { get; set; }
        public string Kod { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public int? Adet { get; set; }
        public double? Toplam { get; set; }
        public double? Kdv { get; set; }
    }
}