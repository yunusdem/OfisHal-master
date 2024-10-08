namespace OfisHal.Web.Models
{
    public class VoambNavlunFaturasiSatiri
    {
        public string FaturaNo { get; set; }
        public int NavlunFaturasiId { get; set; }
        public int NavlunFaturaSatiriId { get; set; }
        public int SatirNo { get; set; }
        public int? GeldigiYerId { get; set; }
        public string GeldigiYer { get; set; }
        public int? GonderenId { get; set; }
        public string Gonderen { get; set; }
        public int Adet { get; set; }
        public double MuameleFiyati { get; set; }
        public double NavlunTutar { get; set; }
        public double MuameleTutar { get; set; }
        public string MalAdi { get; set; }
        public string MalKodu { get; set; }
        public string KapAdi { get; set; }
        public string KapKodu { get; set; }
        public int MalId { get; set; }
        public int? KapId { get; set; }
        public double NavlunFiyati { get; set; }
        public string IrsaliyeNo { get; set; }
        public double MuameleKdv { get; set; }
        public double NavlunKdv { get; set; }
        public double MuameleKdvOrani { get; set; }
        public double NavlunKdvOrani { get; set; }
        public int? IrsaliyeId { get; set; }
        public int? IrsaliyeSatiriId { get; set; }
        public int? PlakaId { get; set; }
        public string PlakaNo { get; set; }
        public int? ToplamAdet { get; set; }
        public string EFaturaUneceKisaltma { get; set; }
    }
}