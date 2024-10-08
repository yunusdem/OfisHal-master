namespace OfisHal.Core.Domain
{
    public class VohalAramaKunye
    {
        public int KunyeId { get; set; }
        public string Kunye { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public string MustahsilAdi { get; set; }
        public int? MalId { get; set; }
        public string MalAdi { get; set; }
        public byte Tur { get; set; }
    }
}