using System;

namespace OfisHal.Web.Models
{
    public class VohalAramaAlisFaturasiKunyeBildirimListesi
    {
        public int KayitId { get; set; }
        public int FaturaId { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public string MüşteriAdı { get; set; }
        public string MüstahsilAdı { get; set; }
        public string MalAdı { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public string StokKünyeNo { get; set; }
        public string SatışKünyeNo { get; set; }
        public string KünyeDurumu { get; set; }
        public string PlakaNo { get; set; }
        public string Durum { get; set; }
    }
}