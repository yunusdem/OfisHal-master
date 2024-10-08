

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrHesapHareketiDegisiklikTakip
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int HesapHareketiId { get; set; }
        public string OHesapKodu { get; set; }
        public string SHesapKodu { get; set; }
        public string OHesapAdi { get; set; }
        public string SHesapAdi { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public double? OMeblag { get; set; }
        public double? SMeblag { get; set; }
        public double? OKdv { get; set; }
        public double? SKdv { get; set; }
        public byte? OTip { get; set; }
        public byte? STip { get; set; }
        public double? OKdvOrani { get; set; }
        public double? SKdvOrani { get; set; }
        public int? TlKurusSayisi { get; set; }
        public byte? OHareketTipi { get; set; }
        public byte? SHareketTipi { get; set; }
    }
}