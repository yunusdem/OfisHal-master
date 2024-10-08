using System;

namespace OfisHal.Core.Domain
{
    public class TohalIskeleRehinFisi
    {
        public Guid? Guid { get; set; }
        public int? SatirId { get; set; }
        public int? SatirNo { get; set; }
        public int? MarkaId { get; set; }
        public int? KapId { get; set; }
        public int? KapMiktari { get; set; }
        public double? Fiyat { get; set; }
        public double? Tutar { get; set; }
        public bool? ElleDegistirildi { get; set; }
        public string SatirGuid { get; set; }
    }
}