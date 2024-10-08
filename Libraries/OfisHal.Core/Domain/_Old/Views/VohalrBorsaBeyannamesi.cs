

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrBorsaBeyannamesi
    {
        public int MakbuzId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public int CariKartId { get; set; }
        public string MustahsilKodu { get; set; }
        public string MustahsilAdi { get; set; }
        public string VergiKimlikNo { get; set; }
        public string Adres { get; set; }
        public int? MalId { get; set; }
        public string MalAdi { get; set; }
        public int? KapSayisi { get; set; }
        public double? Miktar { get; set; }
        public double? MinFiyat { get; set; }
        public double? MaxFiyat { get; set; }
        public double? Tutar { get; set; }
        public double Borsa { get; set; }
    }
}