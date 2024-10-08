

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMustahsilMusteriListesi
    {
        public int CariKartId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public byte Tip { get; set; }
        public string Marka { get; set; }
        public string VergiKimlikNo { get; set; }
        public string Telefon { get; set; }
        public string SehirAdi { get; set; }
        public string Adres { get; set; }
        public string PostaKodu { get; set; }
        public string VergiDairesi { get; set; }
    }
}