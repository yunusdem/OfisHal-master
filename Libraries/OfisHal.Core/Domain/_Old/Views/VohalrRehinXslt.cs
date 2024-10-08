

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrRehinXslt
    {
        public int FaturaId { get; set; }
        public string Marka { get; set; }
        public string MustasilAdi { get; set; }
        public string KapAdi { get; set; }
        public int KapMiktari { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public int? FiyatKurusSayisi { get; set; }
    }
}