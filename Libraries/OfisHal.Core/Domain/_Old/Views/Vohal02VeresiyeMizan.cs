using System;

namespace OfisHal.Web.Models
{
    public class Vohal02VeresiyeMizan
    {
        public int CariKartId { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public DateTime Tarih { get; set; }
        public double BorcToplami { get; set; }
        public double AlacakToplami { get; set; }
        public double CariDevir { get; set; }
        public double CariHareketBakiye { get; set; }
        public double OdemeBordrosuBakiye { get; set; }
        public double RehinKapHareketBakiye { get; set; }
        public double BankaHareketBakiye { get; set; }
        public double Bakiye { get; set; }
    }
}