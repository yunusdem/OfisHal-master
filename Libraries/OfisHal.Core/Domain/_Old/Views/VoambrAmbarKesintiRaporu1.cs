using System;

namespace OfisHal.Web.Models
{
    public class VoambrAmbarKesintiRaporu1
    {
        public int CariKartId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public int RefNo { get; set; }
        public int? PlakaId { get; set; }
        public string Plaka { get; set; }
        public int? Adet { get; set; }
        public double? Navlun { get; set; }
        public double Kesinti { get; set; }
        public double Masraf { get; set; }
        public int IrsaliyeId { get; set; }
        public double AmbarPrimi { get; set; }
    }
}