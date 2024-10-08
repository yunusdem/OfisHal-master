

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSatisFaturasiSatiriRehinli
    {
        public int FaturaSatiriId { get; set; }
        public int FaturaId { get; set; }
        public int SatirNo { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public int KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public double? KapFiyati { get; set; }
        public int KapMiktari { get; set; }
        public DateTime Tarih { get; set; }
        public double Tutar { get; set; }
        public string MalBirimi { get; set; }
    }
}