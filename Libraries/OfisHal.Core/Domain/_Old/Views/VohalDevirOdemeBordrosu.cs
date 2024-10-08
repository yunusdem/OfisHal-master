

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalDevirOdemeBordrosu
    {
        public int? CariKartId { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public byte Tur { get; set; }
        public int? BankaId { get; set; }
        public int? BankaHesabiId { get; set; }
        public int OdemeAraciId { get; set; }
        public string OdemeAraciNo { get; set; }
        public DateTime VadeTarihi { get; set; }
        public double Meblag { get; set; }
        public byte IslemTuru { get; set; }
        public string SatirAciklama { get; set; }
        public byte SonIslemTuru { get; set; }
        public int? SonIslemBankaHesabiId { get; set; }
    }
}