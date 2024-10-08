

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSatisRusumRaporu
    {
        public int FaturaId { get; set; }
        public int? CariKartId { get; set; }
        public string Ad { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public string IrsaliyeNo { get; set; }
        public string VergiKimlikNo { get; set; }
        public double? MalTutari { get; set; }
        public double Rusum { get; set; }
    }
}