

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalYer
    {
        public int IlId { get; set; }
        public string IlAdi { get; set; }
        public byte IlTuru { get; set; }
        public int? IlceId { get; set; }
        public string IlceAdi { get; set; }
        public byte? IlceTuru { get; set; }
        public int? BeldeId { get; set; }
        public string BeldeAdi { get; set; }
        public byte? BeldeTuru { get; set; }
    }
}