using System;

namespace OfisHal.Web.Models
{
    public class TohalLogObSatiri
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int OdemeBordrosuId { get; set; }
        public int SatirNo { get; set; }
        public int OdemeAraciId { get; set; }
        public bool? OOdemeAraciSahibi { get; set; }
        public bool? SOdemeAraciSahibi { get; set; }
        public int? OSonrakiBordroId { get; set; }
        public int? SSonrakiBordroId { get; set; }
        public byte? OTur { get; set; }
        public byte? STur { get; set; }
        public int? OBankaId { get; set; }
        public int? SBankaId { get; set; }
        public int? OBankaHesabiId { get; set; }
        public int? SBankaHesabiId { get; set; }
        public string OOdemeAraciNo { get; set; }
        public string SOdemeAraciNo { get; set; }
        public DateTime? OVadeTarihi { get; set; }
        public DateTime? SVadeTarihi { get; set; }
        public double? OMeblag { get; set; }
        public double? SMeblag { get; set; }
        public bool? OBaskasinaAit { get; set; }
        public bool? SBaskasinaAit { get; set; }
    }
}