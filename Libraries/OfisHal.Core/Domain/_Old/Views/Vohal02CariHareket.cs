using System;

namespace OfisHal.Web.Models
{
    public class Vohal02CariHareket
    {
        public int IslemTipi { get; set; }
        public int? CariKartId { get; set; }
        public DateTime Tarih { get; set; }
        public double? Meblag { get; set; }
        public bool? Kesildi { get; set; }
    }
}