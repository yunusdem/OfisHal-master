using System;

namespace OfisHal.Web.Models
{
    public class Vohal00OdemeAraciVadeListesi
    {
        public int IslemTuru { get; set; }
        public string OdemeAraciTuru { get; set; }
        public string CariAdi { get; set; }
        public int OdemeAraciId { get; set; }
        public byte Tur { get; set; }
        public int? BankaId { get; set; }
        public string Banka { get; set; }
        public string OdemeAraciNo { get; set; }
        public DateTime VadeTarihi { get; set; }
        public double Meblag { get; set; }
    }
}