

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalEFaturaEvrakKdv
    {
        public int? FaturaId { get; set; }
        public int? MakbuzId { get; set; }
        public double? Oran { get; set; }
        public double? Matrah { get; set; }
        public double? Kdv { get; set; }
        public string Kod { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
    }
}