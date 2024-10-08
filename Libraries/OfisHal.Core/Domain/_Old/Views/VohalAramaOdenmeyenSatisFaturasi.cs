using System;

namespace OfisHal.Web.Models
{
    public class VohalAramaOdenmeyenSatisFaturasi
    {
        public int? CariKartId { get; set; }
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public double FaturaToplami { get; set; }
    }
}