

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMustahsilSonUrunHareketi
    {
        public int CariKartId { get; set; }
        public string MustahsilAd { get; set; }
        public string MustahsilKod { get; set; }
        public DateTime? Tarih { get; set; }
        public int MakbuzId { get; set; }
        public string DokumNo { get; set; }
        public string UrunAd { get; set; }
        public int? KapSayisi { get; set; }
        public double? Miktar { get; set; }
    }
}