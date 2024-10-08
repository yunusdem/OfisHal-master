

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrDokumDefteri
    {
        public int Tip { get; set; }
        public int MakbuzId { get; set; }
        public string DokumNo { get; set; }
        public string Mustahsil { get; set; }
        public string Marka { get; set; }
        public string GeldigiYer { get; set; }
        public string MakbuzNo { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string Plaka { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public string MalAdi { get; set; }
        public string KapAdi { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }
        public double Navlun { get; set; }
        public double NavlunKdv { get; set; }
        public double Rusum { get; set; }
        public double Bagkur { get; set; }
        public double Borsa { get; set; }
        public double Stopaj { get; set; }
        public double Komisyon { get; set; }
        public double KomisyonKdv { get; set; }
        public double IadesizKapTutari { get; set; }
        public double IadesizKapKdv { get; set; }
        public double? Masraf { get; set; }
        public double? MasrafKdv { get; set; }
        public double? MalKdv { get; set; }
        public byte? DokDokumAmbar { get; set; }
        public byte? DokDokumDefterTipi { get; set; }
        public string SatisFaturasiNo { get; set; }
        public DateTime SatisFaturasiTarihi { get; set; }
    }
}