

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalBuBeldeyeBagliOlmayanMusterilerIslemdeOlanlar
    {
        public int CariKartId { get; set; }
        public byte Tip { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public int? YerId { get; set; }
        public int? IlId { get; set; }
        public string IlAdi { get; set; }
        public int? IlceId { get; set; }
        public string IlceAdi { get; set; }
        public int? BeldeId { get; set; }
        public string BeldeAdi { get; set; }
        public int? SehirId { get; set; }
        public string EskiSehir { get; set; }
        public string Adres { get; set; }
    }
}