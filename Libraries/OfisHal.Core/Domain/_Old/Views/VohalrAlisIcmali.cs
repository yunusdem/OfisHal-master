

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrAlisIcmali
    {
        public DateTime Tarih { get; set; }
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public string Marka { get; set; }
        public int MalId { get; set; }
        public byte Tur { get; set; }
        public string MalAdi { get; set; }
        public int KapMiktari { get; set; }
        public double Fiyat { get; set; }
        public double Fiyat2 { get; set; }
        public double MalMiktari { get; set; }
        public double NetTutar { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public double? DokRusumOrani { get; set; }
    }
}