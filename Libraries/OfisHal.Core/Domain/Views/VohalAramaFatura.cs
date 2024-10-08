using System;

namespace OfisHal.Core.Domain
{
    public class VohalAramaFatura
    {
        public int FaturaId { get; set; }
        public int Tip { get; set; }
        public int? CariKartId { get; set; }
        public string Unvan { get; set; }
        public string MagazaAdi { get; set; }
        public int? RehinDevri { get; set; }
        public string ReferansNo { get; set; }
        public string PV { get; set; }
        public int? ReferansId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string IrsaliyeNo { get; set; }
        public int EkleyenId { get; set; }
        public int? SiparisId { get; set; }
        public double? SonToplam { get; set; }
    }
}