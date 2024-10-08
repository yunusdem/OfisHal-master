using System;

namespace OfisHal.Core.Domain
{
    public class VohalGonderimeHazirEIrsaliye
    {
        public int FaturaId { get; set; }
        public string IrsaliyeNo { get; set; }
        public DateTime Tarih { get; set; }
        public int? CariKartId { get; set; }
        public string Unvan { get; set; }
        public string EIrsaliyeHataAciklamasi { get; set; }
        public double? ToplamTutar { get; set; }
        public byte EIrsaliyeDurumu { get; set; }
        public int? EBelgeTuru { get; set; }
        public string EIrsaliyeBelgesi { get; set; }
    }
}