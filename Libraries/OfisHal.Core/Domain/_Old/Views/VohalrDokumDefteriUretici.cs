

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrDokumDefteriUretici
    {
        public int MakbuzId { get; set; }
        public string Mustahsil { get; set; }
        public string Marka { get; set; }
        public double Navlun { get; set; }
        public double NavlunKdv { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string FaturaNo { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public string GeldigiYer { get; set; }
        public string DokumNo { get; set; }
        public string Plaka { get; set; }
        public double Rusum { get; set; }
        public double Bagkur { get; set; }
        public double Borsa { get; set; }
        public double Stopaj { get; set; }
        public string MalAdi { get; set; }
        public double Komisyon { get; set; }
        public double KomisyonKdv { get; set; }
        public double IadesizKapTutari { get; set; }
        public double IadesizKapKdv { get; set; }
        public bool? Kesildi { get; set; }
        public double? Miktar { get; set; }
        public string KapAdi { get; set; }
        public int? KapSayisi { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
    }
}