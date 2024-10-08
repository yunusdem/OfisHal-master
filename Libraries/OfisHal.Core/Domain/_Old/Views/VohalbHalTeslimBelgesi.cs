using System;

namespace OfisHal.Web.Models
{
    public class VohalbHalTeslimBelgesi
    {
        public int MakbuzId { get; set; }
        public string MalinCinsi { get; set; }
        public int ParcaSayisi { get; set; }
        public double Kg { get; set; }
        public string AmbarNo { get; set; }
        public string HalNo { get; set; }
        public string AracPlaka { get; set; }
        public DateTime GelisTarihi { get; set; }
        public string BelgeNo { get; set; }
        public string AdiSoyadi { get; set; }
        public string BeldeAdi { get; set; }
        public string IlceAdi { get; set; }
        public string IlAdi { get; set; }
        public string MalinGeldigiYer { get; set; }
        public string StokKunyesi { get; set; }
    }
}