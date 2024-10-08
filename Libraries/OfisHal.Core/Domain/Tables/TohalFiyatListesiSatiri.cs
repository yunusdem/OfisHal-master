namespace OfisHal.Core.Domain
{
    public class TohalFiyatListesiSatiri
    {
        public int FiyatListesiId { get; set; }
        public int SatirNo { get; set; }
        public int MalId { get; set; }
        public double Fiyat { get; set; }
        public double IskontoOrani { get; set; }

        public virtual TohalFiyatListesi FiyatListesi { get; set; }
        public virtual TohalMal Mal { get; set; }
    }
}