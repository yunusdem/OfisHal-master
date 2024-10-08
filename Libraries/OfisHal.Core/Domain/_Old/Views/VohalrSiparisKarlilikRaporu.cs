

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSiparisKarlilikRaporu
    {
        public int SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public string Aciklama { get; set; }
        public bool? Kapandi { get; set; }
        public int? AlisKapMiktari { get; set; }
        public double? AlisMiktari { get; set; }
        public int? SatisKapMiktari { get; set; }
        public double? SatisMiktari { get; set; }
        public double? AlisTutari { get; set; }
        public double SatisTutari { get; set; }
        public double Masraf { get; set; }
        public double FaturaMasrafi { get; set; }
        public double? Kar { get; set; }
    }
}