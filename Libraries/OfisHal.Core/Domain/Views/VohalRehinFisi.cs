using System;

namespace OfisHal.Core.Domain
{
    public class VohalRehinFisi
    {
        public int? CariKartId { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public int RehinFisiId { get; set; }
        public string Guid { get; set; }
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public int SatirNo { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public int KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public int KapMiktari { get; set; }
        public bool? Iadeli { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public bool? ElleDegistirildi { get; set; }
        public int? GonderenId { get; set; }
        public string GonderenKodu { get; set; }
        public string GonderenAdi { get; set; }
    }
}