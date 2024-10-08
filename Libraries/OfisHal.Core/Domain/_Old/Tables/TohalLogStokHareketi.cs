using System;

namespace OfisHal.Web.Models
{
    public class TohalLogStokHareketi
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int MakbuzId { get; set; }
        public int SatirNo { get; set; }
        public byte? OStokTipi { get; set; }
        public byte? SStokTipi { get; set; }
        public int? OMalId { get; set; }
        public int? SMalId { get; set; }
        public int? OKapId { get; set; }
        public int? SKapId { get; set; }
        public int? OKapSayisi { get; set; }
        public int? SKapSayisi { get; set; }
        public double? OMiktar { get; set; }
        public double? SMiktar { get; set; }
        public int? OSatilanKap { get; set; }
        public int? SSatilanKap { get; set; }
        public double? OSatilanMiktar { get; set; }
        public double? SSatilanMiktar { get; set; }
        public int? OStokKunyeId { get; set; }
        public int? SStokKunyeId { get; set; }
        public double? OFiyat { get; set; }
        public double? SFiyat { get; set; }
        public DateTime? OGirisTarihi { get; set; }
        public DateTime? SGirisTarihi { get; set; }
    }
}