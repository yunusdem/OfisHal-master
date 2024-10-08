using System;

namespace OfisHal.Web.Models
{
    public class Vohal01PosHareketi
    {
        public int PosCihaziId { get; set; }
        public DateTime? Tarih { get; set; }
        public double Meblag { get; set; }
        public string Aciklama { get; set; }
        public int HareketTipi { get; set; }
        public string IslemKodu { get; set; }
        public int IslemTipi { get; set; }
        public string IslemAdi { get; set; }
    }
}