

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMasraf
    {
        public string Aciklama { get; set; }
        public int? MakbuzId { get; set; }
        public int? FaturaId { get; set; }
        public int? SiparisId { get; set; }
        public string HesapAdi { get; set; }
        public string KapAdi { get; set; }
        public int? KapSayisi { get; set; }
        public double Masraf { get; set; }
        public double Kdv { get; set; }
        public double Toplam { get; set; }
        public string SiparisNo { get; set; }
        public DateTime? SiparisTarihi { get; set; }
    }
}