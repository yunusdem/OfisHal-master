namespace OfisHal.Web.Models
{
    public class VohalAramaKayitsizMusteriIlIlceBeldeBilgileriOlanlar
    {
        public int KayitsizMusteriId { get; set; }
        public string Unvan { get; set; }
        public int? YerId { get; set; }
        public int? IlId { get; set; }
        public string IlAdi { get; set; }
        public int? IlceId { get; set; }
        public string IlceAdi { get; set; }
        public int? BeldeId { get; set; }
        public string BeldeAdi { get; set; }
        public string Adres { get; set; }
    }
}