

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrDokumDefteriMusteriBazli
    {
        public string DokumNo { get; set; }
        public int MakbuzId { get; set; }
        public string MustahsilAdi { get; set; }
        public string MustahsilVergiKimlikNo { get; set; }
        public string Marka { get; set; }
        public string MustahsilFaturaNo { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public double Navlun { get; set; }
        public string GeldigiYer { get; set; }
        public double IadesizKapTutari { get; set; }
        public string Plaka { get; set; }
        public string SatisFaturasiNo { get; set; }
        public DateTime SatisTarihi { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriVergiKimlikNo { get; set; }
        public string VergiDairesi { get; set; }
        public string MalAdi { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
    }
}