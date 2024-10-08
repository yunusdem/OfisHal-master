using System;

namespace OfisHal.Web.Models
{
    public class TohalIskeleKullanilanKunye
    {
        public Guid? Guid { get; set; }
        public int? KunyeSatirId { get; set; }
        public int? SatirNo { get; set; }
        public int? FaturaSatiriId { get; set; }
        public int? FaturaSatiriNo { get; set; }
        public int? StokKunyeId { get; set; }
        public int? SatisKunyeId { get; set; }
        public double? Miktar { get; set; }
    }
}