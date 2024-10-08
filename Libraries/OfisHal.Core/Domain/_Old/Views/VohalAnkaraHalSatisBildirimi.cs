using System;

namespace OfisHal.Web.Models
{
    public class VohalAnkaraHalSatisBildirimi
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Belde { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
        public string PlakaNo { get; set; }
        public int SatirNo { get; set; }
        public DateTime? StokGirisTarihi { get; set; }
        public string DokumNo { get; set; }
        public int? DokumSatirNo { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public string KunyeNo { get; set; }
        public double? Miktar { get; set; }
        public byte? Birim { get; set; }
        public int BildirimDurumu { get; set; }
        public string DonenAlanDegeri { get; set; }
        public int Siralama { get; set; }
    }
}