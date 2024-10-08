

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMustahsilSatisIstatistigi
    {
        public DateTime StokGirisTarihi { get; set; }
        public int CariKartId { get; set; }
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public int MalId { get; set; }
        public byte Tur { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public int KapSayisi { get; set; }
        public double Fiyat { get; set; }
        public double Fiyat2 { get; set; }
        public double Miktar { get; set; }
        public double Tutar { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public double? DokRusumOrani { get; set; }
    }
}