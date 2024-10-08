

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSiparisKarsilastirmasi
    {
        public int SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public int? MalId { get; set; }
        public string MalAdi { get; set; }
        public double? SiparisMiktari { get; set; }
        public double? SatinAlimMiktari { get; set; }
        public double? SatisMiktari { get; set; }
        public string SatisBirimi { get; set; }
        public string SatinAlinanBirim { get; set; }
        public byte? Birim { get; set; }
    }
}