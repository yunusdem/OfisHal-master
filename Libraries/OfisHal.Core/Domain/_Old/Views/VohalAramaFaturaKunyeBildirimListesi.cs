using System;

namespace OfisHal.Web.Models
{
    public class VohalAramaFaturaKunyeBildirimListesi
    {
        public int KayitId { get; set; }
        public int FaturaId { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public string MagazaKodu { get; set; }
        public string MagazaAdi { get; set; }
        public int FaturaSatiriId { get; set; }
        public int SatirNo { get; set; }
        public string MusteriKodu { get; set; }
        public string MusteriAdi { get; set; }
        public string UreticiAdi { get; set; }
        public string MustahsilAdi { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public double MalMiktari { get; set; }
        public double Fiyat { get; set; }
        public int? StokKunyeId { get; set; }
        public string StokKunyeNo { get; set; }
        public DateTime? StokKunyeTarihi { get; set; }
        public int? SatisKunyeId { get; set; }
        public string SatisKunyeNo { get; set; }
        public DateTime? SatisKunyeTarihi { get; set; }
        public string KunyeDurumu { get; set; }
        public string PlakaNo { get; set; }
        public string Durum { get; set; }
        public string YerAdi { get; set; }
        public string UretimSekli { get; set; }
        public double? StokFiyati { get; set; }
        public double SatisFiyati { get; set; }
        public string StokKunyeDetayGuid { get; set; }
    }
}