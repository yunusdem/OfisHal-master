namespace OfisHal.Web.Models
{
    public class VohalAramaMustahsilHalBilgileriOlanlar
    {
        public int CariKartId { get; set; }
        public byte Tip { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public int? HalId { get; set; }
        public string HalAdi { get; set; }
        public string EskiSehir { get; set; }
        public string Adres { get; set; }
    }
}