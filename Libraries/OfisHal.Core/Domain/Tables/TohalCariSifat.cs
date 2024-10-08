namespace OfisHal.Core.Domain
{
    public class TohalCariSifat
    {
        public int Id { get; set; }

        public int? CariKartId { get; set; }

        public byte Sifat { get; set; }

        public virtual TohalCariKart CariKart { get; set; }
    }
}
