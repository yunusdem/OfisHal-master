namespace OfisHal.Core.Domain
{
    public class TohalNavlunFaturasi
    {
        public int HesapHareketiId { get; set; }
        public int MakbuzId { get; set; }
        public double Meblag { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
        public int? KdvTevkifatPayi { get; set; }
        public int? KdvTevkifatPaydasi { get; set; }
        public double? KdvTevkifati { get; set; }
        public int SatirNo { get; set; }

        public virtual TohalHesapHareketi HesapHareketi { get; set; }
        public virtual TohalKdvTevkifatTanimi KdvTevkifatTanimi { get; set; }
        public virtual TohalMakbuz Makbuz { get; set; }
    }
}