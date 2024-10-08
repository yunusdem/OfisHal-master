

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMakbuzSatiri
    {
        public int MakbuzId { get; set; }
        public string DokumNo { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string Plaka { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public double? Fiyat { get; set; }
        public double? Tutar { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public double? KdvOrani { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
        public int? CariKartId { get; set; }
        public string Aciklama { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public string StokKunyesi { get; set; }
    }
}