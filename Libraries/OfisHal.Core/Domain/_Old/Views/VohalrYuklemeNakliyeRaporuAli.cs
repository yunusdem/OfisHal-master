

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrYuklemeNakliyeRaporuAli
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public string Unvan { get; set; }
        public DateTime Tarih { get; set; }
        public double Yukleme { get; set; }
        public double YuklemeKdv { get; set; }
        public double Nakliye { get; set; }
        public double NakliyeKdv { get; set; }
        public string SatHamaliyeAdlandirma { get; set; }
        public string SatNakliyeAdlandirma { get; set; }
    }
}