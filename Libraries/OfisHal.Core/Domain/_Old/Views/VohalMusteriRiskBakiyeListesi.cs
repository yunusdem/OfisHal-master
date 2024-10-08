

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalMusteriRiskBakiyeListesi
    {
        public int CariKartId { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public double VeresiyeBakiye { get; set; }
        public double BekleyenCekBakiye { get; set; }
        public double RiskBakiye { get; set; }
    }
}