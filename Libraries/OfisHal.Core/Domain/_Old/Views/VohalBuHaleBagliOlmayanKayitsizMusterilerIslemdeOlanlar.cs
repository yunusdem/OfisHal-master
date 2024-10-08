

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalBuHaleBagliOlmayanKayitsizMusterilerIslemdeOlanlar
    {
        public int CariKartId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public int? HalId { get; set; }
        public string HalAdi { get; set; }
        public string EskiSehir { get; set; }
        public string Adres { get; set; }
    }
}