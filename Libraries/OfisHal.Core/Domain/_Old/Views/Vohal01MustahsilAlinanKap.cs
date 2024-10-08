using System;

namespace OfisHal.Web.Models
{
    public class Vohal01MustahsilAlinanKap
    {
        public int? CariKartId { get; set; }
        public DateTime Tarih { get; set; }
        public int KapId { get; set; }
        public int KapMiktari { get; set; }
        public double Tutar { get; set; }
    }
}