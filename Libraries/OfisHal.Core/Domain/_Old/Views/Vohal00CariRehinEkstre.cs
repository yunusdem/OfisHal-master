using System;

namespace OfisHal.Web.Models
{
    public class Vohal00CariRehinEkstre
    {
        public int CariKartId { get; set; }
        public DateTime Tarih { get; set; }
        public int? RehinMiktari { get; set; }
        public double RehinTutari { get; set; }
        public double KesilmeyenDahilRehinTutari { get; set; }
    }
}