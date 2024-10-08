

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMustahsilFaturaMasraflar
    {
        public int MakbuzId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public int CariKartId { get; set; }
        public string MustahsilKodu { get; set; }
        public string MustahsilAdi { get; set; }
        public string Aciklama { get; set; }
        public int Kesildi { get; set; }
        public string Sehir { get; set; }
        public int? HesapId { get; set; }
        public string HesapAdi { get; set; }
        public double? Masraf { get; set; }
        public double? Kdv { get; set; }
    }
}