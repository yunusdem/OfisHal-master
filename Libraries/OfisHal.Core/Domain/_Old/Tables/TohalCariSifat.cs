namespace OfisHal.Web.Models
{
    public class TohalCariSifat
    {
        public int? CariKartId { get; set; }
        public byte Sifat { get; set; }

        public virtual TohalCariKart CariKart { get; set; }
    }
}