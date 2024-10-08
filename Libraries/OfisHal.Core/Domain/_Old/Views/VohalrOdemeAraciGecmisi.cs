

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrOdemeAraciGecmisi
    {
        public int OdemeAraciId { get; set; }
        public string OdemeAraciNo { get; set; }
        public string Muhatap { get; set; }
        public DateTime Tarih { get; set; }
        public string Durumu { get; set; }
        public string BordroNo { get; set; }
        public int OdemeBordrosuId { get; set; }
    }
}