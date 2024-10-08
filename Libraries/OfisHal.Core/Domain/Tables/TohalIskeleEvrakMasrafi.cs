using System;

namespace OfisHal.Core.Domain
{
    public class TohalIskeleEvrakMasrafi
    {
        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public int? SatirNo { get; set; }
        public int? HesapId { get; set; }
        public int? KapId { get; set; }
        public int? KapSayisi { get; set; }
        public double? KapFiyati { get; set; }
        public double? Masraf { get; set; }
        public double? KdvOrani { get; set; }
        public double? Kdv { get; set; }
        public byte? Muhatap { get; set; }
        public double? KesintiOrani { get; set; }
    }
}