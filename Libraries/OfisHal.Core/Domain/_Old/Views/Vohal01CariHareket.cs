using System;

namespace OfisHal.Web.Models
{
    public class Vohal01CariHareket
    {
        public int? CariKartId { get; set; }
        public DateTime? Tarih { get; set; }
        public int Tip { get; set; }
        public double? Meblag { get; set; }
        public int HareketTipi { get; set; }
        public int HareketId { get; set; }
        public string Aciklama { get; set; }
        public DateTime? EklemeZamani { get; set; }
        public int? KapSayisi { get; set; }
        public int? FaturaTuru { get; set; }
        public byte? OdemeAraciTuru { get; set; }
        public int BelgeTuru { get; set; }
    }
}