

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrAlisFaturasiRehinDetay
    {
        public int FaturaId { get; set; }
        public string Kap { get; set; }
        public int? KapMiktari { get; set; }
        public double Fiyat { get; set; }
        public double? Tutar { get; set; }
        public string Marka { get; set; }
    }
}