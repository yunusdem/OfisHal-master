

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrStokHareketiMusteriBazli
    {
        public int MakbuzId { get; set; }
        public string MalAdi { get; set; }
        public decimal Kap { get; set; }
        public double? Miktar { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
    }
}