

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalDokumDefteriFiyatBazinda
    {
        public int MakbuzId { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public int? KapSayisi { get; set; }
        public double? Miktar { get; set; }
        public double Fiyat { get; set; }
        public double? Tutar { get; set; }
    }
}