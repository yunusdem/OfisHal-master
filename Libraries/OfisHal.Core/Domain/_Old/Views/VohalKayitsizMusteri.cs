

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalKayitsizMusteri
    {
        public int KayitsizMusteriId { get; set; }
        public string Unvan { get; set; }
        public string GsmNo { get; set; }
        public string EPosta { get; set; }
        public string VergiKimlikNo { get; set; }
        public int? VergiDairesiId { get; set; }
        public string VergiDairesi { get; set; }
        public int? IlId { get; set; }
        public string IlAdi { get; set; }
        public int? IlceId { get; set; }
        public string IlceAdi { get; set; }
        public int? BeldeId { get; set; }
        public string BeldeAdi { get; set; }
        public string Adres { get; set; }
        public byte KisilikTipi { get; set; }
        public bool? Ihracatci { get; set; }
        public string PlakaNo { get; set; }
        public byte? GidecegiYerTipi { get; set; }
        public byte? Sifati { get; set; }
        public byte? BildirimTuru { get; set; }
        public byte? CariSifati { get; set; }
        public int? HalId { get; set; }
        public string HalAdi { get; set; }
        public int? SehirId { get; set; }
        public string Sehir { get; set; }
        public bool? Komisyoncu { get; set; }
        public int? GidecegiYerWebSiraNo { get; set; }
        public int? HksId { get; set; }
        public bool? HksBilgisiAlindi { get; set; }
    }
}