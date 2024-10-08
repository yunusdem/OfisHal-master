

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalEvrakMasrafi
    {
        public int? MakbuzId { get; set; }
        public int? FaturaId { get; set; }
        public int? SiparisId { get; set; }
        public int? IrsaliyeId { get; set; }
        public int SatirNo { get; set; }
        public int HesapId { get; set; }
        public string HesapKodu { get; set; }
        public string HesapAdi { get; set; }
        public int? KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public int? KapSayisi { get; set; }
        public double? KapFiyati { get; set; }
        public double Masraf { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public DateTime? StokGirisTarihi { get; set; }
        public double? IscilikKiloKatsayisi { get; set; }
        public double? IscilikAdetKatsayisi { get; set; }
        public double? KesintiOrani { get; set; }
        public byte Muhatap { get; set; }
    }
}