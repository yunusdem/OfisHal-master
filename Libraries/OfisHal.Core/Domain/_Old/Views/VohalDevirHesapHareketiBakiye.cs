

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalDevirHesapHareketiBakiye
    {
        public int HesapId { get; set; }
        public string HesapAdi { get; set; }
        public double? KasaHareketiBakiyesi { get; set; }
        public double? HesapHareketiBakiyesi { get; set; }
    }
}