using System;

namespace OfisHal.Web.Models
{
    public class Vohal01HesapHareketi
    {
        public int Grup { get; set; }
        public int HesapId { get; set; }
        public int HesapHareketiId { get; set; }
        public DateTime? Tarih { get; set; }
        public int Tip { get; set; }
        public string Aciklama { get; set; }
        public string HesapKodu { get; set; }
        public string HesapAdi { get; set; }
        public double? Miktar { get; set; }
    }
}