using System;

namespace OfisHal.Web.Models
{
    public class VoambrIrsaliyeGozlemRaporuPrimDetayi
    {
        public int IrsaliyeId { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public double Prim { get; set; }
        public double? AmbarPrimi { get; set; }
        public double? AmbarPrimFiyat { get; set; }
        public int Adet { get; set; }
        public int? PrimSahibiId { get; set; }
        public string PrimSahibiKodu { get; set; }
        public string PrimSahibi { get; set; }
        public int SatirNo { get; set; }
    }
}