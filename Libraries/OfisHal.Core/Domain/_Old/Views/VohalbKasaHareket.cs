using System;

namespace OfisHal.Web.Models
{
    public class VohalbKasaHareket
    {
        public int HesapHareketiId { get; set; }
        public int HesapId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public double Meblag { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public byte Tip { get; set; }
        public byte HareketTipi { get; set; }
        public string EkleyenKullaniciAdi { get; set; }
        public DateTime EklemeZamani { get; set; }
        public string GuncelleyenKullaniciAdi { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public string KodTarih { get; set; }
        public string AdTarih { get; set; }
    }
}