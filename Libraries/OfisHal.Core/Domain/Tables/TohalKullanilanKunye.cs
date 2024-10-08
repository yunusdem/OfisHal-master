namespace OfisHal.Core.Domain
{
    public class TohalKullanilanKunye
    {
        public int KunyeSatirId { get; set; }
        public int? SatirNo { get; set; }
        public int? FaturaSatiriId { get; set; }
        public int? StokKunyeId { get; set; }
        public int? SatisKunyeId { get; set; }
        public double? Miktar { get; set; }
        public int? SatisKunyeSatiriId { get; set; }

        public virtual TohalFaturaSatiri FaturaSatiri { get; set; }
        public virtual TohalKunye SatisKunye { get; set; }
        public virtual TohalSatisKunyeSatiri SatisKunyeSatiri { get; set; }
        public virtual TohalKunye StokKunye { get; set; }
    }
}