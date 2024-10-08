

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrBagkurMuafiyetRaporu
    {
        public int CariKartId { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public string Adres { get; set; }
        public string GsmNumarasi { get; set; }
        public string Tel1 { get; set; }
        public string BagkurNo { get; set; }
        public string MuafiyetBelgeNo { get; set; }
        public DateTime? MuafiyetBitisTarihi { get; set; }
        public string VergiKimlikNo { get; set; }
        public string VergiDairesiAdi { get; set; }
    }
}