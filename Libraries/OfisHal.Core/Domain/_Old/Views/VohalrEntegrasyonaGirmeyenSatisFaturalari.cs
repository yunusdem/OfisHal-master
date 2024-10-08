

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrEntegrasyonaGirmeyenSatisFaturalari
    {
        public int FaturaId { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public string Unvan { get; set; }
        public int RefNo { get; set; }
        public double? ToplamTutar { get; set; }
    }
}