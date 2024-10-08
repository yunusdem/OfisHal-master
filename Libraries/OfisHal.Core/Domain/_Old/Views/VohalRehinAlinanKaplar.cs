

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalRehinAlinanKaplar
    {
        public int CariKartId { get; set; }
        public string MustahsilKodu { get; set; }
        public string MustahsilAdi { get; set; }
        public int KapId { get; set; }
        public string KapKodu { get; set; }
        public int? KapMiktari { get; set; }
        public double? Tutar { get; set; }
        public int? KalanMiktar { get; set; }
        public double? Fiyat { get; set; }
        public double? KalanTutar { get; set; }
    }
}