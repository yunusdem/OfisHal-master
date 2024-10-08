using System;

namespace OfisHal.Web.Models
{
    public class VoambrYazihaneHareketRaporu
    {
        public int YazihaneId { get; set; }
        public string Kod { get; set; }
        public string Yazihane { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public double Tutar { get; set; }
        public double Kdv { get; set; }
        public int DizaynId { get; set; }
        public string Dizayn { get; set; }
        public string DosyaAdi { get; set; }
    }
}