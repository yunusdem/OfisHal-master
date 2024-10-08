

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrOdemeBordrosu
    {
        public int OdemeBordrosuId { get; set; }
        public int CariKartId { get; set; }
        public string CariKod { get; set; }
        public string Unvan { get; set; }
        public byte CariTipi { get; set; }
        public string Adres { get; set; }
        public byte IslemTuru { get; set; }
        public string BordroNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public byte OdemeAraciTuru { get; set; }
        public string OdemeAraciNo { get; set; }
        public DateTime VadeTarihi { get; set; }
        public double Meblag { get; set; }
        public string BankaAdi { get; set; }
        public string Sehir { get; set; }
        public string VergiKimlikNo { get; set; }
        public string VergiDairesi { get; set; }
        public byte KisilikTipi { get; set; }
        public string SatirAciklamasi { get; set; }
    }
}