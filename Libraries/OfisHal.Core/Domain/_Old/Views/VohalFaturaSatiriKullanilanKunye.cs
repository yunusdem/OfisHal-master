

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalFaturaSatiriKullanilanKunye
    {
        public int FaturaId { get; set; }
        public int FaturaSatiriId { get; set; }
        public int FaturaSatiriNo { get; set; }
        public int KunyeSatirId { get; set; }
        public int? SatirNo { get; set; }
        public int? StokKunyeId { get; set; }
        public string StokKunye { get; set; }
        public int? SatisKunyeId { get; set; }
        public string SatisKunye { get; set; }
        public double? Miktar { get; set; }
    }
}