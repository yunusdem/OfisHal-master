

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class VohalRehinFisiBekleyen
    {
        public int CariKartId { get; set; }
        public string MusteriKodu { get; set; }
        public string MusteriAdi { get; set; }
        public int RehinFisiId { get; set; }
        public int FaturaId { get; set; }
        public string RefNo { get; set; }
        public int FaturaTipi { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public bool? Veresiye { get; set; }
        public int? SatirNo { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public int KapId { get; set; }
        public string KapKodu { get; set; }
        public int KapMiktari { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public int? KalanMiktar { get; set; }
    }
}