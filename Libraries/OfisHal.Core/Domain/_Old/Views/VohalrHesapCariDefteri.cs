

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrHesapCariDefteri
    {
        public int HesapId { get; set; }
        public int EvrakTuru { get; set; }
        public int HesapHareketiId { get; set; }
        public DateTime? Tarih { get; set; }
        public int Tip { get; set; }
        public string Aciklama { get; set; }
        public string HesapKodu { get; set; }
        public string HesapAdi { get; set; }
        public double? Miktar { get; set; }
        public int? MiktarBasamakSayisi { get; set; }
    }
}