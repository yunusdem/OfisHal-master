

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalHesap
    {
        public int HesapId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public double? KdvOrani { get; set; }
        public bool? YilsonuDevri { get; set; }
        public byte? Tip { get; set; }
        public double? IscilikKiloKatsayisi { get; set; }
        public double? IscilikAdetKatsayisi { get; set; }
        public double? KesintiOrani { get; set; }
        public int? MuhHesapId { get; set; }
        public string MuhHesapKodu { get; set; }
        public bool? RehinDevri { get; set; }
    }
}