

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrTicariKarlilik
    {
        public double? Alis { get; set; }
        public double? AlisMalMiktari { get; set; }
        public double? Satis { get; set; }
        public double? SatisMalMiktari { get; set; }
        public string MusteriAdi { get; set; }
        public string Kod { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public int SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public string SiparisAciklamasi { get; set; }
        public double? AlisFaturasiMasrafi { get; set; }
        public double? SatisFaturasiMasrafi { get; set; }
    }
}