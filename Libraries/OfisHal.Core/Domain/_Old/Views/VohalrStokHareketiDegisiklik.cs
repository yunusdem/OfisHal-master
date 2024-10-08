

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrStokHareketiDegisiklik
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int MakbuzId { get; set; }
        public int? SatirNo { get; set; }
        public double? OFiyat { get; set; }
        public double? SFiyat { get; set; }
        public int? OKapId { get; set; }
        public int? SKapId { get; set; }
        public int? OKapSayisi { get; set; }
        public int? SKapSayisi { get; set; }
        public int? OMalId { get; set; }
        public int? SMalId { get; set; }
        public double? OMiktar { get; set; }
        public double? SMiktar { get; set; }
        public int? OSatilanKap { get; set; }
        public int? SSatilanKap { get; set; }
        public double? OSatilanMiktar { get; set; }
        public double? SSatilanMiktar { get; set; }
        public byte? OStokTipi { get; set; }
        public byte? SStokTipi { get; set; }
        public string OMalKodu { get; set; }
        public string OMalAdi { get; set; }
        public string SMalKodu { get; set; }
        public string SMalAdi { get; set; }
        public string OKapKodu { get; set; }
        public string OKapAdi { get; set; }
        public string SKapKodu { get; set; }
        public string SKapAdi { get; set; }
    }
}