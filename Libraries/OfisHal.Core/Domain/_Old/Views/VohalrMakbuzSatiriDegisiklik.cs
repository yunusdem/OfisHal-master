

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMakbuzSatiriDegisiklik
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int MakbuzId { get; set; }
        public int? SatirNo { get; set; }
        public double? OFiyat { get; set; }
        public double? SFiyat { get; set; }
        public int? OKapSayisi { get; set; }
        public int? SKapSayisi { get; set; }
        public double? OKdvOrani { get; set; }
        public double? SKdvOrani { get; set; }
        public int? OMalId { get; set; }
        public int? SMalId { get; set; }
        public double? OMiktar { get; set; }
        public double? SMiktar { get; set; }
        public DateTime? OSatisTarihi { get; set; }
        public DateTime? SSatisTarihi { get; set; }
        public double? OTutar { get; set; }
        public double? STutar { get; set; }
        public string OMalKodu { get; set; }
        public string OMalAdi { get; set; }
        public string SMalKodu { get; set; }
        public string SMalAdi { get; set; }
    }
}