using System;

namespace OfisHal.Web.Models
{
    public class TohalIskeleNavlunFaturasi
    {
        public int MakbuzId { get; set; }
        public double Meblag { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
        public int? KdvTevkifatPayi { get; set; }
        public int? KdvTevkifatPaydasi { get; set; }
        public double? KdvTevkifati { get; set; }
        public int SatirNo { get; set; }
        public Guid? Guid { get; set; }
    }
}