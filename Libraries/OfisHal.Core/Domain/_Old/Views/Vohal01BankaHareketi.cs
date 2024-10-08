﻿using System;

namespace OfisHal.Web.Models
{
    public class Vohal01BankaHareketi
    {
        public int? BankaHesabiId { get; set; }
        public int IslemTipi { get; set; }
        public DateTime? Tarih { get; set; }
        public double? Meblag { get; set; }
        public int HareketTipi { get; set; }
        public string Aciklama { get; set; }
        public string IslemAdi { get; set; }
    }
}