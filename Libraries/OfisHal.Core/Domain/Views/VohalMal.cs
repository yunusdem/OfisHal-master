using System;

namespace OfisHal.Core.Domain
{
    public class VohalMal
    {
        public int MalId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public byte Tur { get; set; }
        public byte? Birim { get; set; }
        public byte? FaturaBirimi { get; set; }
        public byte? GrupNo { get; set; }
        public int? DigerAdId { get; set; }
        public string DigerAdi { get; set; }
        public int? HksMalId { get; set; }
        public int? HksMalAdiId { get; set; }
        public string HksMalAdi { get; set; }
        public int? HksMalCinsiId { get; set; }
        public int? HksUrunCinsiId { get; set; }
        public string HksMalCinsi { get; set; }
        public byte? UretimSekli { get; set; }
        public string HksMalKodu { get; set; }
        public int? AlisHesapId { get; set; }
        public string AlisHesapKodu { get; set; }
        public int? SatisHesapId { get; set; }
        public string SatisHesapKodu { get; set; }
        public double? KdvOrani { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public string GtipNo { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
        public string KdvTevkifatTanimiAciklamasi { get; set; }
        public int? KdvTevkifatPayi { get; set; }
        public int? KdvTevkifatPaydasi { get; set; }
        public double? KdvTevkifatUygulamaAltSiniri { get; set; }
        public int? KapIcindekiMiktari { get; set; }
        public double? OrtalamaKilo { get; set; }
    }
}