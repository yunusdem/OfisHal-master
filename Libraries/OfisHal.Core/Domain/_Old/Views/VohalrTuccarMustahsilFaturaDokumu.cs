

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrTuccarMustahsilFaturaDokumu
    {
        public int MakbuzId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public int? CariKartId { get; set; }
        public string MustahsilKodu { get; set; }
        public string MustahsilAdi { get; set; }
        public string Marka { get; set; }
        public string VergiKimlikNo { get; set; }
        public double Navlun { get; set; }
        public double NavlunKdv { get; set; }
        public double? Masraf { get; set; }
        public double? Tutar { get; set; }
        public double? Stopaj { get; set; }
        public string Sehir { get; set; }
        public bool? Kesildi { get; set; }
        public double? Bagkur { get; set; }
        public decimal Rusum { get; set; }
        public decimal Komisyon { get; set; }
        public decimal KomisyonKdv { get; set; }
        public double? Borsa { get; set; }
        public double IadesizKapTutari { get; set; }
        public double IadesizKapKdv { get; set; }
        public double? Kdv { get; set; }
        public string SatHamaliyeAdlandirma { get; set; }
        public string SatNakliyeAdlandirma { get; set; }
    }
}