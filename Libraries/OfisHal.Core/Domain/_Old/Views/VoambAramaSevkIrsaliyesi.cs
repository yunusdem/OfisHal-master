using System;

namespace OfisHal.Web.Models
{
    public class VoambAramaSevkIrsaliyesi
    {
        public int KayitId { get; set; }
        public int IrsaliyeId { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public int? GeldigiYerId { get; set; }
        public string GeldigiYer { get; set; }
        public int? PlakaId { get; set; }
        public string PlakaNo { get; set; }
        public string Sofor { get; set; }
        public double KdvOrani { get; set; }
        public bool? Odendi { get; set; }
        public double ToplamTutar { get; set; }
        public double GenelToplam { get; set; }
        public int AmbarId { get; set; }
        public string AmbarAdi { get; set; }
        public string AmbarKodu { get; set; }
        public double Kesinti { get; set; }
    }
}