

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMustahsilCariDefteri
    {
        public int CariKartId { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? EklemeZamani { get; set; }
        public string Aciklama { get; set; }
        public string SehirAdi { get; set; }
        public string Marka { get; set; }
        public double? Borc { get; set; }
        public double? Alacak { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
    }
}