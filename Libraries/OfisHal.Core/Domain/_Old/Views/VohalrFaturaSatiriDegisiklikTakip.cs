

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrFaturaSatiriDegisiklikTakip
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int FaturaId { get; set; }
        public string OMarka { get; set; }
        public string SMarka { get; set; }
        public int? SatirNo { get; set; }
        public string OMalKodu { get; set; }
        public string OMalAdi { get; set; }
        public string SMalKodu { get; set; }
        public string SMalAdi { get; set; }
        public string OKapKodu { get; set; }
        public string OKapAdi { get; set; }
        public string SKapKodu { get; set; }
        public string SKapAdi { get; set; }
        public int? OKapMiktari { get; set; }
        public int? SKapMiktari { get; set; }
        public double? ODarali { get; set; }
        public double? SDarali { get; set; }
        public double? ODara { get; set; }
        public double? SDara { get; set; }
        public double? OMalMiktari { get; set; }
        public double? SMalMiktari { get; set; }
        public double? OFiyat { get; set; }
        public double? SFiyat { get; set; }
        public double? OTutar { get; set; }
        public double? STutar { get; set; }
        public double? OKdvOrani { get; set; }
        public double? SKdvOrani { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public double? ORusumOrani { get; set; }
        public double? SRusumOrani { get; set; }
        public double? ORusum { get; set; }
        public double? SRusum { get; set; }
        public int? OStokKunyeId { get; set; }
        public string OStokK { get; set; }
        public int? SStokKunyeId { get; set; }
        public string SStokK { get; set; }
        public int? OSatisKunyeId { get; set; }
        public string OSatisK { get; set; }
        public int? SSatisKunyeId { get; set; }
        public string SSatisK { get; set; }
        public int? TlKurusSayisi { get; set; }
        public double? OIskonto { get; set; }
        public double? SIskonto { get; set; }
        public double? OIskontoOrani { get; set; }
        public double? SIskontoOrani { get; set; }
    }
}