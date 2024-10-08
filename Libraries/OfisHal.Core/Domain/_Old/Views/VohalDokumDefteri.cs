

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalDokumDefteri
    {
        public int MakbuzId { get; set; }
        public int? FaturaSatiriId { get; set; }
        public int? SatirNo { get; set; }
        public int? FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }
        public double CiroPrimi { get; set; }
        public string Aciklama { get; set; }
    }
}