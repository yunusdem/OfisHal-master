namespace OfisHal.Core.Domain
{
    public class VohalKap
    {
        public int KapId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public double Dara { get; set; }
        public bool? Iadeli { get; set; }
        public double? BirimFiyati { get; set; }
        public int? RehinKabiId { get; set; }
        public string RehinKabiKodu { get; set; }
        public string RehinKabiAdi { get; set; }
        public int? DigerAdId { get; set; }
        public string DigerAdi { get; set; }
        public int? AlisHesapId { get; set; }
        public string AlisHesapKodu { get; set; }
        public int? SatisHesapId { get; set; }
        public string SatisHesapKodu { get; set; }
        public double? Kapasite { get; set; }
        public string AmbalajTipiKodu { get; set; }
        public string AmbalajMarkasi { get; set; }
    }
}