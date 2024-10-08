

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMustahsilSatisRaporu
    {
        public int MakbuzId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public int CariKartId { get; set; }
        public string MustahsilKodu { get; set; }
        public string MustahsilAdi { get; set; }
        public int MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public string Aciklama { get; set; }
        public bool? Kesildi { get; set; }
        public int? KapSayisi { get; set; }
        public double? Miktar { get; set; }
        public double? OrtalamaFiyat { get; set; }
        public double? Tutar { get; set; }
        public double? MalKdv { get; set; }
    }
}