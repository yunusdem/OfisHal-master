using System;

namespace OfisHal.Web.Models
{
    public class VoambrNavlunFaturaDokumu
    {
        public DateTime FaturaTarihi { get; set; }
        public int NavlunFaturasiId { get; set; }
        public string FaturaNo { get; set; }
        public int CariKartId { get; set; }
        public string YazihaneKodu { get; set; }
        public string Yazihane { get; set; }
        public int? Adet { get; set; }
        public double Tutar { get; set; }
        public int DizaynId { get; set; }
        public string DizaynAdi { get; set; }
        public string DosyaAdi { get; set; }
        public int? BolgeKoduId { get; set; }
        public string BolgeKodu { get; set; }
    }
}