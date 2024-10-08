using System;

namespace OfisHal.Web.Models
{
    public class VohalAramaDokumKunyeBildirimListesi
    {
        public int KayitId { get; set; }
        public int MakbuzId { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string DokumNo { get; set; }
        public string MustahsilKodu { get; set; }
        public string MustahsilAdi { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public double Miktar { get; set; }
        public string KunyeNo { get; set; }
        public string KunyeDurumu { get; set; }
        public string Plaka { get; set; }
        public string Durum { get; set; }
        public double? Fiyat { get; set; }
    }
}