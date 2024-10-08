using System;

namespace OfisHal.Web.Models
{
    public class VoambrAmbarKomisyonu
    {
        public int? SatirNo { get; set; }
        public int IrsaliyeId { get; set; }
        public int AmbarId { get; set; }
        public int? Adet { get; set; }
        public double? Komisyon { get; set; }
        public DateTime Tarih { get; set; }
        public string AmbarKodu { get; set; }
        public string AmbarAdi { get; set; }
        public string PlakaNo { get; set; }
    }
}