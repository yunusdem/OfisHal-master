using System;

namespace OfisHal.Web.Models
{
    public class ToambLogSevkIrsaliyesi
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int IrsaliyeId { get; set; }
        public int? OAmbarId { get; set; }
        public int? SAmbarId { get; set; }
        public int? OGeldigiYerId { get; set; }
        public int? SGeldigiYerId { get; set; }
        public string OIrsaliyeNo { get; set; }
        public string SIrsaliyeNo { get; set; }
        public DateTime? OIrsaliyeTarihi { get; set; }
        public DateTime? SIrsaliyeTarihi { get; set; }
        public int? OPlakaId { get; set; }
        public int? SPlakaId { get; set; }
        public string OSofor { get; set; }
        public string SSofor { get; set; }
        public string OSoforNot { get; set; }
        public string SSoforNot { get; set; }
        public double? OToplamTutar { get; set; }
        public double? SToplamTutar { get; set; }
        public double? OKdvOrani { get; set; }
        public double? SKdvOrani { get; set; }
        public double? OKdv { get; set; }
        public double? SKdv { get; set; }
        public bool? OOdendi { get; set; }
        public bool? SOdendi { get; set; }
        public bool? OTutariDegistir { get; set; }
        public bool? STutariDegistir { get; set; }
        public bool? OKesinti { get; set; }
        public bool? SKesinti { get; set; }
    }
}