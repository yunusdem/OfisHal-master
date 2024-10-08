

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrKullaniciSatisDurumu
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public int FaturaId { get; set; }
        public DateTime Tarih { get; set; }
        public int RefNo { get; set; }
        public string FaturaNo { get; set; }
        public string FaturaUnvani { get; set; }
        public byte? SatRusumKdvIliskisi { get; set; }
        public double? Tutar { get; set; }
        public double KesintilerToplami { get; set; }
        public double? FaturaToplami { get; set; }
        public double? Veresiye { get; set; }
        public string PesinVeyaVeresiye { get; set; }
        public double Rehin { get; set; }
        public int? KurusBasamakSayisi { get; set; }
    }
}