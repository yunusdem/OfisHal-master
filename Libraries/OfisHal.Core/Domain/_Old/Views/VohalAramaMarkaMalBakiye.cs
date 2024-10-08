namespace OfisHal.Web.Models
{
    public class VohalAramaMarkaMalBakiye
    {
        public int KayitId { get; set; }
        public int MarkaId { get; set; }
        public int? KapId { get; set; }
        public string Marka { get; set; }
        public string MustahsilAdi { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public int? KapKodu { get; set; }
        public int? KapMiktari { get; set; }
        public double? MalMiktari { get; set; }
    }
}