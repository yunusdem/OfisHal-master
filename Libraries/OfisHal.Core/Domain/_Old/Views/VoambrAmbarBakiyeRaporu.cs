namespace OfisHal.Web.Models
{
    public class VoambrAmbarBakiyeRaporu
    {
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public double? ToplamBorc { get; set; }
        public double ToplamAlacak { get; set; }
        public double? AlacakBakiye { get; set; }
        public double BorcBakiye { get; set; }
    }
}