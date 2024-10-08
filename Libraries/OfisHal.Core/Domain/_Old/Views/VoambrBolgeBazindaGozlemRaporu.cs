using System;

namespace OfisHal.Web.Models
{
    public class VoambrBolgeBazindaGozlemRaporu
    {
        public DateTime FaturaTarihi { get; set; }
        public int NavlunFaturasiId { get; set; }
        public int CariKartId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public int? BolgeKoduId { get; set; }
        public string BolgeKodu { get; set; }
        public int? Sayi { get; set; }
        public int? KapAdedi { get; set; }
        public double? KdvTutari { get; set; }
        public double? MuameleTutar { get; set; }
        public double? NavlunTutar { get; set; }
        public int? DizaynId { get; set; }
        public string DizaynAdi { get; set; }
        public string DosyaAdi { get; set; }
    }
}