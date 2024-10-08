

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSiparisKarsilastirmaAlisDetay
    {
        public int SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public int? SatirNo { get; set; }
        public int KapMiktari { get; set; }
        public double MalMiktari { get; set; }
        public double Tutar { get; set; }
    }
}