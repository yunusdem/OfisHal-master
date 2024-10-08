using System;

namespace OfisHal.Web.Models
{
    public class TohalIskeleStokIadeSatiri
    {
        public Guid? Guid { get; set; }
        public int? StokHareketId { get; set; }
        public DateTime? Tarih { get; set; }
        public string Aciklama { get; set; }
        public int? KapSayisi { get; set; }
        public double? Miktar { get; set; }
    }
}