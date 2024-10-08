

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalHazirdaVeIslemdekiMakbuzlar
    {
        public int CariKartId { get; set; }
        public string Kod { get; set; }
        public int? HazirdakiMakbuzSayisi { get; set; }
        public int? IslemdekiMakbuzSayisi { get; set; }
        public double? HazirdakiMakbuzTutari { get; set; }
        public double? IslemdekiMakbuzTutari { get; set; }
    }
}