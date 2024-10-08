

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrTicariKarlilikDetay
    {
        public int FaturaId { get; set; }
        public string Ad { get; set; }
        public int KapMiktari { get; set; }
        public double Kg { get; set; }
        public double Tutar { get; set; }
        public double Fiyat { get; set; }
        public double Masraf { get; set; }
        public double Iskonto { get; set; }
    }
}