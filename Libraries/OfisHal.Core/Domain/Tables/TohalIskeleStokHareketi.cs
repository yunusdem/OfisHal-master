using System;

namespace OfisHal.Core.Domain
{
    public class TohalIskeleStokHareketi
    {
        public int Id { get; set; }
        public int? StokHareketiId { get; set; }
        public int? SatirNo { get; set; }
        public DateTime? GirisTarihi { get; set; }
        public int? StokTipi { get; set; }
        public int? MalId { get; set; }
        public int? KapId { get; set; }
        public int? KapSayisi { get; set; }
        public double? Miktar { get; set; }
        public double? Fiyat { get; set; }
        public double? SatilanMiktar { get; set; }
        public int? SatilanKap { get; set; }
        public int? AlisKunyeId { get; set; }
        public int? StokKunyeId { get; set; }
        public int? VtStokKunyeId { get; set; }
        public string Aciklama { get; set; }
        public Guid? Guid { get; set; }
    }
}