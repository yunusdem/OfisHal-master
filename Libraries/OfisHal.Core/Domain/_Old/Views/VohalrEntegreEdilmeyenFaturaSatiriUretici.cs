

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrEntegreEdilmeyenFaturaSatiriUretici
    {
        public int CariKartId { get; set; }
        public string MusteriAdi { get; set; }
        public bool? Kesildi { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public int FaturaId { get; set; }
        public string RefNo { get; set; }
        public int? SatirNo { get; set; }
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public int KapMiktari { get; set; }
        public double MalMiktari { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
        public int StokTipi { get; set; }
        public string Aciklama { get; set; }
    }
}