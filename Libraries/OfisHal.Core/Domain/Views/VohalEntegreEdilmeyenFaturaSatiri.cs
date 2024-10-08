using System;

namespace OfisHal.Core.Domain
{
    public class VohalEntegreEdilmeyenFaturaSatiri
    {
        public int FaturaId { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public string RefNo { get; set; }
        public int FaturaSatiriId { get; set; }
        public string SatirNo { get; set; }
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public int? KapId { get; set; }
        public int KapMiktari { get; set; }
        public double MalMiktari { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }
        public int StokTipi { get; set; }
        public bool? Kesildi { get; set; }
        public double? CiroPrimi { get; set; }
        public int? StokKunyeId { get; set; }
    }
}