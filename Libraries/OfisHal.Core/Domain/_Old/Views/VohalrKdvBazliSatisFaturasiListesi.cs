

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrKdvBazliSatisFaturasiListesi
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public int CariKartId { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public byte? KisilikTipi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiKimlikNo { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public double KdvOrani { get; set; }
        public double? NetTutar { get; set; }
        public double? Kdv { get; set; }
        public double Tevkifat { get; set; }
    }
}