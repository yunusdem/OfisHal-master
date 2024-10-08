

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrDokumKontrol
    {
        public int Tip { get; set; }
        public int MakbuzId { get; set; }
        public string Kod { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
    }
}