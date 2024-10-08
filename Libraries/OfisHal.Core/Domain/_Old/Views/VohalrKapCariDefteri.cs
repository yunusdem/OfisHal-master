

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrKapCariDefteri
    {
        public int SiraNo { get; set; }
        public int KapId { get; set; }
        public DateTime Tarih { get; set; }
        public int Tip { get; set; }
        public string Aciklama { get; set; }
        public int? CariKartId { get; set; }
        public string CariKod { get; set; }
        public string CariAd { get; set; }
        public string KapKodu { get; set; }
        public byte? CariKartTipi { get; set; }
        public string KapAdi { get; set; }
        public int Miktar { get; set; }
        public int MiktarBasamakSayisi { get; set; }
        public double Tutar { get; set; }
        public string IslenecegiHesap { get; set; }
    }
}