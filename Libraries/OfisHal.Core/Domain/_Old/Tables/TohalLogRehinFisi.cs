using System;

namespace OfisHal.Web.Models
{
    public class TohalLogRehinFisi
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int FaturaId { get; set; }
        public int? OSatirNo { get; set; }
        public int? SSatirNo { get; set; }
        public int? OMarkaId { get; set; }
        public int? SMarkaId { get; set; }
        public int? OKapId { get; set; }
        public int? SKapId { get; set; }
        public int? OKapMiktari { get; set; }
        public int? SKapMiktari { get; set; }
        public double? OFiyat { get; set; }
        public double? SFiyat { get; set; }
        public double? OTutar { get; set; }
        public double? STutar { get; set; }
        public bool? OElleDegistirildi { get; set; }
        public bool? SElleDegistirildi { get; set; }
    }
}