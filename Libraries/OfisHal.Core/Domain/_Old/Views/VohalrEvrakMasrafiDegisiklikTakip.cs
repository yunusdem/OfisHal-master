

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrEvrakMasrafiDegisiklikTakip
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int? FaturaId { get; set; }
        public int? MakbuzId { get; set; }
        public string HesapAdi { get; set; }
        public string HesapKodu { get; set; }
        public int? SatirNo { get; set; }
        public int? HesapId { get; set; }
        public double? OMasraf { get; set; }
        public double? SMasraf { get; set; }
        public double? OKdvOrani { get; set; }
        public double? SKdvOrani { get; set; }
        public double? OKdv { get; set; }
        public double? SKdv { get; set; }
        public int? TlKurusSayisi { get; set; }
        public byte? OMuhatap { get; set; }
        public byte? SMuhatap { get; set; }
        public int? OKapSayisi { get; set; }
        public int? SKapSayisi { get; set; }
        public double? OKapFiyati { get; set; }
        public double? SKapFiyati { get; set; }
        public string OKapKodu { get; set; }
        public string SKapKodu { get; set; }
        public string OKapAdi { get; set; }
        public string SKapAdi { get; set; }
    }
}