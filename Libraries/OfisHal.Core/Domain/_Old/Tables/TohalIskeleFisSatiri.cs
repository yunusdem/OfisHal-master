using System;

namespace OfisHal.Web.Models
{
    public class TohalIskeleFisSatiri
    {
        public Guid? Guid { get; set; }
        public int? FisSatiriId { get; set; }
        public int? SatirNo { get; set; }
        public int? MarkaId { get; set; }
        public int? CariKartId { get; set; }
        public int? MalId { get; set; }
        public int? KapId { get; set; }
        public int? KapMiktari { get; set; }
        public double? Darali { get; set; }
        public double? Dara { get; set; }
        public double? MalMiktari { get; set; }
        public double? PiyasaFiyati { get; set; }
        public double? FiyatFarki { get; set; }
        public double? Fiyat { get; set; }
        public double? Tutar { get; set; }
    }
}