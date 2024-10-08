using System;

namespace OfisHal.Web.Models
{
    public class TohalIskeleMuhFisSatiri
    {
        public int? SatirNo { get; set; }
        public int? MuhHesapId { get; set; }
        public string Aciklama { get; set; }
        public byte? Tip { get; set; }
        public double? Meblag { get; set; }
        public Guid? Guid { get; set; }
    }
}