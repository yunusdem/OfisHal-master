

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalNavlunFaturasi
    {
        public int HesapHareketiId { get; set; }
        public int SatirNo { get; set; }
        public int MakbuzId { get; set; }
        public string DokumNo { get; set; }
        public string MustahsilAdi { get; set; }
        public double Meblag { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
        public string KdvTevkifatTanimiAciklamasi { get; set; }
        public int? KdvTevkifatPayi { get; set; }
        public int? KdvTevkifatPaydasi { get; set; }
        public double? KdvTevkifati { get; set; }
    }
}