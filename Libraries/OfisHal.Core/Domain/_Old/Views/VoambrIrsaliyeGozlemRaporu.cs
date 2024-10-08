using System;

namespace OfisHal.Web.Models
{
    public class VoambrIrsaliyeGozlemRaporu
    {
        public int IrsaliyeId { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public string GeldigiYer { get; set; }
        public string PlakaNo { get; set; }
        public double Havale { get; set; }
        public double ToplamTutar { get; set; }
        public double GenelToplam { get; set; }
        public int AmbarId { get; set; }
        public string AmbarAdi { get; set; }
        public string AmbarKodu { get; set; }
        public string YazihaneKodu { get; set; }
        public string Yazihane { get; set; }
        public string Gonderen { get; set; }
        public string MalAdi { get; set; }
        public string KapAdi { get; set; }
        public int? Adet { get; set; }
        public string FiyatListesi { get; set; }
        public double? MuameleBirimFiyat { get; set; }
        public double? HammaliyeFiyati { get; set; }
        public double? MuameleKdvOrani { get; set; }
        public double? Fiyat { get; set; }
        public double? NavlunKdvOrani { get; set; }
        public double? Tutar { get; set; }
        public int? DizaynId { get; set; }
        public int? MuameleDizaynId { get; set; }
        public double? Prim { get; set; }
        public double? AmbarPrimi { get; set; }
        public string BolgeKodu { get; set; }
        public double Masraf { get; set; }
        public double Kesinti { get; set; }
        public double OdenecekTutar { get; set; }
        public string SatNakliyeAdlandirma { get; set; }
        public string SatHamaliyeAdlandirma { get; set; }
    }
}