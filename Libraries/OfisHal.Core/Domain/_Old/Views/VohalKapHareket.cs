

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalKapHareket
    {
        public int KapHareketId { get; set; }
        public int? CariKartId { get; set; }
        public byte KartTipi { get; set; }
        public string CariKod { get; set; }
        public string CariAd { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public int KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public int Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public byte Tip { get; set; }
        public int? RehinFisiId { get; set; }
        public byte? IslenecegiHesap { get; set; }
        public string EkleyenKullaniciAdi { get; set; }
        public DateTime EklemeZamani { get; set; }
        public string GuncelleyenKullaniciAdi { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public string KodTarih { get; set; }
        public string AdTarih { get; set; }
        public int? FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public string FaturaRefNo { get; set; }
    }
}