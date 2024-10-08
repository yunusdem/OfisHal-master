namespace OfisHal.Core.Domain
{
    public class VohalBankaHesabi
    {
        public int BankaHesabiId { get; set; }
        public string HesapNo { get; set; }
        public string HesapAdi { get; set; }
        public string Iban { get; set; }
        public string SubeAdi { get; set; }
        public int BankaId { get; set; }
        public string BankaAdi { get; set; }
        public double Devir { get; set; }
        public bool? EFaturadaGozuksun { get; set; }
        public int? MuhHesapId { get; set; }
        public string HesapKodu { get; set; }
    }
}