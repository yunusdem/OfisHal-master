

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMakbuzSatiriXslt
    {
        public int MakbuzId { get; set; }
        public int SatirNo { get; set; }
        public int? MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public string DigerMalAdi { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public string MalBirimi { get; set; }
        public string EFaturaUneceKisaltma { get; set; }
    }
}