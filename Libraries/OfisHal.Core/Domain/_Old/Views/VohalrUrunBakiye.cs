

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrUrunBakiye
    {
        public double? Giris { get; set; }
        public double? Cikis { get; set; }
        public string Urun { get; set; }
        public DateTime Tarih { get; set; }
        public string Kod { get; set; }
        public string MustahsilAdi { get; set; }
        public decimal KapGiris { get; set; }
        public decimal KapCikis { get; set; }
    }
}