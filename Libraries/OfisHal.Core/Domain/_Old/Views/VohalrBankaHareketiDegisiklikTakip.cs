

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrBankaHareketiDegisiklikTakip
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int BankaHareketiId { get; set; }
        public string OHesapNo { get; set; }
        public string SHesapNo { get; set; }
        public string OHesapAdi { get; set; }
        public string SHesapAdi { get; set; }
        public string OKarsiHesapAdi { get; set; }
        public string SKarsiHesapAdi { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public double? OMeblag { get; set; }
        public double? SMeblag { get; set; }
        public byte? OIslemTipi { get; set; }
        public byte? SIslemTipi { get; set; }
        public int? TlKurusSayisi { get; set; }
    }
}