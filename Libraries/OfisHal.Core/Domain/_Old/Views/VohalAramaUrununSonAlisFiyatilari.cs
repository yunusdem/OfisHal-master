using System;

namespace OfisHal.Web.Models
{
    public class VohalAramaUrununSonAlisFiyatilari
    {
        public int? FaturaId { get; set; }
        public int? CariKartId { get; set; }
        public int? MalId { get; set; }
        public string MustahsilAdi { get; set; }
        public string MalAdi { get; set; }
        public DateTime? Tarih { get; set; }
        public string FaturaNo { get; set; }
        public double Fiyat { get; set; }
    }
}