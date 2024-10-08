

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalSipari
    {
        public int SiparisId { get; set; }
        public int? MusteriCariKartId { get; set; }
        public string MusteriKodu { get; set; }
        public string MusteriAdi { get; set; }
        public string SiparisNo { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public string Aciklama { get; set; }
        public bool? Kapandi { get; set; }
    }
}