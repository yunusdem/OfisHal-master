using System;

namespace OfisHal.Web.Models
{
    public class Vohal00Makbuz
    {
        public int MakbuzId { get; set; }
        public int CariKartId { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime EklemeZamani { get; set; }
        public string FaturaNo { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public byte CariyeIslemeSekli { get; set; }
        public int? OrtakId { get; set; }
        public double? OrtaklikOrani { get; set; }
        public int? KapSayisi { get; set; }
        public bool? Kesildi { get; set; }
        public double KdvTutari { get; set; }
        public double MasrafToplami { get; set; }
        public double NetToplam { get; set; }
    }
}