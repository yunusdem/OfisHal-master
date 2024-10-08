

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalObSatiri
    {
        public int? OdemeBordrosuId { get; set; }
        public int? SatirNo { get; set; }
        public int OdemeAraciId { get; set; }
        public string OdemeAraciNo { get; set; }
        public int? BankaId { get; set; }
        public string BankaAdi { get; set; }
        public DateTime VadeTarihi { get; set; }
        public double Meblag { get; set; }
        public int? SonrakiBordroId { get; set; }
        public byte? IslemTuru { get; set; }
        public byte OdemeAraciTuru { get; set; }
        public int? CariKartId { get; set; }
        public int? BordroBankaHesabiId { get; set; }
        public int? BankaHesabiId { get; set; }
        public string BankaHesabiAdi { get; set; }
        public string Aciklama { get; set; }
    }
}