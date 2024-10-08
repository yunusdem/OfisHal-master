namespace OfisHal.Web.Models
{
    public class Vohal00EvrakMasrafi
    {
        public int? MakbuzId { get; set; }
        public int? FaturaId { get; set; }
        public int HesapId { get; set; }
        public int SatirNo { get; set; }
        public double Masraf { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public int? SiparisId { get; set; }
        public int? IrsaliyeId { get; set; }
    }
}