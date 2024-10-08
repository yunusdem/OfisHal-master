

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrEvrakMasrafi
    {
        public int? MakbuzId { get; set; }
        public string HesapAdi { get; set; }
        public double Masraf { get; set; }
        public double Kdv { get; set; }
        public double Tutar { get; set; }
        public int? Tip { get; set; }
        public int? SiparisId { get; set; }
        public int? FaturaId { get; set; }
        public string FaturaNo { get; set; }
    }
}