using System;

namespace OfisHal.Core.Domain
{
    public class TohksIskeleKunyeListesi
    {
        public Guid? Guid { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? GirisTarihi { get; set; }
        public string Kunye { get; set; }
        public int? MalId { get; set; }
        public double? KapMiktar { get; set; }
        public double? KiloMiktar { get; set; }
        public double? Fiyat { get; set; }
        public int? CariKartId { get; set; }
        public string PlakaNo { get; set; }
        public int? Sifat { get; set; }
        public int? TeslimatYeriId { get; set; }
        public string BelgeNo { get; set; }
    }
}