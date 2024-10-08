using System;

namespace OfisHal.Web.Models
{
    public class ToambIskeleSevkIrsaliyesiSatiri
    {
        public int? SatirId { get; set; }
        public int? SatirNo { get; set; }
        public int? HalId { get; set; }
        public int? GonderenId { get; set; }
        public bool? MuameleDahil { get; set; }
        public double? Adet { get; set; }
        public int? AmbarFiyatiId { get; set; }
        public int? MalId { get; set; }
        public int? KapId { get; set; }
        public double? HammaliyeFiyati { get; set; }
        public double? MuameleBirimFiyat { get; set; }
        public double? MuameleKdv { get; set; }
        public double? MuameleKdvOrani { get; set; }
        public double? Fiyat { get; set; }
        public double? NavlunKdv { get; set; }
        public double? NavlunKdvOrani { get; set; }
        public double? Tutar { get; set; }
        public int? DizaynId { get; set; }
        public int? MuameleDizaynId { get; set; }
        public Guid? Guid { get; set; }
        public int? PrimSahibiId { get; set; }
        public double? AmbarPrimi { get; set; }
    }
}