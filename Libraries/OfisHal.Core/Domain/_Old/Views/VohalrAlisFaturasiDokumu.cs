

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrAlisFaturasiDokumu
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Unvan { get; set; }
        public bool? Kesildi { get; set; }
        public double FaturaToplami { get; set; }
        public double MasrafTutari { get; set; }
        public bool? Degistirildi { get; set; }
        public bool? Veresiye { get; set; }
    }
}