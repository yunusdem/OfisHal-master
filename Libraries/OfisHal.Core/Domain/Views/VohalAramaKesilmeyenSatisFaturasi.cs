using System;

namespace OfisHal.Core.Domain
{
    public class VohalAramaKesilmeyenSatisFaturasi
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Unvan { get; set; }
        public string IrsaliyeNo { get; set; }
        public string PV { get; set; }
        public int EkleyenId { get; set; }
        public double FaturaToplami { get; set; }
    }
}