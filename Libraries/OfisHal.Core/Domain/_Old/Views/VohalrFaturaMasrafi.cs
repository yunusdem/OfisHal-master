

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrFaturaMasrafi
    {
        public int? FaturaId { get; set; }
        public string Ad { get; set; }
        public double Masraf { get; set; }
        public double Kdv { get; set; }
    }
}