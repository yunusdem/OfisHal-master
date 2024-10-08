using System;

namespace OfisHal.Web.Models
{
    public class TohalLogFaturaSatiri
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int FaturaId { get; set; }
        public int? SatirNo { get; set; }
        public byte? OSatisTipi { get; set; }
        public byte? SSatisTipi { get; set; }
        public int? OMarkaId { get; set; }
        public int? SMarkaId { get; set; }
        public int? OMalId { get; set; }
        public int? SMalId { get; set; }
        public int? OKapId { get; set; }
        public int? SKapId { get; set; }
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
        public int? SStokKunyeId { get; set; }
        public int? OAlisKunyeId { get; set; }
        public int? SAlisKunyeId { get; set; }
        public int? OSatisKunyeId { get; set; }
        public int? SSatisKunyeId { get; set; }
        public bool? ORusumHesaplanmasin { get; set; }
        public bool? SRusumHesaplanmasin { get; set; }
        public int? OAlisFatSatId { get; set; }
        public int? SAlisFatSatId { get; set; }
        public double? OIskontoOrani { get; set; }
        public double? SIskontoOrani { get; set; }
        public double? OIskonto { get; set; }
        public double? SIskonto { get; set; }
        public int? OFisSatiriId { get; set; }
        public int? SFisSatiriId { get; set; }
        public double? OMalKapFiyati { get; set; }
        public double? SMalKapFiyati { get; set; }
        public int? OKdvTevkifatTanimiId { get; set; }
        public int? SKdvTevkifatTanimiId { get; set; }
    }
}