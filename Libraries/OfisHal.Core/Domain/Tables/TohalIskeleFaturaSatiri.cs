using System;

namespace OfisHal.Core.Domain
{
    public class TohalIskeleFaturaSatiri
    {
        public Guid? Guid { get; set; }
        public int? SatirId { get; set; }
        public int? SatirNo { get; set; }
        public byte? SatisTipi { get; set; }
        public int? MarkaId { get; set; }
        public string Aciklama { get; set; }
        public int? MalId { get; set; }
        public int? KapId { get; set; }
        public int? KapMiktari { get; set; }
        public double? Darali { get; set; }
        public double? Dara { get; set; }
        public double? MalMiktari { get; set; }
        public double? Fiyat { get; set; }
        public double? Tutar { get; set; }
        public double? RusumOrani { get; set; }
        public double? Rusum { get; set; }
        public double? KdvOrani { get; set; }
        public string SatirGuid { get; set; }
        public int? StokKunyeId { get; set; }
        public int? AlisKunyeId { get; set; }
        public int? SatisKunyeId { get; set; }
        public bool? RusumHesaplanmasin { get; set; }
        public int? AlisFatSatId { get; set; }
        public int? VtStokKunyeId { get; set; }
        public int? VtSatisKunyeId { get; set; }
        public bool? TutarHesaplanmasin { get; set; }
        public double? IskontoPayi { get; set; }
        public double? IskontoOrani { get; set; }
        public double? Iskonto { get; set; }
        public bool? IskontoHesaplanmasin { get; set; }
        public int? FisSatiriId { get; set; }
        public double? MalKapFiyati { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
        public int? KdvTevkifatPayi { get; set; }
        public int? KdvTevkifatPaydasi { get; set; }
        public double? Yukleme { get; set; }
    }
}