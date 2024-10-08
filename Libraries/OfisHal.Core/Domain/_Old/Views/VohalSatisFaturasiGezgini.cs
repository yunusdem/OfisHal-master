

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalSatisFaturasiGezgini
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public string IrsaliyeNo { get; set; }
        public DateTime Tarih { get; set; }
        public int? CariKartId { get; set; }
        public bool? Kesildi { get; set; }
        public string Guid { get; set; }
    }
}