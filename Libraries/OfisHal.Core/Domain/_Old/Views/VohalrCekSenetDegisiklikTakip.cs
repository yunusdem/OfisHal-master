

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrCekSenetDegisiklikTakip
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int OdemeBordrosuId { get; set; }
        public string OCariKodu { get; set; }
        public string SCariKodu { get; set; }
        public string OCariAd { get; set; }
        public string SCariAd { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public byte? OIslemTuru { get; set; }
        public byte? SIslemTuru { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public string OBordroNo { get; set; }
        public string SBordroNo { get; set; }
        public int? DegisenSatirSayisi { get; set; }
    }
}