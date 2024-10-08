

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrBekleyenStokHareketi
    {
        public int CariKartId { get; set; }
        public int StokHareketiId { get; set; }
        public int? KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public string DokumBilgisi { get; set; }
        public int? KalanKap { get; set; }
        public double KalanMiktar { get; set; }
        public string MustahsilAdi { get; set; }
        public string MustahsilKodu { get; set; }
    }
}