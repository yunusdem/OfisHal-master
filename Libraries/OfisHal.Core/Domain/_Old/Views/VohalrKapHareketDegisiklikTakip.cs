

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrKapHareketDegisiklikTakip
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int KapHareketId { get; set; }
        public byte KartTipi { get; set; }
        public string OCariKodu { get; set; }
        public string SCariKodu { get; set; }
        public string OCariAd { get; set; }
        public string SCariAd { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public string OKapKodu { get; set; }
        public string SKapKodu { get; set; }
        public string OKapAdi { get; set; }
        public string SKapAdi { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public int? OMiktar { get; set; }
        public int? SMiktar { get; set; }
        public byte? OTip { get; set; }
        public byte? STip { get; set; }
        public double? OFiyat { get; set; }
        public double? SFiyat { get; set; }
        public double? OTutar { get; set; }
        public double? STutar { get; set; }
        public byte? OIslenecegiHesap { get; set; }
        public byte? SIslenecegiHesap { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
    }
}