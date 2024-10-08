namespace OfisHal.Core.Domain
{
    public class TohalSatisMakbuzSatiri
    {
        public int FaturaSatiriId { get; set; }
        public int SatirNo { get; set; }
        public int KapMiktari { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }

        public virtual TohalFaturaSatiri FaturaSatiri { get; set; }
    }
}