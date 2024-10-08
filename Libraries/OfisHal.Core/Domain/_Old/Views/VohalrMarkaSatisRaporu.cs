

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMarkaSatisRaporu
    {
        public DateTime Tarih { get; set; }
        public bool? Kesildi { get; set; }
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public int MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public int KapMiktari { get; set; }
        public double Fiyat { get; set; }
        public double MalMiktari { get; set; }
        public double NetTutar { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public string KapAdi { get; set; }
        public string KapKodu { get; set; }
    }
}