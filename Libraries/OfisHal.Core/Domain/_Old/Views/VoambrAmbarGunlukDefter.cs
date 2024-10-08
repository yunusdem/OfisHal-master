using System;

namespace OfisHal.Web.Models
{
    public class VoambrAmbarGunlukDefter
    {
        public int IrsaliyeId { get; set; }
        public string IrsaliyeNo { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public string PlakaNo { get; set; }
        public string Kod { get; set; }
        public string Ambar { get; set; }
        public double Navlun { get; set; }
        public double? Yekun { get; set; }
        public double Komisyon { get; set; }
        public double? MuameleHammaliye { get; set; }
        public double? MuameleFiyat { get; set; }
        public double? Hammaliye { get; set; }
        public double? MuameleKdv { get; set; }
        public double? NavlunKdv { get; set; }
        public int? Adet { get; set; }
        public double Kesinti { get; set; }
        public double AmbarPrimi { get; set; }
    }
}