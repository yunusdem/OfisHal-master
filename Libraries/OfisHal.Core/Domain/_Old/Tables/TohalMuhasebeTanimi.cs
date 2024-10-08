namespace OfisHal.Web.Models
{
    public class TohalMuhasebeTanimi
    {
        public byte Tur { get; set; }
        public int MuhHesapId { get; set; }

        public virtual TohalMuhHesap MuhHesap { get; set; }
    }
}