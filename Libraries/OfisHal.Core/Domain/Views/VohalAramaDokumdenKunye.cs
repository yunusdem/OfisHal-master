namespace OfisHal.Core.Domain
{
    public class VohalAramaDokumdenKunye
    {
        public int StokHareketiId { get; set; }
        public int? KunyeId { get; set; }
        public string Kunye { get; set; }
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public string MustahsilAdi { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public int? KapId { get; set; }
        public string KapAdi { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public int? SatilanKap { get; set; }
        public double? SatilanMiktar { get; set; }
    }
}