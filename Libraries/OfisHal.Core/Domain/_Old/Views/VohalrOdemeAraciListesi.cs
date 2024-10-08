

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrOdemeAraciListesi
    {
        public int OdemeAraciId { get; set; }
        public byte Tur { get; set; }
        public string OdemeAraciNo { get; set; }
        public DateTime VadeTarihi { get; set; }
        public DateTime Tarih { get; set; }
        public double Meblag { get; set; }
        public byte IslemTuru { get; set; }
        public string Durum { get; set; }
        public int? SahibiId { get; set; }
        public string SahibininKodu { get; set; }
        public string SahibininAdi { get; set; }
        public int? BankaId { get; set; }
        public string BankaAdi { get; set; }
        public string Aciklama { get; set; }
    }
}