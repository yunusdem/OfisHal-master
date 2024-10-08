

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSiparisFaturaMasraf
    {
        public string Ad { get; set; }
        public double Masraf { get; set; }
        public double Kdv { get; set; }
        public int? SiparisId { get; set; }
    }
}