

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrBordroHesabi
    {
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public double? Rusum { get; set; }
        public double? KdvsizTutar { get; set; }
        public double? KiloMiktari { get; set; }
        public int? KapMiktari { get; set; }
        public double? MahsupEdilen { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public double? Tevkifat { get; set; }
        public double? Kdv { get; set; }
    }
}