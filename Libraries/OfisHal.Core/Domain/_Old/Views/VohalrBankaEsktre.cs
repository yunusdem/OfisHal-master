

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrBankaEsktre
    {
        public string HesapNo { get; set; }
        public string HesapAdi { get; set; }
        public int BankaId { get; set; }
        public string BankaAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public double? Borc { get; set; }
        public double? Alacak { get; set; }
    }
}