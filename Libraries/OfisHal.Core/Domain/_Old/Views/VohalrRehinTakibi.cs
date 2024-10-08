

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrRehinTakibi
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Marka { get; set; }
        public string KapAdi { get; set; }
        public int KapMiktari { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public int IadeMiktari { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public int RehinFisiId { get; set; }
        public int Tip { get; set; }
        public bool? Iadeli { get; set; }
    }
}