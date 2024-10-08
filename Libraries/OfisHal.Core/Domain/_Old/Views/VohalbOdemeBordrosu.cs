using System;

namespace OfisHal.Web.Models
{
    public class VohalbOdemeBordrosu
    {
        public int OdemeBordrosuId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public byte? CariTipi { get; set; }
        public string Adres { get; set; }
        public byte IslemTuru { get; set; }
        public string BordroNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public byte OdemeAraciTuru { get; set; }
        public string OdemeAraciNo { get; set; }
        public DateTime VadeTarihi { get; set; }
        public double Meblag { get; set; }
        public string BankaAdi { get; set; }
    }
}