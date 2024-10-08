using System;

namespace OfisHal.Core.Domain
{
    public class VohalGonderimeHazirEFatura
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public int? CariKartId { get; set; }
        public string Unvan { get; set; }
        public string EFaturaHataAciklamasi { get; set; }
        public double? ToplamTutar { get; set; }
        public byte EFaturaDurumu { get; set; }
        public int? EBelgeTuru { get; set; }
        public string EFaturaBelgesi { get; set; }
    }
}