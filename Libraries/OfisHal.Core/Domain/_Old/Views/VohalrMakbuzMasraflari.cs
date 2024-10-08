

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMakbuzMasraflari
    {
        public int MakbuzId { get; set; }
        public string HesapAdi { get; set; }
        public double? MasrafTutari { get; set; }
        public double? KdvOrani { get; set; }
        public double? KdvTutari { get; set; }
    }
}