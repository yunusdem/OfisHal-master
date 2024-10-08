using System;

namespace OfisHal.Web.Models
{
    public class Vohal00MusteriOdemeAraciRiskListesi
    {
        public int OdemeBordrosuId { get; set; }
        public DateTime Tarih { get; set; }
        public int? CariKartId { get; set; }
        public string CariAdi { get; set; }
        public byte IslemTuru { get; set; }
        public bool? OdemeAraciSahibi { get; set; }
        public int? BankaId { get; set; }
        public string OdemeAraciNo { get; set; }
        public DateTime VadeTarihi { get; set; }
        public byte Tur { get; set; }
        public double Meblag { get; set; }
        public int IlkCariKartId { get; set; }
        public string IlkCariAdi { get; set; }
    }
}