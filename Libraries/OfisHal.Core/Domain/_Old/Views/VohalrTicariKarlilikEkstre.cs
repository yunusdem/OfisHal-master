

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrTicariKarlilikEkstre
    {
        public double Tutar { get; set; }
        public int FaturaId { get; set; }
        public string Ad { get; set; }
        public double Satis { get; set; }
        public double Fiyat { get; set; }
        public double Alis { get; set; }
        public int SatilanKap { get; set; }
        public int AlinanKap { get; set; }
        public string FaturaNo { get; set; }
    }
}