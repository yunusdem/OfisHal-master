

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrKesintiRaporu
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string MustahsilKodu { get; set; }
        public string MustahsilAdi { get; set; }
        public string VergiKimlikNo { get; set; }
        public double? StopajMasrafi { get; set; }
        public double? RusumMasrafi { get; set; }
        public double? BorsaMasrafi { get; set; }
        public double? BagkurMasrafi { get; set; }
        public string HesStopajHesabiKodu { get; set; }
        public string HesRusumHesabiKodu { get; set; }
        public string HesBorsaHesabiKodu { get; set; }
        public string HesBagkurHesabiKodu { get; set; }
        public int Tip { get; set; }
    }
}