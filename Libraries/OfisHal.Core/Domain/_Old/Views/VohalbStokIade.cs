using System;

namespace OfisHal.Web.Models
{
    public class VohalbStokIade
    {
        public int StokHareketiId { get; set; }
        public int MakbuzId { get; set; }
        public int CariKartId { get; set; }
        public string CariKod { get; set; }
        public string CariAd { get; set; }
        public string Aciklama { get; set; }
        public int? KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public int MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public int? KapSayisi { get; set; }
        public double? Miktar { get; set; }
        public Guid? Guid { get; set; }
        public DateTime? Tarih { get; set; }
        public string DokumBilgisi { get; set; }
    }
}