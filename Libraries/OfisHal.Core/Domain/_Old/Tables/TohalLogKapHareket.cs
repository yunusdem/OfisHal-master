using System;

namespace OfisHal.Web.Models
{
    public class TohalLogKapHareket
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int KapHareketId { get; set; }
        public int? OCariKartId { get; set; }
        public int? SCariKartId { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public int? OKapId { get; set; }
        public int? SKapId { get; set; }
        public byte? OTip { get; set; }
        public byte? STip { get; set; }
        public int? OMiktar { get; set; }
        public int? SMiktar { get; set; }
        public double? OFiyat { get; set; }
        public double? SFiyat { get; set; }
        public double? OTutar { get; set; }
        public double? STutar { get; set; }
        public int? ORehinFisiId { get; set; }
        public int? SRehinFisiId { get; set; }
        public byte? OIslenecegiHesap { get; set; }
        public byte? SIslenecegiHesap { get; set; }
    }
}