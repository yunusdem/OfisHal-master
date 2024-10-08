

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSatisIzlenebilirligi
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public string FaturaUnvani { get; set; }
        public string MusteriKodu { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string UrunAdi { get; set; }
        public string Marka { get; set; }
        public double Miktar { get; set; }
        public int MiktarBasamakSayisi { get; set; }
        public int KapMiktari { get; set; }
        public double BirimFiyati { get; set; }
        public int? FiyatKurusBasamakSayisi { get; set; }
        public double? NetTutar { get; set; }
        public double? MalKdv { get; set; }
        public string DokumNo { get; set; }
        public string MustahsilFatNo { get; set; }
        public string MustahsilKodu { get; set; }
        public string MustahsilAdi { get; set; }
    }
}