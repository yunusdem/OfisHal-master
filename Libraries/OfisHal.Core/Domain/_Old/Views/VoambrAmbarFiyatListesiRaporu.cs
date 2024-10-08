namespace OfisHal.Web.Models
{
    public class VoambrAmbarFiyatListesiRaporu
    {
        public int CariKartId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public double Muamele { get; set; }
        public double Hammaliye { get; set; }
        public string Aciklama { get; set; }
        public double? AmbarPrimi { get; set; }
        public int? PrimSahibiId { get; set; }
        public string PrimSahibiKodu { get; set; }
        public string PrimSahibiAdi { get; set; }
        public double Navlun { get; set; }
        public double? HammaliyePrimi { get; set; }
    }
}