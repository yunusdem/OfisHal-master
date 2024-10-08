using System;

namespace OfisHal.Core.Domain
{
    public class VohalAramaOdemeAraci
    {
        public int OdemeAraciId { get; set; }
        public string OdemeAraciNo { get; set; }
        public string BankaAdi { get; set; }
        public string HesapAdi { get; set; }
        public DateTime VadeTarihi { get; set; }
        public double Meblag { get; set; }
        public int? VerenId { get; set; }
        public string Veren { get; set; }
        public int? CariKartId { get; set; }
        public int? BankaHesabiId { get; set; }
        public int? SonrakiBordroId { get; set; }
        public byte Tur { get; set; }
        public byte IslemTuru { get; set; }
        public string Durum { get; set; }
        public int? CekBankaHesabiId { get; set; }
    }
}