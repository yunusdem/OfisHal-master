

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrPosEkstresi
    {
        public int PosCihaziId { get; set; }
        public DateTime? Tarih { get; set; }
        public double Meblag { get; set; }
        public string Aciklama { get; set; }
        public int HareketTipi { get; set; }
        public string IslemKodu { get; set; }
        public int IslemTipi { get; set; }
        public string IslemAdi { get; set; }
        public string CihazKodu { get; set; }
        public string CihazAdi { get; set; }
    }
}