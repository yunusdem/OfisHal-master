namespace OfisHal.Web.Models
{
    public class VoambSevkIrsaliyesiSatiri
    {
        public int IrsaliyeId { get; set; }
        public int IrsaliyeSatiriId { get; set; }
        public int SatirNo { get; set; }
        public int? GonderenId { get; set; }
        public string GonderenKodu { get; set; }
        public string Gonderen { get; set; }
        public int Adet { get; set; }
        public double MuameleBirimFiyat { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public string YazihaneKodu { get; set; }
        public string Yazihane { get; set; }
        public string MalAdi { get; set; }
        public string MalKodu { get; set; }
        public string KapAdi { get; set; }
        public string KapKodu { get; set; }
        public int MalId { get; set; }
        public int? KapId { get; set; }
        public int YazihaneId { get; set; }
        public double HammaliyeFiyati { get; set; }
        public double MuameleKdv { get; set; }
        public double NavlunKdv { get; set; }
        public int? DizaynId { get; set; }
        public string DizaynAdi { get; set; }
        public double MuameleKdvOrani { get; set; }
        public double NavlunKdvOrani { get; set; }
        public int? MuameleDizaynId { get; set; }
        public string MuameleDizaynAdi { get; set; }
        public int? NavlunIrsaliyeId { get; set; }
        public int? AmbarFiyatiId { get; set; }
        public string FiyatListesi { get; set; }
        public int? FaturaNo { get; set; }
        public int? PrimSahibiId { get; set; }
        public double? AmbarPrimi { get; set; }
        public string PrimSahibiKodu { get; set; }
        public string PrimSahibi { get; set; }
        public int? NavlunFaturasiId { get; set; }
        public int? HammaliyeFaturasiId { get; set; }
        public bool? MuameleDahil { get; set; }
    }
}