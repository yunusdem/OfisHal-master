

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrCariHareketDegisiklikTakip
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int CariHareketId { get; set; }
        public string OCariKodu { get; set; }
        public string SCariKodu { get; set; }
        public string OCariAd { get; set; }
        public string SCariAd { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public byte? OIslemTipi { get; set; }
        public byte? SIslemTipi { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public double? OMeblag { get; set; }
        public double? SMeblag { get; set; }
        public byte? OTip { get; set; }
        public byte? STip { get; set; }
        public byte Tip { get; set; }
    }
}