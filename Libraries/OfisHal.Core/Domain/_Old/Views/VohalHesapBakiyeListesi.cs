

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalHesapBakiyeListesi
    {
        public int HesapId { get; set; }
        public string HesapKodu { get; set; }
        public string HesapAdi { get; set; }
        public double? BorcToplami { get; set; }
        public double? AlacakToplami { get; set; }
        public double? Bakiye { get; set; }
    }
}