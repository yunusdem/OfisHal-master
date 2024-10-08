using System;

namespace OfisHal.Web.Models
{
    public class Vohal00MakbuzKesilmemis
    {
        public int CariKartId { get; set; }
        public int? OrtakId { get; set; }
        public double? OrtaklikOrani { get; set; }
        public int MakbuzId { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public double? NetToplam { get; set; }
        public double? StokTutari { get; set; }
        public byte CariyeIslemeSekli { get; set; }
    }
}