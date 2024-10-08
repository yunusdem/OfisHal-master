

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrKisaltmaMalListeDokumu
    {
        public byte Kisaltma { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public byte? GrupNoFiyat { get; set; }
        public int Dara { get; set; }
    }
}