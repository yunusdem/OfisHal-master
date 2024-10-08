

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrTicariKarlilikFaturaDetay
    {
        public double Tutar { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriKodu { get; set; }
        public DateTime Tarih { get; set; }
        public int SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public string SiparisAciklamasi { get; set; }
        public string FaturaNo { get; set; }
        public int FaturaId { get; set; }
        public string MalAdi { get; set; }
        public string Birim { get; set; }
        public double MalMiktari { get; set; }
        public double Fiyat { get; set; }
        public int Tip { get; set; }
        public byte? BirimId { get; set; }
        public double SatirIskonto { get; set; }
    }
}