

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMuhHesapMizani
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public int? Yil { get; set; }
        public int? Ay { get; set; }
        public double? BorcToplami { get; set; }
        public double? AlacakToplami { get; set; }
        public int KurusBasamakSayisi { get; set; }
    }
}