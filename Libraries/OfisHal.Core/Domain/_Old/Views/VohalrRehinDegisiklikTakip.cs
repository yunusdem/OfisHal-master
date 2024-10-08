

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrRehinDegisiklikTakip
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int FaturaId { get; set; }
        public string OMarka { get; set; }
        public string SMarka { get; set; }
        public string OKapAdi { get; set; }
        public string SKapAdi { get; set; }
        public int? OKapMiktari { get; set; }
        public int? SKapMiktari { get; set; }
        public double? OFiyat { get; set; }
        public double? SFiyat { get; set; }
        public double? OTutar { get; set; }
        public double? STutar { get; set; }
        public bool? OElleDegistirildi { get; set; }
        public bool? SElleDegistirildi { get; set; }
        public int? OSatirNo { get; set; }
        public int? SSatirNo { get; set; }
        public int? TlKurusSayisi { get; set; }
    }
}