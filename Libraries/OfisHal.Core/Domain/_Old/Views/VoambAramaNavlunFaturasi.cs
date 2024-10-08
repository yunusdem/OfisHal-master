using System;

namespace OfisHal.Web.Models
{
    public class VoambAramaNavlunFaturasi
    {
        public int NavlunFaturasiId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string YazihaneKodu { get; set; }
        public string YazihaneAdi { get; set; }
        public string DizaynAdi { get; set; }
        public bool Kesildi { get; set; }
        public int? DizaynId { get; set; }
        public int? YazihaneSiraNo { get; set; }
        public int YazihaneId { get; set; }
        public int? BolgeKoduId { get; set; }
        public string BolgeKodu { get; set; }
    }
}