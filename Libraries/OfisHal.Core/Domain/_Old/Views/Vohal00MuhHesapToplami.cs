namespace OfisHal.Web.Models
{
    public class Vohal00MuhHesapToplami
    {
        public int MuhHesapId { get; set; }
        public int? Yil { get; set; }
        public int? Ay { get; set; }
        public double? BorcToplami { get; set; }
        public double? AlacakToplami { get; set; }
    }
}