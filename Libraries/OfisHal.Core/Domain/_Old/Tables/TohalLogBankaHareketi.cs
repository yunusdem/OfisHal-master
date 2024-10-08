using System;

namespace OfisHal.Web.Models
{
    public class TohalLogBankaHareketi
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int BankaHareketiId { get; set; }
        public int? OBankaHesabiId { get; set; }
        public int? SBankaHesabiId { get; set; }
        public int? OCariKartId { get; set; }
        public int? SCariKartId { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public double? OMeblag { get; set; }
        public double? SMeblag { get; set; }
        public byte? OIslemTipi { get; set; }
        public byte? SIslemTipi { get; set; }
        public int? OHesapId { get; set; }
        public int? SHesapId { get; set; }
        public int? OKarsiBankaHesabiId { get; set; }
        public int? SKarsiBankaHesabiId { get; set; }
        public int? OPosCihaziId { get; set; }
        public int? SPosCihaziId { get; set; }
    }
}