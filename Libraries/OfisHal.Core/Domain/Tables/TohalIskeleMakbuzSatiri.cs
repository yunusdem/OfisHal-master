using System;

namespace OfisHal.Core.Domain
{
    public class TohalIskeleMakbuzSatiri
    {
        public int Id { get; set; }
        public int? SatirNo { get; set; }
        public int? MalId { get; set; }
        public int? KapSayisi { get; set; }
        public double? Miktar { get; set; }
        public double? Fiyat { get; set; }
        public double? Tutar { get; set; }
        public double? KdvOrani { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public Guid? Guid { get; set; }
    }
}