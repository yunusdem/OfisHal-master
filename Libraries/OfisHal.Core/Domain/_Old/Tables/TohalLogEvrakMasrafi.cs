using System;

namespace OfisHal.Web.Models
{
    public class TohalLogEvrakMasrafi
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int? MakbuzId { get; set; }
        public int? FaturaId { get; set; }
        public int? SatirNo { get; set; }
        public int? HesapId { get; set; }
        public double? OMasraf { get; set; }
        public double? SMasraf { get; set; }
        public double? OKdvOrani { get; set; }
        public double? SKdvOrani { get; set; }
        public double? OKdv { get; set; }
        public double? SKdv { get; set; }
        public byte? OMuhatap { get; set; }
        public byte? SMuhatap { get; set; }
        public int? OKapId { get; set; }
        public int? SKapId { get; set; }
        public int? OKapSayisi { get; set; }
        public int? SKapSayisi { get; set; }
        public double? OKapFiyati { get; set; }
        public double? SKapFiyati { get; set; }
    }
}