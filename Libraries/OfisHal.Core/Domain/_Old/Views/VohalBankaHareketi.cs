using System;

namespace OfisHal.Web.Models
{
    public class VohalBankaHareketi
    {
        public int BankaHareketiId { get; set; }
        public int BankaHesabiId { get; set; }
        public string HesapNo { get; set; }
        public string HesapAdi { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public double Meblag { get; set; }
        public byte IslemTipi { get; set; }
        public int? CariKartId { get; set; }
        public string CariAdi { get; set; }
        public int? KasaHesapId { get; set; }
        public string KasaHesapAdi { get; set; }
        public int? KarsiBankaHesabiId { get; set; }
        public string KarsiBankaHesabiAdi { get; set; }
        public int? PosCihaziId { get; set; }
        public string PosCihaziAdi { get; set; }
        public string EkleyenKullaniciAdi { get; set; }
        public DateTime EklemeZamani { get; set; }
        public string GuncelleyenKullaniciAdi { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public string HesapNoTarih { get; set; }
        public string HesapAdiTarih { get; set; }
    }
}